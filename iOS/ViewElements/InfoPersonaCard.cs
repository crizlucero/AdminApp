using System;
using CoreGraphics;
using Foundation;
using UIKit;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;

namespace WorklabsMx.iOS.ViewElements
{
    public class InfoPersonaCard
    {
        public InfoPersonaCard(MiembroModel miembro, UIView View, int initialPosition = 0)
        {
            
            using (UIView headerView = new UIView(new CGRect(0, initialPosition, UIScreen.MainScreen.Bounds.Width, 100)) { BackgroundColor = UIColor.White })
            {
                UIView line = new UIView(new System.Drawing.RectangleF(0,0,100,100))
				{
                    Frame = new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 5),
                    BackgroundColor = UIColor.FromRGB(101, 216, 250)
				};
                headerView.AddSubview(line);
                headerView.AddSubview(new STLLabel(miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos, 10, 22));
                UILabel lblMail = new STLLabel(miembro.Miembro_Correo_Electronico, 14)
                {
                    TextColor = UIColor.Cyan,
                    BackgroundColor = UIColor.Clear,
                    UserInteractionEnabled = true,
                    Frame = new CGRect(20, 35, UIScreen.MainScreen.Bounds.Width, 30)
                };
                UITapGestureRecognizer tapMail = new UITapGestureRecognizer
                {
                    NumberOfTapsRequired = 1,
                    DelaysTouchesBegan = true,
                };
                tapMail.AddTarget(() => UIApplication.SharedApplication.OpenUrl(new NSUrl("mailto:" + miembro.Miembro_Correo_Electronico)));
                lblMail.AddGestureRecognizer(tapMail);
                headerView.AddSubview(lblMail);

                View.AddSubview(headerView);
            }
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 70 + initialPosition, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)) { BackgroundColor = UIColor.White })
            {
                scrollView.AddSubview(new STLImageView(50, miembro.Miembro_Fotografia)
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 50, 200, 200)
                });
                scrollView.AddSubview(new STLImageLabel(scrollView, "Género", 250, "ic_person"));
                scrollView.AddSubview(new STLLabel(miembro.Genero_Descripcion, 280) { Frame = new CGRect(30, 280, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Fecha de Nacimiento", 310, "ic_today"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Fecha_Nacimiento, 340) { Frame = new CGRect(30, 340, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Profesión", 370, "ic_scholl"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Profesion, 400) { Frame = new CGRect(30, 400, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Puesto", 430, "ic_work"));
                scrollView.AddSubview(new STLLabel(miembro.Genero_Descripcion, 460) { Frame = new CGRect(30, 460, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Habilidades", 490, "ic_create"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Habilidades, 520) { Frame = new CGRect(30, 520, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Teléfono", 550, "ic_call"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Telefono, 580) { Frame = new CGRect(30, 580, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Celular", 610, "ic_stay_current_portrait"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Celular, 640) { Frame = new CGRect(30, 640, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 1010);

                View.AddSubview(scrollView);
            }
        }
    }
}
