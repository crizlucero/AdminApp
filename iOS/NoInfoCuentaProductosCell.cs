using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoInfoCuentaProductosCell : UITableViewCell
    {
        public NoInfoCuentaProductosCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                this.lblNoInfo.Text = "No hay productos en tu cuenta";
            }
            else
            {
                this.lblNoInfo.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}