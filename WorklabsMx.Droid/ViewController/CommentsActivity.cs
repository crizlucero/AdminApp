using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Enum;
using WorklabsMx.Models;
using System.Linq;
using Java.IO;
using Android.Content.PM;
using Android.Provider;
using static Android.Provider.MediaStore.Images;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class CommentsActivity : Activity
    {
        EscritorioController DashboardController;
        SimpleStorage localStorage;
        TableLayout tlComentarios;
        ScrollView svComentarios;
        List<ComentarioModel> comentarios;
        File _file, _dir;
        Bitmap bitmap;
        readonly int sizePage = 10, PickImageId = 1000, TakePicture = 500;
        int page;
        string post_id, imgPublish;
        public CommentsActivity()
        {
            localStorage = SimpleStorage.EditGroup("Login");
        }

        protected async override void OnCreate(Bundle savedInstanceState)
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
            comentarios = DashboardController.GetComentariosPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"));
            FindViewById<ImageButton>(Resource.Id.imgPicture).Visibility = ViewStates.Gone;
            FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
            if (Convert.ToInt32(Intent.GetStringExtra("comments_total")) > 0)
            {
                tlComentarios.RemoveAllViews();
                await FillComments();
            }
            SwipeRefreshLayout refresher = FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_container);
            refresher.SetColorSchemeColors(Color.Gray, Color.LightGray, Color.Gray, Color.DarkGray, Color.Black, Color.DarkGray);
            refresher.Refresh += async (sender, e) =>
            {
                tlComentarios.RemoveAllViews();
                await FillComments();
                ((SwipeRefreshLayout)sender).Refreshing = false;
            };
            FindViewById<ImageButton>(Resource.Id.btnApplyComment).Click += async delegate
            {
                AndHUD.Shared.Show(this, null, -1, MaskType.Black);
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                bitmap?.Compress(Bitmap.CompressFormat.Png, 0, stream);
                byte[] bitmapData = stream?.ToArray();
                if (new EscritorioController().CommentPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), FindViewById<EditText>(Resource.Id.txtComment).Text, bitmapData))
                {
                    FindViewById<EditText>(Resource.Id.txtComment).Text = "";
                    FindViewById<EditText>(Resource.Id.txtComment).ClearFocus();
                    await FillComments();
                    svComentarios.ScrollY = svComentarios.Height;
                }
                AndHUD.Shared.Dismiss(this);
            };
            svComentarios.ScrollChange += async (sender, e) =>
            {
                if ((comentarios.Count / (page + 1)) < 10)
                    if ((((ScrollView)sender).ScrollY / (page + 1)) > ((svComentarios.Height) * .4))
                    {
                        ++page;
                        await FillComments();
                        FindViewById<ImageView>(Resource.Id.imgPicture).Visibility = ViewStates.Gone;
                        FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
                    }
            };

            FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Click += delegate
            {
                ImageButton imgPicture = FindViewById<ImageButton>(Resource.Id.imgPicture);
                _file = null;
                imgPicture.SetImageURI(null);
                imgPicture.Visibility = ViewStates.Gone;
                FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
            };

            FindViewById<ImageButton>(Resource.Id.btnTakePicture).Click += delegate
            {
                CreateDirectoryForPictures();
                IsThereAnAppToTakePictures();
                Intent intent = new Intent(MediaStore.ActionImageCapture);
                _file = new File(_dir, String.Format("{0}.png", Guid.NewGuid()));
                intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(_file));
                StartActivityForResult(intent, TakePicture);
            };

            FindViewById<ImageButton>(Resource.Id.btnAttachImage).Click += delegate
            {
                var imageIntent = new Intent();
                imageIntent.SetType("image/*");
                imageIntent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(
                    Intent.CreateChooser(imageIntent, "Select photo"), PickImageId);
            };

        }

        async Task FillComments()
        {
            AndHUD.Shared.Show(this, null, -1, MaskType.Black);
            await Task.Delay(500);

            comentarios.Skip(page * sizePage).Take(sizePage).ToList().ForEach(comentario =>
            {
                int i = 0;
                String Usuario_Id = comentario.Miembro_Id ?? comentario.Colaborador_Empresa_Id;
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
                ibFotoPostUsuario.SetImageURI(ImagesHelper.GetPerfilImagen(comentario.Usuario_Fotografia_Ruta));
                GridLayout.LayoutParams param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(0);
                param.RowSpec = GridLayout.InvokeSpec(i, 3);
                ibFotoPostUsuario.LayoutParameters = param;
                ibFotoPostUsuario.Click += (sender, e) =>
                    AndHUD.Shared.ShowImage(this, Resources.GetDrawable(Resource.Mipmap.ic_work, null), null, MaskType.Black);

                glPost.AddView(ibFotoPostUsuario);

                TextView txtNombre = new TextView(this)
                {
                    Text = comentario.Usuario_Nombre,
                    TextSize = 14,
                };
                txtNombre.SetMinimumWidth((Resources.DisplayMetrics.WidthPixels - 200) / 2);
                txtNombre.Click += delegate
                {
                    Intent perfil = new Intent(this, typeof(PerfilActivity));
                    perfil.PutExtra("usuario_id", Usuario_Id);
                    perfil.PutExtra("usuario_tipo", comentario.Usuario_Tipo);
                    StartActivity(perfil);
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 2);
                param.RowSpec = GridLayout.InvokeSpec(i);
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
                    if (Usuario_Id == localStorage.Get("Usuario_Id") && comentario.Usuario_Tipo == localStorage.Get("Usuario_Tipo"))
                    {
                        alert.SetTitle(Resources.GetString(Resource.String.BorrarComentario));
                        alert.SetMessage(Resources.GetString(Resource.String.MensajeBorrarComentario));
                        alert.SetPositiveButton(Resources.GetString(Resource.String.OK), (senderO, eO) =>
                        {
                            AndHUD.Shared.Show(this, null, -1, MaskType.Black);
                            if (new EscritorioController().OcultarComment(comentario.Publicacion_Id, 0))
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
                            intent.PutExtra("comment_id", comentario.Comentario_Id);
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
                param.RowSpec = GridLayout.InvokeSpec(i, 3);
                llButton.LayoutParameters = param;
                llButton.AddView(btnClear);
                glPost.AddView(llButton);
                ++i;
                TextView txtPuesto = new TextView(this)
                {
                    Text = comentario.Usuario_Puesto,
                    TextSize = 12
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 3);
                param.RowSpec = GridLayout.InvokeSpec(i);
                txtPuesto.LayoutParameters = param;
                glPost.AddView(txtPuesto);
                ++i;
                TextView txtPost = new TextView(this)
                {
                    Text = comentario.Comentario_Contenido,
                    TextSize = 10,
                };
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1, 3);
                param.RowSpec = GridLayout.InvokeSpec(i);
                txtPost.LayoutParameters = param;
                glPost.AddView(txtPost);
                ++i;
                if (!string.IsNullOrEmpty(comentario.Comentario_Imagen))
                {
                    Android.Net.Uri url = Android.Net.Uri.Parse("http://desarrolloworklabs.com/Dashboard_Client/" + comentario.Comentario_Imagen_Ruta);
                    ImageView imgPost = new ImageView(this);
                    imgPost.SetMaxWidth(75);
                    imgPost.SetMaxHeight(75);
                    imgPost.SetImageURI(url);
                    imgPost.Click += delegate
                    {
                        AndHUD.Shared.ShowImage(this, Drawable.CreateFromPath(""));
                    };
                    param = new GridLayout.LayoutParams();
                    param.SetGravity(GravityFlags.Center);
                    param.ColumnSpec = GridLayout.InvokeSpec(1, 2);
                    param.RowSpec = GridLayout.InvokeSpec(i);
                    imgPost.LayoutParameters = param;
                    glPost.AddView(imgPost);
                    ++i;
                }
                TextView txtFecha = new TextView(this)
                {
                    Text = comentario.Comentario_Fecha.Substring(0, comentario.Comentario_Fecha.Length - 6),
                    TextSize = 10,
                };
                txtFecha.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 150) / 2);
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center);
                param.ColumnSpec = GridLayout.InvokeSpec(1);
                param.RowSpec = GridLayout.InvokeSpec(i);
                txtFecha.LayoutParameters = param;
                glPost.AddView(txtFecha);

                LinearLayout llLike = new LinearLayout(this);
                Drawable icon = ContextCompat.GetDrawable(this, Resource.Mipmap.ic_star_like);
                icon.SetBounds(0, 0, 20, 20);
                TextView lblLike = new TextView(this)
                {
                    Text = comentario.Comentario_Me_Gustan_Cantidad + " Like(s)",
                    TextSize = 10
                };
                lblLike.SetCompoundDrawables(icon, null, null, null);
                lblLike.SetMinWidth((Resources.DisplayMetrics.WidthPixels - 130) / 5);
                lblLike.Click += delegate
                {
                    string transaccion = "ALTA";
                    if (comentario.Comentario_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                        transaccion = "BAJA";
                    else if (comentario.Comentario_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
                        transaccion = "MODIFICAR";
                    if (new EscritorioController().CommentLike(comentario.Comentario_Id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), transaccion))
                    {
                        lblLike.Text = new EscritorioController().GetLikesComments(comentario.Comentario_Id) + " Like(s)";
                        if (transaccion == "BAJA")
                        {
                            comentario.Comentario_Me_Gusta_Usuario = "0";
                            lblLike.SetTextColor(Color.Black);
                        }
                        else
                        {
                            comentario.Comentario_Me_Gusta_Usuario = "1";
                            lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                        }
                    }
                };
                if (comentario.Comentario_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                {
                    lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                }
                llLike.AddView(lblLike);
                param = new GridLayout.LayoutParams();
                param.SetGravity(GravityFlags.Center | GravityFlags.Left);
                param.ColumnSpec = GridLayout.InvokeSpec(2);
                param.RowSpec = GridLayout.InvokeSpec(i);
                llLike.LayoutParameters = param;
                glPost.AddView(llLike);

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
            ImageButton imgPicture = FindViewById<ImageButton>(Resource.Id.imgPicture);
            if (resultCode == Result.Ok)
            {
                if (requestCode == TakePicture && resultCode == Result.Ok)
                {
                    Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
                    Android.Net.Uri contentUri = Android.Net.Uri.FromFile(_file);
                    mediaScanIntent.SetData(contentUri);
                    SendBroadcast(mediaScanIntent);

                    int height = Resources.DisplayMetrics.HeightPixels;
                    int width = 75;
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
                    bitmap = Media.GetBitmap(ContentResolver, data.Data);
                    imgPicture.SetImageURI(data.Data);
                    imgPublish = Uri.EscapeUriString(data.Data.LastPathSegment);
                }
                imgPicture.Visibility = ViewStates.Visible;
                FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Visible;
            }
        }
    }
}
