using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class ComentariosBodyCell : UITableViewCell
    {

        PostModel PostLocal;
        SimpleStorage storageLocal;
        String LikesLocal;

        public ComentariosBodyCell (IntPtr handle) : base (handle)
        {
            
        }

		internal void UpdateCell(PostModel post, String Likes, UIImage PostImage)
		{
            lblNombre.Text = post.Miembro_Nombre + " " + post.Miembro_Apellidos;
            lblLikes.Text = Likes;
            lblFechaPost.Text = post.POST_FECHA;
            lblOcupacion.Text = post.Miembro_Puesto == "" ? "Designer Jewelry" : post.Miembro_Puesto;
            lblComentarios.Text = "09 COMENTARIOS";
            lblDetalleComentario.Text = post.POST_CONTENIDO == "" ? "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam" : post.POST_CONTENIDO ;

            StyleHelper.Style(vwVistaComentario.Layer);

            imgPerfil.Image = PostImage;

            LikesLocal = Likes;
            PostLocal = post;
		}

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
            if (new Controllers.EscritorioController().PostLike(PostLocal.POST_ID, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo")))
            {
                this.lblLikes.Text = LikesLocal;
            }
        }
    }
}