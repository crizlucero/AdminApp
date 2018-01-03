using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoInfoEmpresas : UITableViewCell
    {
        public NoInfoEmpresas (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblMensajes.Text = "No hay comentarios en tu muro";
            }
            else
            {
                lblMensajes.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}