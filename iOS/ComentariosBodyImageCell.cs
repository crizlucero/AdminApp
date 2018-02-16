using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using CoreGraphics;
using System.Collections.Generic;


namespace WorklabsMx.iOS
{

    public interface EventosComentarios
    {
        void MostrarImagenEnGrande(UIImageView imgPublicacion);
        void ComentarPost(PostModel PostLocal);
        void InfoUserPost(UsuarioModel listaUser);
        void EnviarActions(UIAlertController actionSheetAlert);
        void ActualizaTabla();
    }


    public partial class ComentariosBodyImageCell : UITableViewCell
    {
 

        public EventosComentarios EventosComentariosDelegate;

        PostModel PostLocal;

        string transaccion = "ALTA";

        public ComentariosBodyImageCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(PostModel post, UIImage currentImageProfile, UIImage CurrentImagePost)
        {
            var Tap = new UITapGestureRecognizer(this.ImageTapped);
            imgPublicacion.UserInteractionEnabled = true;
            imgPublicacion.AddGestureRecognizer(Tap);

            if (post.Usuario.Usuario_Id == KeyChainHelper.GetKey("Usuario_Id") && post.Usuario.Usuario_Tipo == KeyChainHelper.GetKey("Usuario_Tipo"))
            {
                this.btnOpciones.Hidden = false;
                this.btnOpciones.Enabled = true;
            }
            else
            {
                this.btnOpciones.Hidden = true;
                this.btnOpciones.Enabled = false;
            }
            lblNombre.Text = post.Usuario.Usuario_Nombre;
            lblLikes.Text = post.Publicacion_Me_Gustan_Cantidad + " LIKES";
            if (int.Parse(post.Publicacion_Me_Gustan_Cantidad) == 0)
            {
                this.btnLikes.SetImage(UIImage.FromBundle("NoLike"), UIControlState.Normal);
            }
            else
            {
                this.btnLikes.SetImage(UIImage.FromBundle("Likes"), UIControlState.Normal);
            }
            lblFechaPost.Text = post.Publicacion_Fecha;
            lblComentarios.Text = post.Publicacion_Comentarios_Cantidad + " COMENTARIOS";

            if (int.Parse(post.Publicacion_Comentarios_Cantidad) == 0)
            {
                this.imgComentarios.Image = UIImage.FromBundle("NoCom");
            }
            else
            {
                this.imgComentarios.Image = UIImage.FromBundle("Comments");
            }
            imgPublicacion.Image = CurrentImagePost;
            txtComentario.TranslatesAutoresizingMaskIntoConstraints = false;
            txtComentario.ScrollEnabled = false;
            txtComentario.Text = post.Publicacion_Contenido;
            StyleHelper.Style(vwVistaComentario.Layer);
            btnImgPerfil.SetBackgroundImage(currentImageProfile ?? UIImage.FromBundle("PerfilEscritorio"), UIControlState.Normal);
            PostLocal = post;
        }

        private void ImageTapped(UITapGestureRecognizer Recognizer)
        {
            EventosComentariosDelegate.MostrarImagenEnGrande(imgPublicacion);
        }

        partial void btnLikes_Touch(UIButton sender)
        {
            if (PostLocal.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
            {
                transaccion = "BAJA";
            }
            else if (PostLocal.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
            {
                transaccion = "MODIFICAR";
            }

            if (new Controllers.EscritorioController().PostLike(PostLocal.Publicacion_Id, KeyChainHelper.GetKey("Usuario_Id"), KeyChainHelper.GetKey("Usuario_Tipo"), transaccion))
            {
                lblLikes.Text = new Controllers.EscritorioController().GetLikesPublish(PostLocal.Publicacion_Id) + " LIKES";

                if (transaccion == "BAJA")
                {
                    PostLocal.Publicacion_Me_Gusta_Usuario = (int.Parse(PostLocal.Publicacion_Me_Gusta_Usuario) - 1).ToString();
                    lblLikes.TextColor = UIColor.Black;
                }
                else
                {
                    PostLocal.Publicacion_Me_Gusta_Usuario = (int.Parse(PostLocal.Publicacion_Me_Gusta_Usuario) + 1).ToString();
                    lblLikes.TextColor = (UIColor.FromRGB(57, 87, 217));
                }
            }
            var likes = new Controllers.EscritorioController().GetLikesPublish(PostLocal.Publicacion_Id);
            if (int.Parse(likes) == 0)
            {
                this.btnLikes.SetImage(UIImage.FromBundle("NoLike"), UIControlState.Normal);
            }
            else
            {
                this.btnLikes.SetImage(UIImage.FromBundle("Likes"), UIControlState.Normal);
            }

        }

        partial void btnImagePerfil_Touch(UIButton sender)
        {
            EventosComentariosDelegate.InfoUserPost(PostLocal.Usuario);
        }

        partial void btnComentarios_Touch(UIButton sender)
        {
            EventosComentariosDelegate.ComentarPost(PostLocal);
        }

        partial void btnOpciones_Toouch(UIButton sender)
        {
            UIAlertController actionSheetAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);
            actionSheetAlert.AddAction(this.EliminarPublicacion());
            actionSheetAlert.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, null));
            EventosComentariosDelegate.EnviarActions(actionSheetAlert);  
        }

        private UIAlertAction EliminarPublicacion()
        {
            UIAlertAction Eliminar = UIAlertAction.Create("Eliminar publicación", UIAlertActionStyle.Default, (action) =>
            {
                var PublicacionEliminada = new Controllers.EscritorioController().OcultarPost(PostLocal.Usuario.Usuario_Id, PostLocal.Usuario.Usuario_Tipo, PostLocal.Publicacion_Id);
                if (PublicacionEliminada)
                {
                    EventosComentariosDelegate.ActualizaTabla();
                }
            });
            return Eliminar;
        }
    }
}