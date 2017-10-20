using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;

namespace WorklabsMx.iOS
{
    public partial class ComentarioViewCell : UITableViewCell
    {

        ComentarioModel comentarioLocal;
        SimpleStorage storageLocal;

        public event EventHandler MostrarImagenEnGrande;

        public event EventHandler LeDioLike;


        public ComentarioViewCell (IntPtr handle) : base (handle)
        {
        }

		internal void UpdateCell(ComentarioModel comentario)
		{
            lblNombre.Text = comentario.Usuario_Nombre;
			lblLikes.Text = comentario.Comentario_Me_Gustan_Cantidad + " LIKES";
            lblFechaPost.Text = comentario.Comentario_Fecha;
            //lblPuesto.Text = comentario.USUARIO_PUESTO;
			lblContenido.Text = comentario.Comentario_Contenido;

            imgPerfil.Image = ImageGallery.LoadImage(comentario.Usuario_Fotografia_Ruta);
            if (comentario.Comentario_Imagen_Ruta != "")
            {
                btnImagenComentario.ImageView.Image = ImageGallery.LoadImage(comentario.Comentario_Imagen_Ruta);
                btnImagenComentario.Hidden = false;
                btnImagenComentario.Enabled = true;
            }
            else 
            {
                btnImagenComentario.Hidden = true;
                btnImagenComentario.Enabled = false;
            }
            comentarioLocal = comentario;

		}

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
            storageLocal = SimpleStorage.EditGroup("Login");
            if (comentarioLocal.Comentario_Me_Gustan_Cantidad == "2")
            {
                if (new Controllers.EscritorioController().PostLike(comentarioLocal.Comentario_Id, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo")))
                {
                    //this.lblLikes.Text = new Controllers.EscritorioController().GetLikesPublish(comentarioLocal.Comentario_Id) + " LIKES";
                    if(LeDioLike != null)
                    {
                        LeDioLike(null, EventArgs.Empty);
                    }
                }
            }
        }

        partial void btnImagenComentario_TouchUpInside(UIButton sender)
        {
            if (MostrarImagenEnGrande != null)
            {
                MostrarImagenEnGrande(sender.ImageView, EventArgs.Empty);
            }
        }
    }
}