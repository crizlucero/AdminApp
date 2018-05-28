
using System;
using System.Globalization;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservacionConfirmacionActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalasReunionConfirmacionLayout);
            SalaJuntasModel sala = new SalasJuntasController().GetSalaJuntasInfo(Intent.GetStringExtra("sala_id"));
            if (Intent.GetStringExtra("Tipo") != "Cancelar")
            {
                FindViewById<TextView>(Resource.Id.lblFecha).Text = DateTime.Parse(Intent.GetStringExtra("fecha_seleccionada"), new CultureInfo("es-MX")).ToLongDateString();
                FindViewById<TextView>(Resource.Id.lblHorario).Text = string.Format("{0}hrs - {1}hrs", Intent.GetStringExtra("hora_inicio"), Intent.GetStringExtra("hora_fin"));
                FindViewById<TextView>(Resource.Id.lblNombre).Text = string.Format("Sala: {0}", sala.Sala_Descripcion);
                FindViewById<TextView>(Resource.Id.lblNivel).Text = string.Format("Nivel {0}", sala.Sala_Nivel);
                FindViewById<TextView>(Resource.Id.lblCantidad).Text = string.Format("{0} personas", Intent.GetStringExtra("cantidad_personas"));
                if (Intent.GetStringExtra("Tipo") == "Editar")
                {
                    FindViewById<TextView>(Resource.Id.lblSubTitle).Text = "Se editó con éxito tu reserva";
                }
            }
            else
            {
                FindViewById<TextView>(Resource.Id.lblTitle).Text = "¡CANCELADO!";
                FindViewById<TextView>(Resource.Id.lblFecha).Visibility = ViewStates.Gone;
                FindViewById<TextView>(Resource.Id.lblHorario).Visibility = ViewStates.Gone;
                FindViewById<TextView>(Resource.Id.lblNombre).Visibility = ViewStates.Gone;
                FindViewById<TextView>(Resource.Id.lblNivel).Visibility = ViewStates.Gone;
                FindViewById<TextView>(Resource.Id.lblCantidad).Visibility = ViewStates.Gone;
                FindViewById<TextView>(Resource.Id.lblMensaje).Text = "Gracias por cancelar tu reserva, esto le permite a la comunidad aprovechar el espacio.";
            }
            FindViewById<ImageView>(Resource.Id.ivContinuar).Click += delegate
            {
                StartActivity(new Intent(this, typeof(SalaReunionesProgramaActivity)));
                Finish();
            };

        }
    }
}
