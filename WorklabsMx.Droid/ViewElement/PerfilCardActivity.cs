using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Support.V4.View;
using Android.Widget;
using com.refractored;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "PerfilCardActivity")]
    public class PerfilCardActivity : Activity
    {
        UsuarioModel miembro;
        readonly SimpleStorage storage;

        public PerfilCardActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PerfilCardLayout);
            miembro = JsonConvert.DeserializeObject<UsuarioModel>(Intent.GetStringExtra("Miembro"));
            FindViewById<ImageButton>(Resource.Id.ibCerrar).Click += (sender, e) => OnBackPressed();

            FindViewById<TextView>(Resource.Id.lblNombre).Text = miembro.Usuario_Nombre + " " + miembro.Usuario_Apellidos;
            FindViewById<TextView>(Resource.Id.lblEmpresa).Text = miembro.Usuario_Empresa_Nombre;
            FindViewById<Button>(Resource.Id.btnSendMessage).Click += delegate
            {
                Intent intent;
                try { intent = PackageManager.GetLaunchIntentForPackage("mx.worklabs"); }
                catch
                {
                    intent = new Intent(Intent.ActionView, Uri.Parse("market://details?id=mx.worklabs"));
                    intent.AddFlags(ActivityFlags.NewTask);
                }

                StartActivity(intent);
            };

            if (miembro.Usuario_Id == storage.Get("Usuario_Id") && miembro.Usuario_Tipo == storage.Get("Usuario_Tipo"))
            {
                FindViewById<Button>(Resource.Id.btnSeguir).Visibility = Android.Views.ViewStates.Gone;
                ImageView editar = FindViewById<ImageView>(Resource.Id.btnEditar);
                editar.Visibility = Android.Views.ViewStates.Visible;
                editar.Click += delegate
                {
                    Intent intent = new Intent(this, typeof(PerfilCardEditarActivity));
                    intent.PutExtra("Miembro", Intent.GetStringExtra("Miembro"));
                    StartActivity(intent);
                };
            }

            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.vpPerfil);
            _viewPager.Adapter = new PerfilPageAdapter(this, new List<string> { Resources.GetString(Resource.String.str_profile_about_me), Resources.GetString(Resource.String.str_profile_social), Resources.GetString(Resource.String.str_profile_work) }, miembro);

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);

        }
    }
}
