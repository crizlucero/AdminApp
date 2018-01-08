using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using CoreGraphics;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class ComentariosBodyCell : UITableViewCell
    {

        PostModel PostLocal;
        //SimpleStorage storageLocal;

        public event EventHandler MostrarImagenEnGrande;

        public event EventHandler ComentarPost;

        public event EventHandler InfoUserPost;

        string transaccion = "ALTA";

        public ComentariosBodyCell (IntPtr handle) : base (handle)
        {
            
        }

        internal void UpdateCell(PostModel post, UIImage currentImageProfile, UIImage currentImagePost)
        {
            lblNombre.Text = post.Usuario_Nombre;
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

            if(int.Parse(post.Publicacion_Comentarios_Cantidad) == 0)
            {
                this.imgComentarios.Image = UIImage.FromBundle("NoCom");
            }
            else 
            {
                this.imgComentarios.Image = UIImage.FromBundle("Comments");
            }

            if (currentImagePost != null)
            {
                var newFrame = new CGRect(btnImagenComentatio.Frame.X, btnImagenComentatio.Frame.Y, btnImagenComentatio.Frame.Width, 400);
                btnImagenComentatio.Frame = newFrame;
                btnImagenComentatio.SetBackgroundImage(currentImagePost, UIControlState.Normal);
            }
            else if (post.Publicacion_Imagen_Ruta == "" || currentImagePost == null)
            {
                var newFrame = new CGRect(btnImagenComentatio.Frame.X, btnImagenComentatio.Frame.Y, btnImagenComentatio.Frame.Width, 1);
                btnImagenComentatio.Frame = newFrame;
                //btnImagenComentatio.SetBackgroundImage(currentImagePost, UIControlState.Normal);
            }
            txtComentario.TranslatesAutoresizingMaskIntoConstraints = false;
            txtComentario.ScrollEnabled = false;
            txtComentario.Text = post.Publicacion_Contenido;

            //post.Miembro_Id, post.Colaborador_Empresa_Id, post.Usuario_Tipo

            StyleHelper.Style(vwVistaComentario.Layer);
            btnImgPerfil.SetBackgroundImage(currentImageProfile ?? UIImage.FromBundle("PerfilEscritorio"), UIControlState.Normal);

            PostLocal = post;
        }

        partial void btnLikes_TouchUpInside(UIButton sender)
        {
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


        partial void btnComentarPost_TouchUpInside(UIButton sender)
        {
            if (ComentarPost != null)
            {
                ComentarPost(PostLocal, EventArgs.Empty);
            }
        }

        private void btnImagenComentario_Touch(UIImage ImagenComentario)
        {
            if (MostrarImagenEnGrande != null)
            {
                MostrarImagenEnGrande(ImagenComentario, EventArgs.Empty);
            }
        }

        partial void btnImgPerfil_Touch(UIButton sender)
        {
            if (InfoUserPost != null)
            {
                //string[] ArrayUserPost = { PostLocal.Miembro_Id, PostLocal.Colaborador_Empresa_Id, PostLocal.Usuario_Tipo};
                List<String> listaUser = new List<string>();
                listaUser.Add(PostLocal.Miembro_Id);
                listaUser.Add(PostLocal.Colaborador_Empresa_Id);
                listaUser.Add(PostLocal.Usuario_Tipo);
                listaUser.Add(PostLocal.Usuario_Fotografia_Ruta);
                InfoUserPost(listaUser, EventArgs.Empty);
            }
            
        }
    }
}