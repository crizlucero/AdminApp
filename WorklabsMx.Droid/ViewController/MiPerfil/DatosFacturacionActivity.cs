using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "DatosFacturacionActivity")]
    public class DatosFacturacionActivity : Activity
    {
        SimpleStorage storage;
        EditText RazonSocial, RFC, Estado, Municipio, Colonia, CodigoPostal, Calle, NumExterior, NumInterior;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DatosFacturacionLayout);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.MiPerfil);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            RazonSocial = FindViewById<EditText>(Resource.Id.txtRazonSocialFactura);
            RFC = FindViewById<EditText>(Resource.Id.txtRFCFactura);
            Estado = FindViewById<EditText>(Resource.Id.txtEstadoFactura);
            Municipio = FindViewById<EditText>(Resource.Id.txtMunicipioFactura);
            Colonia = FindViewById<EditText>(Resource.Id.txtColoniaFactura);
            CodigoPostal = FindViewById<EditText>(Resource.Id.txtCalleFactura);
            Calle = FindViewById<EditText>(Resource.Id.txtCalleFactura);
            NumExterior = FindViewById<EditText>(Resource.Id.txtNumExteriorFactura);
            NumInterior = FindViewById<EditText>(Resource.Id.txtNumInteriorFactura);

            FillData();
        }

        void FillData()
        {
            DatosFiscales fiscal = new EmpresaController().GetDatosFiscales(storage.Get("Usuario_Id"));
            RazonSocial.Text = fiscal.Razon_Social;
            RFC.Text = fiscal.RFC;
            Estado.Text = fiscal.Territorio_Estado;
            Municipio.Text = fiscal.Territorio_Municipio;
            Colonia.Text = fiscal.Territorio_Colonia;
            CodigoPostal.Text = fiscal.Territorio_CP;
            Calle.Text = fiscal.Domicilio_Fiscal_Empresa_Calle;
            NumExterior.Text = fiscal.Domicilio_Fiscal_Empresa_Numero_Exterior;
            NumInterior.Text = fiscal.Domicilio_Fiscal_Empresa_Numero_Interior;

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.send_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.menu_send:
                    new EmpresaController().UpdateDatosFiscales("",""); break;
                default:
                    base.OnBackPressed(); break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
