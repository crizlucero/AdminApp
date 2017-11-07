using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using WorklabsMx.Helpers;

namespace WorklabsMx.iOS
{
    public partial class CeldaCarritoProductos : UITableViewCell
    {

        double subTotalGlobal = 0.0;
        ProductoModel ProductoGlobal;
        DateTime dpFechaInicio;

        public CeldaCarritoProductos (IntPtr handle) : base (handle)
        {
            
        }

        public override void LayoutIfNeeded()
        {
            base.LayoutIfNeeded();

        }

        internal void UpdateCell(ProductoModel Producto, bool QuitarViewCompraRecurrente, string MensajeTarifa)
        {
            StyleHelper.Style(this.vwProductos.Layer);
            ProductoGlobal = Producto;
            double subtotal = Producto.Producto_Precio_Base;
            subTotalGlobal = subtotal;
            if (QuitarViewCompraRecurrente)
            {
                //this.vwControlesTarifaMensual.Frame = new CGRect(vwControlesTarifaMensual.Frame.X, vwControlesTarifaMensual.Frame.Y, vwControlesTarifaMensual.Frame.Width, 0);
                this.btnFechaInicio.Hidden = true;
                this.btnFechaInicio.Enabled = false;
                this.lblMensajeMeses.Hidden = true;
                this.lblCantidadMeses.Hidden = true;
                this.stpCantidadMeses.Hidden = true;
                this.lblMensajeProporcionalMes.Hidden = true;
                this.lblProporcionalMes.Hidden = true;
            }
            else 
            {
                this.ProporcionalMes();
            }
            this.lblCantidadMeses.Text = "1";
            this.lblMensajeTarifa.Text = MensajeTarifa;
            this.lblNombreProducto.Text = Producto.Producto_Descripcion;
            this.lblTarifa.Text = Producto.Producto_Precio_Base.ToString("C");
            this.lblTotal.Text = (Producto.Producto_Precio_Base * stpCantidadMeses.Value).ToString("C");
            this.lblCantidadProductos.Text = "0";
            dpFechaInicio = DateTime.Now;
        }

        partial void stpCantidadProductos_Changed(UIStepper sender)
        {
            this.lblCantidadProductos.Text = sender.Value.ToString();
            /*Productos[producto.Producto_Id].Producto_Cantidad = (int)stpProducto.Value;
            CanPay = (stpProducto.Value > 0);
            Changed = CanPay;*/
            this.ProporcionalMes();
            lblTotal.Text = (((ProductoGlobal.Producto_Precio_Base * (Convert.ToDouble(this.lblCantidadMeses.Text) - 1)) + subTotalGlobal) * Convert.ToDouble(lblCantidadProductos.Text)).ToString("C");
        }

        partial void stpMeses_Changed(UIStepper sender)
        {
            this.lblCantidadMeses.Text = sender.Value.ToString();
            this.lblTotal.Text = (((ProductoGlobal.Producto_Precio_Base * (Convert.ToDouble(lblCantidadMeses.Text) - 1)) + subTotalGlobal) * Convert.ToDouble(lblCantidadProductos.Text)).ToString("C");
        }

        private void ProporcionalMes()
        {
            double EndMonth = DateHelper.GetMonthsDays((DateTime)dpFechaInicio.Date);
            double currentDay = ((DateTime)dpFechaInicio.Date).Day;
            if (ProductoGlobal.Producto_Disponibilidad.Contains("RECURRENTE"))
                subTotalGlobal = Convert.ToInt32(lblCantidadProductos.Text) == 0 ? 0 : (ProductoGlobal.Producto_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
            else
                subTotalGlobal = Convert.ToInt32(lblCantidadProductos.Text) == 0 ? 0 : ProductoGlobal.Producto_Precio_Base;
            this.lblProporcionalMes.Text = subTotalGlobal.ToString("C");
        }
    }
}