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
using Java.IO;
using Android.Provider;
using Android.Content.PM;
using static Android.Provider.MediaStore.Images;
using System.Threading.Tasks;
using Android.Support.V4.Widget;
using WorklabsMx.Models;
using System.Linq;
using Android.Support.V7.App;
using Android.App;
using Newtonsoft.Json;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name", Icon = "@mipmap/icon",
        LaunchMode = LaunchMode.SingleInstance,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
              ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        ScrollView scroll;
        int page;
        SimpleStorage localStorage;
        EscritorioController DashboardController;
        TableLayout tlPost;
        Android.Support.V7.App.AlertDialog dialog;
        string nombre, puesto, foto, imgPublish, imagePath, empresa;
        File _file, _dir;
        Bitmap bitmap;
        View customView;
        List<PostModel> posts;
        List<ItemsMenu> ListMenu;
        List<string> DataUsuario;
        readonly int sizePage = 10, PickImageId = 1000, TakePicture = 500;
        public MainActivity()
        {
            DashboardController = new EscritorioController();
            DataUsuario = new List<string>();
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

                localStorage = SimpleStorage.EditGroup("Login");
                ListMenu = DashboardController.GetMenuAndroid(Convert.ToInt32(localStorage.Get("Usuario_Tipo")));
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

        async Task OpenDashboard()
        {
            SetContentView(Resource.Layout.DashboardLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Escritorio);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            FillMemberCard();
            FillMenu();
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
                tlPost.RemoveAllViews();
                posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
                await FillPosts(posts);
                ((SwipeRefreshLayout)sender).Refreshing = false;
            };
            posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
            await FillPosts(posts);
            scroll.ScrollChange += async (sender, e) =>
            {
                if (posts.Count / (page + 1) > 10)
                    if ((((ScrollView)sender).ScrollY / (page + 1)) > ((scroll.Height) * .6))
                    {
                        ++page;
                        await FillPosts(posts);
                    }
            };

            SearchView svBuscar = FindViewById<SearchView>(Resource.Id.svBuscar);
            svBuscar.QueryTextSubmit += async (sender, e) =>
            {
                ((SearchView)sender).ClearFocus();
                tlPost.RemoveAllViews();
                page = 0;
                if (((SearchView)sender).Query.Length != 0)
                    await FillPosts(posts.Where(post => post.Publicacion_Contenido.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                post.Usuario_Nombre.IndexOf(((SearchView)sender).Query, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
                else
                    await FillPosts(posts);
            };
            svBuscar.QueryTextChange += async (sender, e) =>
            {
                if (((SearchView)sender).Query.Length == 0)
                {
                    ((SearchView)sender).ClearFocus();
                    page = 0;
                    tlPost.RemoveAllViews();
                    posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
                    await FillPosts(posts);
                }
            };
        }

        async Task FillPosts(List<PostModel> publicaciones)
        {
            AndHUD.Shared.Show(this, null, -1, MaskType.Black);
            await Task.Delay(500);

            publicaciones.Skip(page * sizePage).Take(sizePage).ToList().ForEach(post =>
            {
                LayoutInflater liView = LayoutInflater;
                View PostView = liView.Inflate(Resource.Layout.PostLayout, null, true);
                PostView.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);
                string Usuario_Id = !string.IsNullOrEmpty(post.Miembro_Id) ? post.Miembro_Id : post.Colaborador_Empresa_Id;

                ImageButton imgPerfil = PostView.FindViewById<ImageButton>(Resource.Id.imgPerfil);
                imgPerfil.SetImageURI(ImagesHelper.GetPerfilImagen(post.Usuario_Fotografia_Ruta));
                imgPerfil.Click += (sender, e) => ShowPerfilCard(new MiembrosController().GetMemberData(Usuario_Id, post.Usuario_Tipo));

                TextView lblNombre = PostView.FindViewById<TextView>(Resource.Id.lblNombre);
                lblNombre.Text = post.Usuario_Nombre;
                lblNombre.Click += (sender, e) => ShowPerfilCard(new MiembrosController().GetMemberData(Usuario_Id, post.Usuario_Tipo));

                TextView lblPuesto = PostView.FindViewById<TextView>(Resource.Id.lblPuesto);
                lblPuesto.Text = post.Usuario_Puesto;
                lblPuesto.Click += (sender, e) => ShowPerfilCard(new MiembrosController().GetMemberData(Usuario_Id, post.Usuario_Tipo));

                TextView lblFecha = PostView.FindViewById<TextView>(Resource.Id.lblFecha);
                lblFecha.Text = post.Publicacion_Fecha;
                lblFecha.Click += (sender, e) => ShowPerfilCard(new MiembrosController().GetMemberData(Usuario_Id, post.Usuario_Tipo));

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
                {
                    icLike.SetTintList(GetColorStateList(Resource.Color.like_heart_pressed));
                }

                ImageView imgPost = PostView.FindViewById<ImageView>(Resource.Id.imgPost);
                if (!string.IsNullOrEmpty(post.Publicacion_Imagen_Ruta))
                {
                    imgPost.Visibility = ViewStates.Visible;
                    imgPost.SetImageURI(Android.Net.Uri.Parse("http://desarrolloworklabs.com/Dashboard_Client/" + post.Publicacion_Imagen_Ruta));
                    imgPost.Click += delegate
                    {
                        AndHUD.Shared.ShowImage(this, Drawable.CreateFromPath(""));
                    };
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

                /*
                btnClear.Click += delegate
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    if (Usuario_Id == localStorage.Get("Usuario_Id") && post.Usuario_Tipo == localStorage.Get("Usuario_Tipo"))
                    {
                        alert.SetTitle(Resources.GetString(Resource.String.BorrarPost));
                        alert.SetMessage(Resources.GetString(Resource.String.MensajeBorrarPost));
                        alert.SetPositiveButton(Resources.GetString(Resource.String.OK), delegate
                    {
                        AndHUD.Shared.Show(this, null, -1, MaskType.Black);
                        if (new EscritorioController().OcultarPost(Usuario_Id, post.Publicacion_Id, 0))
                        {
                            Toast.MakeText(this, Resources.GetString(Resource.String.PostEliminado), ToastLength.Short).Show();
                            page = 0;
                            tlPost.RemoveView(row);
                        }
                        else
                            Toast.MakeText(this, Resources.GetString(Resource.String.ErrorIntento), ToastLength.Short).Show();
                        AndHUD.Shared.Dismiss(this);
                    });
                        alert.SetNegativeButton(Resources.GetString(Resource.String.Cancelar), (sender, e) => { });
                    }
                    else
                    {
                        alert.SetTitle(Resources.GetString(Resource.String.ReportarPost));
                        alert.SetMessage(Resources.GetString(Resource.String.MensajeReportarPost));
                        alert.SetPositiveButton(Resources.GetString(Resource.String.OK), delegate
                    {
                        Intent intent = new Intent(this, typeof(ReportActivity));
                        intent.PutExtra("post_id", post.Publicacion_Id);
                        StartActivity(intent);
                    });
                        alert.SetNegativeButton(Resources.GetString(Resource.String.Cancelar), (sender, e) => { });
                    }
                    alert.Create();
                    alert.Show();
                };*/
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
                        {
                            menu_scroll.Visibility = ViewStates.Gone;
                        }
                    }
                    else
                    {
                        localStorage.Delete("Parent");
                        FillMenu();
                    }

                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        void FillMemberCard()
        {
            DataUsuario = new MiembrosController().GetMemberName(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
            nombre = DataUsuario[(int)CamposMiembro.Usuario_Nombre];
            foto = DataUsuario[(int)CamposMiembro.Usuario_Fotografia];
            puesto = DataUsuario[(int)CamposMiembro.Usuario_Puesto];
            empresa = DataUsuario[(int)CamposMiembro.Usuario_Empresa_Nombre];
            ImageView imgFoto = FindViewById<ImageView>(Resource.Id.imgProfileMenu);
            Bitmap bmFoto = ImagesHelper.GetImageBitmapFromUrl(foto);
            if (bmFoto != null)
                imgFoto.SetImageBitmap(bmFoto);
            else
                imgFoto.SetImageResource(Resource.Mipmap.ic_profile_empty);
            TextView NombreUsuario = FindViewById<TextView>(Resource.Id.lblNombreMenu);
            NombreUsuario.Text = nombre;
            NombreUsuario.SetMaxWidth(Resources.DisplayMetrics.WidthPixels - 110);
            FindViewById<TextView>(Resource.Id.lblEmpresaMenu).Text = empresa;
        }

        void FillMenu()
        {
            //NavigationView nv = FindViewById<NavigationView>(Resource.Id.nav_home);
            TableLayout menuLayout = FindViewById<TableLayout>(Resource.Id.menu_layout);
            menuLayout.RemoveAllViews();
            menuLayout.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);
            ListMenu.Where((ItemsMenu arg) => arg.Menu_Padre_Id == (localStorage.Get("Parent") ?? "")).ToList().ForEach(menu =>
            {
                TableRow row = new TableRow(this);
                View line = new View(this);
                line.SetBackgroundColor(Color.LightGray);
                line.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);
                line.SetMinimumHeight(2);
                row.AddView(line);
                menuLayout.AddView(row);
                row = new TableRow(this);
                Drawable icon = ContextCompat.GetDrawable(this, Resources.GetIdentifier(menu.Image, "mipmap", PackageName));
                icon.SetTintList(GetColorStateList(Resource.Color.comment_pressed));
                icon.SetBounds(0, 0, 50, 50);
                Button btnMenu = new Button(this)
                {
                    Text = menu.Label,
                    TextAlignment = TextAlignment.ViewStart
                };
                btnMenu.SetTextColor(Color.White);
                btnMenu.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
                btnMenu.SetBackgroundColor(Color.Transparent);
                btnMenu.SetCompoundDrawables(icon, null, null, null);
                btnMenu.Click += delegate
                {
                    switch (menu.Controller)
                    {
                        //case "MainActivity": FindViewById<LinearLayout>(Resource.Id.menu).Visibility = ViewStates.Gone; break;
                        case "MyMembershipActivity": StartActivity(new Intent(this, typeof(MyMembershipActivity))); break;
                        case "SubMenuActivity":
                            localStorage.Put("Parent", menu.Menu_Id);
                            FillMenu();
                            break;
                        case "LogoutActivity":
                            localStorage.Delete("Usuario_Id"); localStorage.Delete("Usuario_Tipo"); localStorage.Delete("Empresa_Id");
                            StartActivity(new Intent(this, typeof(LoginActivity)));
                            Finish();
                            break;
                        case "ColeccionProductosActivity": StartActivity(new Intent(this, typeof(ColeccionProductosActivity))); break;
                        case "ReservaSalaJuntasActivity": StartActivity(new Intent(this, typeof(TabSalasJuntasHistorialActivity))); break;
                        case "RegistroInvitadosActivity": StartActivity(new Intent(this, typeof(InvitadosActivity))); break;
                        case "PerfilActivity": StartActivity(new Intent(this, typeof(TabPerfilActivity))); break;
                        case "DatosFacturacionActivity": StartActivity(new Intent(this, typeof(DatosFacturacionActivity))); break;
                        case "MisColaboradoresActivity": StartActivity(new Intent(this, typeof(TabColaboradoresActivity))); break;
                        case "DirectorioActivity": StartActivity(new Intent(this, typeof(DirectorioActivity))); break;
                    }
                };
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            });
        }

        void ShowPerfilCard(MiembroModel miembro)
        {
            Intent intent = new Intent(this, typeof(PerfilCardActivity));
            intent.PutExtra("Miembro", JsonConvert.SerializeObject(miembro));
            StartActivity(intent);
        }

        void ShowPublish()
        {

            Android.Support.V7.App.AlertDialog.Builder builder = new Android.Support.V7.App.AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            customView = liView.Inflate(Resource.Layout.PublishLayout, null, true);

            customView.FindViewById<TextView>(Resource.Id.lblNombre).Text = nombre;
            customView.FindViewById<TextView>(Resource.Id.lblPuesto).Text = puesto;
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
                    if (new EscritorioController().SetPost(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"),
                                                           customView.FindViewById<EditText>(Resource.Id.txtPublicacion).Text,
                                                           bitmapData))
                    {
                        tlPost.RemoveAllViews();
                        page = 0;
                        posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
                        await FillPosts(posts);
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