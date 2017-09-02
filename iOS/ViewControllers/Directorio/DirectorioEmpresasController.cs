using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.ViewElements;
using CoreGraphics;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS
{
    public partial class DirectorioEmpresasController : UIViewController
    {
        UIScrollView searchView;
        UITableView selectView;
        UITextField txtPais, txtEstado, txtMunicipio, txtGiro;
        readonly PickerItemsController items;
        int position = 0;
        public DirectorioEmpresasController(IntPtr handle) : base(handle)
        {
            items = new PickerItemsController();
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
        /// <summary>
        /// Llena la información de la vista
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="pais">Pais</param>
        /// <param name="estado">Estado</param>
        /// <param name="municipio">Municipio</param>
        /// <param name="giro">Giro de la empresa</param>
        void FillData(string nombre = "", string pais = "", string estado = "", string municipio = "", string giro = "")
        {
            using (UIScrollView scrollView = new UIScrollView(new CGRect(0, position, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height)))
            {
                foreach (EmpresaModel empresa in new EmpresaController().GetDirectorioEmpresas(nombre, pais, estado, municipio, giro))
                {
                    new InfoEmpresaCard(empresa, scrollView, position);
                    position += 400;

                }
                scrollView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, position);
                View.Add(scrollView);
            }
        }
        /// <summary>
        /// Vista de la busqueda
        /// </summary>
        void SearchView()
        {
            UITextField txtNombre = new STLTextField("Nombre", 130);
            txtPais = new STLTextField("País", 190);
            txtPais.EditingDidBegin += (sender, e) =>
            {
                selectView = new UIDropdownList(txtPais, View);
            };
            txtPais.EditingDidEnd += (sender, e) =>
            {
                selectView.RemoveFromSuperview();
            };
            txtEstado = new STLTextField("Estado", 250);
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
            txtMunicipio = new STLTextField("Municipio", 310);
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
            txtGiro = new STLTextField("Giro", 370);
            txtGiro.EditingDidBegin += (sender, e) =>
            {
                selectView = new UIDropdownList(txtGiro, View);
            };
            txtGiro.EditingDidEnd += (sender, e) =>
            {
                selectView.RemoveFromSuperview();
            };

            UIButton btnBuscar = new STLButton("Buscar") { Frame = new CGRect(20, 400, 100, 30) };
            btnBuscar.TouchUpInside += (sender, e) =>
            {
                position = 32;
                FillData(txtNombre.Text, txtPais.Text, txtEstado.Text, txtMunicipio.Text, txtGiro.Text);
                searchView.RemoveFromSuperview();
                selectView.RemoveFromSuperview();
            };

            UIButton btnClose = new STLButton(UIImage.FromBundle("ic_clear")) { Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 40, 70, 30, 30) };
            btnClose.Layer.CornerRadius = 15;
            btnClose.TouchUpInside += (sender, e) =>
            {
                searchView.RemoveFromSuperview();
            };
            searchView = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, UIScreen.MainScreen.Bounds.Height))
            {
                btnClose,

                new STLLabel("Nombre", 100),
                txtNombre,

                new STLLabel("País", 160),
                txtPais,

                new STLLabel("Estado", 220),
                txtEstado,

                new STLLabel("Municipio", 280),
                txtMunicipio,

                new STLLabel("Giro", 340),
                txtGiro,

                btnBuscar
            };
            searchView.BackgroundColor = UIColor.White;

            searchView.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, 500);

            View.AddSubview(searchView);

        }
    }
}