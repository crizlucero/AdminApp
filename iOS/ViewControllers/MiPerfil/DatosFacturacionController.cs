using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.ViewElements;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class DatosFacturacionController : UIViewController
    {
        DatosFiscales datosfiscales;
        UITableView selectView;
        string territorio_id, empresa_id, pais;
        List<string> colonias;
        UITextField txtEstado, txtMunicipio, txtColonia, txtCP;
        readonly PickerItemsController items;
        SimpleStorage storage;
        UIScrollView scrollView;
        public DatosFacturacionController(IntPtr handle) : base(handle)
        {
            items = new PickerItemsController();
            storage = SimpleStorage.EditGroup("Login");
            datosfiscales = new EmpresaController().GetDatosFiscales(storage.Get("Usuario_Id"));
            TerritorioModel territorio = new TerritorioController().GetTerritorio(datosfiscales.Territorio_CP);
            empresa_id = datosfiscales.Domicilio_Fiscal_Empresa_Id;
            territorio_id = territorio.Territorio_Id;
            colonias = items.GetColonias(territorio.CP);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            pais = datosfiscales.Territorio_Pais;
            using (scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                scrollView.Add(new STLLabel("Razón social", 30));
                UITextField txtRazonSocial = new STLTextField("Razón Social", 60, datosfiscales.Razon_Social)
                {
                    Enabled = false,
                    TextColor = UIColor.Gray
                };
                scrollView.Add(txtRazonSocial);

                scrollView.Add(new STLLabel("RFC", 90));
                UITextField txtRFC = new STLTextField("RFC", 120, datosfiscales.RFC)
                {
                    Enabled = false,
                    TextColor = UIColor.Gray
                };
                scrollView.Add(txtRFC);

                scrollView.Add(new STLLabel("Estado", 150));
                txtEstado = new STLTextField("Estado", 180, datosfiscales.Territorio_Estado)
                {
                    Enabled = false,
                    TextColor = UIColor.Gray
                };
                scrollView.Add(txtEstado);

                scrollView.Add(new STLLabel("Municipio", 210));
                txtMunicipio = new STLTextField("Municipio", 240, datosfiscales.Territorio_Municipio)
                {
                    Enabled = false,
                    TextColor = UIColor.Gray
                };
                scrollView.Add(txtMunicipio);

                scrollView.Add(new STLLabel("Colonia", 270));
                txtColonia = new STLTextField("Colonia", 300, datosfiscales.Territorio_Colonia);
                txtColonia.EditingDidBegin += (sender, e) =>
                {
                    //selectView = new UIDropdownList(txtColonia, scrollView, colonias);
                    selectView = new STLDropDownList(colonias, txtColonia);
                    View.AddSubview(selectView);
                };
                txtColonia.EditingDidEnd += (sender, e) =>
                {
                    GetTerritorioId();
                    selectView.RemoveFromSuperview();
                };
                scrollView.Add(txtColonia);

                scrollView.Add(new STLLabel("Código Postal", 330));
                txtCP = new STLTextField("Código Postal", 360, datosfiscales.Territorio_CP, UIKeyboardType.NumberPad);
                txtCP.EditingChanged += TxtCP_EditingChanged;
                scrollView.Add(txtCP);

                scrollView.Add(new STLLabel("Calle", 390));
                UITextField txtCalle = new STLTextField("Calle", 420, datosfiscales.Domicilio_Fiscal_Empresa_Calle);
                scrollView.Add(txtCalle);

                scrollView.Add(new STLLabel("Num. Exterior", 450));
                UITextField txtNumExterior = new STLTextField("Num. Exterior", 480, datosfiscales.Domicilio_Fiscal_Empresa_Numero_Exterior);
                scrollView.Add(txtNumExterior);

                scrollView.Add(new STLLabel("Num. Interior", 510));
                UITextField txtNumInterior = new STLTextField("Num. Interior", 540, datosfiscales.Domicilio_Fiscal_Empresa_Numero_Interior);
                scrollView.Add(txtNumInterior);

                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 580);
                View.Add(scrollView);
                NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Actualizar", UIBarButtonItemStyle.Plain, (sender, e) =>
                {
                    if (new EmpresaController().UpdateDatosFiscales(empresa_id, storage.Get("Usuario_Id"), territorio_id, txtCalle.Text, txtNumExterior.Text, txtNumInterior.Text, ""))
                        new MessageDialog().SendToast("Datos guardados");
                    else
                        new MessageDialog().SendToast("Hubo un error\nIntente de nuevo");
                }), true);
            }

        }

        void TxtCP_EditingChanged(object sender, EventArgs e)
        {
            if (((UITextField)sender).Text.Length == 5)
            {
                TerritorioModel territorio = new TerritorioController().GetTerritorio(((UITextField)sender).Text);
                territorio_id = territorio.Territorio_Id;
                txtEstado.Text = territorio.Estado;
                txtMunicipio.Text = territorio.Municipio;
                colonias = items.GetColonias(territorio.CP);
            }
        }
        void GetTerritorioId()
        {
            territorio_id = new TerritorioController().GetTerritorioId(txtCP.Text, txtColonia.Text);
        }
    }
}