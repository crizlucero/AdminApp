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
                lblNoComentariosInfo.Text = "Sé el primero en comentar";
			}
			else
			{
				lblNoComentariosInfo.Text = "No se pudieron mostras los comentario, verifica tu conexión a internet";
			}
		}
    }
}