using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class DatosFacturacionController : UIViewController
    {
        DatosFiscales datosfiscales;
        public DatosFacturacionController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            datosfiscales = new EmpresaController().GetDatosFiscales(SimpleStorage.EditGroup("Login").Get("Miembro_Id"));
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                scrollView.Add(new STLLabel("Razón social", 30));
                UITextField txtRazonSocial = new STLTextField("Razón Social", 60, datosfiscales.Razon_Social)
                {
                    Enabled = false
                };
                scrollView.Add(txtRazonSocial);

                scrollView.Add(new STLLabel("RFC", 90));
                UITextField txtRFC = new STLTextField("RFC", 120, datosfiscales.RFC)
                {
                    Enabled = false
                };
                scrollView.Add(txtRFC);

                scrollView.Add(new STLLabel("Estado", 150));
                UITextField txtEstado = new STLTextField("Estado", 180, datosfiscales.Territorio_Estado);
                scrollView.Add(txtEstado);

                scrollView.Add(new STLLabel("Municipio", 210));
                UITextField txtMunicipio = new STLTextField("Municipio", 240, datosfiscales.Territorio_Municipio);
                scrollView.Add(txtMunicipio);

                scrollView.Add(new STLLabel("Colonia", 270));
                UITextField txtColonia = new STLTextField("Colonia", 300, datosfiscales.Territorio_Colonia);
                scrollView.Add(txtColonia);

                scrollView.Add(new STLLabel("Código Postal", 330));
                UITextField txtCP = new STLTextField("Código Postal", 360, datosfiscales.Territorio_CP, UIKeyboardType.NumberPad);
                scrollView.Add(txtCP);

                scrollView.Add(new STLLabel("Calle", 390));
                UITextField txtCalle = new STLTextField("Calle", 420, datosfiscales.Domicilio_Fiscal_Empresa_Calle);
                scrollView.Add(txtCalle);

                scrollView.Add(new STLLabel("Num. Exterior", 450));
                UITextField txtNumExterior = new STLTextField("Num. Exterior", 470, datosfiscales.Domicilio_Fiscal_Empresa_Numero_Exterior);
                scrollView.Add(txtNumExterior);

                scrollView.Add(new STLLabel("Num. Interior", 500));
                UITextField txtNumInterior = new STLTextField("Num. Interior", 530, datosfiscales.Domicilio_Fiscal_Empresa_Numero_Interior);
                scrollView.Add(txtNumInterior);

                View.Add(scrollView);
                NavigationItem.SetRightBarButtonItem(new UIBarButtonItem("Actualizar", UIBarButtonItemStyle.Plain, (sender, e) =>
                {
                    new EmpresaController().UpdateDatosFiscales("", "");
                }), true);
            }

        }
    }
}