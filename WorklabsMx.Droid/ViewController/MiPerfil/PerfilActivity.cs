using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "PerfilActivity")]
    public class PerfilActivity : Activity
    {
        SimpleStorage storage;
        public string usuario_id = string.Empty, usuario_tipo = string.Empty;
        MiembrosController Favorites;
        TableLayout tlPost;
        ScrollView svDirectorio;
        public PerfilActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
            Favorites = new MiembrosController();
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
            FillDescripcionData();
            SimpleStorage.SetContext(ApplicationContext);
        }

        void ButtonAction()
        {
            FindViewById<ImageButton>(Resource.Id.btnDescripcion).Click += (sender, e) => FillDescripcionData();

            FindViewById<ImageButton>(Resource.Id.btnPosts).Click += delegate
            {
                SetContentView(Resource.Layout.PostsUserLayout);
                if (!string.IsNullOrEmpty(Intent.GetStringExtra("usuario_id")) && !string.IsNullOrEmpty(Intent.GetStringExtra("usuario_tipo")))
                {
                    SetContentView(Resource.Layout.PrePostUserLayout);
                    Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                    SetActionBar(toolbar);
                    ActionBar.SetDisplayHomeAsUpEnabled(true);
                }
                else
                {
                    SetContentView(Resource.Layout.PostsUserLayout);
                }
                tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
                List<string> data = new MiembrosController().GetMemberName(usuario_id, usuario_tipo);
                FindViewById<TextView>(Resource.Id.lblNombre).Text = data[(int)CamposMiembro.Usuario_Nombre];
                FindViewById<TextView>(Resource.Id.lblPuesto).Text = data[(int)CamposMiembro.Usuario_Puesto];
                FindViewById<Button>(Resource.Id.btnInitPublish).Click += (sender, e) => ShowPublish();
                FillPosts();
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
            MiembroModel miembro;
            ImageButton btnFavorito = FindViewById<ImageButton>(Resource.Id.btnFavorite);
            miembro = new MiembrosController().GetMemberData(usuario_id, usuario_tipo);
            if (!string.IsNullOrEmpty(Intent.GetStringExtra("usuario_id")) || !string.IsNullOrEmpty(Intent.GetStringExtra("usuario_tipo")))
            {
                ActionBar.Title = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
                if (storage.Get("Usuario_Id") != miembro.Miembro_Id || storage.Get("Usuario_Tipo") != miembro.Miembro_Tipo)
                {
                    KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Miembro_Id, miembro.Miembro_Tipo);
                    btnFavorito.Visibility = ViewStates.Visible;
                    btnFavorito.SetBackgroundColor(Color.White);
                    if (isFavorite.Value)
                        btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                    btnFavorito.Click += delegate
                    {
                        if (isFavorite.Key == 0)
                        {
                            if (Favorites.AddMiembroFavorito(usuario_id, usuario_tipo, miembro.Miembro_Id, miembro.Miembro_Tipo))
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
                        isFavorite = Favorites.IsMiembroFavorito(usuario_id, usuario_tipo, miembro.Miembro_Id, miembro.Miembro_Tipo);
                    };
                }
            }
            FindViewById<ImageView>(Resource.Id.imgPerfil).SetImageURI(Android.Net.Uri.Parse("http://worklabs.mx/Dashboard_Client/usr_imgs/" + miembro.Miembro_Fotografia));
            FindViewById<TextView>(Resource.Id.txtProfileName).Text = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
            FindViewById<TextView>(Resource.Id.txtEmailPerfil).Text = miembro.Miembro_Correo_Electronico;
            FindViewById<TextView>(Resource.Id.txtGeneroPerfil).Text = miembro.Genero_Descripcion;
            FindViewById<TextView>(Resource.Id.txtFechaNacimientoPerfil).Text = DateTime.TryParse(miembro.Miembro_Fecha_Nacimiento, out var result) ? result.ToString("dd/MM/yyyy") : DateTime.Now.ToString("dd/MM/yyyy");
            FindViewById<TextView>(Resource.Id.txtProfesionPerfil).Text = miembro.Miembro_Profesion;
            FindViewById<TextView>(Resource.Id.txtPuestoPerfil).Text = miembro.Miembro_Puesto;
            FindViewById<TextView>(Resource.Id.txtHabilidadesPerfil).Text = miembro.Miembro_Habilidades;
            FindViewById<TextView>(Resource.Id.txtTelefonoPerfil).Text = miembro.Miembro_Telefono;
            FindViewById<TextView>(Resource.Id.txtCelularPerfil).Text = miembro.Miembro_Celular;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            base.OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }


        void FillPosts()
        {
            ButtonAction();
            new EscritorioController().GetPerfilPosts(usuario_id, usuario_tipo).ForEach((post) =>
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
                ibFotoPostUsuario.SetImageURI(ImagesHelper.GetPerfilImagen(post.Usuario_Fotografia_Ruta));
                GridLayout.LayoutParams param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(0);
                param.RowSpec = GridLayout.InvokeSpec(0, 3);
                ibFotoPostUsuario.LayoutParameters = param;
                ibFotoPostUsuario.Click += (sender, e) => AndHUD.Shared.ShowImage(this, Resources.GetDrawable(Resource.Mipmap.ic_work, null), null, MaskType.Black);
                glPost.AddView(ibFotoPostUsuario);

                TextView txtNombre = new TextView(this)
                {
                    Text = post.Usuario_Nombre,
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
                    //Text = post.Miembro_Puesto,
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
                    Text = new EscritorioController().GetLikes(post.Publicacion_Id) + " Like(s)",
                    TextSize = 10
                };
                lblLike.SetCompoundDrawables(icon, null, null, null);
                lblLike.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 130) / 5);
                lblLike.Click += delegate
                 {
                    if (new EscritorioController().PostLike(post.Publicacion_Id, usuario_id, usuario_tipo))
                        lblLike.Text = new EscritorioController().GetLikes(post.Publicacion_Id) + " Like(s)";
                 };
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
        }

        void DirectorioFavoritos()
        {

            if (!string.IsNullOrEmpty(Intent.GetStringExtra("usuario_id")) || !string.IsNullOrEmpty(Intent.GetStringExtra("usuario_tipo")))
            {
                SetContentView(Resource.Layout.PreFavoritesUserLayout);
                Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                SetActionBar(toolbar);
                ActionBar.SetDisplayHomeAsUpEnabled(true);
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
            foreach (MiembroModel miembro in new MiembrosController().GetMiembrosFavoritos(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo")))
            {
                RelativeLayout llNombre = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };
                TextView txtNombre = new TextView(this)
                {
                    Text = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos,
                    TextSize = 20
                };
                llNombre.AddView(txtNombre);
                if (storage.Get("Usuario_Id") != miembro.Miembro_Id || storage.Get("Usuario_Tipo") != miembro.Miembro_Tipo)
                {
                    KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Miembro_Id, miembro.Miembro_Tipo);
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
                            if (Favorites.AddMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Miembro_Id, miembro.Miembro_Tipo))
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
                        isFavorite = Favorites.IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Miembro_Id, miembro.Miembro_Tipo);
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
                    Text = miembro.Miembro_Correo_Electronico
                };
                txtEmail.Click += delegate
                {
                    try
                    {
                        Intent email = new Intent(Intent.ActionSend);
                        email.PutExtra(Intent.ExtraEmail,
                                       new string[] { miembro.Miembro_Correo_Electronico });
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
                    Text = miembro.Genero_Descripcion
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
                    Text = miembro.Miembro_Fecha_Nacimiento
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
                    Text = miembro.Miembro_Profesion
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
                    Text = miembro.Miembro_Puesto
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
                    Text = miembro.Miembro_Habilidades
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
                    Text = miembro.Miembro_Empresa
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
                    Text = miembro.Miembro_Telefono
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
                    Text = miembro.Miembro_Celular
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

            View customView = liView.Inflate(Resource.Layout.PublishLayout, null);

            builder.SetView(customView);
            builder.Create();
            builder.Show();
        }
    }
}