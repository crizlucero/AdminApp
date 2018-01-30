using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.View;
using Android.Widget;
using com.refractored;
using Newtonsoft.Json;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "PerfilCardActivity")]
    public class PerfilCardActivity : Activity
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
                catch { intent = PackageManager.GetLaunchIntentForPackage("http://play.google.com/store/apps/details?id="); }
                StartActivity(intent);
            };

            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.vpPerfil);
            _viewPager.Adapter = new PerfilPageAdapter(this, new List<string> { Resources.GetString(Resource.String.SobreMi), Resources.GetString(Resource.String.Social), Resources.GetString(Resource.String.Trabajo) }, miembro);

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);

        }
    }
}
