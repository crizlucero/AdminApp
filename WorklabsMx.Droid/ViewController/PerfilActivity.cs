
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WorklabsMx.Droid
{
    [Activity(Label = "PerfilActivity")]
    public class PerfilActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            SetContentView(Resource.Layout.PerfilLayout);
            ActionBar.Tab tab = ActionBar.NewTab();
            tab.SetText(Resources.GetString(Resource.String.MiPerfil));
            tab.SetIcon(Resource.Mipmap.ic_profile);
            tab.TabSelected += (sender, e) => {
                
            };

            ActionBar.AddTab(tab);

            tab = ActionBar.NewTab();
            tab.SetText(Resources.GetString(Resource.String.MiEmpresa));
            tab.SetIcon(Resource.Mipmap.ic_domain);
            tab.TabSelected += (sender, e) => {
                
            };
            ActionBar.AddTab(tab);
        }
    }
}
