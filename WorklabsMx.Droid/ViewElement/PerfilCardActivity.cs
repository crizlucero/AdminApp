using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Provider;
using Android.Support.V4.View;
using Android.Widget;
using com.refractored;
using Java.IO;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using static Android.Provider.MediaStore.Images;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class PerfilCardActivity : Activity
    {
        UsuarioModel miembro;
        readonly SimpleStorage storage;
        KeyValuePair<int, bool> isFavorite;
        readonly string usuario_imagen_path;
        File _dir, _file;
        readonly int PickImageId = 1000, TakePicture = 500;
        Bitmap bitmap, photo, background;
        ImageView imgPerfil, imgFondo;
        int Height, Width;
        bool flag;
        string imagePath;

        public PerfilCardActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
            usuario_imagen_path = new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PerfilCardLayout);
            miembro = JsonConvert.DeserializeObject<UsuarioModel>(Intent.GetStringExtra("Miembro"));
            FindViewById<ImageButton>(Resource.Id.ibCerrar).Click += (sender, e) => OnBackPressed();

            imgPerfil = FindViewById<ImageView>(Resource.Id.ivPerfil);
            if (!string.IsNullOrEmpty(miembro.Usuario_Fotografia))
            {
                miembro.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(miembro.Usuario_Fotografia, usuario_imagen_path);
                photo = BitmapFactory.DecodeByteArray(miembro.Usuario_Fotografia_Perfil, 0, miembro.Usuario_Fotografia_Perfil.Length);
                imgPerfil.SetImageBitmap(ImagesHelper.GetRoundedShape(BitmapFactory.DecodeByteArray(miembro.Usuario_Fotografia_Perfil, 0, miembro.Usuario_Fotografia_Perfil.Length)));
            }
            else
                imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);
            imgFondo = FindViewById<ImageView>(Resource.Id.imgFondo);
            if (!string.IsNullOrEmpty(miembro.Usuario_Fotografia_Fondo))
            {
                miembro.Usuario_Fotografia_FondoPerfil = new UploadImages().DownloadFileFTP(miembro.Usuario_Fotografia_Fondo, usuario_imagen_path);
                background = BitmapFactory.DecodeByteArray(miembro.Usuario_Fotografia_FondoPerfil, 0, miembro.Usuario_Fotografia_FondoPerfil.Length);
                imgFondo.SetImageBitmap(background);
            }

            FindViewById<TextView>(Resource.Id.lblNombre).Text = miembro.Usuario_Nombre + " " + miembro.Usuario_Apellidos;
            FindViewById<TextView>(Resource.Id.lblEmpresa).Text = miembro.Usuario_Empresa_Nombre;
            Button btnSeguir = FindViewById<Button>(Resource.Id.btnSeguir);
            FindViewById<Button>(Resource.Id.btnSendMessage).Click += delegate
            {
                Intent intent = PackageManager.GetLaunchIntentForPackage("mx.worklabs");
                if (intent == null) intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=mx.worklabs"));
                intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            };

            if (miembro.Usuario_Id == storage.Get("Usuario_Id") && miembro.Usuario_Tipo == storage.Get("Usuario_Tipo"))
            {
                FindViewById<Button>(Resource.Id.btnSendMessage).Visibility = Android.Views.ViewStates.Gone;
                btnSeguir.Visibility = Android.Views.ViewStates.Gone;
                ImageView editar = FindViewById<ImageView>(Resource.Id.btnEditar);
                editar.Visibility = Android.Views.ViewStates.Visible;
                editar.Click += delegate
                {
                    Intent intent = new Intent(this, typeof(PerfilCardEditarActivity));
                    intent.PutExtra("Miembro", Intent.GetStringExtra("Miembro"));
                    StartActivity(intent);
                    Finish();
                };
            }
            isFavorite = new UsuariosController().IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Usuario_Id, miembro.Usuario_Tipo);
            if (!isFavorite.Value)
                btnSeguir.Text = Resources.GetString(Resource.String.str_social_network_unfollow);
            FindViewById<Button>(Resource.Id.btnSeguir).Click += delegate
            {
                if (isFavorite.Value)
                {
                    if (new UsuariosController().RemoveMiembroFavorito(isFavorite))
                        btnSeguir.Text = Resources.GetString(Resource.String.str_social_network_follow);
                    else
                        btnSeguir.Text = Resources.GetString(Resource.String.str_social_network_unfollow);
                }
            };

            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.vpPerfil);
            _viewPager.Adapter = new PerfilPageAdapter(this, new List<string> { Resources.GetString(Resource.String.str_profile_about_me), Resources.GetString(Resource.String.str_profile_social), Resources.GetString(Resource.String.str_profile_work) }, miembro);

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);

            imgPerfil.Click += delegate
            {
                Width = Height = 400;
                CreateDirectoryForPictures();
                IsThereAnAppToTakePictures();
                Intent intent = new Intent(MediaStore.ActionImageCapture);
                _file = new File(_dir, String.Format("{0}.jpg", Guid.NewGuid()));
                intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(_file));
                StartActivityForResult(intent, TakePicture);
                flag = true;
            };

            imgFondo.Click += delegate
            {
                Width = 1500;
                Height = 500;
                CreateDirectoryForPictures();
                IsThereAnAppToTakePictures();
                Intent intent = new Intent(MediaStore.ActionImageCapture);
                _file = new File(_dir, String.Format("{0}.jpg", Guid.NewGuid()));
                intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(_file));
                StartActivityForResult(intent, TakePicture);
                flag = false;
            };

        }

        public override void OnBackPressed() => base.OnBackPressed();

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
            if (resultCode == Result.Ok)
            {
                if (requestCode == TakePicture && resultCode == Result.Ok)
                {
                    Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
                    Android.Net.Uri contentUri = Android.Net.Uri.FromFile(_file);
                    mediaScanIntent.SetData(contentUri);
                    SendBroadcast(mediaScanIntent);

                    imagePath = _file.Path;
                    bitmap = _file.Path.LoadAndResizeBitmap(Width, Height);
                    if (flag)
                    {
                        imgPerfil.SetImageBitmap(bitmap);
                        photo = bitmap;
                    }
                    else
                    {
                        imgFondo.SetImageBitmap(bitmap);
                        background = bitmap;
                    }
                    GC.Collect();
                }
                if (requestCode == PickImageId && resultCode == Result.Ok && data != null)
                {
                    imagePath = (string)data.Data;
                    bitmap = Media.GetBitmap(ContentResolver, data.Data);
                    if (flag)
                    {
                        imgPerfil.SetImageBitmap(bitmap);
                        photo = bitmap;
                    }
                    else
                    {
                        imgFondo.SetImageBitmap(bitmap);
                        background = bitmap;
                    }
                }
            }
        }
    }
}
