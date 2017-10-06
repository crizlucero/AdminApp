
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "CommentsActivity")]
    public class CommentsActivity : Activity
    {
        EscritorioController DashboardController;
        SimpleStorage localStorage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.DashboardLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Escritorio);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            //FillMenu(FindViewById<TableLayout>(Resource.Id.menu_layout));
            //scroll = FindViewById<ScrollView>(Resource.Id.post_scroll);
            //tlPost = FindViewById<TableLayout>(Resource.Id.post_table);
        }

        TableRow FillComments(string post_id)
        {
            TableRow row = new TableRow(this);
            TableLayout tlComments = new TableLayout(this);
            DashboardController.GetComentariosPost(post_id).ForEach((comentario) =>
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
                   if (comentario.USUARIO_ID == localStorage.Get("Usuario_Id") && comentario.USUARIO_TIPO == localStorage.Get("Usuario_Tipo"))
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
           });
            //row.AddView(tlComments, param);
            return row;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            base.OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }
    }
}
