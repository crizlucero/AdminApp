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
using WorklabsMx.Droid.Helpers;
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
        string nombre, puesto, foto, empresa, upload_image_path;
        List<PostModel> posts;
        MenuView menu;
        public MainActivity()
        {
            DashboardController = new EscritorioController();


        }

        protected override void OnPause()
        {
            base.OnPause();
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
                upload_image_path = new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PUBLICACIONES").Parametro_Varchar_1;
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
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            menu.FillMemberCard(ref nombre, ref foto, ref puesto, ref empresa);
            menu.FillMenu();
            FindViewById<TextView>(Resource.Id.lblNombre).Text = nombre;
            FindViewById<TextView>(Resource.Id.lblPuesto).Text = puesto;
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
            await Task.Delay(500);
            if (page == 0) tlPost.RemoveAllViews();
            posts.Skip(page * sizePage).Take(sizePage).ToList().ForEach(post =>
            {
                LayoutInflater liView = LayoutInflater;
                View PostView = liView.Inflate(Resource.Layout.PostLayout, null, true);
                PostView.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);
                //string Usuario_Id = !string.IsNullOrEmpty(post.Usuario.Usuario_Id) ? post.Miembro_Id : post.Colaborador_Empresa_Id;

                ImageButton imgPerfil = PostView.FindViewById<ImageButton>(Resource.Id.imgPerfil);
                if (post.Usuario.Usuario_Fotografia_Perfil != null)
                    imgPerfil.SetImageURI(ImagesHelper.GetPerfilImagen(post.Usuario.Usuario_Fotografia));
                else
                    imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
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
                lblPost.SetMaxWidth(Convert.ToInt32(Resources.DisplayMetrics.WidthPixels * .911));
                lblPost.Text = post.Publicacion_Contenido;

                TextView lblLike = PostView.FindViewById<TextView>(Resource.Id.lblLikes);
                Drawable icLike = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_like);
                icLike.SetTintList(GetColorStateList(Resource.Color.button_unpressed));
                icLike.SetBounds(0, 0, 50, 50);
                lblLike.SetCompoundDrawables(icLike, null, null, null);
                lblLike.Text = post.Publicacion_Me_Gustan_Cantidad + " " + Resources.GetString(Resource.String.Likes);
                lblLike.Click += delegate
                {
                    string transaccion = "ALTA";
                    if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                        transaccion = "BAJA";
                    else if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
                        transaccion = "MODIFICAR";
                    if (new EscritorioController().PostLike(post.Publicacion_Id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), transaccion))
                    {
                        lblLike.Text = new EscritorioController().GetLikesPublish(post.Publicacion_Id) + " " + Resources.GetString(Resource.String.Likes);
                        if (transaccion == "BAJA")
                        {
                            post.Publicacion_Me_Gusta_Usuario = "0";
                            lblLike.SetTextColor(Color.Black);
                            icLike.SetTintList(GetColorStateList(Resource.Color.button_unpressed));
                        }
                        else
                        {
                            post.Publicacion_Me_Gusta_Usuario = "1";
                            icLike.SetTintList(GetColorStateList(Resource.Color.like_heart_pressed));
                            lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                        }
                    }
                };
                if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                    icLike.SetTintList(GetColorStateList(Resource.Color.like_heart_pressed));

                ImageView imgPost = PostView.FindViewById<ImageView>(Resource.Id.imgPost);
                if (!string.IsNullOrEmpty(post.Publicacion_Imagen_Ruta))
                {
                    byte[] photo = new UploadImages().DownloadFileFTP(post.Publicacion_Imagen, upload_image_path);
                    if (photo != null && photo.Length != 0)
                    {
                        imgPost.Visibility = ViewStates.Visible;
                        imgPost.SetImageBitmap(BitmapFactory.DecodeByteArray(photo, 0, photo.Length));//SetImageURI(Android.Net.Uri.Parse("http://desarrolloworklabs.com/Dashboard_Client/" + post.Publicacion_Imagen_Ruta));
                        imgPost.Click += delegate
                        {
                            //AndHUD.Shared.ShowImage(this, Drawable.CreateFromStream());
                        };
                    }
                }
                TextView lblComentario = PostView.FindViewById<TextView>(Resource.Id.lblComments);
                lblComentario.Text = post.Publicacion_Comentarios_Cantidad + " " + Resources.GetString(Resource.String.Comentarios);

                Drawable icComentario = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_mode_comment);
                icComentario.SetTintList(GetColorStateList(Resource.Color.button_unpressed));
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
                    icComentario.SetTintList(GetColorStateList(Resource.Color.comment_pressed));
                }
                TableRow row = new TableRow(this);
                row.AddView(PostView);
                tlPost.AddView(row);
            });
            AndHUD.Shared.Dismiss(this);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            try
            {
                bool isOnline = ((ConnectivityManager)GetSystemService(ConnectivityService)).ActiveNetworkInfo.IsConnected;
                MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }

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