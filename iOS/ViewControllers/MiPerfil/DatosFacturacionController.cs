using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using PerpetualEngine.Storage;
using WorklabsMx.iOS.ViewElements;

namespace WorklabsMx.iOS
{
    public partial class DatosFacturacionController : UIViewController
    {
        DatosFiscales datosfiscales;
        UITableView selectView;
        string pais;
        UITextField txtEstado, txtMunicipio, txtColonia;
        readonly PickerItemsController items;
        public DatosFacturacionController(IntPtr handle) : base(handle)
        {
            items = new PickerItemsController();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            datosfiscales = new EmpresaController().GetDatosFiscales(SimpleStorage.EditGroup("Login").Get("Usuario_Id"));
            pais = datosfiscales.Territorio_Pais;
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
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
                txtEstado = new STLTextField("Estado", 180, datosfiscales.Territorio_Estado);
                txtEstado.EditingDidBegin += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(pais))
                        selectView = new UIDropdownList(txtEstado, View, pais);
                };
                txtEstado.EditingDidEnd += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(pais))
                        selectView.RemoveFromSuperview();
                };
                scrollView.Add(txtEstado);

                scrollView.Add(new STLLabel("Municipio", 210));
                txtMunicipio = new STLTextField("Municipio", 240, datosfiscales.Territorio_Municipio);
                txtMunicipio.EditingDidBegin += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtEstado.Text))
                        selectView = new UIDropdownList(txtMunicipio, View, txtEstado.Text);
                };
                txtMunicipio.EditingDidEnd += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtEstado.Text))
                        selectView.RemoveFromSuperview();
                };
                scrollView.Add(txtMunicipio);

                scrollView.Add(new STLLabel("Colonia", 270));
                txtColonia = new STLTextField("Colonia", 300, datosfiscales.Territorio_Colonia);
                txtColonia.EditingDidBegin += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtMunicipio.Text))
                        selectView = new UIDropdownList(txtColonia, scrollView, txtMunicipio.Text);
                };
                txtColonia.EditingDidEnd += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtMunicipio.Text))
                        selectView.RemoveFromSuperview();
                };
                scrollView.Add(txtColonia);

                scrollView.Add(new STLLabel("Código Postal", 330));
                UITextField txtCP = new STLTextField("Código Postal", 360, datosfiscales.Territorio_CP, UIKeyboardType.NumberPad);
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
                    new EmpresaController().UpdateDatosFiscales("", "");
                }), true);
            }

        }
    }
}