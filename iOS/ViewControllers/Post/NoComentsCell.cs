using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoComentsCell : UITableViewCell
    {
        public NoComentsCell (IntPtr handle) : base (handle)
        {
            lblMessageNoComments.Text = "No hay comentarios en tu muro";
        }

		internal void UpdateCell(bool existeConeccion)
		{
            if(existeConeccion){
                lblMessageNoComments.Text = "No hay comentarios en tu muro";
            } else {
                lblMessageNoComments.Text = "No tienes acceso a una conexión de Internet";
            }
		}
    }
}