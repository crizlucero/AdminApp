using System;
using Android.App;
using Android.OS;
using Android.Widget;
using WorklabsMx.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ReservaSalaJuntasActivity")]
    public class ReservaSalaJuntasActivity : Activity
    {
        CalendarView calendar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReservaSalaJuntasLayout);
			Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(toolbar);
			ActionBar.Title = Resources.GetString(Resource.String.ReservaSala);
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

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

    }
}
