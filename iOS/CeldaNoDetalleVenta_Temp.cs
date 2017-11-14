using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public class CeldaNoDetalleVenta_Temp : UITableViewCell
    {

        public CeldaNoDetalleVenta_Temp(IntPtr handle) : base(handle)
        {

        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblMessage.Text = "No hay productos en tu carrito";
            }
            else
            {
                lblMessage.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}
