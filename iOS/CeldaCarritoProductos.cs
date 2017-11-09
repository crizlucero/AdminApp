using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using CoreGraphics;
using WorklabsMx.Helpers;
using WorklabsMx.iOS.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using WorklabsMx.Enum;

namespace WorklabsMx.iOS
{
    public partial class CeldaCarritoProductos : UITableViewCell
    {

        double subTotalGlobal = 0.0;
        ProductoModel ProductoGlobal;
        public event EventHandler ObtenerTotalPagar;
        public event EventHandler ObtenerTotalProductos;

        public CeldaCarritoProductos (IntPtr handle) : base (handle)
        {
            
        }

        public override void LayoutIfNeeded()
        {
            base.LayoutIfNeeded(); 

        }

        internal void UpdateCell(ProductoModel Producto, bool QuitarViewCompraRecurrente, string MensajeTarifa)
        {
            var pickerModelSucursales = new SucursalesModel();
            pkvSucursal.Model = pickerModelSucursales;
            StyleHelper.Style(this.vwProductos.Layer);
            ProductoGlobal = Producto;
            double subtotal = Producto.Producto_Precio_Base;
            subTotalGlobal = subtotal;
            if (QuitarViewCompraRecurrente)
            {
                this.vwControlesTarifaMensual.Frame = new CGRect(vwControlesTarifaMensual.Frame.X, vwControlesTarifaMensual.Frame.Y, vwControlesTarifaMensual.Frame.Width, 0);
                this.lblMensajeMeses.Hidden = true;
                this.lblCantidadMeses.Hidden = true;
                this.stpCantidadMeses.Hidden = true;
                this.lblMensajeProporcionalMes.Hidden = true;
                this.lblProporcionalMes.Hidden = true;
                this.lblFechaInicio.Hidden = true;
                dpkFechaInicio.Hidden = true;
            }
            else 
            {
                this.lblMensajeMeses.Hidden = false;
                this.lblCantidadMeses.Hidden = false;
                this.stpCantidadMeses.Hidden = false;
                this.lblMensajeProporcionalMes.Hidden = false;
                this.lblProporcionalMes.Hidden = false;
                this.lblFechaInicio.Hidden = false;
                dpkFechaInicio.Hidden = false;
                dpkFechaInicio.MinimumDate = (NSDate)DateTime.Now;
            }
            this.lblCantidadMeses.Text = "1";
            this.lblMensajeTarifa.Text = MensajeTarifa;
            this.lblNombreProducto.Text = Producto.Producto_Descripcion;
            this.lblTarifa.Text = Producto.Producto_Precio_Base.ToString("C");
            this.lblTotal.Text = "$0.00";
            this.lblCantidadProductos.Text = "0";
            this.ProporcionalMes();
        }

        partial void stpCantidadProductos_Changed(UIStepper sender)
        {
            this.lblCantidadProductos.Text = sender.Value.ToString();
            if (ObtenerTotalProductos != null)
            {
                ObtenerTotalProductos(int.Parse(sender.Value.ToString()), EventArgs.Empty);
            }
            this.ProporcionalMes();
            this.ObtenerTotal();
        }

        partial void stpMeses_Changed(UIStepper sender)
        {
            this.lblCantidadMeses.Text = sender.Value.ToString();
            this.ObtenerTotal();
        }

        private void ProporcionalMes()
        {
            double EndMonth = DateHelper.GetMonthsDays((DateTime)dpkFechaInicio.Date);
            double currentDay = ((DateTime)dpkFechaInicio.Date).Day;
            if (ProductoGlobal.Producto_Disponibilidad.Contains("RECURRENTE"))
                subTotalGlobal = Convert.ToInt32(lblCantidadProductos.Text) == 0 ? 0 : (ProductoGlobal.Producto_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
            else
                subTotalGlobal = Convert.ToInt32(lblCantidadProductos.Text) == 0 ? 0 : ProductoGlobal.Producto_Precio_Base;
            this.lblProporcionalMes.Text = subTotalGlobal.ToString("C");
        }

        partial void dtpFechaInicio_ValueChanged(UIDatePicker sender)
        {
            double EndMonth = DateHelper.GetMonthsDays((DateTime)dpkFechaInicio.Date);
            double currentDay = ((DateTime)dpkFechaInicio.Date).Day;
            subTotalGlobal = Convert.ToInt32(lblCantidadMeses.Text) == 0 ? 0 : (ProductoGlobal.Producto_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
            lblProporcionalMes.Text = subTotalGlobal.ToString("C");
            this.ObtenerTotal();
        }

        private void ObtenerTotal()
        {
            lblTotal.Text = (((ProductoGlobal.Producto_Precio_Base * (Convert.ToDouble(lblCantidadMeses.Text) - 1)) + subTotalGlobal) * Convert.ToDouble(lblCantidadProductos.Text)).ToString("C");
            var total = double.Parse((((ProductoGlobal.Producto_Precio_Base * (Convert.ToDouble(lblCantidadMeses.Text) - 1)) + subTotalGlobal) * Convert.ToDouble(lblCantidadProductos.Text)).ToString());
            if (ObtenerTotalPagar != null)
            {
                ObtenerTotalPagar(total, EventArgs.Empty);
            }
        }
    }

}