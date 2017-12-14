using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoInfoReservacionesCell : UITableViewCell
    {
        public NoInfoReservacionesCell (IntPtr handle) : base (handle)
        {
        }


        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblMensajeNoInfo.Text = "No hay reservaciones";
            }
            else
            {
                lblMensajeNoInfo.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}