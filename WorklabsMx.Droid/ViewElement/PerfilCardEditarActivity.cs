using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Support.V4.View;
using Android.Widget;
using com.refractored;
using Java.IO;
using Newtonsoft.Json;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using static Android.Provider.MediaStore.Images;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class PerfilCardEditarActivity : Activity
    {
        UsuarioModel miembro;
        File _dir, _file;
        readonly int PickImageId = 1000, TakePicture = 500;
        Bitmap bitmap, photo, background;
        string imagePath;
        int Height, Width;
        bool flag;
        ImageView imgPerfil, imgFondo;
        readonly string usuario_imagen_path;

        public PerfilCardEditarActivity()
        {
            usuario_imagen_path = new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PerfilCardEditarLayout);
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

            FindViewById<Button>(Resource.Id.btnGuardar).Click += delegate
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                photo?.Compress(Bitmap.CompressFormat.Jpeg, 0, stream);
                miembro.Usuario_Fotografia_Perfil = stream?.ToArray();
                stream = new System.IO.MemoryStream();
                background?.Compress(Bitmap.CompressFormat.Jpeg, 0, stream);
                miembro.Usuario_Fotografia_FondoPerfil = stream?.ToArray();
                if (new UsuariosController().UpdateDataMiembros(miembro.Usuario_Id, FindViewById<EditText>(Resource.Id.txtNombre).Text,
                                                                FindViewById<EditText>(Resource.Id.txtApellidos).Text, miembro.Usuario_Correo_Electronico, miembro.Usuario_Telefono,
                                                                miembro.Usuario_Celular, miembro.Usuario_Descripcion, DateTime.Parse(miembro.Usuario_Fecha_Nacimiento), miembro.Usuario_Fotografia_Perfil, miembro.Usuario_Fotografia_FondoPerfil))
                {
                    miembro.Redes_Sociales.AsParallel().ToList().ForEach(red =>
                    {
                        if (!string.IsNullOrEmpty(red.Usuario_Red_Social_Id) || !string.IsNullOrEmpty(red.Red_Social_Enlace))
                            new RedesSocialesController().SetRedSocial(miembro.Usuario_Id, miembro.Usuario_Tipo, red.Red_Social_Id, red.Red_Social_Enlace, red.Usuario_Red_Social_Id);
                    });
                    new EmpresaController().UpdateUsuarioEmpresaPerfil(miembro.Empresa_Actual.Empresa_Id, miembro.Usuario_Id, "",
                                                                       miembro.Empresa_Actual.Empresa_Nombre, miembro.Empresa_Actual.Empresa_Correo_Electronico,
                                                                       miembro.Empresa_Actual.Empresa_Pagina_Web, miembro.Usuario_Puesto, miembro.Empresa_Actual.Empresa_Logotipo_Perfil);
                    Toast.MakeText(this, Resource.String.str_general_save, ToastLength.Short).Show();
                    Intent intent = new Intent(this, typeof(PerfilCardActivity));
                    intent.PutExtra("Miembro", JsonConvert.SerializeObject(new UsuariosController().GetMemberData(miembro.Usuario_Id, miembro.Usuario_Tipo)));
                    StartActivity(intent);
                    Finish();
                }
                else
                {
                    Toast.MakeText(this, Resource.String.str_general_save_error, ToastLength.Short).Show();
                }
            };

            FindViewById<ImageView>(Resource.Id.btnCamara).Click += delegate
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

            FindViewById<ImageView>(Resource.Id.btnCamaraFondo).Click += delegate
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

            FindViewById<EditText>(Resource.Id.txtNombre).Text = miembro.Usuario_Nombre;
            FindViewById<EditText>(Resource.Id.txtApellidos).Text = miembro.Usuario_Apellidos;
            FindViewById<TextView>(Resource.Id.lblEmpresa).Text = miembro.Usuario_Empresa_Nombre;

            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.vpPerfil);
            _viewPager.Adapter = new PerfilEditarPageAdapter(this, new List<string> { Resources.GetString(Resource.String.str_profile_about_me), Resources.GetString(Resource.String.str_profile_social), Resources.GetString(Resource.String.str_profile_work) }, ref miembro);

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);

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