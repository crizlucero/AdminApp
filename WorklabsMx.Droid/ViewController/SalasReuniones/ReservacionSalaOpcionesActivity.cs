
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ReserevacionSalaOpcionesActivity")]
    public class ReservacionSalaOpcionesActivity : Activity
    {
        string sala_id, fecha_seleccionada, hora_inicio, hora_fin, cantidad_personas, cantidad_creditos, reservacion_id;
        bool penalizacion;
        readonly SalasJuntasController controller;

        public ReservacionSalaOpcionesActivity()
        {
            controller = new SalasJuntasController();
            penalizacion = false;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalaReunionOpcionesLayout);

            string opcion = Intent.GetStringExtra("Opcion");
            sala_id = Intent.GetStringExtra("sala_id");
            fecha_seleccionada = Intent.GetStringExtra("fecha_seleccionada");
            hora_inicio = Intent.GetStringExtra("hora_inicio");
            hora_fin = Intent.GetStringExtra("hora_fin");
            cantidad_personas = Intent.GetStringExtra("cantidad_personas");

            FindViewById<TextView>(Resource.Id.lblTipo).Text = opcion;
            FindViewById<ImageView>(Resource.Id.ivCancelar).Click += delegate
            {
                StartActivity(new Intent(this, typeof(SalaReunionesProgramaActivity)));
                Finish();
            };
            Button confirmar = FindViewById<Button>(Resource.Id.btnConfirmar);
            if (opcion == "Cancelar")
            {
                confirmar.SetBackgroundColor(Color.Rgb(232, 60, 57));
            }

            confirmar.Click += delegate
            {
                if (opcion == "Cancelar")
                    controller.CancelarSalaJuntas("Baja", sala_id);
                else
                {
                    double creditos = DateHelper.CalcularCreditos(hora_inicio, hora_fin);
                    if (penalizacion)
                        --creditos;
                    controller.ModificarSalaJuntas("Modificar", sala_id, DateTime.Parse(fecha_seleccionada, new CultureInfo("es-MX")), hora_inicio, hora_fin, creditos.ToString(), cantidad_personas);
                }
            };
            FillData(opcion);
        }

        void FillData(string opcion)
        {
            SalaJuntasReservacionModel sala = controller.GetReservacion(Intent.GetStringExtra("Reservacion_Id"));
            sala.Sala_Fecha = DateTime.Parse(sala.Sala_Fecha, new CultureInfo("es-MX")).ToString("d");
            penalizacion = DateTime.Now.Hour + 2 >= TimeSpan.Parse(sala.Sala_Hora_Inicio).Hours;
            if (string.IsNullOrEmpty(sala_id))
            {
                FindViewById<TextView>(Resource.Id.txtNombre).Text = sala.Sala_Descripcion;
                FindViewById<TextView>(Resource.Id.txtFecha).Text = string.Format("{0} {1} - {2} Hrs", sala.Sala_Fecha, sala.Sala_Hora_Inicio, sala.Sala_Hora_Fin);
            }
            else
            {
                FindViewById<TextView>(Resource.Id.txtNombre).Text = controller.GetSalaJuntasInfo(sala_id).Sala_Descripcion;
                FindViewById<TextView>(Resource.Id.txtFecha).Text = string.Format("{0} {1} - {2} Hrs", fecha_seleccionada, hora_inicio, hora_fin);
            }


            ImageView nombre = FindViewById<ImageView>(Resource.Id.ivEditarSala);
            ImageView fecha = FindViewById<ImageView>(Resource.Id.ivEditarFecha);
            if (opcion == "Cancelar")
            {
                nombre.Visibility = ViewStates.Gone;
                fecha.Visibility = ViewStates.Gone;
            }
            nombre.Click += delegate
            {
                Intent intent = new Intent(this, typeof(ReservacionSalasActivity));
                intent.PutExtra("Tipo", (int)TipoSalaReunionFlujo.Editar);
                intent.PutExtra("Reservacion_Id", sala.Sala_Junta_Reservacion_Id);
                intent.PutExtra("sala_id", sala.Sala_Id);
                intent.PutExtra("fecha_seleccionada", sala.Sala_Fecha);
                intent.PutExtra("hora_inicio", sala.Sala_Hora_Inicio);
                intent.PutExtra("hora_fin", sala.Sala_Hora_Fin);
                intent.PutExtra("cantidad_personas", sala.Cantidad_Personas);

                StartActivity(intent);
            };

            fecha.Click += delegate
            {
                Intent intent = new Intent(this, typeof(ReservacionHorariosActivity));
                intent.PutExtra("Tipo", (int)TipoSalaReunionFlujo.Editar);
                intent.PutExtra("Reservacion_Id", sala.Sala_Junta_Reservacion_Id);
                intent.PutExtra("sala_id", sala.Sala_Id);
                intent.PutExtra("fecha_seleccionada", sala.Sala_Fecha);
                intent.PutExtra("hora_inicio", sala.Sala_Hora_Inicio);
                intent.PutExtra("hora_fin", sala.Sala_Hora_Fin);
                intent.PutExtra("cantidad_personas", sala.Cantidad_Personas);

                StartActivity(intent);
            };
        }
    }
}
