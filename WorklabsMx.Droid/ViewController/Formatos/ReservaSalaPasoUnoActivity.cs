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
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ReservaSalaPasoUnoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReservacionSalaJuntasPaso1Layout);

            DatePicker dpFecha = FindViewById<DatePicker>(Resource.Id.dpFecha);
            dpFecha.MinDate = new Java.Util.Date().Time;
            TimePicker tpHoraInicio = FindViewById<TimePicker>(Resource.Id.tpHoraInicio);
            tpHoraInicio.SetIs24HourView(Java.Lang.Boolean.True);
            if (dpFecha.DateTime == DateTime.Now)
            {

            }
            TimePicker tpHoraFin = FindViewById<TimePicker>(Resource.Id.tpHoraFin);
            tpHoraFin.SetIs24HourView(Java.Lang.Boolean.True);

            RadioGroup rgCantidad = FindViewById<RadioGroup>(Resource.Id.rgCapacidad);
            RadioButton rbCantidad = FindViewById<RadioButton>(rgCantidad.CheckedRadioButtonId);

            FindViewById<Button>(Resource.Id.btnAceptar).Click += delegate
            {
                if (dpFecha.DateTime == DateTime.Now)
                {
                    if(tpHoraInicio.Hour >= DateTime.Now.Hour){
                        if(tpHoraInicio.Hour == DateTime.Now.Hour && tpHoraInicio.Minute > DateTime.Now.Minute){
                            
                        }else{
                            
                        }
                    }
                }
            };
        }
    }
}
