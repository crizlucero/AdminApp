using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ReservaSalaJuntasActivity")]
    public class ReservaSalaJuntasActivity : Activity
    {
        CalendarView calendar;
        Spinner sucursales;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReservaSalaJuntasLayout);
			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
			ActionBar.Title = Resources.GetString(Resource.String.ReservaSala);
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			//ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            sucursales = FindViewById<Spinner>(Resource.Id.spSucursal);
            sucursales.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new PickerItemsController().GetSucursales().ToArray());

            SetCalendarConfig();
        }

        void SetCalendarConfig(){
            calendar = FindViewById<CalendarView>(Resource.Id.cvSalaJuntas);
            try
            {
                //calendar.MinDate = DateTime.Now.Ticks;
            }catch(Exception e){
                SlackLogs.SendMessage(e.Message);
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
					//new EmpresaController().UpdateDatosFiscales();
					break;
				default:
					base.OnBackPressed(); break;
			}
			return base.OnOptionsItemSelected(item);
		}
    }
}
