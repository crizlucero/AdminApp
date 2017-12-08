using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class DirectorioActivity : ActivityGroup
    {
        static TabHost _tabs;

        public static void CreateNewTab(Intent intent, string tabId, string tabName, Drawable Image, bool IsCurrent)
        {
            TabHost.TabSpec spec = _tabs.NewTabSpec(tabId);
            spec.SetIndicator(tabName, (Image));
            spec.SetContent(intent);
            _tabs.AddTab(spec);
            if (IsCurrent)
                _tabs.SetCurrentTabByTag(tabId);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TabsLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Directorio);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            _tabs = FindViewById<TabHost>(Resource.Id.tabHostProfile);
            _tabs.Setup(LocalActivityManager);

            CreateNewTab(new Intent(this, typeof(DirectorioUsuariosActivity)), "tab1", "Comunidad", Resources.GetDrawable(Resource.Mipmap.ic_group, null), true);
            CreateNewTab(new Intent(this, typeof(DirectorioEmpresaActivity)), "tab2", "Empresa", Resources.GetDrawable(Resource.Mipmap.ic_business_center, null), false);
            CreateNewTab(new Intent(this, typeof(DirectorioFavoritosActivity)), "tab2", "Favoritos", Resources.GetDrawable(Resource.Mipmap.ic_star, null), false);

        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
        }
    }
}
