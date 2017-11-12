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

        public event EventHandler ObtenerPreordenProductos;

        CarritoCompras Preorden = new CarritoCompras();
        string FechaInicio;
        NSDateFormatter dateFormat = new NSDateFormatter();

        int indiceGlobal;

        public CeldaCarritoProductos (IntPtr handle) : base (handle)
        {
            
        }

        public override void LayoutIfNeeded()
        {
            base.LayoutIfNeeded(); 

        }

        internal void UpdateCell(ProductoModel Producto, bool QuitarViewCompraRecurrente, string MensajeTarifa, int indice)
        {
            this.indiceGlobal = indice;
            dateFormat.DateFormat = "dd/MM/yyyy";  
            var pickerModelSucursales = new SucursalesModel();
            pkvSucursal.Model = pickerModelSucursales;
            StyleHelper.Style(this.vwProductos.Layer);
            ProductoGlobal = Producto;
            double subtotal = Producto.Producto_Precio_Base_Neto;
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
                this.FechaInicio = dateFormat.ToString(this.dpkFechaInicio.Date);
            }
            this.lblCantidadMeses.Text = "1";
            this.lblMensajeTarifa.Text = MensajeTarifa;
            this.lblNombreProducto.Text = Producto.Producto_Descripcion;
            this.lblTarifa.Text = Producto.Producto_Precio_Base_Neto.ToString("C");
            this.lblTotal.Text = "$0.00";
            this.lblCantidadProductos.Text = "0";
            this.ProporcionalMes();
        }

        partial void stpCantidadProductos_Changed(UIStepper sender)
        {
            this.lblCantidadProductos.Text = sender.Value.ToString();
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
                subTotalGlobal = Convert.ToInt32(lblCantidadProductos.Text) == 0 ? 0 : (ProductoGlobal.Producto_Precio_Base_Neto / EndMonth * (EndMonth - currentDay + 1));
            else
                subTotalGlobal = Convert.ToInt32(lblCantidadProductos.Text) == 0 ? 0 : ProductoGlobal.Producto_Precio_Base_Neto;
            this.lblProporcionalMes.Text = subTotalGlobal.ToString("C");
        }

        partial void dtpFechaInicio_ValueChanged(UIDatePicker sender)
        {
            this.FechaInicio = dateFormat.ToString(sender.Date);
            double EndMonth = DateHelper.GetMonthsDays((DateTime)dpkFechaInicio.Date);
            double currentDay = ((DateTime)dpkFechaInicio.Date).Day;
            subTotalGlobal = Convert.ToInt32(lblCantidadMeses.Text) == 0 ? 0 : (ProductoGlobal.Producto_Precio_Base_Neto / EndMonth * (EndMonth - currentDay + 1));
            lblProporcionalMes.Text = subTotalGlobal.ToString("C");
            this.ObtenerTotal();
        }

        private void ObtenerTotal()
        {
            lblTotal.Text = (((ProductoGlobal.Producto_Precio_Base_Neto * (Convert.ToDouble(lblCantidadMeses.Text) - 1)) + subTotalGlobal) * Convert.ToDouble(lblCantidadProductos.Text)).ToString("C");
            this.LlenarPreordenProductos();
        }

        private void LlenarPreordenProductos()
        {
            Preorden.Tipo = "PRODUCTO";
            Preorden.Id = int.Parse(ProductoGlobal.Producto_Id);
            Preorden.Cantidad = int.Parse(this.lblCantidadProductos.Text);
            Preorden.Meses = int.Parse(this.lblCantidadMeses.Text);
            Preorden.FechaInicio = this.FechaInicio;//dd/mm/yyyy
            Preorden.ListaPrecioId = this.ProductoGlobal.Lista_Precio_Id;
            Preorden.MonedaId = this.ProductoGlobal.Moneda_Id;
            Preorden.ImpuestoId = this.ProductoGlobal.Impuesto_Id;
            Preorden.DescuentoId = null;
            Preorden.TotalPagar = this.lblTotal.Text;
            Preorden.IndiceProducto = this.indiceGlobal;
            Preorden.Nombre = this.lblNombreProducto.Text;
            if (ObtenerPreordenProductos != null)
            {
                ObtenerPreordenProductos(Preorden, EventArgs.Empty);
            }
        }
    }

}