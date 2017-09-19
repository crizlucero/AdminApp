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

namespace WorklabsMx.Droid
{
    [Activity(Label = "WorklabsMx", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        SimpleStorage storage;
        static int page = 0;
        ScrollView scroll;
        bool limitPage = true;
        int sizePage = 10;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SimpleStorage.SetContext(ApplicationContext);

            storage = SimpleStorage.EditGroup("Login");

            if (storage.HasKey("Usuario_Id") && storage.HasKey("Usuario_Tipo"))
            {
                OpenDashboard();
            }
            else
            {
                SetContentView(Resource.Layout.LoginLayout);

                EditText txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
                EditText txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
                Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
                btnLogin.Touch += (sender, e) =>
                {
                    List<string> MiembrosId = new LoginController().MemberLogin(txtEmail.Text, new PassSecurity().EncodePassword(txtPassword.Text));
                    if (MiembrosId.Count > 0)
                    {
                        var localStorage = SimpleStorage.EditGroup("Login");
                        localStorage.Put("Usuario_Id", MiembrosId[0]);
                        localStorage.Put("Usuario_Tipo", MiembrosId[1]);
                        OpenDashboard();
                    }
                    else
                        Toast.MakeText(this, Resource.String.LoginError, ToastLength.Short);
                };
            }
        }

        void OpenDashboard()
        {
            SetContentView(Resource.Layout.Main);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Escritorio);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            FillMenu(FindViewById<TableLayout>(Resource.Id.menu_layout));
            scroll = FindViewById<ScrollView>(Resource.Id.post_scroll);
            FillPosts();
            scroll.ScrollChange += (sender, e) =>
            {
                if (limitPage)
                    if ((((ScrollView)sender).ScrollY / (page + 1)) >= (scroll.Height - 500))
                    {
                        ++page;
                        FillPosts();
                    }
            };
        }

        void FillPosts()
        {
            TableLayout tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
            List<PostModel> posts = new EscritorioController().GetMuroPosts(page);
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
                    lblFecha.SetMinimumWidth(600);
                    lblFecha.SetX(170);
                    lblFecha.SetY(70);
                    rl.AddView(lblFecha);
                    row.AddView(rl);
                    tlPost.AddView(row);
                    row = new TableRow(this);
                    LinearLayout ll = new LinearLayout(this);

                    TextView lblPost = new TextView(this)
                    {
                        Text = post.POST_CONTENIDO
                    };
                    lblPost.SetMinWidth(Window.Attributes.Width);
                    lblPost.SetMinHeight(50);
                    ll.AddView(lblPost);

                    row.AddView(ll);

                    tlPost.AddView(row);
                }
            }
            else limitPage = false;

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
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
            storage.Delete("Parent");
            foreach (ItemsMenu menu in new EscritorioController().GetMenuAndroid(Convert.ToInt32(storage.Get("Usuario_Tipo"))))
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
                        case "SubMenuActivity":
                            storage.Put("Parent", menu.Menu_Id);
                            StartActivity(new Intent(this, typeof(SubMenuActivity))); break;
                        case "LogoutActivity":
                            storage.Delete("Usuario_Id"); storage.Delete("Usuario_Tipo");
                            StartActivity(new Intent(this, typeof(MainActivity))); break;
                    }
                };
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            }
        }
    }
}