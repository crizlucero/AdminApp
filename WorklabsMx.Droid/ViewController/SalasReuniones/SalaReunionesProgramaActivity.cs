using System;
using Android.App;
using Android.OS;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using System.Linq;
using Android.Widget;
using Android.Views;
using System.Globalization;
using Android.Content;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class SalaReunionesProgramaActivity : Activity
    {
        SalasJuntasController controller;
        readonly SimpleStorage storage;
        public SalaReunionesProgramaActivity()
        {
            controller = new SalasJuntasController();
            storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SalasReunionProgramaLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            FillProximas();
            FillAnteriores();
        }

        void FillProximas()
        {
            LinearLayout llhProximas = FindViewById<LinearLayout>(Resource.Id.llhProximas);
            controller.GetReservaciones(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), "1").AsParallel().ToList().ForEach(reserva =>
            {
                View ProximasView = LayoutInflater.Inflate(Resource.Layout.SalaReunionProximaLayout, null, true);
                try
                {
                    ProximasView.FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Parse(reserva.Sala_Fecha, new CultureInfo("es-MX")).ToLongDateString();
                }
                catch
                {
                    ProximasView.FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Parse(reserva.Sala_Fecha).ToLongDateString();
                }
                ProximasView.FindViewById<TextView>(Resource.Id.lblHorario).Text = string.Format("{0}hrs - {1}hrs", reserva.Sala_Hora_Inicio, reserva.Sala_Hora_Fin);
                ProximasView.FindViewById<TextView>(Resource.Id.lblNombre).Text = string.Format("Sala: {0}", reserva.Sala_Descripcion);
                ProximasView.FindViewById<TextView>(Resource.Id.lblNivel).Text = string.Format("Nivel {0}", reserva.Sala_Nivel);
                ProximasView.FindViewById<TextView>(Resource.Id.lblCreditos).Text = string.Format("{0} Créditos", reserva.Creditos_Usados);
                ProximasView.FindViewById<Button>(Resource.Id.btnEditar).Tag = reserva.Sala_Junta_Reservacion_Id;
                ProximasView.FindViewById<Button>(Resource.Id.btnEditar).Click += Handle_Click;
                ProximasView.FindViewById<Button>(Resource.Id.btnCancelar).Tag = reserva.Sala_Junta_Reservacion_Id;
                ProximasView.FindViewById<Button>(Resource.Id.btnCancelar).Click += Handle_Click;
                llhProximas.AddView(ProximasView);
            });
        }

        void FillAnteriores()
        {
            LinearLayout llhAnteriores = FindViewById<LinearLayout>(Resource.Id.llhAnteriores);
            controller.GetReservaciones(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), "0,2").AsParallel().ToList().ForEach(reserva =>
            {
                View ProximasView = LayoutInflater.Inflate(Resource.Layout.SalaReunionCardLayout, null, true);
                try
                {
                    ProximasView.FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Parse(reserva.Sala_Fecha, new CultureInfo("es-MX")).ToLongDateString();
                }
                catch
                {
                    ProximasView.FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Parse(reserva.Sala_Fecha).ToLongDateString();
                }
                ProximasView.FindViewById<TextView>(Resource.Id.lblNombre).Text = string.Format("Sala: {0}", reserva.Sala_Descripcion);
                ProximasView.FindViewById<TextView>(Resource.Id.lblNivel).Text = string.Format("Nivel {0}", reserva.Sala_Nivel);
                ProximasView.FindViewById<TextView>(Resource.Id.lblCreditos).Text = string.Format("{0} Créditos", reserva.Creditos_Usados);
                llhAnteriores.AddView(ProximasView);
            });
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.reserva_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_reserva:
                    StartActivity(new Intent(this, typeof(ReservacionReunionActivity)));
                    break;
                default:
                    OnBackPressed();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        void Handle_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ReservacionSalaOpcionesActivity));
            intent.PutExtra("Reservacion_Id", ((Button)sender).Tag.ToString());
            intent.PutExtra("Opcion", ((Button)sender).Text);
            StartActivity(intent);
            Finish();
        }

    }
}
