
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WorklabsMx.Droid
{
    [Activity(Label = "TabPerfilActivity")]
    public class TabPerfilActivity : ActivityGroup
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
            ActionBar.Title = Resources.GetString(Resource.String.MiPerfil);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            _tabs = FindViewById<TabHost>(Resource.Id.tabHostProfile);
            _tabs.Setup(LocalActivityManager);

            CreateNewTab(new Intent(this, typeof(PerfilActivity)), "tab1", "Perfil", Resources.GetDrawable(Resource.Mipmap.ic_menu), true);
            CreateNewTab(new Intent(this, typeof(MiEmpresaActivity)), "tab2", "Empresa", Resources.GetDrawable(Resource.Mipmap.ic_domain), false);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.edit_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_edit:
                    if (_tabs.CurrentTab == 0)
                        StartActivity(new Intent(this, typeof(EditPerfilActivity)));
                    else if (_tabs.CurrentTab == 1)
                        StartActivity(new Intent(this, typeof(EditEmpresaActivity)));
                    break;
                default: base.OnBackPressed(); break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
