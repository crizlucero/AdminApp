using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using AndroidHUD;
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
        TableLayout tlComentarios;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CommentLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Escritorio);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            DashboardController = new EscritorioController();
            tlComentarios = FindViewById<TableLayout>(Resource.Id.llComentarios);
            FillComments(Intent.GetStringExtra("post_id"));

        }

        void FillComments(string post_id)
        {
            DashboardController.GetComentariosPost(post_id).ForEach((comentario) =>
            {
                TableRow row = new TableRow(this);
                row.SetMinimumHeight(100);
                row.SetBackgroundColor(Color.AliceBlue);
                TableLayout.LayoutParams layoutParams = new TableLayout.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.WrapContent);
                layoutParams.SetMargins(10, 10, 10, 10);
                row.LayoutParameters = layoutParams;
                GridLayout glPost = new GridLayout(this)
                {
                    ColumnCount = 4,
                    RowCount = 4
                };

                glPost.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);

                ImageButton ibFotoPostUsuario = new ImageButton(this);
                ibFotoPostUsuario.SetMinimumWidth(150);
                ibFotoPostUsuario.SetMinimumHeight(150);
                ibFotoPostUsuario.SetImageURI(ImagesHelper.GetPerfilImagen(comentario.Miembro_Fotografia));
                GridLayout.LayoutParams param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(0);
                param.RowSpec = GridLayout.InvokeSpec(0, 3);
                ibFotoPostUsuario.LayoutParameters = param;
                ibFotoPostUsuario.Click += (sender, e) =>
                {
                    AndHUD.Shared.ShowImage(this, Resources.GetDrawable(Resource.Mipmap.ic_work), null, MaskType.Black);
                };
                glPost.AddView(ibFotoPostUsuario);

                TextView txtNombre = new TextView(this)
                {
                    Text = comentario.Nombre,
                    TextSize = 14,
                };
                txtNombre.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels - 150);
                txtNombre.Click += (sender, e) =>
                {
                    Intent perfil = new Intent(this, typeof(PerfilActivity));
                    perfil.PutExtra("usuario_id", comentario.USUARIO_ID);
                    perfil.PutExtra("usuario_tipo", comentario.USUARIO_TIPO);
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
                    Text = comentario.USUARIO_PUESTO,
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
                    Text = comentario.COMM_CONTENIDO,
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
                    Text = comentario.COMM_FECHA.Substring(0, comentario.COMM_FECHA.Length - 6),
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
                    //Text = new EscritorioController().GetLikes(comentario.COMM_ID) + " Like(s)",
                    TextSize = 10
                };
                lblLike.SetCompoundDrawables(icon, null, null, null);
                lblLike.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 150) / 5);
                //lblLike.SetMinHeight(50);
                lblLike.SetX(10);
                lblLike.Click += (sender, e) =>
                {
                    //if (new EscritorioController().PostLike(post.POST_ID, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo")))
                    //	lblLike.Text = "\t" + new EscritorioController().GetLikes(post.POST_ID) + " Like(s)";
                };
                llLike.AddView(lblLike);
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(2);
                param.RowSpec = GridLayout.InvokeSpec(3);
                llLike.LayoutParameters = param;
                glPost.AddView(llLike);

                row.AddView(glPost);
                tlComentarios.AddView(row);
                /*
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

                trComment.AddView(llButton, 1);*/
            });
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
