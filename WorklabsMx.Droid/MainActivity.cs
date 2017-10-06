using Android.App;
using Android.Widget;
using Android.OS;
using PerpetualEngine.Storage;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using System;
using Android.Views;
using Android.Content;
using WorklabsMx.Models;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using WorklabsMx.Droid.Helpers;
using Android.Graphics;
using Android.Views.InputMethods;
using Android.Net;
using System.Threading.Tasks;
using WorklabsMx.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "WorklabsMx", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        static int page = 0;
        ScrollView scroll;
        bool limitPage = true;
        int sizePage = 10;
        TableRow.LayoutParams param;
        SimpleStorage localStorage;
        EditText txtEmail, txtPassword;
        EscritorioController DashboardController;
        TableLayout tlPost;
        public MainActivity()
        {
            param = new TableRow.LayoutParams
            {
                Column = 0,
                Span = 2
            };
            DashboardController = new EscritorioController();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            try
            {
                bool isOnline = ((ConnectivityManager)GetSystemService(ConnectivityService)).ActiveNetworkInfo.IsConnected;
                SimpleStorage.SetContext(ApplicationContext);

                localStorage = SimpleStorage.EditGroup("Login");

                if (localStorage.HasKey("Usuario_Id") && localStorage.HasKey("Usuario_Tipo") && localStorage.HasKey("Empresa_Id"))
                {
                    OpenDashboard();
                }
                else
                {
                    SetContentView(Resource.Layout.LoginLayout);

                    txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
                    txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
                    Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
                    txtEmail.EditorAction += (sender, e) =>
                    {
                        if (Android.Util.Patterns.EmailAddress.Matcher(txtEmail.Text).Matches())
                        {
                            if (e.ActionId == ImeAction.Done || e.ActionId == ImeAction.Next)
                            {
                                txtPassword.RequestFocus();
                            }
                        }
                        else Toast.MakeText(this, Resource.String.FormatoCorreoError, ToastLength.Short).Show();
                    };

                    txtPassword.EditorAction += (sender, e) =>
                    {
                        if (e.ActionId == ImeAction.Done)
                        {
                            btnLogin.CallOnClick();
                        }
                    };
                    btnLogin.Touch += BtnLogin_Touch;
                }
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

        void OpenDashboard()
        {
            SetContentView(Resource.Layout.DashboardLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Escritorio);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            FillMenu(FindViewById<TableLayout>(Resource.Id.menu_layout));
            scroll = FindViewById<ScrollView>(Resource.Id.post_scroll);
            tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
            FillPosts();
            scroll.ScrollChange += (sender, e) =>
           {
               if (limitPage)
                   if ((((ScrollView)sender).ScrollY / (page + 1)) >= ((scroll.Height) * .4))
                   {
                       ++page;
                       FillPosts();
                   }
           };
        }

        void FillPosts()
        {
            DashboardController.GetMuroPosts(page * sizePage).ForEach((post) =>
            {

                TableRow row = new TableRow(this);
                row.SetMinimumHeight(100);
                GridLayout glPost = new GridLayout(this)
                {
                    ColumnCount = 4,
                    RowCount = 4
                };

                glPost.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);

                ImageButton ibFotoPostUsuario = new ImageButton(this);
                ibFotoPostUsuario.SetMinimumWidth(150);
                ibFotoPostUsuario.SetMinimumHeight(150);
                ibFotoPostUsuario.SetImageURI(ImagesHelper.GetPerfilImagen(post.Miembro_Fotografia));
                GridLayout.LayoutParams param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(0);
                param.RowSpec = GridLayout.InvokeSpec(0, 3);
                ibFotoPostUsuario.LayoutParameters = param;
                glPost.AddView(ibFotoPostUsuario);

                TextView txtNombre = new TextView(this)
                {
                    Text = post.Miembro_Nombre + " " + post.Miembro_Apellidos,
                    TextSize = 14,
                };
                txtNombre.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels - 150);
                txtNombre.Click += (sender, e) =>
                {
                    Intent perfil = new Intent(this, typeof(PerfilActivity));
                    perfil.PutExtra("usuario_id", post.MIEMBRO_ID);
                    perfil.PutExtra("usuario_tipo", post.Tipo);
                    StartActivity(perfil);
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 3);
                param.RowSpec = GridLayout.InvokeSpec(0);
                txtNombre.LayoutParameters = param;
                glPost.AddView(txtNombre);

                TextView txtPuesto = new TextView(this)
                {
                    Text = post.Miembro_Puesto,
                    TextSize = 12
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 3);
                param.RowSpec = GridLayout.InvokeSpec(1);
                txtPuesto.LayoutParameters = param;
                glPost.AddView(txtPuesto);

                TextView txtPost = new TextView(this)
                {
                    Text = post.POST_CONTENIDO,
                    TextSize = 10,
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 3);
                param.RowSpec = GridLayout.InvokeSpec(2);
                txtPost.LayoutParameters = param;
                glPost.AddView(txtPost);

                TextView txtFecha = new TextView(this)
                {
                    Text = post.POST_FECHA.Substring(0, post.POST_FECHA.Length - 6),
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
                    Text = new EscritorioController().GetLikes(post.POST_ID) + " Like(s)",
                    TextSize = 10
                };
                lblLike.SetCompoundDrawables(icon, null, null, null);
                lblLike.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 150) / 5);
                //lblLike.SetMinHeight(50);
                lblLike.SetX(10);
                lblLike.Click += (sender, e) =>
                {
                    if (new EscritorioController().PostLike(post.POST_ID, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo")))
                        lblLike.Text = "\t" + new EscritorioController().GetLikes(post.POST_ID) + " Like(s)";
                };
                llLike.AddView(lblLike);
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(2);
                param.RowSpec = GridLayout.InvokeSpec(3);
                llLike.LayoutParameters = param;
                glPost.AddView(llLike);

                LinearLayout llComment = new LinearLayout(this);
                Drawable iconComment = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_mode_comment);
                iconComment.SetBounds(0, 0, 20, 20);
                TextView lblComment = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Comentarios),
                    TextSize = 10
                };
                lblComment.SetCompoundDrawables(iconComment, null, null, null);
                lblComment.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 150) / 3);
                //lblLike.SetMinHeight(50);
                lblComment.SetX(10);
                lblComment.Click += (sender, e) =>
                {
                    Intent intent = new Intent(this, typeof(CommentsActivity));
                    intent.PutExtra("post_id", post.POST_ID);
                    StartActivity(intent);
                };
                llComment.AddView(lblComment);
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(3);
                param.RowSpec = GridLayout.InvokeSpec(3);
                llComment.LayoutParameters = param;
                glPost.AddView(llComment);

                row.AddView(glPost);
                tlPost.AddView(row);

            });
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
                    ScrollView menu_scroll = FindViewById<ScrollView>(Resource.Id.menu_scroll);
                    if (menu_scroll.Visibility == ViewStates.Gone)
                    {
                        menu_scroll.LayoutParameters.Height = Window.Attributes.Height;
                        menu_scroll.Visibility = ViewStates.Visible;
                    }
                    else
                    {
                        menu_scroll.Visibility = ViewStates.Gone;
                    }
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        void FillMenu(TableLayout menuLayout)
        {
            localStorage.Delete("Parent");

            using (TableRow row = new TableRow(this))
            {
                KeyValuePair<string, string> data = new MiembrosController().GetMemberName(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
                ImageView image = new ImageView(this);
                image.SetImageBitmap(ImagesHelper.GetImageBitmapFromUrl(data.Value));
                Drawable icon = image.Drawable;
                icon.SetBounds(0, 0, 30, 30);

                Button btnMenu = new Button(this)
                {
                    Text = data.Key,
                    TextAlignment = TextAlignment.ViewStart
                };
                btnMenu.SetWidth(Resources.DisplayMetrics.WidthPixels);
                btnMenu.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
                btnMenu.SetBackgroundColor(Color.White);
                //btnMenu.SetCompoundDrawables(icon, null, null, null);
                btnMenu.Click += delegate
                {
                    StartActivity(new Intent(this, typeof(TabPerfilActivity)));
                };
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            }
            DashboardController.GetMenuAndroid(Convert.ToInt32(localStorage.Get("Usuario_Tipo"))).ForEach((menu) =>
            {
                TableRow row = new TableRow(this);
                Drawable icon = ContextCompat.GetDrawable(this, Resources.GetIdentifier(menu.Image, "mipmap", PackageName));
                icon.SetBounds(0, 0, 30, 30);
                Button btnMenu = new Button(this)
                {
                    Text = menu.Label,
                    TextAlignment = TextAlignment.ViewStart
                };
                btnMenu.SetWidth(Resources.DisplayMetrics.WidthPixels);
                btnMenu.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
                btnMenu.SetBackgroundColor(Color.White);
                btnMenu.SetCompoundDrawables(icon, null, null, null);
                btnMenu.Click += delegate
                {
                    switch (menu.Controller)
                    {
                        case "MainActivity": StartActivity(new Intent(this, typeof(MainActivity))); break;
                        case "MyMembershipActivity": StartActivity(new Intent(this, typeof(MyMembershipActivity))); break;
                        case "SubMenuActivity":
                            localStorage.Put("Parent", menu.Menu_Id);
                            StartActivity(new Intent(this, typeof(SubMenuActivity))); break;
                        case "LogoutActivity":
                            localStorage.Delete("Usuario_Id"); localStorage.Delete("Usuario_Tipo"); localStorage.Delete("Empresa_Id");
                            StartActivity(new Intent(this, typeof(MainActivity))); break;
                    }
                };
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            });
        }

        void BtnLogin_Touch(object sender, View.TouchEventArgs e)
        {
            if (Android.Util.Patterns.EmailAddress.Matcher(txtEmail.Text).Matches())
            {
                List<string> MiembrosId = new LoginController().MemberLogin(txtEmail.Text, new PassSecurity().EncodePassword(txtPassword.Text));
                if (MiembrosId.Count > 0)
                {
                    localStorage = SimpleStorage.EditGroup("Login");
                    localStorage.Put("Usuario_Id", MiembrosId[0]);
                    localStorage.Put("Usuario_Tipo", MiembrosId[1]);
                    localStorage.Put("Empresa_Id", MiembrosId[2]);
                    OpenDashboard();
                }
                else
                    Toast.MakeText(this, Resource.String.LoginError, ToastLength.Short).Show();
            }
            else
                Toast.MakeText(this, Resource.String.FormatoCorreoError, ToastLength.Short).Show();
        }
    }
}