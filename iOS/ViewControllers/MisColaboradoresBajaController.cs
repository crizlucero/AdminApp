using Foundation;
using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Controllers;
using System.Collections.Generic;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class MisColaboradoresBajaController : UIViewController
    {
        int totalSize = 20;
        UIScrollView scrollView;
        UIView searchView;
        PerpetualEngine.Storage.SimpleStorage storageLocal;
        public MisColaboradoresBajaController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.ClearsContextBeforeDrawing = true;
            storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");

            searchView = new UIView(new CGRect(0, 60, UIScreen.MainScreen.Bounds.Width, 40))
            {
                BackgroundColor = UIColor.White
            };
            UITextField txtSearch = new STLTextField("Buscar", 10)
            {
                Frame = new CGRect(10, 10, UIScreen.MainScreen.Bounds.Width - 20, 30)
            };
            searchView.Add(txtSearch);

            UIButton btnSearch = new STLButton("")
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 11, 29, 28),
                BackgroundColor = UIColor.White
            };
            btnSearch.SetImage(UIImage.FromBundle("ic_search"), UIControlState.Normal);
            btnSearch.TouchUpInside += (sender, e) =>
            {
                btnSearch.BackgroundColor = UIColor.White;
                scrollView.RemoveFromSuperview();
                totalSize = 52;
                FillColaboradores(storageLocal.Get("Miembro_Id"), txtSearch.Text);

            };

            searchView.Add(btnSearch);
            View.AddSubview(searchView);


            this.FillColaboradores(storageLocal.Get("Miembro_Id"));
        }

        private void FillColaboradores(string miembro_id, string busqueda = "")
        {

            scrollView = new UIScrollView(new CGRect(0, totalSize, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height));
            List<ColaboradorModel> colaboradores = new ColaboradoresController().GetColaboradoresMiembro(miembro_id, busqueda, "0");
            foreach (ColaboradorModel colaborador in colaboradores)
            {
                UIView line = new UIView(new System.Drawing.RectangleF(0, 0, 100, 100))
                {
                    Frame = new CGRect(0, totalSize, UIScreen.MainScreen.Bounds.Width, 2),
                    BackgroundColor = UIColor.LightGray
                };
                scrollView.AddSubview(line);
                scrollView.AddSubview(new STLImageView(20 + totalSize, colaborador.Colaborador_Fotografia));

                UIButton btnAlta = new STLButton(UIImage.FromBundle("ic_add"))
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 20 + totalSize, 20, 20)
                };
                btnAlta.TouchUpInside += (sender, e) =>
                {
					totalSize = 20;
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
            View.BringSubviewToFront(searchView);
            View.SendSubviewToBack(scrollView);
        }
    }
}