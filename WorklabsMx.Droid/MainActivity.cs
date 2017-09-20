﻿using Android.App;
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
        static int page = 0;
        ScrollView scroll;
        bool limitPage = true;
        int sizePage = 10;
        TableRow.LayoutParams param;
        SimpleStorage localStorage;
        public MainActivity()
        {
            param = new TableRow.LayoutParams
            {
                Column = 0,
                Span = 2
            };
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SimpleStorage.SetContext(ApplicationContext);

            localStorage = SimpleStorage.EditGroup("Login");

            if (localStorage.HasKey("Usuario_Id") && localStorage.HasKey("Usuario_Tipo"))
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
                        localStorage = SimpleStorage.EditGroup("Login");
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
                        AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                        if (post.MIEMBRO_ID == localStorage.Get("Usuario_Id") && post.Tipo == localStorage.Get("Usuario_Tipo"))
                        {
                            dialog.SetTitle("Eliminar post");
                            dialog.SetMessage("Se eliminará el post");
                            dialog.SetPositiveButton("Ok", (senderO, eO) =>
                            {

                                if (new EscritorioController().OcultarPost(post.MIEMBRO_ID, post.POST_ID, 0))
                                {
                                    Toast.MakeText(this, "Post eliminado", ToastLength.Short).Show();

                                }
                                else
                                    Toast.MakeText(this, "Hubo un error, intente de nuevo", ToastLength.Short).Show();
                            });
                            dialog.SetNegativeButton("Cancelar", (sender1, e1) => { });
                        }
                        else
                        {
							dialog.SetTitle("Reportar post");
							dialog.SetMessage("¿Desea reportar el post?");
                            dialog.SetPositiveButton("Ok", (senderO, eO) =>
                            {
                                {
                                    /*ReporteController reporteController = (ReporteController)Storyboard.InstantiateViewController("ReporteController");
                                    reporteController.post_id = post.POST_ID;
                                    reporteController.Title = "Reportar Post";
                                    NavigationController.PushViewController(reporteController, true);
                                    ((UIButton)sender).BackgroundColor = UIColor.Clear;*/
                                }
                            });
                            dialog.SetNegativeButton("Cancelar", (sender1, e1) => { });
                        }
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
                    lblLike.Click += (sender, e) => {
                        if (new EscritorioController().PostLike(post.POST_ID, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo")))
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
                rl.AddView(lblNombre);

                TextView lblFecha = new TextView(this)
                {
                    Text = comentario.COMM_FECHA,
                    TextSize = 8
                };
                lblFecha.SetMinimumWidth(600);
                lblFecha.SetX(80);
                lblFecha.SetY(30);
                rl.AddView(lblFecha);
                trComment.AddView(rl);

                LinearLayout llButton = new LinearLayout(this);
                ImageButton btnClear = new ImageButton(this);
                btnClear.SetBackgroundColor(Color.White);
                btnClear.SetImageResource(Resource.Mipmap.ic_clear);
                btnClear.SetMinimumWidth(15);
                btnClear.SetMinimumHeight(15);
                btnClear.SetX(50);
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

                row.AddView(tlComments, param);
            }
            return row;
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
            localStorage.Delete("Parent");
            foreach (ItemsMenu menu in new EscritorioController().GetMenuAndroid(Convert.ToInt32(localStorage.Get("Usuario_Tipo"))))
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
                            localStorage.Delete("Usuario_Id"); localStorage.Delete("Usuario_Tipo");
                            StartActivity(new Intent(this, typeof(MainActivity))); break;
                    }
                };
                row.AddView(btnMenu);
                menuLayout.AddView(row);
            }
        }
    }
}