using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class CarritoProductos : UITableViewController
    {
        const string IDENTIFIER_HEADER_PRODUCTS = "HeaderProductos";
        const string IDENTIFIER_PRODUCTS = "Productos";
        const string IDENTIFIER_NO_PRODUCTS_CELL = "NoProducts";

        const int TamañoHeader = 73;
        const int TamañoVistaProductos = 337;

        bool isShowInformation = false;
        bool QuitarViewCompraRecurrente = false;
        bool existeConeccion = true;

        string MensajeTarifa = "";

        List<ProductoModel> allProducts = new List<ProductoModel>();

        public CarritoProductos (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
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

        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (HeaderCarritoProductos)tableView.DequeueReusableCell(IDENTIFIER_HEADER_PRODUCTS);
            return headerCell;
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
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
                    return TamañoVistaProductos - 113;
                }

            }
            else
            {
                return TamañoVistaProductos;
            }
        }


        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentProduct = allProducts[indexPath.Row];
                var currentProductCell = (CeldaCarritoProductos)tableView.DequeueReusableCell(IDENTIFIER_PRODUCTS, indexPath);
                currentProductCell.UpdateCell(currentProduct, this.QuitarViewCompraRecurrente, this.MensajeTarifa);
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