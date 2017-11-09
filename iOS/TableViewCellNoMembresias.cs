using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class TableViewCellNoMembresias : UITableViewCell
    {
        public TableViewCellNoMembresias (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblMessage.Text = "No hay membresías disponibles";
            }
            else
            {
                lblMessage.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}