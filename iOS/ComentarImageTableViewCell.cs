using System;
using UIKit;
using WorklabsMx.Models;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Enum;
using System.Threading.Tasks;
using WorklabsMx.Controllers;
using BigTed;
using WorklabsMx.Helpers;
using Foundation;
using System.Collections.Generic;

namespace WorklabsMx.iOS
{

    public interface EventosImagen
    {
        void MostrarImagenEnGrandes(UIImageView Imagen);
        void EnviarActions(UIAlertController actionSheetAlert);
        void ActualizaTabla();
        void ImagenPublicada(List<string> FotosId);
        void ImagenPerfilPublicada(List<string> FotosPerfilId);
    }

    public partial class ComentarImageTableViewCell : UITableViewCell
    {
        ComentarioModel comentarioLocal;
        public EventosImagen EventosImagenDel;

        public ComentarImageTableViewCell (IntPtr handle) : base (handle)
        {
        }

        async internal void UpdateCell(ComentarioModel comentario, List<string> FotosId, List<string> FotosPerfilId)
        {
            var Tap = new UITapGestureRecognizer(this.ImageTapped);
            imgPublicacion.UserInteractionEnabled = true;
            imgPublicacion.AddGestureRecognizer(Tap);
            if (comentario.Usuario.Usuario_Id == KeyChainHelper.GetKey("Usuario_Id") && comentario.Usuario.Usuario_Tipo == KeyChainHelper.GetKey("Usuario_Tipo"))
            {
                this.btnComentar.Hidden = false;
                this.btnComentar.Enabled = true;
            }
            else
            {
                this.btnComentar.Hidden = true;
                this.btnComentar.Enabled = false;
            }
            if (int.Parse(comentario.Comentario_Me_Gustan_Cantidad) == 0)
            {
                this.btnLikes.SetImage(UIImage.FromBundle("NoLike"), UIControlState.Normal);
            }
            else
            {
                this.btnLikes.SetImage(UIImage.FromBundle("Likes"), UIControlState.Normal);
            }

            lblNombre.Text = comentario.Usuario.Usuario_Nombre;
            lblLikes.Text = comentario.Comentario_Me_Gustan_Cantidad + " LIKES";
            lblFecha.Text = comentario.Comentario_Fecha;
            txtComentario.TranslatesAutoresizingMaskIntoConstraints = false;
            txtComentario.ScrollEnabled = false;
            txtComentario.Text = comentario.Comentario_Contenido;

            await GetImagenesComment(comentario, FotosId, FotosPerfilId);

            comentarioLocal = comentario;

        }


        async Task GetImagenesComment(ComentarioModel comentario, List<string> FotosId, List<string> FotosPerfilId)
        {
            UIImage ReescalImage = new UIImage();
            UIImage ReescalImageUsr = new UIImage();
            await Task.Run(() =>
            {
                if (comentario.Comentario_Imagen_Comentario == null)
                {
                    var result = FotosId.Find(x => x == comentario.Comentario_Imagen);
                    if(result == null || result == "")
                    {
                        comentario.Comentario_Imagen_Comentario = new UploadImages().DownloadFileFTP(comentario.Comentario_Imagen, MenuHelper.UploadImagePath);
                        FotosId.Add(comentario.Comentario_Imagen);
                        EventosImagenDel.ImagenPublicada(FotosId);
                    }

                }

                if (comentario.Comentario_Imagen_Comentario.Length > 0)
                {
                    var data = NSData.FromArray(comentario.Comentario_Imagen_Comentario);
                    var uiimage = UIImage.LoadFromData(data);
                    ReescalImage = ImageHelper.ReescalImage(uiimage);
                }

                if ((comentario.Usuario.Usuario_Fotografia != "" && comentario.Usuario.Usuario_Fotografia != null && comentario.Usuario.Usuario_Fotografia != "user_male.png"))
                {
                    if (comentario.Usuario.Usuario_Fotografia_Perfil == null)
                    {
                        var result = FotosPerfilId.Find(x => x == comentario.Usuario.Usuario_Fotografia);
                        if (result == null || result == "")
                        {
                            comentario.Usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(comentario.Usuario.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                            FotosPerfilId.Add(comentario.Usuario.Usuario_Fotografia);
                            EventosImagenDel.ImagenPerfilPublicada(FotosPerfilId);
                        }
                    }
                    else if (comentario.Usuario.Usuario_Fotografia_Perfil.Length == 0)
                    {
                        ReescalImageUsr = UIImage.FromBundle("PerfilEscritorio");
                    }
                    else
                    {
                        var data = NSData.FromArray(comentario.Usuario.Usuario_Fotografia_Perfil);
                        var uiimage = UIImage.LoadFromData(data);
                        ReescalImageUsr = ImageHelper.ReescalProfileImage(uiimage);
                    }
                   
                }
                else
                {
                    ReescalImageUsr = UIImage.FromBundle("PerfilEscritorio");
                }

            });
            imgPublicacion.Image = ReescalImage;
            imgPerfil.Image = ReescalImageUsr;
        }


        private void ImageTapped(UITapGestureRecognizer Recognizer)
        {
            EventosImagenDel.MostrarImagenEnGrandes(imgPublicacion);
        }


        partial void btnLikes_TouchUpInside(UIButton sender)
        {
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
            EventosImagenDel.EnviarActions(actionSheetAlert);  
        }

        private UIAlertAction EliminarPublicacion()
        {
            UIAlertAction Eliminar = UIAlertAction.Create("Eliminar comentario", UIAlertActionStyle.Default, (action) =>
            {
                var PublicacionEliminada = new Controllers.EscritorioController().OcultarComment(comentarioLocal.Usuario.Usuario_Id, comentarioLocal.Usuario.Usuario_Tipo, comentarioLocal.Publicacion_Id, comentarioLocal.Comentario_Id);
                if (PublicacionEliminada)
                {
                    EventosImagenDel.ActualizaTabla();
                }
            });
            return Eliminar;
        }
    }
}