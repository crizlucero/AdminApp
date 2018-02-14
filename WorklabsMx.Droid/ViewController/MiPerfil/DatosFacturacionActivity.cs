using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class DatosFacturacionActivity : Activity
    {
        SimpleStorage storage;
        EditText RazonSocial, RFC, Estado, Municipio, CodigoPostal, Calle, NumExterior, NumInterior, Email;
        Spinner Colonia;
        List<string> colonias;
        PickerItemsController items;
        string empresa_id, territorio_id;
        public DatosFacturacionActivity()
        {
            items = new PickerItemsController();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DatosFacturacionLayout);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.str_profile_my_profile);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            Email = FindViewById<EditText>(Resource.Id.txtCorreoElectronicoFactura);
            RazonSocial = FindViewById<EditText>(Resource.Id.txtRazonSocialFactura);
            RFC = FindViewById<EditText>(Resource.Id.txtRFCFactura);
            Estado = FindViewById<EditText>(Resource.Id.txtEstadoFactura);
            Municipio = FindViewById<EditText>(Resource.Id.txtMunicipioFactura);
            Colonia = FindViewById<Spinner>(Resource.Id.txtColoniaFactura);
            CodigoPostal = FindViewById<EditText>(Resource.Id.txtCodigoPostalFactura);
            Calle = FindViewById<EditText>(Resource.Id.txtCalleFactura);
            NumExterior = FindViewById<EditText>(Resource.Id.txtNumExteriorFactura);
            NumInterior = FindViewById<EditText>(Resource.Id.txtNumInteriorFactura);

            FillData();
            CodigoPostal.TextChanged += CodigoPostal_TextChanged;
        }

        void FillData()
        {
            DatosFiscales fiscal = new EmpresaController().GetDatosFiscales(storage.Get("Usuario_Id"));
            empresa_id = fiscal.Domicilio_Fiscal_Empresa_Id;
            RazonSocial.Text = fiscal.Razon_Social;
            RFC.Text = fiscal.RFC;
            Estado.Text = fiscal.Territorio_Estado;
            Municipio.Text = fiscal.Territorio_Municipio;
            colonias = items.GetColonias(fiscal.Territorio_CP);
            Colonia.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, colonias.ToArray());
            Colonia.SetSelection(colonias.IndexOf(fiscal.Territorio_Colonia));
            CodigoPostal.Text = fiscal.Territorio_CP;
            Calle.Text = fiscal.Domicilio_Fiscal_Empresa_Calle;
            NumExterior.Text = fiscal.Domicilio_Fiscal_Empresa_Numero_Exterior;
            NumInterior.Text = fiscal.Domicilio_Fiscal_Empresa_Numero_Interior;
            Email.Text = fiscal.Domicilio_Fiscal_Empresa_Correo_Electronico;

        }

        void CodigoPostal_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (e.Text.ToString().Length == 5)
            {
                TerritorioModel territorio = new TerritorioController().GetTerritorio(e.Text.ToString());
                territorio_id = territorio.Territorio_Id;
                Estado.Text = territorio.Estado;
                Municipio.Text = territorio.Municipio;
                colonias = items.GetColonias(territorio.CP);
                Colonia.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, colonias.ToArray());
                Colonia.SetSelection(colonias.IndexOf(territorio.Colonia));
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.save_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_save:
                    if (new EmpresaController().UpdateDatosFiscales(empresa_id, storage.Get("Usuario_Id"), territorio_id, Calle.Text, NumExterior.Text, NumInterior.Text, Email.Text))
                        Toast.MakeText(this, Resource.String.DatosGuardados,ToastLength.Short).Show();
                    else Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short).Show();
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
