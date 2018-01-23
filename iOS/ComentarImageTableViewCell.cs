using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using CoreGraphics;


namespace WorklabsMx.iOS
{
    public partial class ComentarImageTableViewCell : UITableViewCell
    {

        ComentarioModel comentarioLocal;

        public event EventHandler MostrarImagenEnGrandes;

        public ComentarImageTableViewCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(ComentarioModel comentario, UIImage currentImageProfile, UIImage currentImageComments)
        {

            var Tap = new UITapGestureRecognizer(this.ImageTapped);
            imgPublicacion.UserInteractionEnabled = true;
            imgPublicacion.AddGestureRecognizer(Tap);

            lblNombre.Text = comentario.Usuario_Nombre;
            lblLikes.Text = comentario.Comentario_Me_Gustan_Cantidad + " LIKES";
            lblFecha.Text = comentario.Comentario_Fecha;
            //lblPuesto.Text = comentario.USUARIO_PUESTO;

            txtComentario.TranslatesAutoresizingMaskIntoConstraints = false;
            txtComentario.ScrollEnabled = false;
            txtComentario.Text = comentario.Comentario_Contenido;

            imgPerfil.Image = currentImageProfile ?? UIImage.FromBundle("PerfilEscritorio");

            imgPublicacion.Image = currentImageComments;

            comentarioLocal = comentario;

        }

        private void ImageTapped(UITapGestureRecognizer Recognizer)
        {
            if (MostrarImagenEnGrandes != null)
            {
                MostrarImagenEnGrandes(imgPublicacion, EventArgs.Empty);
            }
        }

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
            //var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            string transaccion = "ALTA";
            if (comentarioLocal.Comentario_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
            {
                transaccion = "BAJA";
            }
            else if (comentarioLocal.Comentario_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
            {
                transaccion = "MODIFICAR";
            }
            if (new Controllers.EscritorioController().PostLike(comentarioLocal.Publicacion_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), transaccion))
            {
                lblLikes.Text = new Controllers.EscritorioController().GetLikesPublish(comentarioLocal.Publicacion_Id) + " LIKES";
                if (transaccion == "BAJA")
                {
                    comentarioLocal.Comentario_Me_Gusta_Usuario = "0";
                    lblLikes.TextColor = UIColor.Black;

                }
                else
                {
                    comentarioLocal.Comentario_Me_Gusta_Usuario = "1";
                    lblLikes.TextColor = (UIColor.FromRGB(57, 87, 217));
                }
            }
        }

    }
}