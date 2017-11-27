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
    public partial class CuentaMembresiasCell : UITableViewCell
    {
        public CuentaMembresiasCell (IntPtr handle) : base (handle)
        {
        }


        public void UpdateCell(CarritoComprasDetalle CurrentProduct)
        {
            StyleHelper.Style(this.btnRenovar.Layer);
            StyleHelper.Style(this.vwMembresias.Layer);
            this.lblCantidad.Text = CurrentProduct.Carrito_Compras_Detalle_Cantidad;
            this.lblNombreMembresia.Text = CurrentProduct.Carrito_Compras_Detalle_Descripcion;
            this.lblFechaVencimiento.Text = CurrentProduct.Carrito_Compras_Detalle_Vigencia_Fecha_Fin;
        }

        partial void btnRenovar_TouchUPInside(UIButton sender)
        {
            
        }
    }
}