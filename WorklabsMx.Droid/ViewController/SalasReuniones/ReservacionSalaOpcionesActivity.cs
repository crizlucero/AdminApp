
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
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ReserevacionSalaOpcionesActivity")]
    public class ReservacionSalaOpcionesActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalaReunionOpcionesLayout);

            string opcion = Intent.GetStringExtra("Opcion");

            FindViewById<TextView>(Resource.Id.lblTipo).Text = opcion;
            FindViewById<ImageView>(Resource.Id.ivCancelar).Click += delegate
            {
                StartActivity(new Intent(this, typeof(SalaReunionesProgramaActivity)));
                Finish();
            };
        }

        void FillData()
        {
            SalaJuntasReservacionModel sala = new SalasJuntasController().GetReservacion(Intent.GetStringExtra("Reservacion_Id"));
            FindViewById<TextView>(Resource.Id.lblNombre).Text = sala.Sala_Descripcion;
            FindViewById<TextView>(Resource.Id.lblFecha).Text = string.Format("{0} {1} - {2} Hrs", sala.Sala_Fecha, sala.Sala_Hora_Inicio, sala.Sala_Hora_Fin);
        }
    }
}
