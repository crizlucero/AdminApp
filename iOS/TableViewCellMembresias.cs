using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Models;
using CoreGraphics;
using WorklabsMx.Helpers;
using System.Collections.Generic;
using WorklabsMx.Controllers;

namespace WorklabsMx.iOS
{
    public partial class TableViewCellMembresias : UITableViewCell
    {

        MembresiaModel MembresiaGlobal;
        double subtotal;

        public TableViewCellMembresias (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(MembresiaModel Membresia)
        {
            StyleHelper.Style(this.vwMembresias.Layer);
            var pickerModelSucursales = new SucursalesModel();
            pcwSucursal.Model = pickerModelSucursales;
            this.lblNombreMembresia.Text = Membresia.Membresia_Descripcion;
            this.lblTarifaMensual.Text = Membresia.Membresia_Precio_Base_Neto.ToString("C");
            this.lblTarifaInscripcion.Text = Membresia.Inscripcion_Precio_Base_Neto.ToString("C");
            this.lblCantidadMeses.Text = "1";
            this.lblCantidadMembresias.Text = "0";
            MembresiaGlobal = Membresia;
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
            double EndMonth = DateHelper.GetMonthsDays(((DateTime)(((UIDatePicker)sender).Date)));
            double currentDay = ((DateTime)(((UIDatePicker)sender).Date)).Day;
            this.CalcularTotalSubtotal(EndMonth, currentDay);
        }

        partial void stpCantidadMeses_ValueChanged(UIStepper sender)
        {
            this.lblCantidadMeses.Text = sender.Value.ToString();
            lblTotal.Text = (((MembresiaGlobal.Membresia_Precio_Base * (Convert.ToDouble(lblCantidadMeses.Text) - 1)) + subtotal + (MembresiaGlobal.Inscripcion_Precio_Base * (Convert.ToDouble(lblCantidadMeses.Text) - 1))) * Convert.ToDouble(lblCantidadMembresias.Text)).ToString("C");
        }

        private void CalcularTotalSubtotal(double EndMonth, double currentDay)
        {
            subtotal = Convert.ToInt32(lblCantidadMembresias.Text) == 0 ? 0 : (MembresiaGlobal.Membresia_Precio_Base / EndMonth * (EndMonth - currentDay + 1));
            lblProporcionalMes.Text = subtotal.ToString("C");
            lblTotal.Text = (((MembresiaGlobal.Membresia_Precio_Base * (Convert.ToDouble(lblCantidadMeses.Text) - 1)) + subtotal + (MembresiaGlobal.Inscripcion_Precio_Base * (Convert.ToDouble(lblCantidadMeses.Text) - 1))) * Convert.ToDouble(lblCantidadMembresias.Text)).ToString("C");
        }
    }
}