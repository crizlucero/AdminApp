using Foundation;
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
    public partial class DetalleVenta_Temp: UITableViewController
    {

        List<CarritoCompras> PreordenProductos = new List<CarritoCompras>();

        const string IdentificadorCeldaHeader = "HeaderDetalleVenta";
        const string IdentificadorCeldaBody = "CuerpoDetalleVenta";
        const string IdentificadorCeldaNoInfo = "NoInfoDetalleVenta";

        const int TamañoHeader = 133;
        const int TamañoCeldaProductos = 136;
        const int TamañoMensajeNoInfo = 400;

        bool isShowInformation = false;
        bool existeConeccion = true;

        string Subtotal, Impuesto, Total;

        public DetalleVenta_Temp(IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerCell = (DetalleVentaHeader_Temp)tableView.DequeueReusableCell(IdentificadorCeldaHeader);
            headerCell.UpdateCell(this.Subtotal, this.Impuesto, this.Total);
            return headerCell;
        }


        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return TamañoHeader;
        }


        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (PreordenProductos.Count > 0)
            {
                isShowInformation = true;
                return PreordenProductos.Count;
            }
            isShowInformation = false;
            return 1;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                return TamañoCeldaProductos;
            }
            else
            {
                return TamañoMensajeNoInfo;
            }
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (isShowInformation)
            {
                var currentProduct = PreordenProductos[indexPath.Row];
                var currentProductCell = (CeldaDetalleVenta_Temp)tableView.DequeueReusableCell(IdentificadorCeldaBody, indexPath);
                currentProductCell.UpdateCell(currentProduct);
                this.WillDisplay(indexPath.Row);
                return currentProductCell;
            }
            else
            {
                BTProgressHUD.Dismiss();
                var noPostCell = (CeldaNoDetalleVenta_Temp)tableView.DequeueReusableCell(IdentificadorCeldaNoInfo, indexPath);
                noPostCell.UpdateCell(this.existeConeccion);
                return noPostCell;
            }
        }

        private void WillDisplay(int Row)
        {
            int LastRow = PreordenProductos.Count - 1;
            if ((Row == LastRow))
            {
                BTProgressHUD.Dismiss();
            }
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "canjearcupon")
            {
               
            }
            else if (segue.Identifier == "detallecompra")
            {
               
            }
        }

    }
}
