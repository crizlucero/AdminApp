using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class CarritoProductos : UITableViewController
    {
        const string IDENTIFIER_HEADER_PRODUCTS = "HeaderProductos";
        const string IDENTIFIER_PRODUCTS = "Productos";
        const string IDENTIFIER_NO_PRODUCTS_CELL = "NoProducts";

        const int TamañoHeader = 73;
        const int TamañoVistaProductos = 447;
        const int TamañoViewControles = 169;

        bool isShowInformation = false;
        bool QuitarViewCompraRecurrente = false;
        bool existeConeccion = true;

        string MensajeTarifa = "";

        List<ProductoModel> allProducts = new List<ProductoModel>();
        List<CarritoCompras> PreordenProductos = new List<CarritoCompras>();

        SimpleStorage Storage;

        public CarritoProductos (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Storage = SimpleStorage.EditGroup("Login");
            if (InternetConectionHelper.VerificarConexion())
            {
                this.allProducts = new PickerItemsController().GetProductos();
            }
            else 
            {
                isShowInformation = false;
                existeConeccion = false;
            }
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var barViewControllers = this.TabBarController.ViewControllers;
            var svc = (TableViewMembresia)barViewControllers[1]; //
            foreach (CarritoCompras preordenMembresia in svc.ObtenerPreordenMembresias())
            {
                if (PreordenProductos.Find(x => x.Id == preordenMembresia.Id) == null)
                {
                    this.PreordenProductos.Add(preordenMembresia);
                }

            }

        }

        public List<CarritoCompras> ObtenerPreordenProductos()
        {
            return this.PreordenProductos;
        }

        private void ObtenerPreordenProductos(object sender, EventArgs e)
        {
            var currentOrderMember = (CarritoCompras)sender;
            if (PreordenProductos.Find(x => x.Id == currentOrderMember.Id) != null)
            {
                if (currentOrderMember.TotalPagar == "$0.00")
                {
                    PreordenProductos.Remove(currentOrderMember);
                }
                else
                {
                    PreordenProductos[currentOrderMember.IndiceProducto] = currentOrderMember;
                }
            }
            else
            {
                PreordenProductos.Add((CarritoCompras)sender);
            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (allProducts.Count > 0)
            {
                isShowInformation = true;
                return allProducts.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                if (allProducts[indexPath.Row].Producto_Disponibilidad.Contains("RECURRENTE"))
                {
                    this.QuitarViewCompraRecurrente = false;
                    this.MensajeTarifa = "Tarifa Mensual";
                    return TamañoVistaProductos;
                }
                else
                {
                    this.QuitarViewCompraRecurrente = true;
                    this.MensajeTarifa = "Tarifa de pago único";
                    return TamañoVistaProductos - TamañoViewControles;
                }

            }
            else
            {
                return 400;
            }
        }


        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentProduct = allProducts[indexPath.Row];
                var currentProductCell = (CeldaCarritoProductos)tableView.DequeueReusableCell(IDENTIFIER_PRODUCTS, indexPath);
                currentProductCell.UpdateCell(currentProduct, this.QuitarViewCompraRecurrente, this.MensajeTarifa, indexPath.Row);
                currentProductCell.ObtenerPreordenProductos += ObtenerPreordenProductos;
                this.WillDisplay(indexPath.Row);
                return currentProductCell;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (CeldaNoProductos)tableView.DequeueReusableCell(IDENTIFIER_NO_PRODUCTS_CELL, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }

        private void WillDisplay(int Row)
        {
            int LastRow = allProducts.Count - 1;
            if (Row == LastRow)
            {
                BTProgressHUD.Dismiss();
            }
        }

    }
}