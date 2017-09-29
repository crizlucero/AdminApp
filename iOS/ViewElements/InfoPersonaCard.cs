using System;
using System.Collections.Generic;
using CoreGraphics;
using PerpetualEngine.Storage;
using UIKit;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;

namespace WorklabsMx.iOS.ViewElements
{
    public class InfoPersonaCard
    {
        public UIButton lblNombre, lblMail;
        MiembrosController Favorites;
        MessageDialog message;
        public InfoPersonaCard(MiembroModel miembro, UIView View, int initialPosition = 0)
        {
            Favorites = new MiembrosController();
            message = new MessageDialog();
            using (UIView headerView = new UIView(new CGRect(0, initialPosition, UIScreen.MainScreen.Bounds.Width, 100)) { BackgroundColor = UIColor.White })
            {
                SimpleStorage storage = SimpleStorage.EditGroup("Login");
                headerView.AddSubview(new STLLine());
                lblNombre = new STLButton(miembro.Miembro_Nombre + " " + miembro.Miembro_Apellidos)
                {
                    Frame = new CGRect(20, 10, UIScreen.MainScreen.Bounds.Width - 20, 30),
                    Font = UIFont.BoldSystemFontOfSize(22),
                    HorizontalAlignment = UIControlContentHorizontalAlignment.Left
                };
                headerView.AddSubview(lblNombre);

                lblMail = new STLButton(miembro.Miembro_Correo_Electronico)
                {
                    BackgroundColor = UIColor.Clear,
                    UserInteractionEnabled = true,
                    Font = UIFont.BoldSystemFontOfSize(14),
                    Frame = new CGRect(20, 35, UIScreen.MainScreen.Bounds.Width, 30),
                    HorizontalAlignment = UIControlContentHorizontalAlignment.Left
                };

                lblMail.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
                headerView.AddSubview(lblMail);
                if (storage.Get("Usuario_Id") != miembro.Miembro_Id || storage.Get("Usuario_Tipo") != miembro.Miembro_Tipo)
                {
                    KeyValuePair<int, bool> isFavorite = Favorites.IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Miembro_Id, miembro.Miembro_Tipo);
                    UIImage star = UIImage.FromBundle("ic_star_border");
                    if (isFavorite.Value)
                        star = UIImage.FromBundle("ic_star");
                    UIButton btnStar = new STLButton(star)
                    {
                        BackgroundColor = UIColor.Clear,
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 20, 30, 30)
                    };
                    btnStar.TouchUpInside += (sender, e) =>
                    {
                        if (isFavorite.Key == 0)
                        {
                            if (Favorites.AddMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Miembro_Id, miembro.Miembro_Tipo))
                                btnStar.SetImage(UIImage.FromBundle("ic_star"), UIControlState.Normal);
                            else
                                message.SendToast("Existió algún error\nIntente nuevamente");
                        }
                        else
                        {
                            if (Favorites.RemoveMiembroFavorito(isFavorite))
                            {
                                if (isFavorite.Value)
                                    btnStar.SetImage(UIImage.FromBundle("ic_star_border"), UIControlState.Normal);
                                else
                                    btnStar.SetImage(UIImage.FromBundle("ic_star"), UIControlState.Normal);
                            }
                        }
                        isFavorite = Favorites.IsMiembroFavorito(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"), miembro.Miembro_Id, miembro.Miembro_Tipo);
                    };
                    headerView.AddSubview(btnStar);
                }
                View.AddSubview(headerView);
            }
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, 70 + initialPosition, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)) { BackgroundColor = UIColor.White })
            {
                int empresaSize = 0;
                scrollView.AddSubview(new STLImageView(50, miembro.Miembro_Fotografia)
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 4, 50, 200, 200)
                });
                scrollView.AddSubview(new STLImageLabel(scrollView, "Género", 250, "ic_person"));
                scrollView.AddSubview(new STLLabel(miembro.Genero_Descripcion, 280) { Frame = new CGRect(30, 280, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Fecha de Nacimiento", 310, "ic_today"));
                scrollView.AddSubview(new STLLabel(DateTime.Parse(miembro.Miembro_Fecha_Nacimiento).ToString("dd/MM/yyyy"), 340) { Frame = new CGRect(30, 340, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Profesión", 370, "ic_school"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Profesion, 400) { Frame = new CGRect(30, 400, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Puesto", 430, "ic_work"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Puesto, 460) { Frame = new CGRect(30, 460, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Habilidades", 490, "ic_create"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Habilidades, 520) { Frame = new CGRect(30, 520, UIScreen.MainScreen.Bounds.Width, 30) });

                if (!string.IsNullOrEmpty(miembro.Miembro_Empresa))
                {
                    scrollView.AddSubview(new STLImageLabel(scrollView, "Empresa", 550, "ic_domain"));
                    scrollView.AddSubview(new STLLabel(miembro.Miembro_Empresa, 580) { Frame = new CGRect(30, 580, UIScreen.MainScreen.Bounds.Width, 30) });
                    empresaSize = 90;
                }
                scrollView.AddSubview(new STLImageLabel(scrollView, "Teléfono", 550 + empresaSize, "ic_call"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Telefono, 580) { Frame = new CGRect(30, 580 + empresaSize, UIScreen.MainScreen.Bounds.Width, 30) });

                scrollView.AddSubview(new STLImageLabel(scrollView, "Celular", 610 + empresaSize, "ic_stay_current_portrait"));
                scrollView.AddSubview(new STLLabel(miembro.Miembro_Celular, 640) { Frame = new CGRect(30, 640 + empresaSize, UIScreen.MainScreen.Bounds.Width, 30) });


                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 750 + empresaSize);

                View.AddSubview(scrollView);
            }
        }
    }
}
