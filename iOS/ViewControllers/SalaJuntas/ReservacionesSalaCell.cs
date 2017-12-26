using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Models;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class ReservacionesSalaCell : UITableViewCell
    {
        public ReservacionesSalaCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(SalaJuntasReservacionModel Reservacion)
        {
            this.lblNombre.Text = Reservacion.Sala_Descripcion;
            this.lblCapacidad.Text = Reservacion.Sala_Capacidad + " Personas";
            this.lblDiaReservacion.Text = Reservacion.Sala_Fecha;
            this.lblFechaReservacion.Text = Reservacion.Sala_Hora_Inicio.Substring(0, 5) + " - " + Reservacion.Sala_Hora_Fin.Substring(0, 5);
        }

    }
}