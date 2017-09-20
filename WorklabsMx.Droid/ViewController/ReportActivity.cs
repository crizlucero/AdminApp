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
using WorklabsMx.Models;

namespace WorklabsMx.Droid.ViewController
{
    [Activity(Label = "ReportActivity")]
    public class ReportActivity : Activity
    {
        string post_id;
        SimpleStorage localStorage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReportLayout);
            SimpleStorage.SetContext(ApplicationContext);

            localStorage = SimpleStorage.EditGroup("Login");
            post_id = Intent.GetStringExtra("post_id");
            FillPost();
        }
        void FillPost()
        {
            TableLayout tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
            PostModel post = new EscritorioController().GetSinglePost(post_id);
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
        }

        void FillAcusacion(){
            TableLayout tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
			foreach (KeyValuePair<int, string> mensaje in new EscritorioController().GetMensajesReporte())
			{
                TableRow row = new TableRow(this);
                LinearLayout llRadio = new LinearLayout(this);
                RadioGroup rgAcusacion = new RadioGroup(this);
                llRadio.AddView(rgAcusacion);
                row.AddView(llRadio);
				LinearLayout llAcusacion = new LinearLayout(this);
                TextView lblAcusacion = new TextView(this){
                    Text = mensaje.Value
                };
				llAcusacion.AddView(lblAcusacion);
				row.AddView(llAcusacion);
			}
		}
    }
}
