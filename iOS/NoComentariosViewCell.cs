using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class NoComentariosViewCell : UITableViewCell
    {
        public NoComentariosViewCell (IntPtr handle) : base (handle)
        {
        }

		internal void UpdateCell(bool existeConeccion)
		{
			if (existeConeccion)
			{
				lblNoComentariosInfo.Text = "No hay comentarios en tu muro";
			}
			else
			{
				lblNoComentariosInfo.Text = "No tienes acceso a una conexión de Internet";
			}
		}
    }
}