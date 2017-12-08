using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using CoreGraphics;
using WorklabsMx.Enum;


namespace WorklabsMx.iOS
{
    public partial class HeaderComentarTableView : UITableViewCell
    {

        PostModel PostLocal;

        public HeaderComentarTableView(IntPtr handle) : base(handle)
        {


        }

        internal void UpdateCell(PostModel Publicacion, UIImage currentImageProfile, UIImage currentImagePost) 
        {
            lblNombre.Text = Publicacion.Usuario_Nombre;
            lblLikes.Text = Publicacion.Publicacion_Me_Gustan_Cantidad + " LIKES";
            lblFechaComentario.Text = Publicacion.Publicacion_Fecha;
            lblComentarios.Text = Publicacion.Publicacion_Comentarios_Cantidad + " COMENTARIOS";

            txtComentario.ScrollEnabled = true;

            txtComentario.Text = Publicacion.Publicacion_Contenido;

            imgPerfil.Image = currentImageProfile ?? UIImage.FromBundle("PerfilEscritorio");
            if (Publicacion.Publicacion_Imagen_Ruta != "")
            {
                btnImagenComentario.SetBackgroundImage(currentImagePost, UIControlState.Normal);
            }
            else
            {
                btnImagenComentario = new UIButton(new CGRect(0, 0, 0, 0));
            }

            PostLocal = Publicacion;
        }

        partial void btnLikes_TouchUpInSide(UIButton sender)
        {
            string transaccion = "ALTA";
            //var storageLocal = PerpetualEngine.Storage.SimpleStorage.EditGroup("Login");
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
        }

        partial void btnComentarios_TouchUpInside(UIButton sender)
        {
        }

        partial void btnImagenComentarios_TouchUpInside(UIButton sender)
        {
            
        }

    }
}