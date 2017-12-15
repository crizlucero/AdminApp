using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Enum;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class TabSalasJuntasHistorialActivity : ActivityGroup
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
            ActionBar.Title = Resources.GetString(Resource.String.SalasJuntas);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            _tabs = FindViewById<TabHost>(Resource.Id.tabHostProfile);
            _tabs.Setup(LocalActivityManager);
            Intent recientes = new Intent(this, typeof(SalasJuntasHistorialActivity));
            recientes.PutExtra("reservacion_estatus", (int)TiposReservacion.Activo);
            CreateNewTab(recientes, "tab1", Resources.GetString(Resource.String.Recientes), null, true);
            Intent historico = new Intent(this, typeof(SalasJuntasHistorialActivity));
            recientes.PutExtra("reservacion_estatus", (int)TiposReservacion.Terminada);
            CreateNewTab(historico, "tab2", Resources.GetString(Resource.String.Historico), null, false);
            Intent cancelado = new Intent(this, typeof(SalasJuntasHistorialActivity));
            recientes.PutExtra("reservacion_estatus", (int)TiposReservacion.Cancelada);
            CreateNewTab(cancelado, "tab2", Resources.GetString(Resource.String.Canceladas), null, false);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.add_element_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_add_element:
                    StartActivity(new Intent(this, typeof(SalasJuntasSucursalActivity)));
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
