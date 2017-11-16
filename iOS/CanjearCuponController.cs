using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{

    public interface DescuentoAplicadoDel
    {
        void DescuentoAplicado(PromocionModel datosDescuento);
    }

    public partial class CanjearCuponController : UIViewController
    {

        public DescuentoAplicadoDel datosDescuentoDelegate;

        PagosController Cupon;

        PromocionModel datosDescuento;

        public CanjearCuponController (IntPtr handle) : base (handle)
        {
            Cupon = new PagosController();
            datosDescuento = new PromocionModel();
           
        }

        public override void ViewDidLoad()
        {
            StyleHelper.Style(this.vwCanjearCupon.Layer);
            StyleHelper.Style(this.btnCanjearCupon.Layer);
            var color = new UIColor(1, 0.8f);
            this.View.BackgroundColor = color;
        }

        partial void btnCanjear_TouchUpInside(UIButton sender)
        {
            if (this.txtCupon.Text != "")
            {
                if (InternetConectionHelper.VerificarConexion()){
                    datosDescuento = Cupon.AplicarCupon(this.txtCupon.Text);
                    if (datosDescuento.Descuento_Id != null){
                        this.datosDescuentoDelegate.DescuentoAplicado(datosDescuento);
                        this.DismissViewController(true, null);
                    }
                    else 
                    {
                        new MessageDialog().SendToast("Cupón incorrecto");
                    }

                }
                else
                {
                    new MessageDialog().SendToast("No tienes conexión a internet, intenta mas tarde");
                }

            }
            else {
                new MessageDialog().SendToast("Ingresa un código de cupón");
            }


        }

        partial void btnBack_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }


    }
}