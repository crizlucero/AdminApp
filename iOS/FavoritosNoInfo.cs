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
                lblMensajes.Text = "";
            }
            else
            {
                lblMensajes.Text = "";
            }
        }
    }
}