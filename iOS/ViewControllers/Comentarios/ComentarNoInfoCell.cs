using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class ComentarNoInfoCell : UITableViewCell
    {
        public ComentarNoInfoCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(bool existeConeccion)
        {
            if (existeConeccion)
            {
                lblNoInfo.Text = "Sé el primero en comentar";
            }
            else
            {
                lblNoInfo.Text = "No se pudieron mostrar los comentarios, verifica tu conexión a internet";
            }
        }
    }
}