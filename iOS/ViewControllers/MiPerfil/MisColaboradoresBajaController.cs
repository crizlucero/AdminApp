using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;
using PerpetualEngine.Storage;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class MisColaboradoresBajaController : UIViewController
    {
        int totalSize = 45;
        UIScrollView scrollView;
        SimpleStorage storageLocal;
        public MisColaboradoresBajaController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.ClearsContextBeforeDrawing = true;
            storageLocal = SimpleStorage.EditGroup("Login");

            FillColaboradores(storageLocal.Get("Usuario_Id"));
        }

        public void FillColaboradores(string miembro_id)
        {
           
            scrollView = new UIScrollView(new CGRect(0, totalSize, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
            List<ColaboradorModel> colaboradores = new ColaboradoresController().GetColaboradoresMiembro(miembro_id, 0);
            foreach (ColaboradorModel colaborador in colaboradores)
            {
                scrollView.AddSubview(new STLLine(totalSize));
                scrollView.AddSubview(new STLImageView(20 + totalSize, colaborador.Colaborador_Fotografia));

                UIButton btnAlta = new STLButton(UIImage.FromBundle("ic_add"))
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 20 + totalSize, 20, 20)
                };
                btnAlta.TouchUpInside += (sender, e) =>
                {
                    totalSize = 45;
                    new ColaboradoresController().ChangeColaboradorEstatus(colaborador.Colaborador_Id, 1);
                    scrollView.RemoveFromSuperview();
                    FillColaboradores(miembro_id);
                };
                scrollView.AddSubview(btnAlta);

                scrollView.AddSubview(new STLLabel(colaborador.Colaborador_Nombre + " " + colaborador.Colaborador_Apellidos, 70 + totalSize));
                scrollView.AddSubview(new STLImageLabel(scrollView, "Género", 100 + totalSize, "ic_person"));
                scrollView.AddSubview(new STLLabel(colaborador.Genero_Id, 130 + totalSize));
                scrollView.AddSubview(new STLImageLabel(scrollView, "Fecha de Nacimiento", 170 + totalSize, "ic_today"));
                scrollView.AddSubview(new STLLabel(Convert.ToDateTime(colaborador.Colaborador_Fecha_Nacimiento).ToString("MM/dd/yyyy"), 200 + totalSize));
                scrollView.AddSubview(new STLImageLabel(scrollView, "Profesión", 240 + totalSize, "ic_school"));
                scrollView.AddSubview(new STLLabel(colaborador.Colaborador_Profesion, 270 + totalSize));

                totalSize += 360;
            }

            scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 40 + totalSize);
            View.AddSubview(scrollView);
            View.SendSubviewToBack(scrollView);
        }
    }
}