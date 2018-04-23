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
        void Comprar(CarritoCompras Preorden);
    }

    public partial class DetalleProductoTableViewController : UITableViewController
    {
        public DetalleProductoInterface CompraDelgate;
        public DetalleCompraInterface ProductosDelegate;
        public ProductoModel Prodcuto = new ProductoModel();
        public UIImage ImagenProducto;

        List<CarritoCompras> PreordenProductos = new List<CarritoCompras>();
        int ContadorProductos = 1;
        string FechaInicio = "";
        NSDateFormatter dateFormat = new NSDateFormatter();

        public DetalleProductoTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            dateFormat.DateFormat = "yyyy-MM-dd";
            NavigationItem.Title = "Compras";
            this.lblNombre.Text = Prodcuto.Producto_Descripcion;

            if (Prodcuto.Producto_Disponibilidad.Contains("RECURRENTE"))
            {
                this.lblLeyenda.Text = "Tarifa Mensual";
                this.btnFecha.Enabled = true;
                this.btnFecha.Hidden = false;
                this.vwFecha.Hidden = false;
            }
            else
            {
                this.btnFecha.Enabled = false;
                this.btnFecha.Hidden = true;
                this.lblLeyenda.Text = "Pago único";
                this.vwFecha.Hidden = true;
            }
            this.lblPrecio.Text = "$" + Prodcuto.Producto_Precio_Base_Neto.ToString() + " / MN";
            ContadorProductos = 1;
            this.txtCantidad.Text = this.ContadorProductos.ToString();
            this.lblDetalleDescripcion.Text = Prodcuto.Producto_Especificacion;
            if (Prodcuto.Producto_Id == "2")
            {
                this.imgProducto.Image = UIImage.FromBundle("CopiaNegro");
            }
            if (Prodcuto.Producto_Id == "3")
            {
                this.imgProducto.Image = UIImage.FromBundle("CopiaColor");
            }
            if (Prodcuto.Producto_Id == "4")
            {
                this.imgProducto.Image = UIImage.FromBundle("Telefonia");
            }

            var Tap = new UITapGestureRecognizer(this.ViewTapped);
            this.View.UserInteractionEnabled = true;
            this.View.AddGestureRecognizer(Tap);
        }

        private void ViewTapped(UITapGestureRecognizer Recognizer)
        {
            View.EndEditing(true);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }
      

        partial void btnQuitar_Touch(UIButton sender)
        {
            if (ContadorProductos > 1)
            {
                ContadorProductos = ContadorProductos - 1;
                this.txtCantidad.Text = ContadorProductos.ToString();
            }
        }

        partial void btnAgregar_Touch(UIButton sender)
        {
            ContadorProductos = ContadorProductos + 1;
            this.txtCantidad.Text = ContadorProductos.ToString();
        }

        partial void btnAñadir_Touch(UIButton sender)
        {
            //var FechaInicio = dateFormat.ToString((NSDate)DateTime.Now);
            CarritoCompras Preorden = new CarritoCompras();
            this.ProductosDelegate.ArticuloSeleccionado(this.CrearOrden());
            this.DismissViewController(true, null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "FechaInicio")
            {
                var FechaView = (FechaNacimientoPickerViewController)segue.DestinationViewController;
                FechaView.EsFechaNacimiento = false;
                FechaView.FechaSeleccionadaDelegate = this;
            }
            else if (segue.Identifier == "Compra")
            {
                var VistaDetalleCompra = (VentaDetalleTableViewController)segue.DestinationViewController;
                VistaDetalleCompra.PreordenProductos = this.PreordenProductos; 
            }
        }

        partial void btnCerrar_Touch(UIBarButtonItem sender)
        {
            this.DismissViewController(true, null);
        }


        partial void btnFecha_Touch(UIButton sender)
        {
            this.PerformSegue("FechaInicio", null);
        }


        partial void btnComprar_Touch(UIButton sender)
        {
            this.DismissViewController(true, () =>
            {
                this.CompraDelgate.Comprar(this.CrearOrden());
            });

        }

        private CarritoCompras CrearOrden()
        {
            CarritoCompras Preorden = new CarritoCompras();
            Preorden.Tipo = Enum.TiposServicios.Producto;
            Preorden.Id = int.Parse(Prodcuto.Producto_Id);
            Preorden.Cantidad = int.Parse(this.txtCantidad.Text);
            Preorden.Meses = 0;
            if (this.FechaInicio != "")
            {
                Preorden.FechaInicio = FechaInicio;
            }
            else
            {
                FechaInicio = dateFormat.ToString((NSDate)DateTime.Now);
            }
            Preorden.FechaInicio = FechaInicio;
            Preorden.ListaPrecioId = this.Prodcuto.Lista_Precio_Id;
            Preorden.MonedaId = this.Prodcuto.Moneda_Id;
            Preorden.ImpuestoId = this.Prodcuto.Impuesto_Id;
            Preorden.DescuentoId = 0;
            Preorden.TotalPagar = ((this.Prodcuto.Producto_Precio_Base_Neto) * Convert.ToDouble(txtCantidad.Text)).ToString("C");
            Preorden.Nombre = this.Prodcuto.Producto_Descripcion;
            return Preorden;
        }
    }

    partial class DetalleProductoTableViewController : FechaNacimientoSeleccionada
    {
        public void FechaSeleccionada(String FechaNacimiento)
        {
            FechaInicio = FechaNacimiento;
            this.CrearOrden();
            this.btnFecha.SetTitle(FechaNacimiento, UIControlState.Normal);
        }
    }
}


