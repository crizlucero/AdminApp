using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.ViewElements;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using MessageUI;

namespace WorklabsMx.iOS
{
    public partial class DirectorioUsuarioController : UIViewController
    {
        UIScrollView searchView;
        UITableView selectView;
        int position = 0;
        public DirectorioUsuarioController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            FillData();

            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIImage.FromBundle("ic_search"), UIBarButtonItemStyle.Done, (sender, e) =>
            {
                SearchView();
            }), true);
        }

        void FillData(string nombre = "", string apellido = "", string puesto = "", string profesion = "",
                      string habilidades = "", bool disponibilidad = true, string pais = "", string estado = "",
                      string municipio = "")
        {
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, position, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                foreach (MiembroModel usuario in new MiembrosController().GetDirectorioUsuarios(nombre, apellido, puesto, profesion, habilidades, disponibilidad, pais, estado, municipio))
                {
                    InfoPersonaCard personaCard = new InfoPersonaCard(usuario, scrollView, position);
					personaCard.lblMail.TouchUpInside += (sender, e) =>
					{
						MFMailComposeViewController mailController;
						if (MFMailComposeViewController.CanSendMail)
						{
							mailController = new MFMailComposeViewController();

							mailController.SetToRecipients(new string[] { usuario.Miembro_Correo_Electronico });
							mailController.SetSubject("Contacto - Worklabs");
							mailController.SetMessageBody("", false);

							mailController.Finished += (object s, MFComposeResultEventArgs args) =>
							{
								Console.WriteLine(args.Result.ToString());
								args.Controller.DismissViewController(true, null);
							};

							this.PresentViewController(mailController, true, null);
						}
					};
					personaCard.lblNombre.TouchUpInside += (sender, e) =>
					{
						PerfilController perfilController = (PerfilController)Storyboard.InstantiateViewController("PerfilIndividualController");
						perfilController.Tipo = usuario.Miembro_Tipo;
                        perfilController.Usuario = usuario.Miembro_Id;
                        perfilController.Title = "Perfil";
						NavigationController.PushViewController(perfilController, true);
						((UIButton)sender).BackgroundColor = UIColor.Clear;
					};
                    position += 400;
                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, position);
                View.AddSubview(scrollView);
                scrollView.SendSubviewToBack(View);
            }
        }

        void SearchView()
        {
            UITextField txtNombre = new STLTextField("Nombre", 30);
            UITextField txtApellidos = new STLTextField("Apellidos", 90);
            UITextField txtPuesto = new STLTextField("Puesto", 150);
            UITextField txtProfesion = new STLTextField("Profesión", 210);
            UITextField txtHabilidades = new STLTextField("Habilidades", 270);
            UITextField txtPais = new STLTextField("País", 330);
            txtPais.EditingDidBegin += (sender, e) =>
            {
                selectView = new UIDropdownList(txtPais, View);
            };
            txtPais.EditingDidEnd += (sender, e) =>
            {
                selectView.RemoveFromSuperview();
            };
            UITextField txtEstado = new STLTextField("Estado", 390);
            txtEstado.EditingDidBegin += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(txtPais.Text))
                    selectView = new UIDropdownList(txtEstado, View, txtPais.Text);
            };
            txtEstado.EditingDidEnd += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(txtPais.Text))
                    selectView.RemoveFromSuperview();
            };
            UITextField txtMunicipio = new STLTextField("Municipio", 450);
            txtMunicipio.EditingDidBegin += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(txtEstado.Text))
                    selectView = new UIDropdownList(txtMunicipio, View, txtEstado.Text);
            };
            txtMunicipio.EditingDidEnd += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(txtEstado.Text))
                    selectView.RemoveFromSuperview();
            };
            UITextField txtEmpresa = new STLTextField("Empresa", 510);
            UICheckBox cbDisponibilidad = new UICheckBox(20, 550);


            UIButton btnBuscar = new STLButton("Buscar") { Frame = new CGRect(20, 580, 100, 30) };
            btnBuscar.TouchUpInside += (sender, e) =>
            {
                position = 32;
                FillData(txtNombre.Text, txtApellidos.Text, txtPuesto.Text, txtProfesion.Text, txtHabilidades.Text, cbDisponibilidad.IsChecked, txtPais.Text, txtEstado.Text, txtMunicipio.Text);
                searchView.RemoveFromSuperview();
            };

            UIButton btnClose = new STLButton(UIImage.FromBundle("ic_clear")) { Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 0, 30, 30) };
            btnClose.TouchUpInside += (sender, e) =>
            {
                searchView.RemoveFromSuperview();
            };
            searchView = new UIScrollView(new CGRect(0, 70, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height))
            {
                btnClose,

                new STLLabel("Nombre", 0),
                txtNombre,

                new STLLabel("Apellidos", 60),
                txtApellidos,

                new STLLabel("Puesto", 120),
                txtPuesto,

                new STLLabel("Profesión", 180),
                txtProfesion,

                new STLLabel("Habilidades", 240),
                txtHabilidades,

                new STLLabel("País", 300),
                txtPais,

                new STLLabel("Estado", 360),
                txtEstado,

                new STLLabel("Municipio", 420),
                txtMunicipio,

                new STLLabel("Empresa", 480),
                txtEmpresa,

                new STLLabel("Disponibilidad", 545){ Frame = new CGRect(50, 545, UIScreen.MainScreen.Bounds.Width,30)},
                cbDisponibilidad,

                btnBuscar
            };
            searchView.BackgroundColor = UIColor.White;

            searchView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 730);

            View.AddSubview(searchView);

        }
    }
}