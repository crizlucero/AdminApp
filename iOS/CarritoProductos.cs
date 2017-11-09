using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;
using WorklabsMx.Enum;

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
        Dictionary<string, CarritoModel> Carrito = new Dictionary<string, CarritoModel>();

        SimpleStorage Storage;

        double TotalPagar = 0.0;
        int TotalProductos = 0;

        public CarritoProductos (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Storage = SimpleStorage.EditGroup("Login");
            Carrito = new CarritoController().GetCarrito(Storage.Get("Usuario_Id"), TiposServicios.Producto);
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

        public double getTotalPagar()
        {
            return this.TotalPagar;
        }

        public void ObtenerTotalPagar(object sender, EventArgs e)
        {
            this.TotalPagar = TotalPagar + (double)sender;
        }

        void ObtenerTotalProductos(object sender, EventArgs e)
        {
            this.TotalProductos = TotalProductos + (int)sender;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
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
                return TamañoVistaProductos;
            }
        }


        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentProduct = allProducts[indexPath.Row];
                var currentProductCell = (CeldaCarritoProductos)tableView.DequeueReusableCell(IDENTIFIER_PRODUCTS, indexPath);
                currentProductCell.ObtenerTotalPagar += ObtenerTotalPagar;
                currentProductCell.ObtenerTotalProductos += ObtenerTotalProductos;
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