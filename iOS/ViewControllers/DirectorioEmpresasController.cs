using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.ViewElements;
using CoreGraphics;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Styles;
using WorklabsMx.iOS.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WorklabsMx.iOS
{
    public partial class DirectorioEmpresasController : UIViewController
    {
        UIScrollView searchView;
        UITableView selectView;
        UITextField txtPais;
        UITextField txtEstado;
        UITextField txtMunicipio;
        UITextField txtGiro;
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
        void SearchView()
        {
            UITextField txtNombre = new STLTextField("Nombre", 130);
            txtPais = new STLTextField("País", 190);
            txtPais.EditingDidBegin += (sender, e) =>
            {
                DropDownList(220, txtPais);
                txtPais.EndEditing(true);
            };
            txtPais.EditingDidEnd += (sender, e) =>
            {
                selectView.RemoveFromSuperview();
                txtEstado.Enabled = !string.IsNullOrEmpty(txtPais.Text);
            };
            txtEstado = new STLTextField("Estado", 250) { Enabled = false };
            txtEstado.EditingDidBegin += (sender, e) =>
            {
                DropDownList(280, txtEstado);
            };
            txtEstado.EditingDidEnd += (sender, e) =>
            {
                selectView.RemoveFromSuperview();
                txtMunicipio.Enabled = !string.IsNullOrEmpty(txtEstado.Text);
            };
            txtMunicipio = new STLTextField("Municipio", 310) { Enabled = false };
            txtMunicipio.EditingDidBegin += (sender, e) =>
            {
                DropDownList(340, txtMunicipio);
            };
            txtMunicipio.EditingDidEnd += (sender, e) =>
            {
                selectView.RemoveFromSuperview();
            };
            txtGiro = new STLTextField("Giro", 370);
            txtGiro.EditingDidBegin += (sender, e) =>
            {
                DropDownList(400, txtGiro);
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
        void DropDownList(int selectPosition, UITextField field)
        {
            List<string> data = new List<string>();
            field.Text = "";
            switch (field.Placeholder)
            {
                case "País": data = items.GetPaises(); break;
                case "Estado": data = items.GetEstados(txtPais.Text); break;
                case "Municipio": data = items.GetMunicipios(txtEstado.Text); break;
                case "Giro": data = items.GetGiros(); break;
            }
            selectView = new STLDropDownList(selectPosition, data, field);
            View.AddSubview(selectView);
        }
    }
}