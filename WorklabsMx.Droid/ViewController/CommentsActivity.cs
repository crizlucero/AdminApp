﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
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
using Newtonsoft.Json;
using WorklabsMx.Helpers;

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
        AlertDialog dialog;
        View customView;
        readonly int sizePage = 5, PickImageId = 1000, TakePicture = 500;
        int page;
        string post_id, imgPublish, imagePath;
        PostModel post;
        Dictionary<KeyValuePair<string, string>, byte[]> Usuario_Fotos_Perfil;
        readonly string usuario_imagen_path, publicaciones_imagen_path;
        public CommentsActivity()
        {
            localStorage = SimpleStorage.EditGroup("Login");
            Usuario_Fotos_Perfil = new Dictionary<KeyValuePair<string, string>, byte[]>();
            List<ConfiguracionesModel> config = new ConfigurationsController().GetListConfiguraciones();
            usuario_imagen_path = config.Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1;
            publicaciones_imagen_path = config.Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PUBLICACIONES").Parametro_Varchar_1;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CommentLayout);

            post_id = Intent.GetStringExtra("post_id");

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Intent.GetStringExtra("Titulo");
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            DashboardController = new EscritorioController();
            post = DashboardController.GetSinglePost(post_id);
            FillPost();
            svComentarios = FindViewById<ScrollView>(Resource.Id.svComentarios);
            tlComentarios = FindViewById<TableLayout>(Resource.Id.comment_table);
            comentarios = DashboardController.GetComentariosPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), page, sizePage);
            if (Convert.ToInt32(Intent.GetStringExtra("comments_total")) > 0)
            {
                tlComentarios.RemoveAllViews();
                FillComments();
            }
            SwipeRefreshLayout refresher = FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_container);
            refresher.SetColorSchemeColors(Color.Gray, Color.LightGray, Color.Gray, Color.DarkGray, Color.Black, Color.DarkGray);
            refresher.Refresh += (sender, e) =>
            {
                comentarios = DashboardController.GetComentariosPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), page, sizePage);
                if (comentarios.Count != 0)
                {
                    tlComentarios.RemoveAllViews();
                    FillComments();
                }
                ((SwipeRefreshLayout)sender).Refreshing = false;
            };
            svComentarios.ScrollChange += (sender, e) =>
            {
                if ((comentarios.Count / (page + 1)) < sizePage - 1)
                    if ((((ScrollView)sender).ScrollY / (page + 1)) > ((svComentarios.Height) * .4))
                    {
                        ++page;
                        FillComments();
                    }
            };
        }

        void FillPost()
        {
            //string Usuario_Id = !string.IsNullOrEmpty(post.Usuario.Usuario_Id.Miembro_Id) ? post.Miembro_Id : post.Colaborador_Empresa_Id;

            ImageButton imgPerfil = FindViewById<ImageButton>(Resource.Id.imgPerfil);
            KeyValuePair<string, string> current = new KeyValuePair<string, string>(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo);
            if (Usuario_Fotos_Perfil.ContainsKey(current))
            {
                if (Usuario_Fotos_Perfil[current] != null)
                    imgPerfil.SetImageBitmap(BitmapFactory.DecodeByteArray(Usuario_Fotos_Perfil[current], 0, Usuario_Fotos_Perfil[current].Length));
                else
                    imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
            }
            else
            {
                post.Usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(post.Usuario.Usuario_Fotografia, usuario_imagen_path);
                Usuario_Fotos_Perfil.Add(current, post.Usuario.Usuario_Fotografia_Perfil);
                if (post.Usuario.Usuario_Fotografia_Perfil != null)
                    imgPerfil.SetImageBitmap(BitmapFactory.DecodeByteArray(post.Usuario.Usuario_Fotografia_Perfil, 0, post.Usuario.Usuario_Fotografia_Perfil.Length));
                else
                    imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
            }

            /*if (post.Usuario.Usuario_Fotografia_Perfil != null)
                imgPerfil.SetImageBitmap(BitmapFactory.DecodeByteArray(post.Usuario.Usuario_Fotografia_Perfil, 0, post.Usuario.Usuario_Fotografia_Perfil.Length));
            else
                imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
            imgPerfil.Click += (sender, e) => AndHUD.Shared.ShowImage(this, Resources.GetDrawable(Resource.Mipmap.ic_work, null), null, MaskType.Black);*/

            TextView lblNombre = FindViewById<TextView>(Resource.Id.lblNombre);
            lblNombre.Text = post.Usuario.Usuario_Nombre;
            lblNombre.Click += delegate
            {
                ShowPerfilCard(new UsuariosController().GetMemberData(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo));
            };

            TextView lblPuesto = FindViewById<TextView>(Resource.Id.lblPuesto);
            lblPuesto.Text = post.Usuario.Usuario_Puesto;

            TextView lblFecha = FindViewById<TextView>(Resource.Id.lblFecha);
            lblFecha.Text = post.Publicacion_Fecha;

            TextView lblPost = FindViewById<TextView>(Resource.Id.lblPost);
            lblPost.SetMaxWidth(Convert.ToInt32(Resources.DisplayMetrics.WidthPixels * .911));
            lblPost.Text = post.Publicacion_Contenido;

            TextView lblLike = FindViewById<TextView>(Resource.Id.lblLikeText);
            lblLike.Text = post.Publicacion_Me_Gustan_Cantidad + " " + Resources.GetString(Resource.String.str_dashboard_likes);

            ImageView imgLike = FindViewById<ImageView>(Resource.Id.imgLikes);

            lblLike.Click += delegate
            {
                string transaccion = "ALTA";
                if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                    transaccion = "BAJA";
                else if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
                    transaccion = "MODIFICAR";
                if (new EscritorioController().PostLike(post.Publicacion_Id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), transaccion))
                {
                    lblLike.Text = new EscritorioController().GetLikesPublish(post.Publicacion_Id) + " " + Resources.GetString(Resource.String.str_dashboard_likes);
                    if (transaccion == "BAJA")
                    {
                        post.Publicacion_Me_Gusta_Usuario = "0";
                        lblLike.SetTextColor(Color.Black);
                        imgLike.SetColorFilter(Resources.GetColor(Resource.Color.button_unpressed));
                    }
                    else
                    {
                        post.Publicacion_Me_Gusta_Usuario = "1";
                        lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                        imgLike.SetColorFilter(Resources.GetColor(Resource.Color.like_heart_pressed));
                    }
                }
            };
            if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
            {
                lblLike.SetTextColor(Color.Rgb(57, 87, 217));
            }
            if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                imgLike.SetColorFilter(Resources.GetColor(Resource.Color.like_heart_pressed));
            TextView lblComentario = FindViewById<TextView>(Resource.Id.lblComentariosText);
            lblComentario.Text = post.Publicacion_Comentarios_Cantidad + " " + Resources.GetString(Resource.String.str_social_network_comments);
            lblComentario.Click += delegate
            {
                Intent intent = new Intent(this, typeof(CommentsActivity));
                intent.PutExtra("post_id", post.Publicacion_Id);
                intent.PutExtra("comments_total", post.Publicacion_Comentarios_Cantidad);
                StartActivity(intent);
            };

            ImageView imgPost = FindViewById<ImageView>(Resource.Id.imgPost);
            if (!string.IsNullOrEmpty(post.Publicacion_Imagen))
            {
                post.Publicacion_Imagen_Post = new UploadImages().DownloadFileFTP(post.Publicacion_Imagen, publicaciones_imagen_path);
                if (post.Publicacion_Imagen_Post != null && post.Publicacion_Imagen_Post.Length != 0)
                {
                    imgPost.Visibility = ViewStates.Visible;
                    imgPost.SetImageBitmap(BitmapFactory.DecodeByteArray(post.Publicacion_Imagen_Post, 0, post.Publicacion_Imagen_Post.Length));
                    imgPost.Click += delegate
                    {
                        //AndHUD.Shared.ShowImage(this, Drawable.CreateFromStream());
                    };
                }
            }

            Button btnComentar = FindViewById<Button>(Resource.Id.btnComentar);
            btnComentar.Visibility = ViewStates.Visible;
            btnComentar.Click += (sender, e) => ShowPublish();
        }

        async void FillComments()
        {
            AndHUD.Shared.Show(this, null, -1, MaskType.Black);
            await Task.Delay(500);

            comentarios.Skip(page * sizePage).Take(sizePage).AsParallel().ToList().ForEach(comentario =>
            {
                LayoutInflater liView = LayoutInflater;
                View CommentView = liView.Inflate(Resource.Layout.PostLayout, null, true);
                CommentView.SetMinimumWidth(Resources.DisplayMetrics.WidthPixels);
                //string Usuario_Id = !string.IsNullOrEmpty(comentario.Miembro_Id) ? comentario.Miembro_Id : comentario.Colaborador_Empresa_Id;
                KeyValuePair<string, string> current = new KeyValuePair<string, string>(comentario.Usuario.Usuario_Id, comentario.Usuario.Usuario_Tipo);
                ImageButton imgPerfil = CommentView.FindViewById<ImageButton>(Resource.Id.imgPerfil);

                if (Usuario_Fotos_Perfil.ContainsKey(current))
                {
                    if (Usuario_Fotos_Perfil[current] != null)
                        imgPerfil.SetImageBitmap(BitmapFactory.DecodeByteArray(Usuario_Fotos_Perfil[current], 0, Usuario_Fotos_Perfil[current].Length));
                    else
                        imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
                }
                else
                {
                    comentario.Usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(comentario.Usuario.Usuario_Fotografia, usuario_imagen_path);
                    Usuario_Fotos_Perfil.Add(current, comentario.Usuario.Usuario_Fotografia_Perfil);
                    if (comentario.Usuario.Usuario_Fotografia_Perfil != null)
                        imgPerfil.SetImageBitmap(BitmapFactory.DecodeByteArray(comentario.Usuario.Usuario_Fotografia_Perfil, 0, comentario.Usuario.Usuario_Fotografia_Perfil.Length));
                    else
                        imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
                }

                /*if (comentario.Usuario.Usuario_Fotografia_Perfil != null)
                    imgPerfil.SetImageBitmap(BitmapFactory.DecodeByteArray(comentario.Usuario.Usuario_Fotografia_Perfil, 0, comentario.Usuario.Usuario_Fotografia_Perfil.Length));
                else
                    imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
                imgPerfil.Click += (sender, e) => ShowPerfilCard(new UsuariosController().GetMemberData(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo));*/

                TextView lblNombre = CommentView.FindViewById<TextView>(Resource.Id.lblNombre);
                lblNombre.Text = comentario.Usuario.Usuario_Nombre;
                lblNombre.Click += (sender, e) => ShowPerfilCard(new UsuariosController().GetMemberData(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo));

                TextView lblPuesto = CommentView.FindViewById<TextView>(Resource.Id.lblPuesto);
                lblPuesto.Text = comentario.Usuario.Usuario_Puesto;

                TextView lblFecha = CommentView.FindViewById<TextView>(Resource.Id.lblFecha);
                lblFecha.Text = comentario.Comentario_Fecha;

                TextView lblPost = CommentView.FindViewById<TextView>(Resource.Id.lblPost);
                lblPost.SetMaxWidth(Convert.ToInt32(Resources.DisplayMetrics.WidthPixels * .911));
                lblPost.Text = comentario.Comentario_Contenido;

                TextView lblLike = CommentView.FindViewById<TextView>(Resource.Id.lblLikeText);
                lblLike.Text = comentario.Comentario_Me_Gustan_Cantidad + " " + Resources.GetString(Resource.String.str_dashboard_likes);
                ImageView imgLike = CommentView.FindViewById<ImageView>(Resource.Id.imgLikes);
                lblLike.Click += delegate
                {
                    string transaccion = "ALTA";
                    if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                        transaccion = "BAJA";
                    else if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
                        transaccion = "MODIFICAR";
                    if (new EscritorioController().CommentLike(comentario.Comentario_Id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), transaccion))
                    {
                        lblLike.Text = new EscritorioController().GetLikesComments(comentario.Comentario_Id) + " " + Resources.GetString(Resource.String.str_dashboard_likes);
                        if (transaccion == "BAJA")
                        {

                            post.Publicacion_Me_Gusta_Usuario = "0";
                            lblLike.SetTextColor(Color.Black);
                            imgLike.SetColorFilter(Resources.GetColor(Resource.Color.button_unpressed));
                        }
                        else
                        {
                            post.Publicacion_Me_Gusta_Usuario = "1";
                            lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                            imgLike.SetColorFilter(Resources.GetColor(Resource.Color.like_heart_pressed));
                        }
                    }
                };
                if (comentario.Comentario_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                {
                    lblLike.SetTextColor(Color.Rgb(57, 87, 217));
                    imgLike.SetColorFilter(Resources.GetColor(Resource.Color.like_heart_pressed));
                }
                CommentView.FindViewById<TextView>(Resource.Id.lblComentariosText).Visibility = ViewStates.Invisible;

                CommentView.FindViewById<ImageView>(Resource.Id.imgMore).Click += delegate
                {
                    using (PopupMenu menuPost = new PopupMenu(this, CommentView.FindViewById<ImageView>(Resource.Id.imgMore)))
                    {
                        menuPost.Inflate(Resource.Menu.post_reporte_menu);
                        menuPost.MenuItemClick += delegate
                       {
                           if (DashboardController.OcultarComment(post.Usuario.Usuario_Id, post.Usuario.Usuario_Tipo, comentario.Publicacion_Id, comentario.Comentario_Id))
                           {
                               Toast.MakeText(this, "Comentario eliminado", ToastLength.Short).Show();
                               page = 0;
                                comentarios = DashboardController.GetComentariosPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), page, sizePage);
                               if (comentarios.Count != 0)
                               {
                                   tlComentarios.RemoveAllViews();
                                   FillComments();
                               }
                           }
                           else
                               Toast.MakeText(this, "Existió un error al eliminar el comentario", ToastLength.Short).Show();
                       };
                        menuPost.Show();
                    }
                };

                TableRow row = new TableRow(this);
                row.AddView(CommentView);

                tlComentarios.AddView(row);
            });
            AndHUD.Shared.Dismiss(this);
        }

        void ShowPerfilCard(UsuarioModel miembro)
        {
            Intent intent = new Intent(this, typeof(PerfilCardActivity));
            intent.PutExtra("Miembro", JsonConvert.SerializeObject(miembro));
            StartActivity(intent);
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            OnBackPressed();
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

        void ShowPublish()
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            customView = liView.Inflate(Resource.Layout.PublishLayout, null, true);

            ImageView imgPerfil = customView.FindViewById<ImageView>(Resource.Id.imgPerfil);
            if (post.Usuario.Usuario_Fotografia_Perfil != null)
                imgPerfil.SetImageBitmap(BitmapFactory.DecodeByteArray(post.Usuario.Usuario_Fotografia_Perfil, 0, post.Usuario.Usuario_Fotografia_Perfil.Length));
            else
                imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
            customView.FindViewById<TextView>(Resource.Id.lblNombre).Text = post.Usuario.Usuario_Nombre;
            customView.FindViewById<TextView>(Resource.Id.lblPuesto).Text = post.Usuario.Usuario_Puesto;

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
            customView.FindViewById<Button>(Resource.Id.btnPublishApply).Click += delegate
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                bitmap?.Compress(Bitmap.CompressFormat.Png, 0, stream);
                byte[] bitmapData = stream?.ToArray();
                if (bitmapData.Length != 0 || customView.FindViewById<EditText>(Resource.Id.txtPublicacion).Text.Trim().Length != 0)
                {
                    if (DashboardController.CommentPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), customView.FindViewById<EditText>(Resource.Id.txtPublicacion).Text, bitmapData))
                    {
                        customView.FindViewById<EditText>(Resource.Id.txtPublicacion).Text = "";
                        customView.FindViewById<EditText>(Resource.Id.txtPublicacion).ClearFocus();
                        comentarios = DashboardController.GetComentariosPost(post_id, localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), page, sizePage);
                        FillComments();
                        svComentarios.ScrollY = svComentarios.Height;
                    }
                    else
                        Toast.MakeText(this, Resource.String.str_general_save_error, ToastLength.Short);
                }
                else
                    Toast.MakeText(this, "Escribe o envía una imagen", ToastLength.Short).Show();
                dialog.Dismiss();
            };

            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
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
                    }

                    GC.Collect();
                }
                if (requestCode == PickImageId && resultCode == Result.Ok && data != null)
                {
                    imagePath = (string)data.Data;
                    bitmap = Media.GetBitmap(ContentResolver, data.Data);
                    imgPicture.SetImageURI(data.Data);
                    imgPublish = Uri.EscapeUriString(data.Data.LastPathSegment);
                }
                imgPicture.Visibility = ViewStates.Visible;
                customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Visible;
                customView.FindViewById<Button>(Resource.Id.btnPublishApply).Enabled = true;
                customView.FindViewById<GridLayout>(Resource.Id.gvPublish).SetMinimumHeight(440);
            }
        }
        public override void OnBackPressed()
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }
    }
}