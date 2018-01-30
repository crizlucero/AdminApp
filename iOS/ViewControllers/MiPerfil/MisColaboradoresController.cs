using System;
using UIKit;
using WorklabsMx.Models;
using CoreGraphics;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
//using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class MisColaboradoresController : UIViewController
    {
        UIScrollView scrollView;
        //SimpleStorage storageLocal;
        public MisColaboradoresController(IntPtr handle) : base(handle)
        {
            //storageLocal = SimpleStorage.EditGroup("Login");
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            FillColaboradores(KeyChainHelper.GetKey("Usuario_Id"));
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.ClearsContextBeforeDrawing = true;

            FillColaboradores(KeyChainHelper.GetKey("Usuario_Id"));
        }

        public void FillColaboradores(string miembro_id)
        {
            int totalSize = 20;
            scrollView = new UIScrollView(new CGRect(0, totalSize, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)) { BackgroundColor = UIColor.White };
            foreach (UsuarioModel colaborador in new UsuariosController().GetColaboradoresMiembro(miembro_id, 1))
            {
                scrollView.AddSubview(new STLLine(totalSize));
                scrollView.AddSubview(new STLImageView(20 + totalSize, colaborador.Usuario_Fotografia));

                UIButton btnBaja = new STLButton(UIImage.FromBundle("ic_clear"))
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 20 + totalSize, 20, 20),
                    BackgroundColor = UIColor.White
                };
                btnBaja.TouchUpInside += (sender, e) =>
                {
                    if (new UsuariosController().ChangeColaboradorEstatus(colaborador.Usuario_Id, 0))
                    {
                        scrollView.RemoveFromSuperview();
                        FillColaboradores(miembro_id);
                    }
                    else
                        new MessageDialog().SendToast("Ocurrió un error");
                };
                scrollView.AddSubview(btnBaja);

                scrollView.AddSubview(new STLLabel(colaborador.Usuario_Nombre + " " + colaborador.Usuario_Apellidos, 70 + totalSize));

                scrollView.AddSubview(new STLImageLabel(scrollView, "Género", 100 + totalSize, "ic_person"));

                scrollView.AddSubview(new STLLabel(colaborador.Genero.Genero_Id, 130 + totalSize));

                scrollView.AddSubview(new STLImageLabel(scrollView, "Fecha de Nacimiento", 170 + totalSize, "ic_today"));

                scrollView.AddSubview(new STLLabel(Convert.ToDateTime(colaborador.Usuario_Fecha_Nacimiento).ToString("MM/dd/yyyy"), 200 + totalSize));

                scrollView.AddSubview(new STLImageLabel(scrollView, "Profesión", 240 + totalSize, "ic_school"));

                scrollView.AddSubview(new STLLabel(colaborador.Usuario_Profesion, 270 + totalSize));

                UIButton btnModificar = new STLButton("Modificar")
                {
                    Frame = new CGRect(UIScreen.MainScreen.Bounds.Width / 2, 300 + totalSize, 120, 30)
                };

                btnModificar.TouchUpInside += (sender, e) =>
                {
                    KeyChainHelper.SetKey("Colaborador_Id", colaborador.Usuario_Id);
                    UIViewController controller = this.Storyboard.InstantiateViewController("MisColaboradoresCambiosController");
                    controller.Title = "Modifica Colaborador";
                    this.NavigationController.PushViewController(controller, true);
                };
                scrollView.AddSubview(btnModificar);

                UIButton btnRenovarAcceso = new STLButton("Renovar Acceso")
                {
                    Frame = new CGRect(20, 300 + totalSize, 150, 30),
                    BackgroundColor = UIColor.Red
                };

                btnRenovarAcceso.TouchUpInside += (sender, e) =>
                {
                    new Emails().SendMail(colaborador.Usuario_Correo_Electronico,
                                          colaborador.Usuario_Nombre + " " + colaborador.Usuario_Apellidos,
                                          new PassSecurity().GeneraIdentifier());
                };
                scrollView.AddSubview(btnRenovarAcceso);

                totalSize += 360;
            }

            scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 40 + totalSize);
            View.Add(scrollView);
            //View.SendSubviewToBack(scrollView);
        }
    }
}