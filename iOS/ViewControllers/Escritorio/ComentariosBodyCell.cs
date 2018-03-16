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
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{

    public interface EventosComentariosBody
    {
        void ComentarPosts(PostModel PostLocal);
        void InfoUserPosts(UsuarioModel listaUser);
        void EnviarAction(UIAlertController actionSheetAlert);
        void ActualizarTabla();
    }

    public partial class ComentariosBodyCell : UITableViewCell
    {
        PostModel PostLocal;

        string transaccion = "ALTA";

        public EventosComentariosBody EventosComentariosBodyDel;

        public ComentariosBodyCell (IntPtr handle) : base (handle)
        {
            
        }

        async internal void UpdateCell(PostModel post)
        {
            lblNombre.Text = post.Usuario.Usuario_Nombre;
            lblLikes.Text = post.Publicacion_Me_Gustan_Cantidad + " LIKES";
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

            await GetImagenesPost(post);
            txtComentario.TranslatesAutoresizingMaskIntoConstraints = false;
            txtComentario.ScrollEnabled = false;
            txtComentario.Text = post.Publicacion_Contenido;
            StyleHelper.Style(vwVistaComentario.Layer);
            PostLocal = post;
        }


        async Task GetImagenesPost(PostModel post)
        {

            UIImage ReescalImage = new UIImage();
            if ((post.Usuario.Usuario_Fotografia != "" && post.Usuario.Usuario_Fotografia != null))
            {
                await Task.Run(() =>
                {
                    if (post.Usuario.Usuario_Fotografia_Perfil == null)
                    {
                        post.Usuario.Usuario_Fotografia_Perfil = new UploadImages().DownloadFileFTP(post.Usuario.Usuario_Fotografia, MenuHelper.ProfileImagePath);
                    }
                    else if (post.Usuario.Usuario_Fotografia_Perfil.Length == 0)
                    {
                        ReescalImage = UIImage.FromBundle("PerfilEscritorio");
                    }
                    else
                    {
                        var data = NSData.FromArray(post.Usuario.Usuario_Fotografia_Perfil);
                        var uiimage = UIImage.LoadFromData(data);
                        ReescalImage = uiimage;
                    }
                   
                });
            }
            btnImgPerfil.SetBackgroundImage(ReescalImage ?? UIImage.FromBundle("PerfilEscritorio"), UIControlState.Normal);

        }


        partial void btnLikes_TouchUpInside(UIButton sender)
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


        partial void btnComentarPost_TouchUpInside(UIButton sender)
        {
            EventosComentariosBodyDel.ComentarPosts(PostLocal);
        }


        partial void btnImgPerfil_Touch(UIButton sender)
        {
            EventosComentariosBodyDel.InfoUserPosts(PostLocal.Usuario);
        }

        partial void btnOpciones_Touch(UIButton sender)
        {
            UIAlertController actionSheetAlert = UIAlertController.Create(null, null, UIAlertControllerStyle.ActionSheet);
            actionSheetAlert.AddAction(this.EliminarPublicacion());
            actionSheetAlert.AddAction(UIAlertAction.Create("Cancelar", UIAlertActionStyle.Cancel, null));
            EventosComentariosBodyDel.EnviarAction(actionSheetAlert);        
        }
        private UIAlertAction EliminarPublicacion()
        {
            UIAlertAction Eliminar = UIAlertAction.Create("Eliminar comentario", UIAlertActionStyle.Default, (action) =>
            {
                var PublicacionEliminada = new Controllers.EscritorioController().OcultarPost(PostLocal.Usuario.Usuario_Id, PostLocal.Usuario.Usuario_Tipo, PostLocal.Publicacion_Id);
                if (PublicacionEliminada)
                {
                    EventosComentariosBodyDel.ActualizarTabla();
                }
            });
            return Eliminar;
        }
    }
}