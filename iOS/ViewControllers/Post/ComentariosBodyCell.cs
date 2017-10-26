using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class ComentariosBodyCell : UITableViewCell
    {

        PostModel PostLocal;
        //SimpleStorage storageLocal;

        public event EventHandler MostrarImagenEnGrande;

        public event EventHandler ComentarPost;

        string transaccion = "ALTA";


        public ComentariosBodyCell (IntPtr handle) : base (handle)
        {
            
        }

        internal void UpdateCell(PostModel post, UIImage currentImageProfile, UIImage currentImagePost)
        {
            lblNombre.Text = post.Usuario_Nombre;
            lblLikes.Text = post.Publicacion_Me_Gustan_Cantidad + " LIKES";
            lblFechaPost.Text = post.Publicacion_Fecha;
            //lblOcupacion.Text = post.Miembro_Puesto;
            lblComentarios.Text = post.Publicacion_Comentarios_Cantidad + " COMENTARIOS";
            lblDetalleComentario.Text = post.Publicacion_Contenido;

            StyleHelper.Style(vwVistaComentario.Layer);

            imgPerfil.Image = currentImageProfile;

            if (post.Publicacion_Imagen_Ruta != "")
            {
                btnImagenComentatio.ImageView.Image = currentImagePost;
                btnImagenComentatio.Hidden = false;
                btnImagenComentatio.Enabled = true;
            }
            else
            {
                btnImagenComentatio.Hidden = true;
                btnImagenComentatio.Enabled = false;
                btnImagenComentatio.Frame = new CGRect(btnImagenComentatio.Frame.X, btnImagenComentatio.Frame.Y, btnImagenComentatio.Frame.Width, 0);

                //btnImagenComentatio.Frame.Size.Height = 0;
            }

            PostLocal = post;
        }

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
            var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
            if (PostLocal.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
            {
                transaccion = "BAJA";
            }
            else if (PostLocal.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
            {
                transaccion = "MODIFICAR";
            }

            if (new Controllers.EscritorioController().PostLike(PostLocal.Publicacion_Id, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"), transaccion))
            {
                lblLikes.Text = new Controllers.EscritorioController().GetLikesPublish(PostLocal.Publicacion_Id) + " LIKES";

                if (transaccion == "BAJA")
                {
                    PostLocal.Publicacion_Me_Gusta_Usuario = "0";
                    lblLikes.TextColor = UIColor.Black;
                }
                else
                {
                    PostLocal.Publicacion_Me_Gusta_Usuario = "1";
                    lblLikes.TextColor = (UIColor.FromRGB(57, 87, 217));
                }
            }


        }

        partial void btnImagenComentatio_touchUpInside(UIButton sender)
        {
            if (MostrarImagenEnGrande != null)
            {
                MostrarImagenEnGrande(sender.ImageView, EventArgs.Empty);
            }
        }

        partial void btnComentarPost_TouchUpInside(UIButton sender)
        {
            if (ComentarPost != null)
            {
                ComentarPost(PostLocal, EventArgs.Empty);
            }
        }    
    
    }
}