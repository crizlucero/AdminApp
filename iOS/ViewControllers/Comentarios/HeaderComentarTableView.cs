using System;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;
using CoreGraphics;
using WorklabsMx.Enum;
using System.Threading.Tasks;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using Foundation;

namespace WorklabsMx.iOS
{
    public partial class HeaderComentarTableView : UITableViewCell
    {

        PostModel PostLocal;

        public HeaderComentarTableView(IntPtr handle) : base(handle)
        {


        }

        async internal void UpdateCell(PostModel Publicacion) 
        {

            lblLikes.Text = Publicacion.Publicacion_Me_Gustan_Cantidad + " LIKES";
            if (int.Parse(Publicacion.Publicacion_Me_Gustan_Cantidad) == 0)
            {
                this.btnLikes.SetImage(UIImage.FromBundle("NoLike"), UIControlState.Normal);
            }
            else
            {
                this.btnLikes.SetImage(UIImage.FromBundle("Likes"), UIControlState.Normal);
            }

            if (int.Parse(Publicacion.Publicacion_Comentarios_Cantidad) == 0)
            {
                this.imgComentarios.Image = UIImage.FromBundle("NoCom");
            }
            else
            {
                this.imgComentarios.Image = UIImage.FromBundle("Comments");
            }

            lblNombre.Text = Publicacion.Usuario.Usuario_Nombre;
            lblLikes.Text = Publicacion.Publicacion_Me_Gustan_Cantidad + " LIKES";
            lblFechaComentario.Text = Publicacion.Publicacion_Fecha;
            lblComentarios.Text = Publicacion.Publicacion_Comentarios_Cantidad + " COMENTARIOS";

            txtComentario.ScrollEnabled = true;

            txtComentario.Text = Publicacion.Publicacion_Contenido;
            await GetImagenesPost(Publicacion);
            PostLocal = Publicacion;
        }


        async Task GetImagenesPost(PostModel post)
        {
            UIImage ReescalImage = new UIImage();
            UIImage ReescalImageUsr = new UIImage();
            await Task.Run(() =>
            {

                if(post.Publicacion_Imagen_Ruta != "" && post.Publicacion_Imagen_Ruta != null)
                {
                    if (post.Publicacion_Imagen_Post == null)
                    {
                        post.Publicacion_Imagen_Post = new UploadImages().DownloadFileFTP(post.Publicacion_Imagen, MenuHelper.UploadImagePath);
                    }
                    else if (post.Publicacion_Imagen_Post.Length == 0)
                    {
                        post.Publicacion_Imagen_Post = new UploadImages().DownloadFileFTP(post.Publicacion_Imagen, MenuHelper.UploadImagePath);
                    }

                    if (post.Publicacion_Imagen_Post.Length > 0)
                    {
                        var data = NSData.FromArray(post.Publicacion_Imagen_Post);
                        var uiimage = UIImage.LoadFromData(data);
                        ReescalImage = ImageHelper.ReescalImage(uiimage);
                    }

                   
                }
            

                if ((post.Usuario.Usuario_Fotografia != "" && post.Usuario.Usuario_Fotografia != null && post.Usuario.Usuario_Fotografia != "user_male.png"))
                {
                    if (post.Usuario.Usuario_Fotografia_Perfil == null)
                    {
                        post.Usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(post.Usuario.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                    }

                    if (post.Usuario.Usuario_Fotografia_Perfil.Length == 0)
                    {
                        ReescalImageUsr = UIImage.FromBundle("PerfilEscritorio");
                    }
                    else
                    {
                        var data = NSData.FromArray(post.Usuario.Usuario_Fotografia_Perfil);
                        var uiimage = UIImage.LoadFromData(data);
                        ReescalImageUsr = ImageHelper.ReescalProfileImage(uiimage);
                    }

                }
                else
                {
                    ReescalImageUsr = UIImage.FromBundle("PerfilEscritorio");
                }

            });
            btnImagenComentario.SetBackgroundImage(ReescalImage, UIControlState.Normal);
            imgPerfil.Image = ReescalImageUsr;
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