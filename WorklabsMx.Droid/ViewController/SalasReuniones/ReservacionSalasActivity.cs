
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
    [Activity(Label = "@string/app_name")]
    public class ReservacionSalasActivity : Activity
    {
        List<SalaJuntasModel> salas;
        string Tipo, fecha_seleccionada, hora_inicio, hora_fin, cantidad_personas;
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
            ActionBar.Title = Resources.GetString(Resource.String.str_meeting_room_reservation);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            Tipo = Intent.GetStringExtra("Tipo");
            fecha_seleccionada = Intent.GetStringExtra("fecha_seleccionada");
            hora_inicio = Intent.GetStringExtra("hora_inicio");
            hora_fin = Intent.GetStringExtra("hora_fin");
            cantidad_personas = Intent.GetStringExtra("cantidad_personas");

            if (Tipo == "sala")
            {
                salas = SalasController.GetSalaJuntas("1");//Intent.GetStringExtra("sucursal_id"));//, fecha_seleccionada, hora_inicio_seleccionada, hora_fin_seleccionada);
            }
            else
            {
                salas = SalasController.GetSalaJuntas("1", fecha_seleccionada, hora_inicio, hora_fin);
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
                TextView lblNombre = SalaView.FindViewById<TextView>(Resource.Id.lblNombre);
                TextView lblNivel = SalaView.FindViewById<TextView>(Resource.Id.lblNivel);
                TextView lblCreditos = SalaView.FindViewById<TextView>(Resource.Id.lblCreditos);

                lblNombre.Text = sala.Sala_Descripcion;
                lblNivel.Text = sala.Sala_Nivel;

                SalaView.Click += delegate
                {
                    if (Tipo == "sala") { }
                    else
                    {
                        Intent intent = new Intent(this, typeof(ReservacionConfirmarActivity));
                        intent.PutExtra("Tipo", "horario");
                        intent.PutExtra("fecha_seleccionada", fecha_seleccionada);
                        intent.PutExtra("hora_inicio", hora_inicio);
                        intent.PutExtra("hora_fin", hora_fin);
                        intent.PutExtra("cantidad_personas", cantidad_personas);
                        intent.PutExtra("sala_id", sala.Sala_Id);
                        StartActivity(intent);
                    }
                };

                glSalas.AddView(SalaView);
            });
        }
    }
}
