
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
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservacionConfirmarActivity : Activity
    {
        SalaJuntasModel sala;
        string Tipo, sala_id, fecha_seleccionada, hora_inicio, hora_fin, cantidad_personas, cantidad_creditos;
        readonly int creditos_disponibles;
        SimpleStorage storage;

        public ReservacionConfirmarActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
            creditos_disponibles = new SalasJuntasController().GetCreditosDisponibles(storage.Get("Usuario_Id"));
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalasReunionConfirmarLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room_reservation);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            sala_id = Intent.GetStringExtra("sala_id");

            sala = new SalasJuntasController().GetSalaJuntasInfo(sala_id);
            fecha_seleccionada = Intent.GetStringExtra("fecha_seleccionada");
            hora_inicio = Intent.GetStringExtra("hora_inicio");
            hora_fin = Intent.GetStringExtra("hora_fin");
            cantidad_personas = Intent.GetStringExtra("cantidad_personas");
            cantidad_creditos = Intent.GetStringExtra("cantidad_creditos");
            FillView();
        }

        void FillView()
        {
            FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Parse(fecha_seleccionada).ToLongDateString();
            FindViewById<TextView>(Resource.Id.lblHorario).Text = string.Format("{0} - {1}", hora_inicio, hora_fin);
            FindViewById<TextView>(Resource.Id.lblCreditosDisponibles).Text = creditos_disponibles.ToString();
            FindViewById<TextView>(Resource.Id.lblCosto).Text = cantidad_creditos;
            FindViewById<TextView>(Resource.Id.lblNombre).Text = sala.Sala_Descripcion;
            FindViewById<TextView>(Resource.Id.lblNivel).Text = string.Format("Nivel {0}", sala.Sala_Nivel);
            FindViewById<TextView>(Resource.Id.lblCapacidadSala).Text = string.Format("Sala para {0} personas", sala.Sala_Capacidad);
        }
    }
}
