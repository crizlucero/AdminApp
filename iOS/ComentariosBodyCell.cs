using System;
using UIKit;
using WorklabsMx.Models;

namespace WorklabsMx.iOS
{
    public partial class ComentariosBodyCell : UITableViewCell
    {
        public ComentariosBodyCell (IntPtr handle) : base (handle)
        {
            
        }

		internal void UpdateCell(PostModel post)
		{
            lblNombre.Text = post.Miembro_Nombre + " " + post.Miembro_Apellidos;
            lblLikes.Text = "11 LIKES";
            lblFechaPost.Text = post.POST_FECHA;
            lblOcupacion.Text = post.Miembro_Puesto;
            lblComentarios.Text = "09 COMENTARIOS";
            lblDetalleComentario.Text = post.POST_CONTENIDO;
			
			//imgPerfil.Image = miembro.Miembro_Fotografia;
		}

    }
}