using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;
using AndroidHUD;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReportActivity : Activity
    {
        string post_id, comment_id;
        int acusacion_id;
        bool isSelectedRadio;
        SimpleStorage localStorage;
        EscritorioController ctrlEscritorio;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReportLayout);
            SimpleStorage.SetContext(ApplicationContext);
            ctrlEscritorio = new EscritorioController();
            localStorage = SimpleStorage.EditGroup("Login");
            post_id = Intent.GetStringExtra("post_id");
            comment_id = Intent.GetStringExtra("comment_id");
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Reportes);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            FillPost();
            FillAcusacion();
        }
        void FillPost()
        {
            TableLayout tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
            PostModel post = new EscritorioController().GetSinglePost(post_id);
            //string Usuario_Id = post.Miembro_Id ?? post.Colaborador_Empresa_Id;
            TableRow row = new TableRow(this);
            row.SetMinimumHeight(100);
            RelativeLayout rl = new RelativeLayout(this);
            rl.SetMinimumHeight(150);

            ImageButton ibFotoPostUsuario = new ImageButton(this);
            ibFotoPostUsuario.SetMinimumWidth(150);
            ibFotoPostUsuario.SetMinimumHeight(150);
            ibFotoPostUsuario.SetImageURI(ImagesHelper.GetPerfilImagen(post.Usuario.Usuario_Fotografia));
            rl.AddView(ibFotoPostUsuario);

            TextView lblNombre = new TextView(this)
            {
                Text = post.Usuario.Usuario_Nombre,
                TextSize = 14
            };
            lblNombre.Click += delegate
            {
                Intent perfil = new Intent(this, typeof(TabPerfilActivity));
                perfil.PutExtra("usuario_id", post.Usuario.Usuario_Id);
                perfil.PutExtra("usuario_tipo", post.Usuario.Usuario_Tipo);
                StartActivity(perfil);
            };
            lblNombre.SetX(170);
            lblNombre.SetY(20);
            lblNombre.SetWidth(Resources.DisplayMetrics.WidthPixels - 140);
            rl.AddView(lblNombre);

            TextView lblFecha = new TextView(this)
            {
                Text = post.Publicacion_Fecha,
                TextSize = 12
            };
            lblFecha.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels - 140);
            lblFecha.SetX(170);
            lblFecha.SetY(70);
            rl.AddView(lblFecha);
            row.AddView(rl);

            tlPost.AddView(row);

            row = new TableRow(this);
            LinearLayout llLike = new LinearLayout(this);
            Drawable icon = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_thumb_up);
            icon.SetBounds(0, 0, 30, 30);
            TextView lblLike = new TextView(this)
            {
                Text = "\t" + post.Publicacion_Me_Gustan_Cantidad + " Like(s)"
            };
            lblLike.SetCompoundDrawables(icon, null, null, null);
            lblLike.SetMinWidth(Window.Attributes.Width);
            lblLike.SetMinHeight(50);
            lblLike.SetX(10);
            lblLike.Click += delegate
            {
                /*if (new EscritorioController().PostLike(post.Publicacion_Id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo")))
                    lblLike.Text = "\t" + new EscritorioController().GetLikesPublish(post.Publicacion_Id) + " Like(s)";*/
            };
            llLike.AddView(lblLike);

            row.AddView(llLike);

            tlPost.AddView(row);

            row = new TableRow(this);
            LinearLayout llPost = new LinearLayout(this);

            TextView lblPost = new TextView(this)
            {
                Text = post.Publicacion_Contenido
            };
            lblPost.SetMinWidth(Window.Attributes.Width);
            lblPost.SetMinHeight(50);
            lblPost.SetX(10);
            llPost.AddView(lblPost);

            row.AddView(llPost);

            tlPost.AddView(row);

        }

        void FillAcusacion()
        {
            RadioGroup rgAcusaciones = FindViewById<RadioGroup>(Resource.Id.rgAcusaciones);
            foreach (KeyValuePair<int, string> mensaje in new EscritorioController().GetMensajesReporte())
            {
                LinearLayout llRadio = new LinearLayout(this);

                RadioButton rbAcusacion = new RadioButton(this)
                {
                    Text = mensaje.Value,
                    Tag = mensaje.Key
                };
                rbAcusacion.Click += (sender, e) =>
                {
                    isSelectedRadio = true;
                    acusacion_id = Convert.ToInt32(((RadioButton)sender).Tag);
                };
                rgAcusaciones.AddView(rbAcusacion);
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.send_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.menu_send:
                    if (isSelectedRadio)
                    {
                        bool report = false;
                        AndHUD.Shared.Show(this, null, -1, MaskType.Black);
                        if (!string.IsNullOrEmpty(post_id))
                            report = ctrlEscritorio.ReportarPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), acusacion_id);
                        else
                            report = ctrlEscritorio.ReportarComment(comment_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), acusacion_id);
                        AndHUD.Shared.Dismiss(this);
                        if (report)
                        {
                            Toast.MakeText(this, "Gracias por su aportación\nEl equipo de Worklabs revisará el caso.", ToastLength.Short).Show();
                            base.OnBackPressed();
                        }
                        else
                            Toast.MakeText(this, "Existió un error, intente de nuevo", ToastLength.Short).Show();
                    }
                    else
                        Toast.MakeText(this, "Seleccione una opción de reporte", ToastLength.Short).Show();
                    break;
                default:
                    Intent intent = new Intent(this, typeof(CommentsActivity));
                    intent.PutExtra("post_id", post_id);
                    StartActivity(intent);
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
