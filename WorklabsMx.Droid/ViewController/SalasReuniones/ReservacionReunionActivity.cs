
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Enum;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ReservacionSalaActivity")]
    public class ReservacionReunionActivity : Activity
    {
        SimpleStorage storage;

        public ReservacionReunionActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SalasReunionesInicialLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room);
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
            if (new SalasJuntasController().CountReservaciones(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo")) > 0)
                StartActivity(new Intent(this, typeof(SalaReunionesProgramaActivity)));
            else
                StartActivity(new Intent(this, typeof(MainActivity)));
            Finish();
        }
    }
}
