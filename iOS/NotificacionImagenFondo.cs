using Foundation;
using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using System.Threading.Tasks;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using CoreGraphics;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{
    public partial class NotificacionImagenFondo : UITableViewCell
    {

        public EventosComentarios EventosComentariosDelegate;

        PostModel PostLocal;

        string transaccion = "ALTA";

        List<UsuarioModel> UsuariosLikes;

        public NotificacionImagenFondo(IntPtr handle) : base(handle)
        {
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

        partial void btnC(UIButton sender)
        {
            EventosComentariosDelegate.ComentarPost(PostLocal);
        }

        partial void btnOpciones_Touch(UIButton sender)
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

        async internal void UpdateCell(PostModel post)
        {
            var Tap = new UITapGestureRecognizer(this.ImageTapped);
            imgPerfil.UserInteractionEnabled = true;
            imgPerfil.AddGestureRecognizer(Tap);

            imgFondo.UserInteractionEnabled = true;
            imgFondo.AddGestureRecognizer(Tap);

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
            lblFechaPublicacion.Text = post.Publicacion_Fecha;
            lblComentarios.Text = post.Publicacion_Comentarios_Cantidad + " COMENTARIOS";

            if (int.Parse(post.Publicacion_Comentarios_Cantidad) == 0)
            {
                this.imgComentarios.Image = UIImage.FromBundle("NoCom");
            }
            else
            {
                this.imgComentarios.Image = UIImage.FromBundle("Comments");
            }
            await GetImagenesPost(post);
            //txtComentario.TranslatesAutoresizingMaskIntoConstraints = false;
            StyleHelper.Style(vwImagenFonde.Layer);
            PostLocal = post;

            UITapGestureRecognizer labelTap = new UITapGestureRecognizer(() =>
            {
                UsuariosLikes = new UsuariosController().GetUsuariosPublicacionMeGusta(post.Publicacion_Id);
                if (UsuariosLikes.Count > 0)
                {
                    EventosComentariosDelegate.LikePresionado(UsuariosLikes);
                }
            });

            lblLikes.UserInteractionEnabled = true;
            lblLikes.AddGestureRecognizer(labelTap);
        }


        async Task GetImagenesPost(PostModel post)
        {
            UIImage ReescaleImageBack = new UIImage();
            UIImage ReescalImageUsr = new UIImage();
            await Task.Run(() =>
            {
                if (post.Publicacion_Imagen_Post_Back == null)
                {
                    post.Publicacion_Imagen_Post_Back = new UploadImages().DownloadFileFTP(post.Publicacion_Imagen_Back, MenuHelper.UploadImagePath);
                }

                if (post.Publicacion_Imagen_Post_Back.Length > 0)
                {
                    var uiimage = DataToImage(post.Publicacion_Imagen_Post_Back);
                    ReescaleImageBack = ImageHelper.ReescalImage(uiimage);
                }
                else
                {
                    ReescaleImageBack = null;
                }


                if ((post.Usuario.Usuario_Fotografia != "" && post.Usuario.Usuario_Fotografia != null && post.Usuario.Usuario_Fotografia != "user_male.png"))
                {
                    if (post.Usuario.Usuario_Fotografia_Perfil == null)
                    {
                        post.Usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(post.Usuario.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                    }
                    if (post.Usuario.Usuario_Fotografia_Perfil.Length > 0)
                    {
                        ReescalImageUsr = DataToImage(post.Usuario.Usuario_Fotografia_Perfil);
                    }
                    else
                    {
                        ReescalImageUsr = UIImage.FromBundle("ProfileImageBig");
                    }
                }
                else
                {
                    ReescalImageUsr = UIImage.FromBundle("ProfileImageBig");
                }


            });
            imgFondo.Image = ReescaleImageBack;
            imgPerfil.Image = (ReescalImageUsr ?? UIImage.FromBundle("PerfilEscritorio"));
            if (imgPerfil.Image != null)
            {
                EventosComentariosDelegate.UpdateRows();
            }

        }

        private UIImage DataToImage(byte[] Fotografia_Perfil)
        {
            var data = NSData.FromArray(Fotografia_Perfil);
            var uiimage = UIImage.LoadFromData(data);
            return uiimage;
        }

        private void ImageTapped(UITapGestureRecognizer Recognizer)
        {
            EventosComentariosDelegate.MostrarImagenEnGrande(this.imgPerfil);
        }

    }
}