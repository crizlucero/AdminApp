using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoInfoCuentaMembresiasCell : UITableViewCell
    {
        public NoInfoCuentaMembresiasCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                this.lblMensaje.Text = "No hay membresías en tu cuenta";
            }
            else
            {
                this.lblMensaje.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}