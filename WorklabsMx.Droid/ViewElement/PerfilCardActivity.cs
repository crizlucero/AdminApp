using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Support.V4.View;
using Android.Widget;
using com.refractored;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class PerfilCardActivity : Activity
    {
        UsuarioModel miembro;
        readonly SimpleStorage storage;
        KeyValuePair<int, bool> isFavorite;
        readonly string usuario_imagen_path;
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
            FindViewById<ImageButton>(Resource.Id.ibCerrar).Click += (sender, e) => base.OnBackPressed();

            ImageView imgPerfil = FindViewById<ImageView>(Resource.Id.ivPerfil);
            if (!string.IsNullOrEmpty(miembro.Usuario_Fotografia))
            {
                miembro.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(miembro.Usuario_Fotografia, usuario_imagen_path);
                imgPerfil.SetImageBitmap(ImagesHelper.GetRoundedShape(BitmapFactory.DecodeByteArray(miembro.Usuario_Fotografia_Perfil, 0, miembro.Usuario_Fotografia_Perfil.Length)));
            }
            else
                imgPerfil.SetImageResource(Resource.Mipmap.ic_profile_empty);

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

        }
    }
}
