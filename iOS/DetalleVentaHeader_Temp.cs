using System;
using UIKit;
using WorklabsMx.Models;
using PerpetualEngine.Storage;
using System.Data;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;

namespace WorklabsMx.iOS
{
    public class DetalleVentaHeader_Temp : UITableViewCell
    {

        UILabel lblSubtotal, lblImpuesto, lblTotal, lblDescuento;

        public DetalleVentaHeader_Temp (IntPtr handle) : base(handle)
        {

        }

        internal void UpdateCell(string Subtotal, string Impuesto, String Total)
        {
            this.lblTotal.Text = Total;
            this.lblImpuesto.Text = Impuesto;
            this.lblSubtotal.Text = Subtotal;
        }


    }
}
