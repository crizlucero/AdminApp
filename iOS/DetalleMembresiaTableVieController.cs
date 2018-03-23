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
        public MembresiaModel Membresia = new MembresiaModel();
        int ContadorMembresias = 1;
        string Sucursal;
        string FechaInicio;
        List<SucursalModel> sucursales;
        NSDateFormatter dateFormat = new NSDateFormatter();

        public DetalleMembresiaTableVieController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            dateFormat.DateFormat = "dd/MM/yyyy";
            NavigationItem.Title = Membresia.Membresia_Descripcion;
            if(Membresia.Membresia_Id == "1")
            {
                this.btnQuitar.Enabled = true;
                this.btnQuitar.Hidden = false;
                this.btnAgregar.Enabled = true;
                this.btnAgregar.Hidden = false;
                this.txtCantidadMembresias.Enabled = true;
                this.txtCantidadMembresias.Hidden = false;
            }
            else
            {
                this.btnQuitar.Enabled = false;
                this.btnQuitar.Hidden = true;
                this.btnAgregar.Enabled = false;
                this.btnAgregar.Hidden = true;
                this.txtCantidadMembresias.Enabled = false;
                this.txtCantidadMembresias.Hidden = true;
            }

            StyleHelper.Style(this.vwSucursales.Layer);
            StyleHelper.Style(this.vwFecha.Layer);
            StyleHelper.Style(this.btnAñadir.Layer);
            this.lblLeyenda.Text = "Tarifa Mensual";
            this.lblPrecio.Text = "$" + Membresia.Membresia_Precio_Base_Neto.ToString() + " / MN";
            this.ContadorMembresias = 1;
            this.txtCantidadMembresias.Text = this.ContadorMembresias.ToString();
            sucursales = new SucursalController().GetSucursales();
            if (sucursales.Count > 0)
            {
                this.btnSucursal.SetTitle(sucursales[0].Sucursal_Descripcion, UIControlState.Normal);
            }
            this.lblDescripcion.Text = Membresia.Membresia_Especificacion;
            this.btnDeatlle.Hidden = false;
            this.btnDeatlle.Enabled = false;

        } 

        partial void btnCarrito_Touch(UIBarButtonItem sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnSucursal_Touch(UIButton sender)
        {
            this.PerformSegue("Sucursales", null);
        }

        partial void btnFecha_Touch(UIButton sender)
        {
            this.PerformSegue("FechaInicio", null);
        }

        partial void btnAñadir_Touch(UIButton sender)
        {
            var FechaInicio = dateFormat.ToString((NSDate)DateTime.Now);
            CarritoCompras Preorden = new CarritoCompras();

            Preorden.Tipo = Enum.TiposServicios.Membresia;
            Preorden.Id = int.Parse(Membresia.Membresia_Id);
            Preorden.Cantidad = int.Parse(this.txtCantidadMembresias.Text);
            Preorden.Meses = 0;
            Preorden.FechaInicio = FechaInicio;
            Preorden.ListaPrecioId = this.Membresia.Lista_Precio_Id;
            Preorden.MonedaId = this.Membresia.Moneda_Id;
            Preorden.ImpuestoId = this.Membresia.Impuesto_Id;
            Preorden.DescuentoId = 0;
            Preorden.TotalPagar = ((this.Membresia.Membresia_Precio_Base_Neto) * Convert.ToDouble(txtCantidadMembresias.Text)).ToString("C");
            Preorden.Nombre = this.Membresia.Membresia_Descripcion;
            this.MembresiaDelegate.ArticuloSeleccionado(Preorden);
            this.DismissViewController(true, null);
        }

        partial void btnDetalle_Touch(UIButton sender)
        {
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
                var SucursalesView = (SucursalesViewController)segue.DestinationViewController;
                SucursalesView.SucursalDelegate = this;
            }
            else if (segue.Identifier == "FechaInicio")
            {
                var FechaView = (FechaNacimientoPickerViewController)segue.DestinationViewController;
                FechaView.EsFechaNacimiento = false;
                FechaView.FechaSeleccionadaDelegate = this;
            }
        }
    }

    partial class DetalleMembresiaTableVieController : Sucursal
    {
        public void SucursalSeleccionada(String Sucursal)
        {
            this.Sucursal = Sucursal;
            this.btnSucursal.SetTitle(Sucursal, UIControlState.Normal);
        }
    }

    partial class DetalleMembresiaTableVieController : FechaNacimientoSeleccionada
    {
        public void FechaSeleccionada(String FechaNacimiento)
        {
            FechaInicio = FechaNacimiento;
            this.btnFecha.SetTitle(FechaNacimiento, UIControlState.Normal);
        }
    }


}