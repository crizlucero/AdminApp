using System;
using UIKit;
using System.Collections.Generic;
using WorklabsMx.Models;
using BigTed;
using WorklabsMx.Controllers;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;

namespace WorklabsMx.iOS
{
    public partial class CuentaProductosCell : UITableViewCell
    {
        public CuentaProductosCell (IntPtr handle) : base (handle)
        {
        }

        partial void btnAgregar_TouchUpInside(UIButton sender)
        {
            
        }

        public void UpdateCell(CarritoComprasDetalle CurrentProduct)
        {
            StyleHelper.Style(this.btnAgregar.Layer);
            StyleHelper.Style(this.vwProductos.Layer);
            this.lblCantidad.Text = CurrentProduct.Carrito_Compras_Detalle_Cantidad;
            this.lblNombreProducto.Text = CurrentProduct.Carrito_Compras_Detalle_Descripcion;
            this.lblFechaVencimiento.Text = CurrentProduct.Carrito_Compras_Detalle_Vigencia_Fecha_Fin;
        }
    }
}