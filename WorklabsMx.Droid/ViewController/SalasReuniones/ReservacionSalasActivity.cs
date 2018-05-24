
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
using WorklabsMx.Enum;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservacionSalasActivity : Activity
    {
        List<SalaJuntasModel> salas;
        string fecha_seleccionada, hora_inicio, hora_fin, cantidad_personas, cantidad_creditos;
        int Tipo;
        readonly SalasJuntasController SalasController;

        public ReservacionSalasActivity()
        {
            SalasController = new SalasJuntasController();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalasReunionSeleccionarSalaLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            Tipo = Intent.GetIntExtra("Tipo", 0);
            fecha_seleccionada = Intent.GetStringExtra("fecha_seleccionada");
            hora_inicio = Intent.GetStringExtra("hora_inicio");
            hora_fin = Intent.GetStringExtra("hora_fin");
            cantidad_personas = Intent.GetStringExtra("cantidad_personas");

            if (Tipo == (int)TipoSalaReunionFlujo.Sala)
            {
                salas = SalasController.GetSalaJuntas("1");//Intent.GetStringExtra("sucursal_id"));//, fecha_seleccionada, hora_inicio_seleccionada, hora_fin_seleccionada);
            }
            else
            {
                salas = SalasController.GetSalaJuntas("1", fecha_seleccionada, hora_inicio, hora_fin, cantidad_personas);
                cantidad_creditos = CalcularCreditos().ToString();
            }

            FillSalas();
        }

        void FillSalas()
        {
            GridLayout glSalas = FindViewById<GridLayout>(Resource.Id.glSalas);

            salas.AsParallel().ToList().ForEach(sala =>
            {
                View SalaView = LayoutInflater.Inflate(Resource.Layout.SalaSeleccionLayout, null, true);
                ImageView ivSala = SalaView.FindViewById<ImageView>(Resource.Id.ivSala);
                SalaView.FindViewById<TextView>(Resource.Id.lblNombre).Text = sala.Sala_Descripcion;
                SalaView.FindViewById<TextView>(Resource.Id.lblNivel).Text = string.Format("Nivel {0}", sala.Sala_Nivel);
                if (Tipo == (int)TipoSalaReunionFlujo.Horario)
                    SalaView.FindViewById<TextView>(Resource.Id.lblCreditos).Text = string.Format("{0} Créditos", cantidad_creditos);
                else
                    SalaView.FindViewById<TextView>(Resource.Id.lblCreditos).Visibility = ViewStates.Gone;


                SalaView.Click += delegate
                {
                    if (Tipo == (int)TipoSalaReunionFlujo.Sala)
                    {
                        Intent intent = new Intent(this, typeof(ReservacionHorariosActivity));
                        intent.PutExtra("Tipo", (int)TipoSalaReunionFlujo.Sala);
                        intent.PutExtra("sala_id", sala.Sala_Id);
                        StartActivity(intent);
                    }
                    else
                    {
                        Intent intent = new Intent(this, typeof(ReservacionConfirmarActivity));
                        intent.PutExtra("Tipo", (int)TipoSalaReunionFlujo.Sala);
                        intent.PutExtra("fecha_seleccionada", fecha_seleccionada);
                        intent.PutExtra("hora_inicio", hora_inicio);
                        intent.PutExtra("hora_fin", hora_fin);
                        intent.PutExtra("cantidad_personas", cantidad_personas);
                        intent.PutExtra("cantidad_creditos", cantidad_creditos);
                        intent.PutExtra("sala_id", sala.Sala_Id);
                        StartActivity(intent);
                    }
                };
                glSalas.AddView(SalaView);
            });
        }

        double CalcularCreditos()
        {
            double horas = DateTime.Parse(hora_fin).Subtract(DateTime.Parse(hora_inicio)).TotalHours * 2;
            DateTime hora_inicial = DateTime.Parse(hora_inicio);
            DateTime hora_final = DateTime.Parse(hora_fin);
            double tiempo = 0;
            for (double i = 0; i < horas; i += .5)
            {
                if (hora_inicial.Hour > 11 && hora_inicial.Hour < 17)
                {
                    if (hora_final != hora_inicial)
                    {
                        tiempo += .5;
                        hora_inicial = hora_inicial.AddMinutes(30);
                    }
                    else break;
                }
                else break;
            }
            return horas + tiempo;
        }
    }
}