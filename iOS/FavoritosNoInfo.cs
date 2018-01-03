using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class FavoritosNoInfo : UITableViewCell
    {
        public FavoritosNoInfo (IntPtr handle) : base (handle)
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