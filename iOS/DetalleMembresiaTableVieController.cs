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


    public partial class DetalleMembresiaTableVieController : UITableViewController
    {
        public DetalleCompraInterface MembresiaDelegate;
        public DetalleProductoInterface CompraDelgate;
        public MembresiaModel Membresia = new MembresiaModel();
        int ContadorMembresias = 1;
        string Sucursal;
        string FechaInicio = "";
        string Plazo = "";
        NSDateFormatter dateFormat = new NSDateFormatter();

        public DetalleMembresiaTableVieController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            dateFormat.DateFormat = "dd/MM/yyyy";
            NavigationItem.Title = "Membresías";
            if(Membresia.Membresia_Id == "1")
            {
                this.vwCantidad.Hidden = false;
                this.btnQuitar.Enabled = true;
                this.btnQuitar.Hidden = false;
                this.btnAgregar.Enabled = true;
                this.btnAgregar.Hidden = false;
                this.txtCantidadMembresias.Enabled = true;
                this.txtCantidadMembresias.Hidden = false;

            }
            else
            {
                this.vwCantidad.Hidden = true;
                this.btnQuitar.Enabled = false;
                this.btnQuitar.Hidden = true;
                this.btnAgregar.Enabled = false;
                this.btnAgregar.Hidden = true;
                this.txtCantidadMembresias.Enabled = false;
                this.txtCantidadMembresias.Hidden = true;
            }
            this.lblLeyenda.Text = "Tarifa Mensual";
            this.lblPrecio.Text = "$" + Membresia.Membresia_Precio_Base_Neto.ToString() + " / MN";
            this.ContadorMembresias = 1;
            this.txtCantidadMembresias.Text = this.ContadorMembresias.ToString();
            this.lblDescripcion.Text = Membresia.Membresia_Especificacion;
            this.lblNombre.Text = Membresia.Membresia_Descripcion;
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

        partial void btnCarrito_Touch(UIBarButtonItem sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnFecha_Touch(UIButton sender)
        {
            this.PerformSegue("FechaInicio", null);
        }

        partial void btnAñadir_Touch(UIButton sender)
        {
            this.MembresiaDelegate.ArticuloSeleccionado(CrearOrden());
            this.DismissViewController(true, null);
        }

        private CarritoCompras CrearOrden()
        {
            var Fecha = dateFormat.ToString((NSDate)DateTime.Now);
            CarritoCompras Preorden = new CarritoCompras();
            Preorden.Tipo = Enum.TiposServicios.Membresia;
            Preorden.Id = int.Parse(Membresia.Membresia_Id);
            Preorden.Cantidad = int.Parse(this.txtCantidadMembresias.Text);
            if (Plazo != "")
            {
                Preorden.Meses = int.Parse(this.Plazo.Replace(" MESES", ""));
            }
            else
            {
                Preorden.Meses = 1;
            }
            if (this.FechaInicio != "")
            {
                Preorden.FechaInicio = this.FechaInicio;
            }
            else
            {
                Preorden.FechaInicio = Fecha;
            }
            Preorden.ListaPrecioId = this.Membresia.Lista_Precio_Id;
            Preorden.MonedaId = this.Membresia.Moneda_Id;
            Preorden.ImpuestoId = this.Membresia.Impuesto_Id;
            Preorden.DescuentoId = 0;
            Preorden.TotalPagar = ((this.Membresia.Membresia_Precio_Base_Neto) * Convert.ToDouble(txtCantidadMembresias.Text) * Preorden.Meses).ToString("C");
            Preorden.Nombre = this.Membresia.Membresia_Descripcion;
            return Preorden;
        }

        partial void btnQuitar_Touch(UIButton sender)
        {
            if (this.ContadorMembresias > 1)
            {
                this.ContadorMembresias = this.ContadorMembresias - 1;
                this.txtCantidadMembresias.Text = this.ContadorMembresias.ToString();
            }
        }

        partial void btnAgregar_Touch(UIButton sender)
        {
            this.ContadorMembresias = this.ContadorMembresias + 1;
            this.txtCantidadMembresias.Text = this.ContadorMembresias.ToString();
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            if (segue.Identifier == "Sucursales")
            {
                var SucursalesView = (SucursalesView)segue.DestinationViewController;
                SucursalesView.SucursalDelegate = this;
            }
            else if (segue.Identifier == "FechaInicio")
            {
                var FechaView = (FechaNacimientoPickerView)segue.DestinationViewController;
                FechaView.EsFechaNacimiento = false;
                FechaView.FechaSeleccionadaDelegate = this;
            }
            else if (segue.Identifier == "Plazos")
            {
                var VistaPlazos = (PlazosViewController)segue.DestinationViewController;
                VistaPlazos.PlazosDelegate = this;
            }
        }

        partial void btnComprar_Touch(UIButton sender)
        {
            this.DismissViewController(true, () =>
            {
                this.CompraDelgate.Comprar(this.CrearOrden());
            });
        }

        partial void btnPlazos_Touch(UIButton sender)
        {
            this.PerformSegue("Plazos", null);
        }
    }

    partial class DetalleMembresiaTableVieController : Sucursal
    {
        public void SucursalSeleccionada(String Sucursal)
        {
            this.Sucursal = Sucursal;
        }
    }

    partial class DetalleMembresiaTableVieController : FechaNacimientoSeleccionada
    {
        public void FechaSeleccionada(String FechaNacimiento)
        {
            FechaInicio = FechaNacimiento;
            this.CrearOrden();
            this.btnFecha.SetTitle(FechaNacimiento, UIControlState.Normal);
        }
    }

    partial class DetalleMembresiaTableVieController : PlazosInterface
    {
        public void PlazoSeleccionado(string Plazo)
        {
            this.Plazo = Plazo;
            this.CrearOrden();
            this.btnPlazos.SetTitle(Plazo, UIControlState.Normal);
        }
    }


}