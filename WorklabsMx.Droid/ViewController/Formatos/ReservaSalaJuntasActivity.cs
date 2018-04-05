
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text.Format;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ReservaSalaJuntasActivity")]
    public class ReservaSalaJuntasActivity : Activity
    {
        List<SalaJuntasModel> salas;
        readonly SalasJuntasController SalasController;
        string fecha_seleccionada, hora_inicio_seleccionada, hora_fin_seleccionada;
        readonly SimpleStorage storage;

        public ReservaSalaJuntasActivity()
        {
            storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReservacionSalaJuntasLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.ReservaSala);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            fecha_seleccionada = DateTime.Now.ToString("d");
            hora_inicio_seleccionada = DateTime.Now.TimeOfDay.ToString("hh:mm");

            hora_fin_seleccionada = DateTime.Now.AddMinutes(30).ToString("hh:mm");

            FindViewById<TextView>(Resource.Id.lblCreditosDisponibles).Text = SalasController.GetCreditosDisponibles(storage.Get("Usuario_Id")).ToString();
            FindViewById<LinearLayout>(Resource.Id.llSeleccionarFecha).Click += (sender, e) =>
            {
                DatePickerMinFragment frag = DatePickerMinFragment.NewInstance(delegate (DateTime time)
                {
                    FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = time.DayOfWeek.ToString().Substring(0, 3);
                    FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = time.Day.ToString();
                    fecha_seleccionada = time.ToString("d");
                });
                frag.Show(FragmentManager, Resources.GetString(Resource.String.ReservaSala));
            };

            FindViewById<TextView>(Resource.Id.llSeleccionarHoraInicio).Click += (sender, e) =>
            {
                TimePickerIntervalFragment frag = TimePickerIntervalFragment.NewInstance(delegate (DateTime time)
                {
                    FindViewById<TextView>(Resource.Id.txtSeleccionarHoraInicio).Text = hora_inicio_seleccionada = time.ToString("hh:mm");
                });
            };

            FindViewById<TextView>(Resource.Id.llSeleccionarHoraFin).Click += (sender, e) =>
            {
                TimePickerIntervalFragment frag = TimePickerIntervalFragment.NewInstance(delegate (DateTime time)
                {
                    FindViewById<TextView>(Resource.Id.txtSeleccionarHoraInicio).Text = hora_fin_seleccionada = time.ToString("hh:mm");
                });
            };

            salas = SalasController.GetSalaJuntas(Intent.GetStringExtra("sucursal_id"),fecha_seleccionada, hora_inicio_seleccionada,hora_fin_seleccionada);
            FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = DateTime.Parse(fecha_seleccionada).DayOfWeek.ToString().Substring(0, 3);
            FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
            //FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = Horarios[fecha_seleccionada].Count.ToString();
            //FindViewById<TextView>(Resource.Id.lblCreditosUsados).Text = creditos.ToString();
        }
    }
}
