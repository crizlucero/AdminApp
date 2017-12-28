using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoInfoCellUsuarios : UITableViewCell
    {
        public NoInfoCellUsuarios (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblNoInfo.Text = "No hay comentarios en tu muro";
            }
            else
            {
                lblNoInfo.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}