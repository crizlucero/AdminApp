
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Enum;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ReservacionSalaActivity")]
    public class ReservacionReunionActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SalasReunionesInicialLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room_reservation);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            FindViewById<ImageView>(Resource.Id.btnHorario).Click += delegate
            {
                Intent intent = new Intent(this, typeof(ReservacionHorariosActivity));
                intent.PutExtra("Tipo", (int)TipoSalaReunionFlujo.Horario);
                StartActivity(intent);
                Finish();
            };

            FindViewById<ImageView>(Resource.Id.btnSala).Click += delegate
            {
                Intent intent = new Intent(this, typeof(ReservacionSalasActivity));
                intent.PutExtra("Tipo", (int)TipoSalaReunionFlujo.Sala);
                StartActivity(intent);
                Finish();
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }

        public override void OnBackPressed()
        {
            StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }
    }
}
