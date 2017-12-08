using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservaSalaJuntasActivity : Activity
    {
        CalendarView calendar;
        Spinner sucursales;
        SwipeRefreshLayout refresher;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReservaSalaJuntasLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.ReservaSala);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            refresher = FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_container);
            sucursales = FindViewById<Spinner>(Resource.Id.spSucursal);
            sucursales.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new PickerItemsController().GetSucursales().ToArray());

            SetCalendarConfig();
        }

        void SetCalendarConfig()
        {
            calendar = FindViewById<CalendarView>(Resource.Id.cvSalaJuntas);
            calendar.MinDate = new Java.Util.Date().Time;
            calendar.DateChange += (sender, e) =>
            {
                AddHours();
                refresher.Visibility = ViewStates.Visible;
            };
        }

        void AddHours()
        {
            TableLayout tlHoras = FindViewById<TableLayout>(Resource.Id.tlHoras);
            for (int i = 0; i < 24; i++)
            {
                TableRow trHora = new TableRow(this);
                TextView lblHora = new TextView(this)
                {
                    Text = i.ToString("00") + ":00"
                };
                trHora.AddView(lblHora);
                tlHoras.AddView(trHora);
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.send_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_send:
                    
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
