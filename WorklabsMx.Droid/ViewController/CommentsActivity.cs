using System;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "CommentsActivity")]
    public class CommentsActivity : Activity
    {
        EscritorioController DashboardController;
        SimpleStorage localStorage;
        TableLayout tlComentarios;
        ScrollView svComentarios;
        string post_id;
        public CommentsActivity()
        {
            localStorage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CommentLayout);

            post_id = Intent.GetStringExtra("post_id");

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Comentarios);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            DashboardController = new EscritorioController();
            svComentarios = FindViewById<ScrollView>(Resource.Id.svComentarios);
            tlComentarios = FindViewById<TableLayout>(Resource.Id.llComentarios);
            if (Convert.ToInt32(Intent.GetStringExtra("comments_total")) > 0)
                FillComments();
            FindViewById<ImageButton>(Resource.Id.btnApplyComment).Click += delegate
            {
                AndHUD.Shared.Show(this, null, -1, MaskType.Black);
                if (new EscritorioController().CommentPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), FindViewById<EditText>(Resource.Id.txtComment).Text))
                {
                    FindViewById<EditText>(Resource.Id.txtComment).Text = "";
                    FindViewById<EditText>(Resource.Id.txtComment).ClearFocus();
                    FillComments();
                    svComentarios.ScrollY = svComentarios.Height;
                }
                AndHUD.Shared.Dismiss(this);
            };

        }

        void FillComments()
        {
            AndHUD.Shared.Show(this, null, -1, MaskType.Black);
            tlComentarios.RemoveAllViews();
            DashboardController.GetComentariosPost(post_id).ForEach((comentario) =>
            {
                TableRow row = new TableRow(this);
                row.SetMinimumHeight(100);
                row.SetBackgroundResource(Resource.Drawable.CardStyle);
                TableLayout.LayoutParams layoutParams = new TableLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                layoutParams.SetMargins(10, 0, 10, 0);
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
                    AndHUD.Shared.ShowImage(this, Resources.GetDrawable(Resource.Mipmap.ic_work, null), null, MaskType.Black);

                glPost.AddView(ibFotoPostUsuario);

                TextView txtNombre = new TextView(this)
                {
                    Text = comentario.Nombre,
                    TextSize = 14,
                };
                txtNombre.SetMinimumWidth((Resources.DisplayMetrics.WidthPixels - 200) / 2);
                txtNombre.Click += delegate
                {
                    Intent perfil = new Intent(this, typeof(PerfilActivity));
                    perfil.PutExtra("usuario_id", comentario.USUARIO_ID);
                    perfil.PutExtra("usuario_tipo", comentario.USUARIO_TIPO);
                    StartActivity(perfil);
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 2);
                param.RowSpec = GridLayout.InvokeSpec(0);
                txtNombre.LayoutParameters = param;
                glPost.AddView(txtNombre);

                LinearLayout llButton = new LinearLayout(this);
                llButton.SetMinimumWidth(20);
                llButton.SetMinimumHeight(20);
                llButton.SetBackgroundColor(Color.AliceBlue);
                ImageButton btnClear = new ImageButton(this);
                btnClear.SetBackgroundColor(Color.White);
                btnClear.SetImageResource(Resource.Mipmap.ic_clear);
                btnClear.SetMinimumWidth(15);
                btnClear.SetMinimumHeight(15);
                btnClear.SetMaxWidth(20);
                btnClear.SetMaxHeight(20);
                btnClear.Click += delegate
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    if (comentario.USUARIO_ID == localStorage.Get("Usuario_Id") && comentario.USUARIO_TIPO == localStorage.Get("Usuario_Tipo"))
                    {
                        alert.SetTitle(Resources.GetString(Resource.String.BorrarComentario));
                        alert.SetMessage(Resources.GetString(Resource.String.MensajeBorrarComentario));
                        alert.SetPositiveButton(Resources.GetString(Resource.String.OK), (senderO, eO) =>
                        {
                            AndHUD.Shared.Show(this, null, -1, MaskType.Black);
                            if (new EscritorioController().OcultarComment(comentario.POST_ID, 0))
                            {
                                Toast.MakeText(this, Resources.GetString(Resource.String.ComentarioEliminado), ToastLength.Short).Show();
                                tlComentarios.RemoveView(row);
                            }
                            else
                                Toast.MakeText(this, Resources.GetString(Resource.String.ErrorIntento), ToastLength.Short).Show();
                            AndHUD.Shared.Dismiss();
                        });
                        alert.SetNegativeButton(Resources.GetString(Resource.String.Cancelar), (sender1, e1) => { });
                    }
                    else
                    {
                        alert.SetTitle(Resources.GetString(Resource.String.ReportarComentario));
                        alert.SetMessage(Resources.GetString(Resource.String.MensajeReportarComentario));
                        alert.SetPositiveButton(Resources.GetString(Resource.String.OK), (senderO, eO) =>
                        {
                            Intent intent = new Intent(this, typeof(ReportActivity));
                            intent.PutExtra("comment_id", comentario.COMM_ID);
                            StartActivity(intent);
                        });
                        alert.SetNegativeButton(Resources.GetString(Resource.String.Cancelar), (sender1, e1) => { });
                    }
                    alert.Create();
                    alert.Show();
                };
                param = new GridLayout.LayoutParams();
                param.Width = 30;
                param.Height = 30;
                param.LeftMargin = (Resources.DisplayMetrics.WidthPixels / 5);
                param.SetGravity(GravityFlags.Right);
                param.TopMargin = 20;
                param.ColumnSpec = GridLayout.InvokeSpec(3);
                param.RowSpec = GridLayout.InvokeSpec(0, 3);
                llButton.LayoutParameters = param;
                llButton.AddView(btnClear);
                glPost.AddView(llButton);

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

                row.AddView(glPost);
                tlComentarios.AddView(row);
            });
            AndHUD.Shared.Dismiss(this);
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            base.OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }
    }
}
