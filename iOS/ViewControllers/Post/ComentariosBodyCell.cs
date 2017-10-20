using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class ComentariosBodyCell : UITableViewCell
    {

        String PostLocal;
        SimpleStorage storageLocal;

        public event EventHandler MostrarImagenEnGrande;

        public ComentariosBodyCell (IntPtr handle) : base (handle)
        {
            
        }

		internal void UpdateCell(PostModel post)
		{
            lblNombre.Text = post.Usuario_Nombre;
            lblLikes.Text = post.Publicacion_Me_Gustan_Cantidad;
            lblFechaPost.Text = post.Publicacion_Fecha;
            //lblOcupacion.Text = post.Miembro_Puesto;
            lblComentarios.Text = post.Publicacion_Comentarios_Cantidad + " COMENTARIOS";
            lblDetalleComentario.Text = post.Publicacion_Contenido;

            StyleHelper.Style(vwVistaComentario.Layer);

            imgPerfil.Image = ImageGallery.LoadImage(post.Usuario_Fotografia_Ruta);

            if (post.Publicacion_Imagen_Ruta != "")
            {
                btnImagenComentatio.ImageView.Image = ImageGallery.LoadImage(post.Publicacion_Imagen_Ruta);
                btnImagenComentatio.Hidden = false;
                btnImagenComentatio.Enabled = true;
            }
            else
            {
                btnImagenComentatio.Hidden = true;
                btnImagenComentatio.Enabled = false;
            }

            PostLocal = post.Publicacion_Id;
		}

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
            if (new Controllers.EscritorioController().PostLike(PostLocal, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo")))
            {
                this.lblLikes.Text = new Controllers.EscritorioController().GetLikesPublish(PostLocal) + " LIKES";
            }
        }

        partial void btnImagenComentatio_touchUpInside(UIButton sender)
        {
            if (MostrarImagenEnGrande != null)
            {
                MostrarImagenEnGrande(sender.ImageView, EventArgs.Empty);
            }
        }
    }
}