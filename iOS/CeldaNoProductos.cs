using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class CeldaNoProductos : UITableViewCell
    {
        public CeldaNoProductos (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblMessageNoProducts.Text = "No hay comentarios en tu muro";
            }
            else
            {
                lblMessageNoProducts.Text = "No tienes acceso a una conexión de Internet";
            }
        }
    }
}