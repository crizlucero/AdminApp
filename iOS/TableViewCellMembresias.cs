using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;
using WorklabsMx.Helpers;
using WorklabsMx.Enum;

namespace WorklabsMx.iOS
{
    public partial class TableViewCellMembresias : UITableViewCell
    {
        MembresiaModel MembresiaGlobal;
        double subtotal;
        CarritoCompras Preorden = new CarritoCompras();
        string FechaInicio;

        public event EventHandler ObtenerPreordenMembresia;

        NSDateFormatter dateFormat = new NSDateFormatter();

        int IndiceMembresia;

        public TableViewCellMembresias (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(MembresiaModel Membresia, int indice)
        {
            this.IndiceMembresia = indice;
            dateFormat.DateFormat = "dd/MM/yyyy"; 
            StyleHelper.Style(this.vwMembresias.Layer);
            var pickerModelSucursales = new SucursalesModel();
            pcwSucursal.Model = pickerModelSucursales;
            this.lblNombreMembresia.Text = Membresia.Membresia_Descripcion;
            this.lblTarifaMensual.Text = Membresia.Membresia_Precio_Base_Neto.ToString("C");
            this.lblTarifaInscripcion.Text = Membresia.Inscripcion_Precio_Base_Neto.ToString("C");
            this.lblCantidadMeses.Text = "1";
            this.lblCantidadMembresias.Text = "0";
            MembresiaGlobal = Membresia;
            this.FechaInicio = dateFormat.ToString(this.dtpFechaInicio.Date);
        }

        partial void stpCantidadMembresias_ValueChanged(UIStepper sender)
        {
            this.lblCantidadMembresias.Text = sender.Value.ToString();
            double EndMonth = DateHelper.GetMonthsDays((DateTime)dtpFechaInicio.Date);
            double currentDay = ((DateTime)dtpFechaInicio.Date).Day;
            this.CalcularTotalSubtotal(EndMonth, currentDay);
        }

        partial void dtpFechaInicio_ValueChanged(UIDatePicker sender)
        {
            this.FechaInicio = dateFormat.ToString(sender.Date);
            double EndMonth = DateHelper.GetMonthsDays(((DateTime)(((UIDatePicker)sender).Date)));
            double currentDay = ((DateTime)(((UIDatePicker)sender).Date)).Day;
            this.CalcularTotalSubtotal(EndMonth, currentDay);
        }

        partial void stpCantidadMeses_ValueChanged(UIStepper sender)
        {
            this.lblCantidadMeses.Text = sender.Value.ToString();
            double currentDay = ((DateTime)dtpFechaInicio.Date).Day;
            double EndMonth = DateHelper.GetMonthsDays((DateTime)dtpFechaInicio.Date);
            this.CalcularTotalSubtotal(EndMonth, currentDay);
        }

        private void CalcularTotalSubtotal(double EndMonth, double currentDay)
        {
            subtotal = Convert.ToInt32(lblCantidadMembresias.Text) == 0 ? 0 : (MembresiaGlobal.Membresia_Precio_Base_Neto / EndMonth * (EndMonth - currentDay + 1));
            lblProporcionalMes.Text = subtotal.ToString("C");

            if (Convert.ToDouble(lblCantidadMeses.Text) > 1)
            {
                lblTotal.Text = (((MembresiaGlobal.Membresia_Precio_Base_Neto * (Convert.ToDouble(lblCantidadMeses.Text))) + subtotal + (MembresiaGlobal.Inscripcion_Precio_Base_Neto)) * Convert.ToDouble(lblCantidadMembresias.Text)).ToString("C");
            }
            else 
            {
                lblTotal.Text = ((subtotal + (MembresiaGlobal.Inscripcion_Precio_Base_Neto)) * Convert.ToDouble(lblCantidadMembresias.Text)).ToString("C");
            }
            this.LlenarPreordenMembresia();
        }

        private void LlenarPreordenMembresia()
        {
            Preorden.Tipo = TiposServicios.Membresia;
            Preorden.Id = int.Parse(MembresiaGlobal.Membresia_Id);
            Preorden.Cantidad = int.Parse(this.lblCantidadMembresias.Text);
            Preorden.Meses = int.Parse(this.lblCantidadMeses.Text);
            Preorden.FechaInicio = this.FechaInicio;//dd/mm/yyyy
            Preorden.ListaPrecioId = this.MembresiaGlobal.Lista_Precio_Id;
            Preorden.MonedaId = this.MembresiaGlobal.Moneda_Id;
            Preorden.ImpuestoId = this.MembresiaGlobal.Impuesto_Id;
            Preorden.DescuentoId = 0;
            Preorden.TotalPagar = this.lblTotal.Text;
            Preorden.IndiceProducto = this.IndiceMembresia;
            Preorden.Nombre = this.lblNombreMembresia.Text;
            if (ObtenerPreordenMembresia != null)
            {
                ObtenerPreordenMembresia(Preorden, EventArgs.Empty);
            }
        }
    }
}