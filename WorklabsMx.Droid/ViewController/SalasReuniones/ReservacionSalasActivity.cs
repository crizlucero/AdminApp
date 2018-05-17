
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
        readonly SalasJuntasController SalasController;

        public ReservacionSalasActivity(){
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

            string Tipo = Intent.GetStringExtra("Tipo");
            string fecha_seleccionada = Intent.GetStringExtra("fecha_seleccionada");
            string hora_inicio = Intent.GetStringExtra("hora_inicio");
            string hora_fin = Intent.GetStringExtra("hora_fin");
            string cantidad_personas = Intent.GetStringExtra("cantidad_personas");

            if (Tipo == "sala")
            {
                salas = SalasController.GetSalaJuntas("1");//Intent.GetStringExtra("sucursal_id"));//, fecha_seleccionada, hora_inicio_seleccionada, hora_fin_seleccionada);
            }else{
                salas = SalasController.GetSalaJuntas("1", fecha_seleccionada, hora_inicio, hora_fin);
            }

            FillSalas();
        }

        void FillSalas(){
            GridLayout glSalas = FindViewById<GridLayout>(Resource.Id.glSalas);

            salas.AsParallel().ToList().ForEach(sala =>{
                View SalaView = LayoutInflater.Inflate(Resource.Layout.SalaSeleccionLayout, null, true);
                ImageView ivSala = SalaView.FindViewById<ImageView>(Resource.Id.ivSala);
                TextView lblNombre = SalaView.FindViewById<TextView>(Resource.Id.lblNombre);
                TextView lblNivel = SalaView.FindViewById<TextView>(Resource.Id.lblNivel);
                TextView lblCreditos = SalaView.FindViewById<TextView>(Resource.Id.lblCreditos);

                lblNombre.Text = sala.Sala_Descripcion;
                lblNivel.Text = sala.Sala_Nivel;

                SalaView.Click += delegate
                {

                };

                glSalas.AddView(SalaView);
            });
        }
    }
}
