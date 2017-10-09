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
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
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
        TableRow.LayoutParams param;
        ScrollView svDirectorio;
        static int page = 0;
        bool limitPage = true;
        int sizePage = 10;
        public PerfilActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
            param = new TableRow.LayoutParams
            {
                Column = 0,
                Span = 2
            };
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            usuario_id = Intent.GetStringExtra("usuario_id");
            usuario_tipo = Intent.GetStringExtra("usuario_tipo");
            FillDescripcionData();
            SimpleStorage.SetContext(ApplicationContext);
            Favorites = new MiembrosController();

        }

        void ButtonAction()
        {
            FindViewById<ImageButton>(Resource.Id.btnDescripcion).Click += (sender, e) =>
            {
                FillDescripcionData();
            };

            FindViewById<ImageButton>(Resource.Id.btnPosts).Click += (sender, e) =>
            {
                SetContentView(Resource.Layout.PostsUserLayout);
                FillPosts();
            };

            FindViewById<ImageButton>(Resource.Id.btnFavoritos).Click += (sender, e) =>
            {
                DirectorioFavoritos();
            };
        }

        void FillDescripcionData()
        {
            if (!string.IsNullOrEmpty(usuario_id) && !string.IsNullOrEmpty(usuario_tipo))
            {
                SetContentView(Resource.Layout.PrePerfilLayout);
                Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                SetActionBar(toolbar);
                ActionBar.SetDisplayHomeAsUpEnabled(true);
                ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
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

            if (string.IsNullOrEmpty(usuario_id) && string.IsNullOrEmpty(usuario_tipo))
            {
                miembro = new MiembrosController().GetMemberData(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));
            }
            else
            {
                miembro = new MiembrosController().GetMemberData(usuario_id, usuario_tipo);
                ActionBar.Title = miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos;
                if (storage.Get("Usuario_Id") != miembro.Miembro_Id || storage.Get("Usuario_Tipo") != miembro.Miembro_Tipo)
                {
                    KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(usuario_id, usuario_tipo, miembro.Miembro_Id, miembro.Miembro_Tipo);
                    btnFavorito.Visibility = ViewStates.Visible;
                    btnFavorito.SetBackgroundColor(Color.White);
                    if (isFavorite.Value)
                        btnFavorito.SetImageResource(Resource.Mipmap.ic_star);
                    btnFavorito.Click += (sender, e) =>
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
            TableLayout tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
            List<PostModel> posts = new EscritorioController().GetPerfilPosts(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), page);
            limitPage = !(posts.Count < sizePage);
            if (posts.Count <= sizePage)
            {
                foreach (PostModel post in posts)
                {
                    TableRow row = new TableRow(this);
                    row.SetMinimumHeight(100);
                    RelativeLayout rl = new RelativeLayout(this);
                    rl.SetMinimumHeight(150);

                    ImageButton ibFotoPostUsuario = new ImageButton(this);
                    ibFotoPostUsuario.SetMinimumWidth(150);
                    ibFotoPostUsuario.SetMinimumHeight(150);
                    ibFotoPostUsuario.SetImageURI(ImagesHelper.GetPerfilImagen(post.Miembro_Fotografia));
                    rl.AddView(ibFotoPostUsuario);

                    TextView lblNombre = new TextView(this)
                    {
                        Text = post.Miembro_Nombre + " " + post.Miembro_Apellidos,
                        TextSize = 14
                    };
                    lblNombre.Click += (sender, e) =>
                    {
                        Intent perfil = new Intent(this, typeof(PerfilActivity));
                        perfil.PutExtra("usuario_id", post.MIEMBRO_ID);
                        perfil.PutExtra("usuario_tipo", post.Tipo);
                        StartActivity(perfil);
                    };
                    lblNombre.SetX(170);
                    lblNombre.SetY(20);
                    rl.AddView(lblNombre);

                    TextView lblFecha = new TextView(this)
                    {
                        Text = post.POST_FECHA,
                        TextSize = 12
                    };
                    lblFecha.SetMinimumWidth(300);
                    lblFecha.SetX(170);
                    lblFecha.SetY(70);
                    rl.AddView(lblFecha);
                    row.AddView(rl);

                    LinearLayout llButton = new LinearLayout(this);
                    ImageButton btnClear = new ImageButton(this);
                    btnClear.SetImageResource(Resource.Mipmap.ic_clear);
                    btnClear.SetBackgroundColor(Color.White);
                    btnClear.SetMinimumWidth(15);
                    btnClear.SetMinimumHeight(15);
                    btnClear.Click += (sender, e) =>
                    {
                        AlertDialog.Builder alert = new AlertDialog.Builder(this);
                        if (post.MIEMBRO_ID == storage.Get("Usuario_Id") && post.Tipo == storage.Get("Usuario_Tipo"))
                        {
                            alert.SetTitle("Eliminar post");
                            alert.SetMessage("Se eliminará el post");
                            alert.SetPositiveButton("Ok", (senderO, eO) =>
                            {

                                if (new EscritorioController().OcultarPost(post.MIEMBRO_ID, post.POST_ID, 0))
                                {
                                    Toast.MakeText(this, "Post eliminado", ToastLength.Short).Show();

                                }
                                else
                                    Toast.MakeText(this, "Hubo un error, intente de nuevo", ToastLength.Short).Show();
                            });
                            alert.SetNegativeButton("Cancelar", (sender1, e1) => { });
                        }
                        else
                        {
                            alert.SetTitle("Reportar post");
                            alert.SetMessage("¿Desea reportar el post?");
                            alert.SetPositiveButton("Ok", (senderO, eO) =>
                            {
                                {
                                    Intent intent = new Intent(this, typeof(ReportActivity));
                                    intent.PutExtra("post_id", post.POST_ID);
                                    StartActivity(intent);
                                }
                            });
                            alert.SetNegativeButton("Cancelar", (sender1, e1) => { });
                        }
                        Dialog dialog = alert.Create();
                        dialog.Show();
                    };
                    llButton.AddView(btnClear);

                    row.AddView(llButton, 1);
                    tlPost.AddView(row);

                    row = new TableRow(this);
                    LinearLayout llLike = new LinearLayout(this);
                    Drawable icon = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_thumb_up);
                    icon.SetBounds(0, 0, 30, 30);
                    TextView lblLike = new TextView(this)
                    {
                        Text = "\t" + new EscritorioController().GetLikes(post.POST_ID) + " Like(s)"
                    };
                    lblLike.SetCompoundDrawables(icon, null, null, null);
                    lblLike.SetMinWidth(Window.Attributes.Width);
                    lblLike.SetMinHeight(50);
                    lblLike.SetX(10);
                    lblLike.Click += (sender, e) =>
                    {
                        if (new EscritorioController().PostLike(post.POST_ID, storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo")))
                            lblLike.Text = "\t" + new EscritorioController().GetLikes(post.POST_ID) + " Like(s)";
                    };
                    llLike.AddView(lblLike);

                    row.AddView(llLike);

                    tlPost.AddView(row);

                    row = new TableRow(this);
                    LinearLayout llPost = new LinearLayout(this);

                    TextView lblPost = new TextView(this)
                    {
                        Text = post.POST_CONTENIDO
                    };
                    lblPost.SetMinWidth(Window.Attributes.Width);
                    lblPost.SetMinHeight(50);
                    lblPost.SetX(10);
                    llPost.AddView(lblPost);

                    row.AddView(llPost);

                    tlPost.AddView(row);
                    //Comentarios
                    row = new TableRow(this);
                    RelativeLayout rlComentar = new RelativeLayout(this);
                    EditText txtComentar = new EditText(this)
                    {
                        Hint = Resources.GetString(Resource.String.Comentar)
                    };
                    txtComentar.SetWidth(Resources.DisplayMetrics.WidthPixels - 140);
                    rlComentar.AddView(txtComentar);
                    row.AddView(rlComentar);

                    LinearLayout llComentar = new LinearLayout(this);
                    ImageButton btnComentar = new ImageButton(this);
                    btnComentar.SetBackgroundColor(Color.White);
                    btnComentar.SetImageResource(Resource.Mipmap.ic_send);
                    llComentar.AddView(btnComentar);
                    row.AddView(llComentar, 1);
                    tlPost.AddView(row);

                    tlPost.AddView(FillComments(post.POST_ID));
                }
            }
            else limitPage = false;
        }

        TableRow FillComments(string post_id)
        {
            TableRow row = new TableRow(this);
            TableLayout tlComments = new TableLayout(this);
            foreach (ComentarioModel comentario in new EscritorioController().GetComentariosPost(post_id))
            {
                TableRow trComment = new TableRow(this);
                RelativeLayout rl = new RelativeLayout(this);

                rl.SetMinimumHeight(70);

                ImageButton ibFotoPostUsuario = new ImageButton(this);
                ibFotoPostUsuario.SetMinimumWidth(70);
                ibFotoPostUsuario.SetMinimumHeight(70);
                ibFotoPostUsuario.SetImageURI(ImagesHelper.GetPerfilImagen(comentario.Miembro_Fotografia));
                rl.AddView(ibFotoPostUsuario);

                TextView lblNombre = new TextView(this)
                {
                    Text = comentario.Nombre,
                    TextSize = 10
                };
                lblNombre.Click += (sender, e) =>
                {
                    Intent perfil = new Intent(this, typeof(PerfilActivity));
                    perfil.PutExtra("usuario_id", comentario.USUARIO_ID);
                    perfil.PutExtra("usuario_tipo", comentario.USUARIO_TIPO);
                    StartActivity(perfil);
                };
                lblNombre.SetX(80);
                lblNombre.SetMinWidth(Resources.DisplayMetrics.WidthPixels - 140);
                rl.AddView(lblNombre);

                TextView lblFecha = new TextView(this)
                {
                    Text = comentario.COMM_FECHA,
                    TextSize = 8
                };
                lblFecha.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels - 140);
                lblFecha.SetX(80);
                lblFecha.SetY(30);
                rl.AddView(lblFecha);
                trComment.AddView(rl, 0);

                LinearLayout llButton = new LinearLayout(this);
                ImageButton btnClear = new ImageButton(this);
                btnClear.SetBackgroundColor(Color.White);
                btnClear.SetImageResource(Resource.Mipmap.ic_clear);
                btnClear.SetMinimumWidth(15);
                btnClear.SetMinimumHeight(15);
                btnClear.Click += (sender, e) =>
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    if (comentario.USUARIO_ID == storage.Get("Usuario_Id") && comentario.USUARIO_TIPO == storage.Get("Usuario_Tipo"))
                    {
                        alert.SetTitle("Eliminar comentario");
                        alert.SetMessage("Se eliminará el comentario");
                        alert.SetPositiveButton("Ok", (senderO, eO) =>
                        {

                            if (new EscritorioController().OcultarComment(comentario.COMM_ID, 0))
                            {
                                Toast.MakeText(this, "Comentario eliminado", ToastLength.Short).Show();

                            }
                            else
                                Toast.MakeText(this, "Hubo un error, intente de nuevo", ToastLength.Short).Show();
                        });
                        alert.SetNegativeButton("Cancelar", (sender1, e1) => { });
                    }
                    else
                    {
                        alert.SetTitle("Reportar comentario");
                        alert.SetMessage("¿Desea reportar el comentario?");
                        alert.SetPositiveButton("Ok", (senderO, eO) =>
                        {
                            {
                                Intent intent = new Intent(this, typeof(ReportActivity));
                                intent.PutExtra("comment_id", comentario.COMM_ID);
                                StartActivity(intent);
                            }
                        });
                        alert.SetNegativeButton("Cancelar", (sender1, e1) => { });
                    }
                    Dialog dialog = alert.Create();
                    dialog.Show();
                };
                llButton.AddView(btnClear);

                trComment.AddView(llButton, 1);

                tlComments.AddView(trComment);
                trComment = new TableRow(this);
                LinearLayout llComentario = new LinearLayout(this);

                TextView lblComentario = new TextView(this)
                {
                    Text = comentario.COMM_CONTENIDO,
                    TextSize = 10
                };
                lblComentario.SetMinWidth(Window.Attributes.Width);
                lblComentario.SetMinHeight(30);
                lblComentario.SetX(20);
                llComentario.AddView(lblComentario);

                trComment.AddView(llComentario);

                tlComments.AddView(trComment);
            }
            row.AddView(tlComments, param);
            return row;
        }

        void DirectorioFavoritos()
        {
            SetContentView(Resource.Layout.FavoritesUserLayout);

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
                    btnFavorito.Click += (sender, e) =>
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
                txtEmail.Click += (sender, e) =>
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
    }
}