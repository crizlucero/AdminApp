using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using CoreGraphics;
using WorklabsMx.iOS.Models;

namespace WorklabsMx.iOS
{
    public partial class CeldaDetalleVenta_Temp: UITableViewCell
    {

        UILabel lblNombreProducto, lblCantidad, lblTotalPagar;

        public CeldaDetalleVenta_Temp (IntPtr handle) : base (handle)
        {
            
        }

        internal void UpdateCell(CarritoCompras carrito)
        {
            this.lblCantidad.Text = carrito.Cantidad.ToString();
            this.lblTotalPagar.Text = carrito.TotalPagar;
            this.lblNombreProducto.Text = carrito.Nombre;
        }
            
    }
}
