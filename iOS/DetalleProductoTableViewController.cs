using Foundation;
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

    public interface DetalleProductoInterface
    {
        void ProductoSeleccionado(CarritoCompras Preorden);
    }

    public partial class DetalleProductoTableViewController : UITableViewController
    {
        public DetalleProductoInterface ProductosDelegate;
        public ProductoModel Prodcuto = new ProductoModel();
        int ContadorProductos = 1;
        string Sucursal;
        List<SucursalModel> sucursales;
        NSDateFormatter dateFormat = new NSDateFormatter();

        public DetalleProductoTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            dateFormat.DateFormat = "dd/MM/yyyy";
            NavigationItem.Title = Prodcuto.Producto_Descripcion;


            StyleHelper.Style(this.vwSucursales.Layer);
            StyleHelper.Style(this.btnAñadir.Layer);

            if (Prodcuto.Producto_Disponibilidad.Contains("RECURRENTE"))
            {
                this.lblLeyenda.Text = "Tarifa Mensual";
            }
            else
            {
                this.lblLeyenda.Text = "Costo por unidad";
            }

            this.lblPrecio.Text = "$" + Prodcuto.Producto_Precio_Base_Neto.ToString() + " / MN";

            ContadorProductos = 1;
            this.lblCantidadProductos.Text = this.ContadorProductos.ToString();

            sucursales = new SucursalController().GetSucursales();
            if (sucursales.Count > 0)
            {
                this.btnSucursales.SetTitle(sucursales[0].Sucursal_Descripcion, UIControlState.Normal);
            }
            this.lblDetalleDescripcion.Text = Prodcuto.Producto_Especificacion;
            this.btnDetalle.Hidden = false;
            this.btnDetalle.Enabled = false;
        }

        partial void btnSucursales_Touch(UIButton sender)
        {
            this.PerformSegue("Sucursales", null);
        }

        partial void btnDetalle_Touch(UIButton sender)
        {
        }

        partial void btnQuitar_Touch(UIButton sender)
        {
            if (ContadorProductos > 1)
            {
                ContadorProductos = ContadorProductos - 1;
                this.lblCantidadProductos.Text = ContadorProductos.ToString();
            }
        }

        partial void btnAgregar_Touch(UIButton sender)
        {
            ContadorProductos = ContadorProductos + 1;
            this.lblCantidadProductos.Text = ContadorProductos.ToString();
        }

        partial void btnAñadir_Touch(UIButton sender)
        {
            var FechaInicio = dateFormat.ToString((NSDate)DateTime.Now);
            CarritoCompras Preorden = new CarritoCompras();

            Preorden.Tipo = Enum.TiposServicios.Producto;
            Preorden.Id = int.Parse(Prodcuto.Producto_Id);
            Preorden.Cantidad = int.Parse(this.lblCantidadProductos.Text);
            Preorden.Meses = 0;
            Preorden.FechaInicio = FechaInicio;
            Preorden.ListaPrecioId = this.Prodcuto.Lista_Precio_Id;
            Preorden.MonedaId = this.Prodcuto.Moneda_Id;
            Preorden.ImpuestoId = this.Prodcuto.Impuesto_Id;
            Preorden.DescuentoId = 0;
            Preorden.TotalPagar = ((this.Prodcuto.Producto_Precio_Base_Neto) * Convert.ToDouble(lblCantidadProductos.Text)).ToString("C");
            Preorden.Nombre = this.Prodcuto.Producto_Descripcion;
            this.ProductosDelegate.ProductoSeleccionado(Preorden);
            this.DismissViewController(true, null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "Sucursales")
            {
                var GenderView = (SucursalesViewController)segue.DestinationViewController;
                GenderView.SucursalDelegate = this;
            }
        }

        partial void btnCerrar_Touch(UIBarButtonItem sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnAgregarACarrito_Touch(UIBarButtonItem sender)
        {
        }

        partial void btnFecha_Touch(UIButton sender)
        {
        }
    }

    partial class DetalleProductoTableViewController : Sucursal
    {
        public void SucursalSeleccionada(String Sucursal)
        {
            this.Sucursal = Sucursal;
            this.btnSucursales.SetTitle(Sucursal, UIControlState.Normal);
        }
    }
}