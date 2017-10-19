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
            lblNombre.Text = post.Usuario_Nombre;
            lblLikes.Text = Likes;
            lblFechaPost.Text = post.Publicacion_Fecha;
            //lblOcupacion.Text = post.Miembro_Puesto;
            lblComentarios.Text = post.Publicacion_Comentarios_Cantidad + " COMENTARIOS";
            lblDetalleComentario.Text = post.Publicacion_Contenido;

            StyleHelper.Style(vwVistaComentario.Layer);

            imgPerfil.Image = PostImage;

            PostLocal = post;
		}

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
            if (new Controllers.EscritorioController().PostLike(PostLocal.Publicacion_Id, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo")))
            {
                this.lblLikes.Text = new Controllers.EscritorioController().GetLikesComments(PostLocal.Publicacion_Id) + " LIKES";
            }
        }

        partial void btnImagenComentatio_touchUpInside(UIButton sender)
        {
           
        }
    }
}