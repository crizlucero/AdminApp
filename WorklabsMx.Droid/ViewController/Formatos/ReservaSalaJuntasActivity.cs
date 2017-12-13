using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservaSalaJuntasActivity : Activity
    {
        Spinner sucursales;
        SwipeRefreshLayout refresher;
        SimpleStorage storage;
        AlertDialog dialog;
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

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            //MenuInflater.Inflate(Resource.Menu.send_menu, menu);
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

        void ShowCalendarView(EditText fecha)
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            View customView = liView.Inflate(Resource.Layout.CalendarioLayout, null, true);

            CalendarView calendar = customView.FindViewById<CalendarView>(Resource.Id.cvCalendario);
            calendar.MinDate = new Java.Util.Date().Time;
            calendar.DateChange += (sender, e) =>
            {
                fecha.Text = e.DayOfMonth + "/" + e.Month + "/" + e.Year;
                dialog.Dismiss();
            };
            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }

        void ShowHorarioPicker(EditText hora)
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            View customView = liView.Inflate(Resource.Layout.HorarioPickerLayout, null, true);

            TimePicker horario = customView.FindViewById<TimePicker>(Resource.Id.tpHorario);
            horario.TimeChanged += (sender, e) =>
            {
                hora.Text = e.HourOfDay.ToString("00") + ":" + e.Minute.ToString("00");
            };
            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }
    }
}
