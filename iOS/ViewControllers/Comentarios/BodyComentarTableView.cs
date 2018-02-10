using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using CoreGraphics;

namespace WorklabsMx.iOS
{


    public interface EventosImagenComentar
    {
        void MostrarImagenEnGrandesComentar(UIImageView Imagen);
        void EnviarAction(UIAlertController actionSheetAlert);
        void ActualizarTabla();
    }

    public partial class BodyComentarTableView : UITableViewCell
    {

        ComentarioModel comentarioLocal;

        public EventosImagenComentar EventosImagenComentarDel;

        public BodyComentarTableView (IntPtr handle) : base (handle)
        {
        }


        internal void UpdateCell(ComentarioModel comentario, UIImage currentImageProfile)
        {


            lblNombre.Text = comentario.Usuario.Usuario_Nombre;
            lblLikes.Text = comentario.Comentario_Me_Gustan_Cantidad + " LIKES";
            lblFecha.Text = comentario.Comentario_Fecha;
            //lblPuesto.Text = comentario.USUARIO_PUESTO;

            txtComentario.TranslatesAutoresizingMaskIntoConstraints = false;
            txtComentario.ScrollEnabled = false;
            txtComentario.Text = comentario.Comentario_Contenido;

            imgPerfil.Image = currentImageProfile ?? UIImage.FromBundle("PerfilEscritorio");

            comentarioLocal = comentario;

        }

        partial void btnImagen_TouchUpInside(UIButton sender)
        {
            EventosImagenComentarDel.MostrarImagenEnGrandesComentar(sender.ImageView);
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

        partial void btnComentar_Touch(UIButton sender)
        {
            UIAlertController actionSheetAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);
            actionSheetAlert.AddAction(this.EliminarPublicacion());
            actionSheetAlert.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, null));
            EventosImagenComentarDel.EnviarAction(actionSheetAlert);  
        }

        private UIAlertAction EliminarPublicacion()
        {
            UIAlertAction Eliminar = UIAlertAction.Create("Eliminar publicación", UIAlertActionStyle.Default, (action) =>
            {
                var PublicacionEliminada = new Controllers.EscritorioController().OcultarComment(comentarioLocal.Usuario.Usuario_Id, comentarioLocal.Usuario.Usuario_Tipo, comentarioLocal.Publicacion_Id, comentarioLocal.Comentario_Id);
                if (PublicacionEliminada)
                {
                    EventosImagenComentarDel.ActualizarTabla();
                }
            });
            return Eliminar;
        }
    }
}