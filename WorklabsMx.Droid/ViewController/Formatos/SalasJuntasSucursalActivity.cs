using System;
using System.Collections.Generic;
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
    public class SalasJuntasSucursalActivity : Activity
    {
        /*protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SalasJuntasSucursalesLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Sucursales);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            GridView gvSucursales = FindViewById<GridView>(Resource.Id.gvSucursales);
            gvSucursales.Adapter = new SucursalAdapter(new SucursalController().GetSucursales());
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            OnBackPressed();
            return base.OnOptionsItemSelected(item);
        }
        public override void OnBackPressed()
        {
            StartActivity(new Intent(this, typeof(TabSalasJuntasHistorialActivity)));
            Finish();
        }
    }

    class SucursalAdapter : BaseAdapter<SucursalModel>
    {
        /*readonly List<SucursalModel> sucursales;

        public SucursalAdapter(List<SucursalModel> sucursales)
        {
            this.sucursales = sucursales;
        }

        public override SucursalModel this[int position] => sucursales[position];

        public override int Count => sucursales.Count;

        public override long GetItemId(int position) => 0;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View SucursalView;
            if (convertView == null)
                SucursalView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.SucursalInfoLayout, parent, false);
            else
                SucursalView = convertView;
            SucursalView.Click += delegate
            {
                Intent intent = new Intent(parent.Context, typeof(ReservaSalaJuntasActivity));
                intent.PutExtra("sucursal_id", sucursales[position].Sucursal_Id);
                parent.Context.StartActivity(intent);
            };
            SucursalView.FindViewById<TextView>(Resource.Id.lblNombre).Text = sucursales[position].Sucursal_Descripcion;
            SucursalView.FindViewById<TextView>(Resource.Id.lblCalle).Text = sucursales[position].Sucursal_Domicilio;
            SucursalView.FindViewById<TextView>(Resource.Id.lblColonia).Text = sucursales[position].Territorio.Colonia;
            return SucursalView;
        }*/


    }
}
