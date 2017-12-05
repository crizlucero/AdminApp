using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class HorariosTableViewCell : UITableViewCell
    {
        public HorariosTableViewCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(string Hora)
        {
            this.lblHorario.Text = Hora;
            this.lblDisponibilidad.Text = "Disponible";
        }
    }
}