using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using System.Linq;
using Java.IO;
using Android.Provider;
using Android.Content.PM;
using static Android.Provider.MediaStore.Images;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class PerfilActivity : Activity
    {
        SimpleStorage storage;
        public string usuario_id = string.Empty, usuario_tipo = string.Empty, imgPublish, imagePath;
        AlertDialog dialog;
        UsuariosController Favorites;
        UsuarioModel miembro;
        TableLayout tlPost;
        ScrollView svDirectorio, svPosts;
        View customView;
        List<PostModel> posts;
        int page = 0;
        readonly int sizePage = 10, PickImageId = 1000, TakePicture = 500;
        File _file, _dir;
        Bitmap bitmap;
        public PerfilActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
            Favorites = new UsuariosController();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            usuario_id = Intent.GetStringExtra("usuario_id");
            usuario_tipo = Intent.GetStringExtra("usuario_tipo");
            if (string.IsNullOrEmpty(usuario_id))
            {
                usuario_id = storage.Get("Usuario_Id");
                usuario_tipo = storage.Get("Usuario_Tipo");
            }
            posts = new EscritorioController().GetMuroPosts(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
                posts = posts.Where(user => user.Usuario.Usuario_Id == usuario_id && user.Usuario.Usuario_Tipo == usuario_tipo).ToList();
            FillDescripcionData();
            SimpleStorage.SetContext(ApplicationContext);
        }

        void ButtonAction()
        {
            FindViewById<ImageButton>(Resource.Id.btnDescripcion).Click += (sender, e) => FillDescripcionData();

            FindViewById<ImageButton>(Resource.Id.btnPosts).Click += async delegate
            {
                SetContentView(Resource.Layout.PostsUserLayout);
                if (!string.IsNullOrEmpty(Intent.GetStringExtra("usuario_id")) && !string.IsNullOrEmpty(Intent.GetStringExtra("usuario_tipo")))
                {
                    SetContentView(Resource.Layout.PrePostUserLayout);

                    Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                    SetActionBar(toolbar);
                    ActionBar.SetDisplayHomeAsUpEnabled(true);
                    ActionBar.Title = miembro.Usuario_Nombre + " " + miembro.Usuario_Apellidos;
                }

                tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
                List<string> data = new UsuariosController().GetMemberName(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
                FindViewById<TextView>(Resource.Id.lblNombre).Text = data[(int)CamposMiembro.Usuario_Nombre];
                FindViewById<TextView>(Resource.Id.lblPuesto).Text = data[(int)CamposMiembro.Usuario_Puesto];
                FindViewById<Button>(Resource.Id.btnInitPublish).Click += (sender, e) => ShowPublish();
                svPosts = FindViewById<ScrollView>(Resource.Id.post_scroll);
                await FillPosts();
                SwipeRefreshLayout refresher = FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_container);
                refresher.SetColorSchemeColors(Color.Gray, Color.LightGray, Color.Gray, Color.DarkGray, Color.Black, Color.DarkGray);
                refresher.Refresh += async (sender, e) =>
                {
                    tlPost.RemoveAllViews();
                    await FillPosts();
                    ((SwipeRefreshLayout)sender).Refreshing = false;
                };
                svPosts.ScrollChange += async (sender, e) =>
                {
                    if ((posts.Count / (page + 1)) < 10)
                        if ((((ScrollView)sender).ScrollY / (page + 1)) > ((svPosts.Height) * .4))
                        {
                            ++page;
                            await FillPosts();
                        }
                };
            };

            FindViewById<ImageButton>(Resource.Id.btnFavoritos).Click += (sender, e) => DirectorioFavoritos();
        }

        void FillDescripcionData()
        {
            if (!string.IsNullOrEmpty(Intent.GetStringExtra("usuario_id")) || !string.IsNullOrEmpty(Intent.GetStringExtra("usuario_tipo")))
            {
                SetContentView(Resource.Layout.PrePerfilLayout);
                Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                SetActionBar(toolbar);
                ActionBar.SetDisplayHomeAsUpEnabled(true);
            }
            else
            {
                SetContentView(Resource.Layout.PerfilLayout);
                FindViewById<ScrollView>(Resource.Id.svPerfil).SetMinimumHeight(Resources.DisplayMetrics.HeightPixels - 200);
            }
            FillUserData();
        }

        void FillUserData()
        {
            ButtonAction();
            ImageButton btnFavorito = FindViewById<ImageButton>(Resource.Id.btnFavorite);
            miembro = new UsuariosController().GetMemberData(usuario_id, usuario_tipo);
            if (!string.IsNullOrEmpty(Intent.GetStringExtra("usuario_id")) || !string.IsNullOrEmpty(Intent.GetStringExtra("usuario_tipo")))
            {
                ActionBar.Title = miembro.Usuario_Nombre + " " + miembro.Usuario_Apellidos;
                if (storage.Get("Usuario_Id") != miembro.Usuario_Id || storage.Get("Usuario_Tipo") != miembro.Usuario_Tipo)
                {
                    KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Usuario_Id, miembro.Usuario_Tipo);
                    btnFavorito.Visibility = ViewStates.Visible;
                    btnFavorito.SetBackgroundColor(Color.White);
                    if (isFavorite.Value)
                        btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                    btnFavorito.Click += delegate
                    {
                        if (isFavorite.Key == 0)
                        {
                            if (Favorites.AddMiembroFavorito(usuario_id, usuario_tipo, miembro.Usuario_Id, miembro.Usuario_Tipo))
                                btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                            else
                                Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                        }
                        else
                        {
                            if (Favorites.RemoveMiembroFavorito(isFavorite))
                            {
                                if (isFavorite.Value)
                                    btnFavorito.SetImageResource(Resource.Mipmap.ic_star_border);
                                else
                                    btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                            }
                            else
                                Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                        }
                        isFavorite = Favorites.IsMiembroFavorito(usuario_id, usuario_tipo, miembro.Usuario_Id, miembro.Usuario_Tipo);
                    };
                }
            }
            FindViewById<ImageView>(Resource.Id.imgPerfil).SetImageURI(Android.Net.Uri.Parse("http://worklabs.mx/Dashboard_Client/usr_imgs/" + miembro.Usuario_Fotografia));
            FindViewById<TextView>(Resource.Id.txtProfileName).Text = miembro.Usuario_Nombre + " " + miembro.Usuario_Apellidos;
            FindViewById<TextView>(Resource.Id.txtEmailPerfil).Text = miembro.Usuario_Correo_Electronico;
            FindViewById<TextView>(Resource.Id.txtGeneroPerfil).Text = miembro.Genero.Genero_Descripcion;
            FindViewById<TextView>(Resource.Id.txtFechaNacimientoPerfil).Text = DateTime.TryParse(miembro.Usuario_Fecha_Nacimiento, out var result) ? result.ToString("dd/MM/yyyy") : DateTime.Now.ToString("dd/MM/yyyy");
            FindViewById<TextView>(Resource.Id.txtProfesionPerfil).Text = miembro.Usuario_Profesion;
            FindViewById<TextView>(Resource.Id.txtPuestoPerfil).Text = miembro.Usuario_Puesto;
            //FindViewById<TextView>(Resource.Id.txtHabilidadesPerfil).Text = miembro.Usuario_Habilidades;
            FindViewById<TextView>(Resource.Id.txtTelefonoPerfil).Text = miembro.Usuario_Telefono;
            FindViewById<TextView>(Resource.Id.txtCelularPerfil).Text = miembro.Usuario_Celular;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            base.OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }


        async Task FillPosts()
        {
            AndHUD.Shared.Show(this, null, -1, MaskType.Black);
            await Task.Delay(500);
            ButtonAction();

            posts.Skip(page * sizePage).Take(sizePage).ToList().ForEach((post) =>
            {
                TableRow row = new TableRow(this);
                row.SetMinimumHeight(100);
                TableLayout.LayoutParams layoutParams = new TableLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                layoutParams.SetMargins(10, 10, 10, 10);
                row.LayoutParameters = layoutParams;
                GridLayout glPost = new GridLayout(this)
                {
                    ColumnCount = 5,
                    RowCount = 4
                };

                glPost.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);

                ImageButton ibFotoPostUsuario = new ImageButton(this);
                ibFotoPostUsuario.SetMinimumWidth(150);
                ibFotoPostUsuario.SetMinimumHeight(150);
                ibFotoPostUsuario.SetImageURI(ImagesHelper.GetPerfilImagen(post.Usuario.Usuario_Fotografia));
                GridLayout.LayoutParams param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(0);
                param.RowSpec = GridLayout.InvokeSpec(0, 3);
                ibFotoPostUsuario.LayoutParameters = param;
                ibFotoPostUsuario.Click += (sender, e) => AndHUD.Shared.ShowImage(this, Resources.GetDrawable(Resource.Mipmap.ic_work, null), null, MaskType.Black);
                glPost.AddView(ibFotoPostUsuario);

                TextView txtNombre = new TextView(this)
                {
                    Text = post.Usuario.Usuario_Nombre,
                    TextSize = 14,
                };
                txtNombre.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels - 150);
                txtNombre.Click += delegate
                {
                    Intent perfil = new Intent(this, typeof(PerfilActivity));
                    perfil.PutExtra("usuario_id", usuario_id);
                    perfil.PutExtra("usuario_tipo", usuario_tipo);
                    StartActivity(perfil);
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 4);
                param.RowSpec = GridLayout.InvokeSpec(0);
                txtNombre.LayoutParameters = param;
                glPost.AddView(txtNombre);

                TextView txtPuesto = new TextView(this)
                {
                    Text = post.Usuario.Usuario_Puesto,
                    TextSize = 12
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 4);
                param.RowSpec = GridLayout.InvokeSpec(1);
                txtPuesto.LayoutParameters = param;
                glPost.AddView(txtPuesto);

                TextView txtPost = new TextView(this)
                {
                    Text = post.Publicacion_Contenido,
                    TextSize = 10,
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 4);
                param.RowSpec = GridLayout.InvokeSpec(2);
                txtPost.LayoutParameters = param;
                glPost.AddView(txtPost);

                TextView txtFecha = new TextView(this)
                {
                    Text = post.Publicacion_Fecha.Substring(0, post.Publicacion_Fecha.Length - 6),
                    TextSize = 10,
                };
                txtFecha.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 150) / 2);
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1);
                param.RowSpec = GridLayout.InvokeSpec(3);
                txtFecha.LayoutParameters = param;
                glPost.AddView(txtFecha);

                LinearLayout llLike = new LinearLayout(this);
                Drawable icon = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_star_like);
                icon.SetBounds(0, 0, 20, 20);
                TextView lblLike = new TextView(this)
                {
                    Text = new EscritorioController().GetLikesPublish(post.Publicacion_Id) + " Like(s)",
                    TextSize = 10
                };
                lblLike.SetCompoundDrawables(icon, null, null, null);
                lblLike.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 130) / 5);
                lblLike.Click += delegate
                {
                    string transaccion = "ALTA";
                    if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                        transaccion = "BAJA";
                    else if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
                        transaccion = "MODIFICAR";
                    if (new EscritorioController().PostLike(post.Publicacion_Id, storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), transaccion))
                    {
                        lblLike.Text = new EscritorioController().GetLikesPublish(post.Publicacion_Id) + " Like(s)";
                        if (transaccion == "BAJA")
                        {
                            post.Publicacion_Me_Gusta_Usuario = "0";
                            lblLike.SetTextColor(Color.Black);
                        }
                        else
                        {
                            post.Publicacion_Me_Gusta_Usuario = "1";
                            lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                        }
                    }
                };
                if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                    lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                llLike.AddView(lblLike);
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center | GravityFlags.Left);
                param.ColumnSpec = GridLayout.InvokeSpec(2);
                param.RowSpec = GridLayout.InvokeSpec(3);
                llLike.LayoutParameters = param;
                glPost.AddView(llLike);

                LinearLayout llComment = new LinearLayout(this);
                Drawable iconComment = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_mode_comment);
                iconComment.SetBounds(0, 0, 20, 20);
                TextView lblComment = new TextView(this)
                {
                    Text = post.Publicacion_Comentarios_Cantidad + " " + Resources.GetString(Resource.String.Comentarios),
                    TextSize = 10
                };
                lblComment.SetCompoundDrawables(iconComment, null, null, null);
                lblComment.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 110) / 3);
                lblComment.Click += delegate
                 {
                     Intent intent = new Intent(this, typeof(CommentsActivity));
                     intent.PutExtra("post_id", post.Publicacion_Id);
                     StartActivity(intent);
                 };
                llComment.Click += delegate
                {
                    Intent intent = new Intent(this, typeof(CommentsActivity));
                    intent.PutExtra("post_id", post.Publicacion_Id);
                    StartActivity(intent);
                };
                llComment.AddView(lblComment);
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center | GravityFlags.Left);
                param.ColumnSpec = GridLayout.InvokeSpec(3, 2);
                param.RowSpec = GridLayout.InvokeSpec(3);
                llComment.LayoutParameters = param;
                glPost.AddView(llComment);

                row.AddView(glPost);
                tlPost.AddView(row);
            });
            AndHUD.Shared.Dismiss();
        }

        void DirectorioFavoritos()
        {

            if (!string.IsNullOrEmpty(Intent.GetStringExtra("usuario_id")) || !string.IsNullOrEmpty(Intent.GetStringExtra("usuario_tipo")))
            {
                SetContentView(Resource.Layout.PreFavoritesUserLayout);
                Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                SetActionBar(toolbar);
                ActionBar.SetDisplayHomeAsUpEnabled(true);
                ActionBar.Title = miembro.Usuario_Nombre + " " + miembro.Usuario_Apellidos;
            }
            else
            {
                SetContentView(Resource.Layout.FavoritesUserLayout);
            }
            svDirectorio = FindViewById<ScrollView>(Resource.Id.svFavoritos);
            FillDirectorioUsuario();
            ButtonAction();
        }

        void FillDirectorioUsuario()
        {
            LinearLayout llDirectorio = new LinearLayout(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            foreach (UsuarioModel favorito in new UsuariosController().GetMiembrosFavoritos(usuario_id, usuario_tipo))
            {
                RelativeLayout llNombre = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };
                TextView txtNombre = new TextView(this)
                {
                    Text = favorito.Usuario_Id + " " + favorito.Usuario_Apellidos,
                    TextSize = 20
                };
                llNombre.AddView(txtNombre);
                if (storage.Get("Usuario_Id") != favorito.Usuario_Id || storage.Get("Usuario_Tipo") != favorito.Usuario_Tipo)
                {
                    KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), favorito.Usuario_Id, favorito.Usuario_Tipo);
                    ImageButton btnFavorito = new ImageButton(this);
                    btnFavorito.SetBackgroundColor(Color.White);
                    btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                    if (!isFavorite.Value)
                        btnFavorito.SetImageResource(Resource.Mipmap.ic_star_border);
                    btnFavorito.SetX(Resources.DisplayMetrics.WidthPixels - 140);
                    btnFavorito.Click += delegate
                    {
                        if (isFavorite.Key == 0)
                        {
                            if (Favorites.AddMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), favorito.Usuario_Id, favorito.Usuario_Tipo))
                                btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                            else
                                Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                        }
                        else
                        {
                            if (Favorites.RemoveMiembroFavorito(isFavorite))
                            {
                                if (isFavorite.Value)
                                    btnFavorito.SetImageResource(Resource.Mipmap.ic_star_border);
                                else
                                    btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                            }
                            else
                                Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                        }
                        isFavorite = Favorites.IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), favorito.Usuario_Id, favorito.Usuario_Tipo);
                    };
                    llNombre.AddView(btnFavorito);
                }
                llDirectorio.AddView(llNombre);
                LinearLayout llEmail = new LinearLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };
                TextView txtEmail = new TextView(this)
                {
                    TextSize = 14,
                    Text = favorito.Usuario_Correo_Electronico
                };
                txtEmail.Click += delegate
                {
                    try
                    {
                        Intent email = new Intent(Intent.ActionSend);
                        email.PutExtra(Intent.ExtraEmail,
                                       new string[] { favorito.Usuario_Correo_Electronico });
                        email.PutExtra(Intent.ExtraSubject, Resources.GetString(Resource.String.AsuntoCorreo));
                        email.SetType("message/rfc822");
                        StartActivity(email);
                    }
                    catch (Exception ex)
                    {
                        SlackLogs.SendMessage(ex.Message);
                    }
                };
                llEmail.AddView(txtEmail);

                llDirectorio.AddView(llEmail);

                ScrollView svInfo = new ScrollView(this)
                {
                    LayoutParameters = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, 600)
                };
                LinearLayout llInfo = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                    Orientation = Orientation.Vertical
                };

                LinearLayout llImg = new LinearLayout(this)
                {
                    Orientation = Orientation.Vertical
                };
                ImageView imgInfo = new ImageView(this);

                llImg.AddView(imgInfo);
                llInfo.AddView(llImg);
                #region Genero
                RelativeLayout rlGenero = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
                };

                ImageView imgGenero = new ImageView(this);
                imgGenero.SetImageResource(Resource.Mipmap.ic_person);
                rlGenero.AddView(imgGenero);
                TextView txtGenero = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Genero)
                };
                txtGenero.SetX(100);
                rlGenero.AddView(txtGenero);
                llInfo.AddView(rlGenero);

                LinearLayout llGenero = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroGenero = new TextView(this)
                {
                    Text = favorito.Genero.Genero_Descripcion
                };
                txtMiembroGenero.SetX(50);
                llGenero.AddView(txtMiembroGenero);
                llInfo.AddView(llGenero);
                #endregion
                #region Fecha de Nacimiento
                RelativeLayout rlFechaNacimiento = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgFechaNacimiento = new ImageView(this);
                imgFechaNacimiento.SetImageResource(Resource.Mipmap.ic_today);
                rlFechaNacimiento.AddView(imgFechaNacimiento);
                TextView txtFechaNacimiento = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.FechaNacimiento)
                };
                txtFechaNacimiento.SetX(100);
                rlFechaNacimiento.AddView(txtFechaNacimiento);
                llInfo.AddView(rlFechaNacimiento);

                LinearLayout llFechaNacimiento = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroFechaNacimiento = new TextView(this)
                {
                    Text = favorito.Usuario_Fecha_Nacimiento
                };
                txtMiembroFechaNacimiento.SetX(50);
                llFechaNacimiento.AddView(txtMiembroFechaNacimiento);
                llInfo.AddView(llFechaNacimiento);
                #endregion
                #region Profesión
                RelativeLayout rlProfesion = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgProfesion = new ImageView(this);
                imgProfesion.SetImageResource(Resource.Mipmap.ic_school);
                rlProfesion.AddView(imgProfesion);
                TextView txtProfesion = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Profesion)
                };
                txtProfesion.SetX(100);
                rlProfesion.AddView(txtProfesion);
                llInfo.AddView(rlProfesion);

                LinearLayout llProfesion = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroProfesion = new TextView(this)
                {
                    Text = favorito.Usuario_Profesion
                };
                txtMiembroProfesion.SetX(50);
                llProfesion.AddView(txtMiembroProfesion);
                llInfo.AddView(llProfesion);
                #endregion
                #region Puesto
                RelativeLayout rlPuesto = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgPuesto = new ImageView(this);
                imgPuesto.SetImageResource(Resource.Mipmap.ic_work);
                rlPuesto.AddView(imgPuesto);
                TextView txtPuesto = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Puesto)
                };
                txtPuesto.SetX(100);
                rlPuesto.AddView(txtPuesto);
                llInfo.AddView(rlPuesto);

                LinearLayout llPuesto = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroPuesto = new TextView(this)
                {
                    Text = favorito.Usuario_Puesto
                };
                txtMiembroPuesto.SetX(50);
                llPuesto.AddView(txtMiembroPuesto);
                llInfo.AddView(llPuesto);
                #endregion
                #region Habilidades
                RelativeLayout rlHabilidades = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgHabilidades = new ImageView(this);
                imgHabilidades.SetImageResource(Resource.Mipmap.ic_create);
                rlHabilidades.AddView(imgHabilidades);
                TextView txtHabilidades = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Habilidades)
                };
                txtHabilidades.SetX(100);
                rlHabilidades.AddView(txtHabilidades);
                llInfo.AddView(rlHabilidades);

                LinearLayout llHabilidades = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroHabilidades = new TextView(this)
                {
                    //Text = favorito.Usuario_Habilidades
                };
                txtMiembroHabilidades.SetX(50);
                llHabilidades.AddView(txtMiembroHabilidades);
                llInfo.AddView(llHabilidades);
                #endregion
                #region Empresa
                RelativeLayout rlEmpresa = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgEmpresa = new ImageView(this);
                imgEmpresa.SetImageResource(Resource.Mipmap.ic_domain);
                rlEmpresa.AddView(imgEmpresa);
                TextView txtEmpresa = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.MiEmpresa)
                };
                txtEmpresa.SetX(100);
                rlEmpresa.AddView(txtEmpresa);
                llInfo.AddView(rlEmpresa);

                LinearLayout llEmpresa = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroEmpresa = new TextView(this)
                {
                    Text = favorito.Usuario_Empresa_Nombre
                };
                txtMiembroEmpresa.SetX(50);
                llEmpresa.AddView(txtMiembroEmpresa);
                llInfo.AddView(llEmpresa);
                #endregion
                #region Telefono
                RelativeLayout rlTelefono = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgTelefono = new ImageView(this);
                imgTelefono.SetImageResource(Resource.Mipmap.ic_call);
                rlTelefono.AddView(imgTelefono);
                TextView txtTelefono = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Telefono)
                };
                txtTelefono.SetX(100);
                rlTelefono.AddView(txtTelefono);
                llInfo.AddView(rlTelefono);

                LinearLayout llTelefono = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroTelefono = new TextView(this)
                {
                    Text = favorito.Usuario_Telefono
                };
                txtMiembroTelefono.SetX(50);
                llTelefono.AddView(txtMiembroTelefono);
                llInfo.AddView(llTelefono);
                #endregion

                #region Celular
                RelativeLayout rlCelular = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgCelular = new ImageView(this);
                imgCelular.SetImageResource(Resource.Mipmap.ic_cellphone);
                rlCelular.AddView(imgCelular);
                TextView txtCelular = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Celular)
                };
                txtCelular.SetX(100);
                rlCelular.AddView(txtCelular);
                llInfo.AddView(rlCelular);

                LinearLayout llCelular = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroCelular = new TextView(this)
                {
                    Text = favorito.Usuario_Celular
                };
                txtMiembroCelular.SetX(50);
                llCelular.AddView(txtMiembroCelular);
                llInfo.AddView(llCelular);
                #endregion

                svInfo.AddView(llInfo);
                llDirectorio.AddView(svInfo);
            }
            svDirectorio.AddView(llDirectorio);
        }

        void ShowPublish()
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            customView = liView.Inflate(Resource.Layout.PublishLayout, null, true);

            customView.FindViewById<TextView>(Resource.Id.lblNombre).Text = FindViewById<TextView>(Resource.Id.lblNombre).Text;
            customView.FindViewById<TextView>(Resource.Id.lblPuesto).Text = FindViewById<TextView>(Resource.Id.lblPuesto).Text;
            customView.FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Now.ToString("d");
            customView.FindViewById<ImageButton>(Resource.Id.imgPicture).Visibility = ViewStates.Gone;
            customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
            customView.FindViewById<ImageButton>(Resource.Id.imgPicture).Click += delegate
            {
                AndHUD.Shared.ShowImage(this, Drawable.CreateFromPath(_file.ToPath().ToString()));
            };

            customView.FindViewById<EditText>(Resource.Id.txtPublicacion).TextChanged += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(((EditText)sender).Text))
                    customView.FindViewById<Button>(Resource.Id.btnPublishApply).Enabled = true;
                else
                    customView.FindViewById<Button>(Resource.Id.btnPublishApply).Enabled = false;
            };

            customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Click += delegate
            {
                ImageButton imgPicture = customView.FindViewById<ImageButton>(Resource.Id.imgPicture);
                imgPicture.SetImageURI(null);
                imgPicture.Visibility = ViewStates.Gone;
                _file = null;
                customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
            };

            customView.FindViewById<ImageButton>(Resource.Id.btnTakePicture).Click += delegate
            {
                CreateDirectoryForPictures();
                IsThereAnAppToTakePictures();
                Intent intent = new Intent(MediaStore.ActionImageCapture);
                _file = new File(_dir, String.Format("{0}.png", Guid.NewGuid()));
                intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(_file));
                StartActivityForResult(intent, TakePicture);
            };

            customView.FindViewById<ImageButton>(Resource.Id.btnAttachImage).Click += delegate
            {
                var imageIntent = new Intent();
                imageIntent.SetType("image/*");
                imageIntent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(
                    Intent.CreateChooser(imageIntent, "Select photo"), PickImageId);
            };
            customView.FindViewById<Button>(Resource.Id.btnPublishApply).Click += async delegate
            {
                try
                {
                    System.IO.MemoryStream stream = new System.IO.MemoryStream();
                    bitmap?.Compress(Bitmap.CompressFormat.Png, 0, stream);
                    byte[] bitmapData = stream?.ToArray();
                    if (new EscritorioController().SetPost(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"),
                                                           customView.FindViewById<EditText>(Resource.Id.txtPublicacion).Text,
                                                           bitmapData))
                    {
                        tlPost.RemoveAllViews();
                        page = 0;
                        await FillPosts();
                        dialog.Dismiss();
                        customView.FindViewById<ImageView>(Resource.Id.imgPicture).Visibility = ViewStates.Gone;
                        customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
                    }
                    else
                        Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                }
                catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            };

            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }

        void CreateDirectoryForPictures()
        {
            _dir = new File(
                Android.OS.Environment.GetExternalStoragePublicDirectory(
                    Android.OS.Environment.DirectoryPictures), "WorklabsMx");
            if (!_dir.Exists())
                _dir.Mkdirs();
        }

        bool IsThereAnAppToTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            ImageButton imgPicture = customView.FindViewById<ImageButton>(Resource.Id.imgPicture);
            if (resultCode == Result.Ok)
            {
                if (requestCode == TakePicture && resultCode == Result.Ok)
                {
                    Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
                    Android.Net.Uri contentUri = Android.Net.Uri.FromFile(_file);
                    mediaScanIntent.SetData(contentUri);
                    SendBroadcast(mediaScanIntent);

                    int height = Resources.DisplayMetrics.HeightPixels;
                    int width = 900;
                    imagePath = _file.Path;
                    bitmap = _file.Path.LoadAndResizeBitmap(width, height);
                    if (bitmap != null)
                    {
                        imgPicture.SetImageBitmap(bitmap);
                        //bitmap = null;
                    }

                    GC.Collect();
                }
                if (requestCode == PickImageId && resultCode == Result.Ok && data != null)
                {
                    imagePath = (string)data.Data;
                    bitmap = Media.GetBitmap(ContentResolver, data.Data);
                    imgPicture.SetImageURI(data.Data);
                    imgPublish = System.Uri.EscapeUriString(data.Data.LastPathSegment);
                }
                imgPicture.Visibility = ViewStates.Visible;
                customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Visible;
                customView.FindViewById<Button>(Resource.Id.btnPublishApply).Enabled = true;
                customView.FindViewById<GridLayout>(Resource.Id.gvPublish).SetMinimumHeight(440);
            }
        }
    }
}