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

        public ComentariosBodyCell (IntPtr handle) : base (handle)
        {
            
        }

		internal void UpdateCell(PostModel post, String Likes, UIImage PostImage)
		{
            lblNombre.Text = post.Miembro_Nombre + " " + post.Miembro_Apellidos;
            lblLikes.Text = Likes;
            lblFechaPost.Text = post.POST_FECHA;
            lblOcupacion.Text = post.Miembro_Puesto;
            lblComentarios.Text = "09 COMENTARIOS";
            lblDetalleComentario.Text = post.POST_CONTENIDO;

            StyleHelper.Style(vwVistaComentario.Layer);

            imgPerfil.Image = PostImage;

            PostLocal = post;
		}

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
            if (new Controllers.EscritorioController().PostLike(PostLocal.POST_ID, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo")))
            {
                this.lblLikes.Text = new Controllers.EscritorioController().GetLikes(PostLocal.POST_ID) + " LIKES";
            }
        }
    }
}