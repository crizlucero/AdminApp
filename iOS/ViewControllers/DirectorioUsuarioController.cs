using System;
using UIKit;
using CoreGraphics;
using WorklabsMx.iOS.ViewElements;
using WorklabsMx.Models;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class DirectorioUsuarioController : UIViewController
    {
        UIScrollView searchView;
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
                    new InfoPersonaCard(usuario, scrollView, position);
                    position += 400;

                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, position);
                View.AddSubview(scrollView);
                scrollView.SendSubviewToBack(View);
            }
        }

        void SearchView()
        {
            UITextField txtNombre = new STLTextField("Nombre", 130);
            UITextField txtApellidos = new STLTextField("Apellidos", 190);
            UITextField txtPuesto = new STLTextField("Puesto", 250);
            UITextField txtProfesion = new STLTextField("Profesión", 310);
            UITextField txtHabilidades = new STLTextField("Habilidades", 370);
            UITextField txtPais = new STLTextField("País", 430);
            UITextField txtEstado = new STLTextField("Estado", 490);
            UITextField txtMunicipio = new STLTextField("Municipio", 550);
            UICheckBox cbDisponibilidad = new UICheckBox("Disponibilidad", 20, 600);


            UIButton btnBuscar = new STLButton("Buscar") { Frame = new CGRect(20, 630, 100, 30) };
            btnBuscar.TouchUpInside += (sender, e) =>
            {
                position = 32;
                FillData(txtNombre.Text, txtApellidos.Text, txtPuesto.Text, txtProfesion.Text, txtHabilidades.Text, cbDisponibilidad.IsChecked, txtPais.Text, txtEstado.Text, txtMunicipio.Text);
                searchView.RemoveFromSuperview();
            };

            UIButton btnClose = new STLButton(UIImage.FromBundle("ic_clear")) { Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 70, 30, 30) };
            btnClose.TouchUpInside += (sender, e) =>
            {
                searchView.RemoveFromSuperview();
            };
            searchView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height))
            {
                btnClose,

                new STLLabel("Nombre", 100),
                txtNombre,

                new STLLabel("Apellidos", 160),
                txtApellidos,

                new STLLabel("Puesto", 220),
                txtPuesto,

                new STLLabel("Profesión", 280),
                txtProfesion,

                new STLLabel("Habilidades", 340),
                txtHabilidades,

                new STLLabel("País", 400),
                txtPais,

                new STLLabel("Estado", 460),
                txtEstado,

                new STLLabel("Municipio", 520),
                txtMunicipio,

                new STLLabel("Disponibiliudad", 400){ Frame = new CGRect(50, 595, UIScreen.MainScreen.Bounds.Width,30)},
                cbDisponibilidad,

                btnBuscar
            };
            searchView.BackgroundColor = UIColor.White;

            searchView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 630);

            View.AddSubview(searchView);

        }
    }
}