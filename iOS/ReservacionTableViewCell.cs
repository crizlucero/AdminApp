using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class ReservacionTableViewCell : UITableViewCell
    {
        public ReservacionTableViewCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(SalaJuntasReservacionModel Reservacion)
        {
            this.lblSucursal.Text = Reservacion.Sucursal_Descripcion;
            this.lblSalaNombre.Text = Reservacion.Sala_Descripcion;
            this.lblNivel.Text = Reservacion.Sala_Nivel;
            this.lblDiaMes.Text = Reservacion.Sala_Fecha;
            this.lblHoraInicioFin.Text = Reservacion.Sala_Hora_Inicio + " - " + Reservacion.Sala_Hora_Fin;
            this.lblCreditos.Text = "3 CREDITOS";
            this.lblCantidadHoras.Text = "1 HRS.";
        }
    }
}