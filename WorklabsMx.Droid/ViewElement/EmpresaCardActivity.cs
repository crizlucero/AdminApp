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
    [Activity(Label = "EmpresaCardActivity")]
    public class EmpresaCardActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.EmpresaCardLayout);
            EmpresaModel empresa = JsonConvert.DeserializeObject<EmpresaModel>(Intent.GetStringExtra("Empresa"));
            FindViewById<ImageButton>(Resource.Id.ibCerrar).Click += (sender, e) => OnBackPressed();

            FindViewById<TextView>(Resource.Id.lblNombre).Text = empresa.Empresa_Nombre;

            ViewPager _viewPager = FindViewById<ViewPager>(Resource.Id.vpPerfil);
            _viewPager.Adapter = new EmpresaPageAdapter(this, new List<string> { Resources.GetString(Resource.String.str_profile_about_me), Resources.GetString(Resource.String.str_profile_social), Resources.GetString(Resource.String.str_profile_work) }, empresa);

            PagerSlidingTabStrip tabs = FindViewById<PagerSlidingTabStrip>(Resource.Id.tabs);
            tabs.SetTextColorResource(Resource.Color.comment_pressed);
            tabs.SetViewPager(_viewPager);
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
        }
    }
}
