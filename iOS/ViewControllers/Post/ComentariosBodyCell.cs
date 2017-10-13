using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;

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
            lblOcupacion.Text = post.Miembro_Puesto == "" ? "Designer Jewelry" : post.Miembro_Puesto;
            lblComentarios.Text = "09 COMENTARIOS";
            lblDetalleComentario.Text = post.POST_CONTENIDO == "" ? "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam" : post.POST_CONTENIDO ;

            StyleHelper.Style(vwVistaComentario.Layer);

            imgPerfil.Image = ImageGallery.LoadImage(post.Miembro_Fotografia);
		}

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
    }
}