using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "MyMembershipActivity")]
    public class MyMembershipActivity : Activity
    {
        SimpleStorage storage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SubscriptionLayout);
            storage = SimpleStorage.EditGroup("Login");
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.MiCuenta);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
        }

        void FillData()
        {
            TableLayout tlMembresias = FindViewById<TableLayout>(Resource.Id.tlMembresias);
            foreach (MembresiaModel membresia in new SuscripcionesController().GetMembresiasContratadas(storage.Get("Usuario_Id")))
            {

            }

            TableLayout tlProductos = FindViewById<TableLayout>(Resource.Id.tlProductos);
            foreach (ProductoModel producto in new SuscripcionesController().GetProductosContratados(storage.Get("Usuario_Id")))
            {

            }
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            base.OnBackPressed();
            return base.OnOptionsItemSelected( item);
        }
    }
}
