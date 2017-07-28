using Foundation;
using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;

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

            UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));

			scrollView.Add(new STLLabel("Estado", 30));
            UITextField txtEstado = new STLTextField("Estado", 60, datosfiscales.Domicilio_Fiscal_Empresa_Calle);
			scrollView.Add(txtEstado);

			scrollView.Add(new STLLabel("Municipio", 250));
            UITextField txtMunicipio = new STLTextField("Municipio", 270, datosfiscales.Domicilio_Fiscal_Empresa_Estatus);
			scrollView.Add(txtMunicipio);

			scrollView.Add(new STLLabel("Colonia", 300));
            UITextField txtColonia = new STLTextField("Colonia", 320, datosfiscales.Empresa_Miembro_Id);
			scrollView.Add(txtColonia);

			scrollView.Add(new STLLabel("Código Postal", 350));
            UITextField txtCP = new STLTextField("Código Postal", 370, datosfiscales.Territorio_Id, UIKeyboardType.NumberPad);
			scrollView.Add(txtCP);

			scrollView.Add(new STLLabel("Calle", 400));
            UITextField txtCalle = new STLTextField("Calle", 420, datosfiscales.Domicilio_Fiscal_Empresa_Calle);
			scrollView.Add(txtCalle);

			scrollView.Add(new STLLabel("Num. Exterior", 450));
			UITextField txtNumExterior = new STLTextField("Num. Exterior", 470, datosfiscales.Domicilio_Fiscal_Empresa_Numero_Exterior);
			scrollView.Add(txtNumExterior);

			scrollView.Add(new STLLabel("Num. Interior", 500));
			UITextField txtNumInterior = new STLTextField("Num. Interior", 520, datosfiscales.Domicilio_Fiscal_Empresa_Numero_Interior);
			scrollView.Add(txtNumInterior);

			scrollView.Add(new STLLabel("RFC", 550));
            UITextField txtRFC = new STLTextField("RFC", 570, datosfiscales.Domicilio_Fiscal_Empresa_Calle);
			scrollView.Add(txtRFC);

			scrollView.Add(new STLLabel("Razón social", 600));
			UITextField txtRazonSocial = new STLTextField("Razón Social", 620, datosfiscales.Domicilio_Fiscal_Empresa_Numero_Exterior);
			scrollView.Add(txtRazonSocial);

            View.Add(scrollView);
        }
    }
}