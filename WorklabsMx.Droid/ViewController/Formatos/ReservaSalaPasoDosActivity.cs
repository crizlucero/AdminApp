
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
    [Activity(Label = "ReservaSalaPasoDosActivity")]
    public class ReservaSalaPasoDosActivity : Activity
    {
        List<SalaJuntasModel> salas;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReservacionSalaJuntasPaso2Layout);

            salas = new SalasJuntasController().GetSalaJuntas(Intent.GetStringExtra("sucursal_id"), DateTime.Now.ToString("d"), DateTime.Now.ToShortTimeString(), DateTime.Now.AddMinutes(30).ToShortTimeString());

            ListView lvSalasJuntas = FindViewById<ListView>(Resource.Id.lvSalasJuntas);
            lvSalasJuntas.Adapter = new SalasJuntasListAdapter(salas);
        }
    }
}
