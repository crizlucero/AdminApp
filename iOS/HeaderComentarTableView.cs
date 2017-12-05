using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using System.Collections.Generic;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using CoreGraphics;


namespace WorklabsMx.iOS
{
    public partial class HeaderComentarTableView : UITableViewCell
    {
        public HeaderComentarTableView (IntPtr handle) : base (handle)
        {
        }

        partial void btnLikes_TouchUpInSide(UIButton sender)
        {
            
        }


        internal void UpdateCell(PostModel Publicacion, UIImage currentImageProfile, UIImage currentImagePost) 
        {
            lblNombre.Text = Publicacion.Usuario_Nombre;
            lblLikes.Text = Publicacion.Publicacion_Me_Gustan_Cantidad + " LIKES";
            lblFechaComentario.Text = Publicacion.Publicacion_Fecha;
            lblComentarios.Text = Publicacion.Publicacion_Comentarios_Cantidad + " COMENTARIOS";

            txtComentario.TranslatesAutoresizingMaskIntoConstraints = false;
            txtComentario.ScrollEnabled = false;

            txtComentario.Text = Publicacion.Publicacion_Contenido;

            imgPerfil.Image = currentImageProfile;
            if (Publicacion.Publicacion_Imagen_Ruta != "")
            {
                btnImagenComentario.TranslatesAutoresizingMaskIntoConstraints = false;
                btnImagenComentario.ImageView.Image = currentImagePost;
                btnImagenComentario.Hidden = false;
                btnImagenComentario.Enabled = true;
                btnImagenComentario.Frame = new CGRect(btnImagenComentario.Frame.X, btnImagenComentario.Frame.Y, btnImagenComentario.Frame.Width, btnImagenComentario.Frame.Width);
            }
            else
            {
                btnImagenComentario.Hidden = true;
                btnImagenComentario.Enabled = false;
            }
        }

        partial void btnComentarios_TouchUpInside(UIButton sender)
        {
        }

        partial void btnImagenComentarios_TouchUpInside(UIButton sender)
        {
            
        }

        partial void btnComentar_TouchUpInside(UIButton sender)
        {
            
        }
    }
}