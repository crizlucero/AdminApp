using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoInfoMenuCell : UITableViewCell
    {
        public NoInfoMenuCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblMensaje.Text = "No hay comentarios en tu muro";
            }
            else
            {
                lblMensaje.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}