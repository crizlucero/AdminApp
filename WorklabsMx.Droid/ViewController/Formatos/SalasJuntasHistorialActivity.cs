using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using PerpetualEngine.Storage;
using WorklabsMx.Enum;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class SalasJuntasHistorialActivity : Activity
    {
        List<SalaJuntasReservacionModel> historico;
        SimpleStorage storage;
        int reservacion_estatus;
        public SalasJuntasHistorialActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalaJuntasHistorialLayout);
            reservacion_estatus = Intent.GetIntExtra("reservacion_estatus", (int)TiposReservacion.Activo);

            historico = new SalasJuntasController().GetReservaciones(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), reservacion_estatus);
            if (historico.Count > 1)
                FillHistorial();
            else
            {
                FindViewById<TextView>(Resource.Id.lblDiaSemana).Text ="Sin Reservaciones";
                FindViewById<TextView>(Resource.Id.lblSalaJunta).Text = "";
                FindViewById<TextView>(Resource.Id.lblDia).Text = "";
                FindViewById<TextView>(Resource.Id.lblHorario).Text = "";
            }
        }

        void FillHistorial()
        {
            historico.ForEach(reservacion =>
            {
                LayoutInflater inflater = LayoutInflater;
                View ReservaView = inflater.Inflate(Resource.Layout.ReservacionElementoLayout, null, true);

                ReservaView.FindViewById<TextView>(Resource.Id.lblSalaJunta).Text = reservacion.Sala_Descripcion;
                ReservaView.FindViewById<TextView>(Resource.Id.lblDiaSemana).Text = DateTime.Parse(reservacion.Sala_Hora_Fecha).Day.ToString();
                ReservaView.FindViewById<TextView>(Resource.Id.lblDia).Text = DateTime.Parse(reservacion.Sala_Hora_Fecha).DayOfWeek.ToString();
                ReservaView.FindViewById<TextView>(Resource.Id.lblHorario).Text = reservacion.Sala_Hora_Inicio + " - " + reservacion.Sala_Hora_Fin;
            });
        }
    }
}
