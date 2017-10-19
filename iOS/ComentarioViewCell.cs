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

		internal void UpdateCell(ComentarioModel comentario, UIImage ImagenComentario)
		{
            lblNombre.Text = comentario.Usuario_Nombre;
			lblLikes.Text = "11 LIKES";
            lblFechaPost.Text = comentario.Comentario_Fecha;
            //lblPuesto.Text = comentario.USUARIO_PUESTO;
			lblContenido.Text = comentario.Comentario_Contenido;

            imgPerfil.Image = ImagenComentario;
		}

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
           
        }
    }
}