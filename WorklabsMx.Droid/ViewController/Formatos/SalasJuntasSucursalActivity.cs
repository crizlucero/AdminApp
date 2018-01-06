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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SalasJuntasSucursalesLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Sucursales);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            GridView gvSucursales = FindViewById<GridView>(Resource.Id.gvSucursales);
            gvSucursales.Adapter = new SucursalAdapter(this, new SucursalController().GetSucursales());
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(TabSalasJuntasHistorialActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
        }
    }

    class SucursalAdapter : BaseAdapter
    {

        Context context;
        List<SucursalModel> sucursales;

        public SucursalAdapter(Context context, List<SucursalModel> sucursales)
        {
            this.context = context;
            this.sucursales = sucursales;
        }


        public override int Count => sucursales.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            LayoutInflater inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View SucursalView = inflater.Inflate(Resource.Layout.SucursalInfoLayout, null, false);
            SucursalView.SetMinimumWidth(context.Resources.DisplayMetrics.WidthPixels / 2);
            SucursalView.Click += delegate
            {
                Intent intent = new Intent(context, typeof(SalasJuntasActivity));
                intent.PutExtra("sucursal_id", sucursales[position].Sucursal_Id);
                context.StartActivity(intent);
            };
            SucursalView.FindViewById<TextView>(Resource.Id.lblNombre).Text = sucursales[position].Sucursal_Descripcion;
            SucursalView.FindViewById<TextView>(Resource.Id.lblCalle).Text = sucursales[position].Sucursal_Domicilio;
            SucursalView.FindViewById<TextView>(Resource.Id.lblColonia).Text = sucursales[position].Sucursal_Domicilio;
            return SucursalView;
        }
    }
}
