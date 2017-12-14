using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Models;

namespace WorklabsMx.iOS
{
    public partial class ReservacionesSalaCell : UITableViewCell
    {
        public ReservacionesSalaCell (IntPtr handle) : base (handle)
        {
        }

        public void UpdateCell(ReservacionSalaModel Reservacion)
        {
            this.lblNombre.Text = "SALA IN TO THE WILD";
            this.lblCapacidad.Text = "6 - 8";
            this.lblDiaReservacion.Text = "LUNES 11";
            this.lblFechaReservacion.Text = "11:00 - 12:00";
        }

    }
}