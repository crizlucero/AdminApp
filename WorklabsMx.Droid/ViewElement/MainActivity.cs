using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Provider;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using Java.IO;
using Newtonsoft.Json;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using static Android.Provider.MediaStore.Images;

namespace WorklabsMx.Droid
{
    public partial class MainActivity
    {
        View customView;
        File _file, _dir;
        readonly int sizePage = 5, PickImageId = 1000, TakePicture = 500;
        Bitmap bitmap;
        AlertDialog dialog;
        string imgPublish, imagePath;
        void ShowPerfilCard(UsuarioModel miembro)
        {
            Intent intent = new Intent(this, typeof(PerfilCardActivity));
            intent.PutExtra("Miembro", JsonConvert.SerializeObject(miembro));
            StartActivity(intent);
        }

        public void ShowPublish()
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            customView = liView.Inflate(Resource.Layout.PublishLayout, null, true);

            customView.FindViewById<TextView>(Resource.Id.lblNombre).Text = nombre;
            customView.FindViewById<TextView>(Resource.Id.lblPuesto).Text = puesto;
            ImageView imgPerfil = customView.FindViewById<ImageView>(Resource.Id.imgPerfil);
            if (foto != null)
                imgPerfil.SetImageBitmap(BitmapFactory.DecodeByteArray(foto, 0, foto.Length));
            else
                imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
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
                _file = new File(_dir, String.Format("{0}.jpg", Guid.NewGuid()));
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
            customView.FindViewById<Button>(Resource.Id.btnPublishApply).Click += async delegate
            {
                try
                {
                    System.IO.MemoryStream stream = new System.IO.MemoryStream();
                    bitmap?.Compress(Bitmap.CompressFormat.Jpeg, 0, stream);
                    byte[] bitmapData = stream?.ToArray();
                    if (new EscritorioController().SetPost(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"),
                                                           customView.FindViewById<EditText>(Resource.Id.txtPublicacion).Text,
                                                           bitmapData))
                    {
                        page = 0;
                        posts = DashboardController.GetMuroPosts(localStorage.Get("Usuario_Id"), localStorage.Get("Usuario_Tipo"), page, sizePage);
                        await FillPosts();
                        dialog.Dismiss();
                        customView.FindViewById<ImageView>(Resource.Id.imgPicture).Visibility = ViewStates.Gone;
                        customView.FindViewById<ImageButton>(Resource.Id.btnDeleteImage).Visibility = ViewStates.Gone;
                    }
                    else
                        Toast.MakeText(this, Resource.String.str_general_save_error, ToastLength.Short);
                }
                catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "ShowPublish"); }
                dialog.Dismiss();
            };

            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
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
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(new Intent(MediaStore.ActionImageCapture), PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
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

                    imagePath = _file.Path;
                    bitmap = _file.Path.LoadAndResizeBitmap(646, 646);
                    if (bitmap != null)
                        imgPicture.SetImageBitmap(bitmap);
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

        void ShowMeGusta(string likeCantidad, string post_id)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            customView = liView.Inflate(Resource.Layout.LikesListLayout, null, true);

            customView.FindViewById<TextView>(Resource.Id.lblLikes).Text = likeCantidad;
            ListView lvUsuarios = customView.FindViewById<ListView>(Resource.Id.lvUsuarios);
            List<UsuarioModel> usuarios = new UsuariosController().GetUsuariosPublicacionMeGusta(post_id);
            usuarios.AsParallel().ToList().ForEach(usuario =>
            {
                KeyValuePair<string, string> current = new KeyValuePair<string, string>(usuario.Usuario_Id, usuario.Usuario_Tipo);
                if (!string.IsNullOrEmpty(usuario.Usuario_Fotografia))
                {
                    if (Usuario_Fotos_Perfil.ContainsKey(current))
                    {
                        usuario.Usuario_Fotografia_Perfil = Usuario_Fotos_Perfil[current];
                    }
                    else
                    {
                        usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(usuario.Usuario_Fotografia, usuario_imagen_path);
                        Usuario_Fotos_Perfil.Add(current, usuario.Usuario_Fotografia_Perfil);
                    }

                }
            });
            lvUsuarios.Adapter = new MeGustaListAdapter(usuarios);

            customView.FindViewById<ImageView>(Resource.Id.imgClose).Click += (sender, e) => { dialog.Dismiss(); };

            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }
    }
}