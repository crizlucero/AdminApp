using Android.Widget;
using Android.OS;
using PerpetualEngine.Storage;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using System;
using Android.Views;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Android.Graphics;
using Android.Net;
using WorklabsMx.Helpers;
using AndroidHUD;
using WorklabsMx.Enum;
using Android.Content.PM;
using System.Threading.Tasks;
using Android.Support.V4.Widget;
using WorklabsMx.Models;
using System.Linq;
using Android.Support.V7.App;
using Android.App;
using WorklabsMx.Droid.ViewElement;
using WorklabsMx.Droid.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name", Icon = "@mipmap/icon",
        LaunchMode = LaunchMode.SingleInstance,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
              ScreenOrientation = ScreenOrientation.Portrait)]
    public partial class MainActivity : Activity
    {
        ScrollView scroll;
        int page;
        SimpleStorage localStorage;
        EscritorioController DashboardController;
        TableLayout tlPost;
        string nombre, puesto, empresa;
        byte[] foto;
        List<PostModel> posts;
        MenuView menu;
        Dictionary<KeyValuePair<string, string>, byte[]> Usuario_Fotos_Perfil;
        readonly string usuario_imagen_path, publicaciones_imagen_path;
        public MainActivity()
        {
            DashboardController = new EscritorioController();
            Usuario_Fotos_Perfil = new Dictionary<KeyValuePair<string, string>, byte[]>();
            List<ConfiguracionesModel> config = new ConfigurationsController().GetListConfiguraciones();
            usuario_imagen_path = config.Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1;
            publicaciones_imagen_path = config.Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PUBLICACIONES").Parametro_Varchar_1;
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            Usuario_Fotos_Perfil.Clear();
            localStorage.Delete("Parent");
            OpenDashboard();
        }

		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            try
            {
                bool isOnline = ((ConnectivityManager)GetSystemService(ConnectivityService)).ActiveNetworkInfo.IsConnected;
                menu = new MenuView(this);
                localStorage = SimpleStorage.EditGroup("Login");
                localStorage.Delete("Parent");
                OpenDashboard();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                SetContentView(Resource.Layout.OfflineAppLayout);
                Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
                SetActionBar(toolbar);
                ActionBar.Title = Resources.GetString(Resource.String.NoConnection);
            }
        }

        async void OpenDashboard()
        {
            SetContentView(Resource.Layout.DashboardLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Escritorio);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu_white);
            menu.FillMemberCard(ref nombre, ref foto, ref puesto, ref empresa);
            Usuario_Fotos_Perfil.Add(new KeyValuePair<string, string>(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo")), foto);
            menu.FillMenu();
            FindViewById<TextView>(Resource.Id.lblNombre).Text = nombre;
            FindViewById<TextView>(Resource.Id.lblPuesto).Text = puesto;
            ImageView imgPerfil = FindViewById<ImageView>(Resource.Id.imgPerfil);
            if (foto.Length != 0)
            {
                imgPerfil.SetImageBitmap(ImagesHelper.GetRoundedShape(BitmapFactory.DecodeByteArray(foto, 0, foto.Length)));
            }
            else
                imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
            scroll = FindViewById<ScrollView>(Resource.Id.post_scroll);
            tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
            FindViewById<Button>(Resource.Id.btnInitPublish).Click += (sender, e) => ShowPublish();
            SwipeRefreshLayout refresher = FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_container);
            refresher.SetColorSchemeColors(Color.Gray, Color.LightGray, Color.Gray, Color.DarkGray, Color.Black, Color.DarkGray);
            refresher.Refresh += async (sender, e) =>
            {
                page = 0;
                posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
                await FillPosts();
                ((SwipeRefreshLayout)sender).Refreshing = false;
            };
            posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
            await FillPosts();
            scroll.ScrollChange += async (sender, e) =>
            {
                if (posts.Count / (page + 1) > 10)
                    if ((((ScrollView)sender).ScrollY / (page + 1)) > ((scroll.Height) * .6))
                    {
                        ++page;
                        await FillPosts();
                    }
            };

            SearchView svBuscar = FindViewById<SearchView>(Resource.Id.svBuscar);
            svBuscar.QueryTextSubmit += async (sender, e) =>
            {
                ((SearchView)sender).ClearFocus();
                page = 0;
                if (((SearchView)sender).Query.Length != 0)
                    posts = posts.Where(post => post.Publicacion_Contenido.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                        post.Usuario.Usuario_Nombre.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                await FillPosts();
            };
            svBuscar.QueryTextChange += async (sender, e) =>
            {
                if (((SearchView)sender).Query.Length == 0)
                {
                    ((SearchView)sender).ClearFocus();
                    page = 0;
                    posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
                    await FillPosts();
                }
            };
        }

        async Task FillPosts()
        {
            AndHUD.Shared.Show(this, null, -1, MaskType.Black);
            if (page == 0) tlPost.RemoveAllViews();
            await Task.Delay(500);
            posts.Skip(page * sizePage).Take(sizePage).AsParallel().ToList().ForEach(post =>
            {
                LayoutInflater liView = LayoutInflater;
                View PostView = liView.Inflate(Resource.Layout.PostLayout, null, true);

                KeyValuePair<string, string> current = new KeyValuePair<string, string>(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo);

                PostView.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);

                ImageButton imgPerfil = PostView.FindViewById<ImageButton>(Resource.Id.imgPerfil);

                if (Usuario_Fotos_Perfil.ContainsKey(current))
                {
                    if (Usuario_Fotos_Perfil[current] != null)
                        imgPerfil.SetImageBitmap(ImagesHelper.GetRoundedShape(BitmapFactory.DecodeByteArray(Usuario_Fotos_Perfil[current], 0, Usuario_Fotos_Perfil[current].Length)));
                    else
                        imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
                }
                else
                {
                    post.Usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(post.Usuario.Usuario_Fotografia, usuario_imagen_path);
                    Usuario_Fotos_Perfil.Add(current, post.Usuario.Usuario_Fotografia_Perfil);
                    if (post.Usuario.Usuario_Fotografia_Perfil != null)
                        imgPerfil.SetImageBitmap(ImagesHelper.GetRoundedShape(BitmapFactory.DecodeByteArray(post.Usuario.Usuario_Fotografia_Perfil, 0, post.Usuario.Usuario_Fotografia_Perfil.Length)));
                    else
                        imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
                }
                imgPerfil.Click += (sender, e) => ShowPerfilCard(new UsuariosController().GetMemberData(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo));

                TextView lblNombre = PostView.FindViewById<TextView>(Resource.Id.lblNombre);
                lblNombre.Text = post.Usuario.Usuario_Nombre;
                lblNombre.Click += (sender, e) => ShowPerfilCard(new UsuariosController().GetMemberData(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo));

                TextView lblPuesto = PostView.FindViewById<TextView>(Resource.Id.lblPuesto);
                lblPuesto.Text = post.Usuario.Usuario_Puesto;
                lblPuesto.Click += (sender, e) => ShowPerfilCard(new UsuariosController().GetMemberData(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo));

                TextView lblFecha = PostView.FindViewById<TextView>(Resource.Id.lblFecha);
                lblFecha.Text = post.Publicacion_Fecha;
                lblFecha.Click += (sender, e) => ShowPerfilCard(new UsuariosController().GetMemberData(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo));

                TextView lblPost = PostView.FindViewById<TextView>(Resource.Id.lblPost);
                //lblPost.SetMaxWidth(Convert.ToInt32(Resources.DisplayMetrics.WidthPixels * .911));
                lblPost.Text = post.Publicacion_Contenido;

                TextView lblLike = PostView.FindViewById<TextView>(Resource.Id.lblLikes);
                Drawable icLike = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_like);
                if ((int)Build.VERSION.SdkInt > 22)
                    icLike.SetTintList(GetColorStateList(Resource.Color.button_unpressed));
                else
                    icLike.SetTint(Resource.Color.button_unpressed);
                icLike.SetBounds(0, 0, 50, 50);
                lblLike.SetCompoundDrawables(icLike, null, null, null);
                lblLike.Text = post.Publicacion_Me_Gustan_Cantidad + " " + Resources.GetString(Resource.String.str_dashboard_likes);
                lblLike.Click += delegate
                {
                    string transaccion = "ALTA";
                    if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                        transaccion = "BAJA";
                    else if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
                        transaccion = "MODIFICAR";
                    if (new EscritorioController().PostLike(post.Publicacion_Id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), transaccion))
                    {
                        lblLike.Text = new EscritorioController().GetLikesPublish(post.Publicacion_Id) + " " + Resources.GetString(Resource.String.str_dashboard_likes);
                        if (transaccion == "BAJA")
                        {
                            post.Publicacion_Me_Gusta_Usuario = "0";
                            lblLike.SetTextColor(Color.Black);
                            if ((int)Build.VERSION.SdkInt > 22)
                                icLike.SetTintList(GetColorStateList(Resource.Color.button_unpressed));
                            else
                                icLike.SetTint(Resource.Color.button_unpressed);
                        }
                        else
                        {
                            post.Publicacion_Me_Gusta_Usuario = "1";
                            if ((int)Build.VERSION.SdkInt > 22)
                                icLike.SetTintList(GetColorStateList(Resource.Color.like_heart_pressed));
                            else
                                icLike.SetTint(Resource.Color.like_heart_pressed);
                            lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                        }
                    }
                };
                if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                    if ((int)Build.VERSION.SdkInt > 22)
                        icLike.SetTintList(GetColorStateList(Resource.Color.like_heart_pressed));
                    else
                        icLike.SetTint(Resource.Color.like_heart_pressed);

                ImageView imgPost = PostView.FindViewById<ImageView>(Resource.Id.imgPost);

                if (!string.IsNullOrEmpty(post.Publicacion_Imagen))
                {
                    post.Publicacion_Imagen_Post = new UploadImages().DownloadFileFTP(post.Publicacion_Imagen, publicaciones_imagen_path);
                    if (post.Publicacion_Imagen_Post != null && post.Publicacion_Imagen_Post.Length != 0)
                    {
                        imgPost.Visibility = ViewStates.Visible;
                        imgPost.SetImageBitmap(BitmapFactory.DecodeByteArray(post.Publicacion_Imagen_Post, 0, post.Publicacion_Imagen_Post.Length));
                        imgPost.Click += delegate
                        {
                            //AndHUD.Shared.ShowImage(this, Drawable.CreateFromStream());
                        };
                    }
                }
                TextView lblComentario = PostView.FindViewById<TextView>(Resource.Id.lblComments);
                lblComentario.Text = post.Publicacion_Comentarios_Cantidad + " " + Resources.GetString(Resource.String.str_social_network_comments);

                Drawable icComentario = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_mode_comment);
                if ((int)Build.VERSION.SdkInt > 22)
                    icComentario.SetTintList(GetColorStateList(Resource.Color.button_unpressed));
                else
                    icComentario.SetTint(Resource.Color.button_unpressed);
                icComentario.SetBounds(0, 0, 50, 50);
                lblComentario.SetCompoundDrawables(icComentario, null, null, null);

                lblComentario.Click += delegate
                {
                    Intent intent = new Intent(this, typeof(CommentsActivity));
                    intent.PutExtra("post_id", post.Publicacion_Id);
                    intent.PutExtra("comments_total", post.Publicacion_Comentarios_Cantidad);
                    StartActivity(intent);
                };
                if (post.Publicacion_Comentarios_Cantidad != "0")
                {
                    if ((int)Build.VERSION.SdkInt > 22)
                        icComentario.SetTintList(GetColorStateList(Resource.Color.comment_pressed));
                    else
                        icComentario.SetTint(Resource.Color.comment_pressed);
                }
                if (localStorage.Get("Usuario_id") == post.Usuario.Usuario_Id && localStorage.Get("Usuario_Tipo") == post.Usuario.Usuario_Tipo)
                {
                    PostView.FindViewById<ImageView>(Resource.Id.imgMore).Click += delegate
                    {
                        using (PopupMenu menuPost = new PopupMenu(this, PostView.FindViewById<ImageView>(Resource.Id.imgMore), GravityFlags.Center))
                        {
                            menuPost.Inflate(Resource.Menu.post_reporte_menu);
                            menuPost.MenuItemClick += async delegate
                            {
                                if (DashboardController.OcultarPost(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo, post.Publicacion_Id))
                                {
                                    Toast.MakeText(this, "Publicación eliminada", ToastLength.Short).Show();
                                    page = 0;
                                    posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
                                    await FillPosts();
                                }
                                else
                                    Toast.MakeText(this, "Existió un error al eliminar la publicación", ToastLength.Short).Show();
                            };
                            menuPost.Show();
                        }
                    };
                }
                else
                {
                    PostView.FindViewById<ImageView>(Resource.Id.imgMore).Visibility = ViewStates.Gone;
                }
                TableRow row = new TableRow(this);
                row.AddView(PostView);
                tlPost.AddView(row);
            });
            AndHUD.Shared.Dismiss(this);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            /*try
            {
                bool isOnline = ((ConnectivityManager)GetSystemService(ConnectivityService)).ActiveNetworkInfo.IsConnected;
                MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }*/

            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.menu_acceso:
                    StartActivity(new Intent(this, typeof(AccesoActivity)));
                    break;

                default:
                    if (!localStorage.HasKey("Parent"))
                    {
                        LinearLayout menu_scroll = FindViewById<LinearLayout>(Resource.Id.menu);
                        menu_scroll.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels * 3 / 4);
                        if (menu_scroll.Visibility == ViewStates.Gone)
                        {
                            menu_scroll.LayoutParameters.Height = Window.Attributes.Height;
                            menu_scroll.Visibility = ViewStates.Visible;
                        }
                        else
                            menu_scroll.Visibility = ViewStates.Gone;
                    }
                    else
                    {
                        localStorage.Delete("Parent");
                        menu.FillMenu();
                    }

                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}