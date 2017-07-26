using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using CoreGraphics;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class MisColaboradoresController : UIViewController
    {
        public MisColaboradoresController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            int totalSize = 0;
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            var scrollView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));

            List<ColaboradorModel> colaboradores = new ColaboradoresController().GetColaboradoresMiembro(storageLocal.Get("Miembro_Id"));
            foreach (ColaboradorModel colaborador in colaboradores)
            {
                UIView line = new UIView(new System.Drawing.RectangleF(0, 0, 100, 100));
                line.Frame = new CGRect(0, 20 + totalSize, UIScreen.MainScreen.Bounds.Width, 2);

                scrollView.Add(line);
                scrollView.Add(new STLImageView(20 + totalSize, colaborador.Colaborador_Fotografia));

                scrollView.Add(new STLLabel(colaborador.Colaborador_Nombre + " " + colaborador.Colaborador_Apellidos, 70 + totalSize));

                scrollView.Add(new STLImageLabel(scrollView, "Género", 100 + totalSize, "ic_person"));

                scrollView.Add(new STLLabel(colaborador.Genero_Id, 130 + totalSize));

                scrollView.Add(new STLImageLabel(scrollView, "Fecha de Nacimiento", 170 + totalSize, "ic_today"));

                scrollView.Add(new STLLabel(colaborador.Colaborador_Fecha_Nacimiento, 200 + totalSize));

                scrollView.Add(new STLImageLabel(scrollView, "Profesión", 240 + totalSize, "ic_school"));

                scrollView.Add(new STLLabel(colaborador.Colaborador_Profesion, 270 + totalSize));

                UIButton btnModificar = new STLButton("Modificar")
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 2, 300 + totalSize, 120, 30)
                };

                btnModificar.TouchUpInside += (sender, e) =>
                {
                    storageLocal.Put("Colaborador_Id", colaborador.Colaborador_Id);
                    UIViewController controller = this.Storyboard.InstantiateViewController("MisColaboradoresCambiosController");
                    controller.Title = "Modifica Colaborador";
                    this.NavigationController.PushViewController(controller, true);
                };
                scrollView.Add(btnModificar);

                totalSize += 350;
            }

            scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, totalSize);
            Add(scrollView);
        }
    }
}