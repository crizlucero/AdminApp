
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

namespace WorklabsMx.Droid.ViewController.SalasReuniones
{
    [Activity(Label = "SalaReunionesProgramaActivity")]
    public class SalaReunionesProgramaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SalasReunionProgramaLayout);
        }

        void FillProximas(){
            
        }

        void FillAnteriores(){
            
        }
    }
}
