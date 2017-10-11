using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class ComentarioViewCell : UITableViewCell
    {
        public ComentarioViewCell (IntPtr handle) : base (handle)
        {
        }

		internal void UpdateCell(ComentarioModel comentario)
		{
            lblNombre.Text = comentario.Nombre;
			lblLikes.Text = "11 LIKES";
            lblFechaPost.Text = comentario.COMM_FECHA;
			lblPuesto.Text = comentario.USUARIO_PUESTO == "" ? "Designer Jewelry" : comentario.USUARIO_PUESTO;
			lblContenido.Text = comentario.COMM_CONTENIDO == "" ? "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam" : comentario.COMM_CONTENIDO;

			imgPerfil.Image = ImageGallery.LoadImage(comentario.Miembro_Fotografia);
		}
    }
}