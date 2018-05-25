
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "SalasReunionesHistorial")]
    public class SalasReunionesHistorialActivity : Activity
    {
        readonly SimpleStorage storage;

        public SalasReunionesHistorialActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalasReunionHistorialLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            FillAnteriores();
        }

        void FillAnteriores()
        {
            GridLayout glHistorial = FindViewById<GridLayout>(Resource.Id.glHistorial);
            new SalasJuntasController().GetReservaciones(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), "0,2").AsParallel().ToList().ForEach(reserva =>
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
                glHistorial.AddView(ProximasView);
            });
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(SalaReunionesProgramaActivity)));
            return base.OnOptionsItemSelected(item);
        }
    }
}
