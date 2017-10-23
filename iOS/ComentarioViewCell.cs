using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using PerpetualEngine.Storage;
using WorklabsMx.Enum;

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
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            string transaccion = "ALTA";
            if (comentarioLocal.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
            {
                transaccion = "BAJA";
            }
            else if (comentarioLocal.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
            {
                transaccion = "MODIFICAR";
            }
            if (new Controllers.EscritorioController().PostLike(comentarioLocal.Publicacion_Id, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"), transaccion))
            {
                lblLikes.Text = new Controllers.EscritorioController().GetLikesPublish(comentarioLocal.Publicacion_Id) + " LIKES";
                if (transaccion == "BAJA")
                {
                    comentarioLocal.Publicacion_Me_Gusta_Usuario = "0";
                    lblLikes.TextColor = UIColor.Black;
                }
                else
                {
                    comentarioLocal.Publicacion_Me_Gusta_Usuario = "1";
                    lblLikes.TextColor = (UIColor.FromRGB(57, 87, 217));
                }
            }
            if (comentarioLocal.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
            {
                lblLikes.TextColor = (UIColor.FromRGB(57, 87, 217));
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