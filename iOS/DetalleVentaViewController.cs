using System;
using Foundation;
using UIKit;
using WorklabsMx.iOS.Models;
using System.Collections.Generic;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;
using WorklabsMx.Enum;
using Photos;
using AVFoundation;
using WorklabsMx.Helpers;
using BigTed;
using System.Threading.Tasks;
using WorklabsMx.Controllers;
using WorklabsMx.Models;


namespace WorklabsMx.iOS
{
    public partial class DetalleVentaViewController : UIViewController
    {

        public CarritoCompras Venta;

        List<CarritoComprasDetalle> membresias = null;
        PickerItemsController controller;

        public DetalleVentaViewController (IntPtr handle) : base (handle)
        {
            membresias = new List<CarritoComprasDetalle>();
            controller = new PickerItemsController();
        }

        public override void ViewDidLoad()
        {
            StyleHelper.Style(vwDetalleProducto.Layer);
            this.CargarDetalleCompra();
        }

        partial void btnBack_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        private void CargarDetalleCompra()
        {
            membresias.AddRange(controller.GetProductosMembresias(Venta.Tipo, Venta.Id, Venta.Cantidad, Venta.Meses, Venta.FechaInicio, Venta.ListaPrecioId, Venta.MonedaId, Venta.ImpuestoId, Venta.DescuentoId));
            foreach (CarritoComprasDetalle membresia in membresias)
            {
                this.lblSucursal.Text = "";
                this.lblProducto.Text = membresia.Carrito_Compras_Detalle_Descripcion;
                this.lblDisponibilidad.Text = "";
                this.lblTarifaMensual.Text = membresia.Carrito_Compras_Detalle_Importe_Precio;
                this.lblTarifaProporcional.Text = membresia.Carrito_Compras_Detalle_Importe_Prorrateo;
                this.lblCantidadProducto.Text = membresia.Carrito_Compras_Detalle_Cantidad;
                this.lblCantidadMeses.Text = "";
                this.lblVigencia.Text = membresia.Carrito_Compras_Detalle_Vigencia_Fecha_Fin;
                this.lblSubtotal.Text = membresia.Carrito_Compras_Detalle_Importe_Subtotal_Texto;
                this.lblImpuesto.Text = membresia.Carrito_Compras_Detalle_Importe_Impuesto_Texto;
                this.lblTotal.Text = membresia.Carrito_Compras_Detalle_Importe_Total_Texto;
            }
        }
    }
}