using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "EditEmpresaActivity")]
    public class EditEmpresaActivity : Activity
    {
        SimpleStorage storage;
        EditText NombreEmpresa, Telefono, CorreoElectronico, PaginaWeb,
        Facebook, Twitter, Instagram, Estado, Municipio, Calle,
        NumExterior, NumInterior, RFC, RazonSocial;
        AutoCompleteTextView CodigoPostal;
        Spinner GiroComercial, Colonia;
        PickerItemsController items;
        string empresa_id;
        List<string> colonias, giros;
        public EditEmpresaActivity()
        {
            items = new PickerItemsController();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.EditCompanyLayout);
            SimpleStorage.SetContext(ApplicationContext);
            storage = SimpleStorage.EditGroup("Login");
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.EditarEmpresa);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
            NombreEmpresa = FindViewById<EditText>(Resource.Id.txtNombreEmpresa);
            CorreoElectronico = FindViewById<EditText>(Resource.Id.txtEmailEmpresa);
            GiroComercial = FindViewById<Spinner>(Resource.Id.txtGiroComercialEmpresa);
            giros = items.GetGiros();
            GiroComercial.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, giros.ToArray());
            Municipio = FindViewById<EditText>(Resource.Id.txtMunicipioEmpresa);
            Estado = FindViewById<EditText>(Resource.Id.txtEstadoEmpresa);
            Calle = FindViewById<EditText>(Resource.Id.txtCalleEmpresa);
            NumExterior = FindViewById<EditText>(Resource.Id.txtNumExteriorEmpresa);
            NumInterior = FindViewById<EditText>(Resource.Id.txtNumInteriorEmpresa);
            Colonia = FindViewById<Spinner>(Resource.Id.txtColoniaEmpresa);
            CodigoPostal = FindViewById<AutoCompleteTextView>(Resource.Id.txtCPEmpresa);
            //CodigoPostal.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, items.GetCodigosPostales().ToArray());
            Telefono = FindViewById<EditText>(Resource.Id.txtTelefonoEmpresa);
            RFC = FindViewById<EditText>(Resource.Id.txtRFCEmpresa);
            RazonSocial = FindViewById<EditText>(Resource.Id.txtRazonSocialEmpresa);
            PaginaWeb = FindViewById<EditText>(Resource.Id.txtPaginaWebEmpresa);
            Facebook = FindViewById<EditText>(Resource.Id.txtFbEmpresa);
            Twitter = FindViewById<EditText>(Resource.Id.txtTwitterEmpresa);
            Instagram = FindViewById<EditText>(Resource.Id.txtInstagramEmpresa);
            FillData();
            CodigoPostal.TextChanged += CodigoPostal_TextChanged;
        }

        void FillData()
        {
            EmpresaModel empresa = new EmpresaController().GetEmpresaMiembro(storage.Get("Usuario_Id"));
            empresa_id = empresa.Empresa_Miembro_Id;
            NombreEmpresa.Text = empresa.Empresa_Miembro_Nombre;
            CorreoElectronico.Text = empresa.Empresa_Miembro_Correo_Electronico;

            GiroComercial.SetSelection(giros.IndexOf(empresa.Giro_Descripcion));
            Municipio.Text = empresa.Territorio_Municipio_Descripcion;
            Estado.Text = empresa.Territorio_Estado_Descripcion;
            Calle.Text = empresa.Empresa_Miembro_Calle;
            NumExterior.Text = empresa.Empresa_Miembro_Numero_Exterior;
            NumInterior.Text = empresa.Empresa_Miembro_Numero_Interior;
            colonias = items.GetColonias(empresa.Territorio_Cp);
            Colonia.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, colonias.ToArray());
            Colonia.SetSelection(colonias.IndexOf(empresa.Territorio_Colonia_Descripcion));
            CodigoPostal.Text = empresa.Territorio_Cp;
            Telefono.Text = empresa.Empresa_Miembro_Telefono;
            RFC.Text = empresa.Empresa_Miembro_Rfc;
            RazonSocial.Text = empresa.Empresa_Miembro_Razon_Social;
            PaginaWeb.Text = empresa.Empresa_Miembro_Pagina_Web;
            Facebook.Text = empresa.Empresa_Miembro_Red_Social_1;
            Twitter.Text = empresa.Empresa_Miembro_Red_Social_2;
            Instagram.Text = empresa.Empresa_Miembro_Red_Social_3;
        }

        void CodigoPostal_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (e.Text.ToString().Length == 5)
            {
                TerritorioModel territorio = new TerritorioController().GetTerritorio(e.Text.ToString());
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
                    //new EmpresaController().UpdateDataEmpresa(empresa_id, storage.Get("Usuario_Id"), GiroComercial.SelectedItemPosition + 1,);

                    break;
                default:
                    base.OnBackPressed(); break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
