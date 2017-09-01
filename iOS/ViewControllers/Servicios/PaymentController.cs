using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class PaymentController : UIViewController
    {
        UIView totalesView;
        public decimal Descuento, Subtotal, IVA = 0.16M, Total, IVATotal;
        public PaymentController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                #region Datos de Tarjeta
                scrollView.AddSubview(new STLLabel("Nombre", 30));

                UITextField txtNombre = new STLTextField("Nombre", 60);
                scrollView.AddSubview(txtNombre);

                scrollView.AddSubview(new STLLabel("Número de tarjeta", 90));

                UITextField txtTarjeta = new STLTextField("Número de tarjeta", 120, "", UIKeyboardType.NumberPad)
                {
                    SecureTextEntry = true,
                    ShouldChangeCharacters = (textField, range, replacementString) =>
                    {
                        nint lng = textField.Text.Length + replacementString.Length - range.Length;
                        return lng <= 18;
                    }
                };
                scrollView.AddSubview(txtTarjeta);

                scrollView.AddSubview(new STLLabel("CCV", 150));

                UITextField txtCCV = new STLTextField("CCV", 180, "", UIKeyboardType.NumberPad)
                {
                    SecureTextEntry = true,
                    ShouldChangeCharacters = (textField, range, replacementString) =>
                    {
                        nint lng = textField.Text.Length + replacementString.Length - range.Length;
                        return lng <= 3;
                    }
                };
                scrollView.AddSubview(txtCCV);

                scrollView.AddSubview(new STLLabel("Mes", 210));

                UITextField txtMes = new STLTextField("MM", 240, "", UIKeyboardType.NumberPad)
                {
                    ShouldChangeCharacters = (textField, range, replacementString) =>
                    {
                        nint lng = textField.Text.Length + replacementString.Length - range.Length;
                        return lng <= 2;
                    }
                };
                scrollView.AddSubview(txtMes);

                scrollView.AddSubview(new STLLabel("Año", 270));

                UITextField txtAnio = new STLTextField("YY", 300, "", UIKeyboardType.NumberPad)
                {
                    ShouldChangeCharacters = (textField, range, replacementString) =>
                    {
                        nint lng = textField.Text.Length + replacementString.Length - range.Length;
                        return lng <= 2;
                    }
                };
                scrollView.AddSubview(txtAnio);
                #endregion

                #region Tabla de totales
                ShowTablaTotales();
                scrollView.AddSubview(totalesView);
                #endregion

                View.AddSubview(scrollView);
            }


        }
        public void ShowTablaTotales()
        {

            totalesView = new UIView(new CGRect(0, 330, UIScreen.MainScreen.Bounds.Width, 150));

            totalesView.AddSubview(new STLLabel("Subtotal")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 30, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });

            UILabel txtSubtotal = new STLLabel(Subtotal.ToString("C"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 30, UIScreen.MainScreen.Bounds.Width / 2, 30)
            };
            totalesView.AddSubview(txtSubtotal);

            totalesView.AddSubview(new STLLabel("Descuento")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 60, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });

            UILabel txtDescuento = new STLLabel(Descuento.ToString("C"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 60, UIScreen.MainScreen.Bounds.Width / 2, 30)
            };
            totalesView.AddSubview(txtDescuento);

            totalesView.AddSubview(new STLLabel("IVA 16%")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 90, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });

            UILabel txtIva = new STLLabel((Total * IVA).ToString("C"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 90, UIScreen.MainScreen.Bounds.Width / 2, 30)
            };
            totalesView.AddSubview(txtIva);

            totalesView.AddSubview(new STLLabel("Total")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 120, UIScreen.MainScreen.Bounds.Width / 2, 30)
            });

            UILabel txtTotal = new STLLabel(Total.ToString("C"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width * 3 / 4, 120, UIScreen.MainScreen.Bounds.Width / 2, 30)
            };
            totalesView.AddSubview(txtTotal);


        }

    }
}