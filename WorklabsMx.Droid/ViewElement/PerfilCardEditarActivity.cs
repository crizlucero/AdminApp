using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Support.V4.View;
using Android.Widget;
using com.refractored;
using Newtonsoft.Json;
using WorklabsMx.Models;

namespace WorklabsMx.Droid.ViewElement
{
    [Activity(Label = "@string/app_name")]
    public class PerfilCardEditarActivity : Activity
    {
        UsuarioModel miembro;
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

            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.vpPerfil);
            _viewPager.Adapter = new PerfilEditarPageAdapter(this, new List<string> { Resources.GetString(Resource.String.str_profile_about_me), Resources.GetString(Resource.String.str_profile_social), Resources.GetString(Resource.String.str_profile_work) }, miembro);

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);

        }
    }
}
