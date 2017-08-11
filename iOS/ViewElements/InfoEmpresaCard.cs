using CoreGraphics;
using Foundation;
using UIKit;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;

namespace WorklabsMx.iOS.ViewElements
{
    public class InfoEmpresaCard
    {
        public InfoEmpresaCard(EmpresaModel empresa, UIView View, int initialPosition = 0)
        {
            using (UIView headerView = new UIView(new CGRect(0, initialPosition, UIScreen.MainScreen.Bounds.Width, 100)) { BackgroundColor = UIColor.White })
            {
                headerView.AddSubview(new STLLabel(empresa.Empresa_Miembro_Nombre, 10, 22));
                using (UIButton lblMail = new STLButton(empresa.Empresa_Miembro_Correo_Electronico)
                {
                    BackgroundColor = UIColor.Clear,
                    UserInteractionEnabled = true,
                    Frame = new CGRect(20, 35, UIScreen.MainScreen.Bounds.Width, 30),
                    Font = UIFont.BoldSystemFontOfSize(14)
                })
                {
                    lblMail.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
                    lblMail.TouchUpInside += (sender, e) =>
                    {
                        UIApplication.SharedApplication.OpenUrl(new NSUrl("mailto:" + empresa.Empresa_Miembro_Correo_Electronico));
                    };

                    headerView.AddSubview(lblMail);
                }

                View.AddSubview(headerView);
            }
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 60 + initialPosition, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)) { BackgroundColor = UIColor.White })
            {
                scrollView.AddSubview(new STLImageView(50, empresa.Empresa_Miembro_Logotipo)
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 50, 200, 200)
                });
                scrollView.AddSubview(new STLImageLabel(scrollView, "Giro Comercial", 250, "ic_business_center"));
                scrollView.AddSubview(new STLLabel(empresa.Giro_Descripcion, 280) { Frame = new CGRect(30, 280, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Dirección", 310, "ic_place"));
                scrollView.AddSubview(new STLLabel(empresa.Territorio_Municipio_Descripcion + ", " + empresa.Territorio_Estado_Descripcion + ", "
                                                   + empresa.Empresa_Miembro_Calle + " #" + empresa.Empresa_Miembro_Numero_Exterior +
                                                    (!string.IsNullOrEmpty(empresa.Empresa_Miembro_Numero_Interior) ? " int. " + empresa.Empresa_Miembro_Numero_Interior : "") +
                                                   " Col. " + empresa.Territorio_Colonia_Descripcion
                                                    + " CP. " + empresa.Territorio_Cp, 340)
                { Frame = new CGRect(30, 340, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Teléfono", 370, "ic_call"));
                scrollView.AddSubview(new STLLabel(empresa.Empresa_Miembro_Telefono, 400) { Frame = new CGRect(30, 400, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "RFC", 430, "ic_label"));
                scrollView.AddSubview(new STLLabel(empresa.Empresa_Miembro_Rfc, 460) { Frame = new CGRect(30, 460, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Razón Social", 490, "ic_label"));
                scrollView.AddSubview(new STLLabel(empresa.Empresa_Miembro_Razon_Social, 520) { Frame = new CGRect(30, 520, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Página Web", 550, "ic_public"));
                scrollView.AddSubview(new STLLabel(empresa.Empresa_Miembro_Pagina_Web, 580) { Frame = new CGRect(30, 580, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Redes Sociales", 610, "ic_share"));
                scrollView.AddSubview(new STLImageLabel(scrollView, empresa.Empresa_Miembro_Red_Social_1, 640, "ic_facebook"));
                scrollView.AddSubview(new STLImageLabel(scrollView, empresa.Empresa_Miembro_Red_Social_2, 670, "ic_twitter"));
                scrollView.AddSubview(new STLImageLabel(scrollView, empresa.Empresa_Miembro_Red_Social_3, 700, "ic_instagram"));

                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 1090);

                View.AddSubview(scrollView);
            }
        }
    }
}
