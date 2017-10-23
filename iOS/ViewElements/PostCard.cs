using System;
using System.Collections.Generic;
using CoreGraphics;
using PerpetualEngine.Storage;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;
using WorklabsMx.Enum;

namespace WorklabsMx.iOS.ViewElements
{
    public class PostCard : UIView
    {
        public List<CommentCard> PostComments;
        public int totalSize, comentarioCount, comentarioSize, usrTipo;
        public UIButton lblNombre, btnDelete;
        SimpleStorage storageLocal;
        UIViewController owner;
        public bool image = false;
        public PostCard(PostModel post, UIViewController owner)
        {
            this.owner = owner;
            storageLocal = SimpleStorage.EditGroup("Login");
            PostComments = new List<CommentCard>();
            AddSubview(new STLLine(2));
            UIButton pstImage = new UIButton
            {
                Frame = new CGRect(10, 20, 50, 50)
            };
            pstImage.SetImage(ImageGallery.LoadImage(post.Usuario_Fotografia_Ruta), UIControlState.Normal);
            pstImage.Layer.MasksToBounds = true;
            pstImage.Layer.CornerRadius = 25;
            pstImage.TouchUpInside += (sender, e) =>
            {
                new MessageDialog().ShowImage(ImageGallery.LoadImage(post.Usuario_Fotografia_Ruta));
            };
            AddSubview(pstImage);

            lblNombre = new STLButton(post.Usuario_Nombre)
            {
                Frame = new CGRect(65, 25, UIScreen.MainScreen.Bounds.Width, 20),
                Font = UIFont.BoldSystemFontOfSize(16),
                BackgroundColor = UIColor.Clear,
                HorizontalAlignment = UIControlContentHorizontalAlignment.Left
            };
            lblNombre.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            AddSubview(lblNombre);

            //Delete or report post
            btnDelete = new STLButton(UIImage.FromBundle("ic_clear"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 30, 25, 20, 20)
            };
            AddSubview(btnDelete);

            UILabel lblfecha = new STLLabel(post.Publicacion_Fecha, 45, 12)
            {
                Frame = new CGRect(65, 35, UIScreen.MainScreen.Bounds.Width, 50)
            };
            AddSubview(lblfecha);

            //Likes
            using (UIButton btnLike = new STLButton(new Controllers.EscritorioController().GetLikesPublish(post.Publicacion_Id) + " Like(s)", UIImage.FromBundle("ic_thumb_up"))
            {
                Frame = new CGRect(10, 75, UIScreen.MainScreen.Bounds.Width - 100, 20),
                Font = UIFont.SystemFontOfSize(10),
                BackgroundColor = UIColor.White,

            })
            {
                btnLike.TouchUpInside += (sender, e) =>
                 {
                     btnLike.BackgroundColor = UIColor.White;

                     string transaccion = "ALTA";
                    if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                     {
                         transaccion = "BAJA";
                     }
                    else if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Baja).ToString())
                     {
                         transaccion = "MODIFICAR";
                     }
                    if (new Controllers.EscritorioController().PostLike(post.Publicacion_Id, storageLocal.Get("Usuario_Id"), storageLocal.Get("Usuario_Tipo"), transaccion))
                     {
                        //lblLikes.Text = new Controllers.EscritorioController().GetLikesPublish(post.Publicacion_Id) + " LIKES";
                         if (transaccion == "BAJA")
                         {
                            post.Publicacion_Me_Gusta_Usuario = "0";
                             //lblLikes.TextColor = UIColor.Black;
                         }
                         else
                         {
                            post.Publicacion_Me_Gusta_Usuario = "1";
                             //lblLikes.TextColor = (UIColor.FromRGB(57, 87, 217));
                         }
                     }
                    if (post.Publicacion_Me_Gusta_Usuario == ((int)TiposMeGusta.Activo).ToString())
                     {
                         //lblLikes.TextColor = (UIColor.FromRGB(57, 87, 217));
                     }

                    /*if (new Controllers.EscritorioController().PostLike(post.Publicacion_Id, SimpleStorage.EditGroup("Login").Get("Usuario_Id"), SimpleStorage.EditGroup("Login").Get("Usuario_Tipo")))
                        btnLike.SetTitle(new Controllers.EscritorioController().GetLikesPublish(post.Publicacion_Id) + " Like(s)", UIControlState.Normal);*/
                 };
                btnLike.TouchDown += (sender, e) =>
                {
                    btnLike.BackgroundColor = UIColor.LightGray;

                };
                AddSubview(btnLike);
            }

            if (post.Publicacion_Imagen_Ruta != "")
            {
                UIImageView imgPost = new STLImageView(110, post.Publicacion_Imagen_Ruta)
                {
                    Frame = new CGRect(10, 140, UIScreen.MainScreen.Bounds.Width - 100, 100)
                };
                AddSubview(imgPost);
                totalSize += 160;
                image = true;
            }

            UILabel txtPost = new UILabel
            {
                Frame = new CGRect(10, 110 + totalSize, UIScreen.MainScreen.Bounds.Width - 10, 30),
                Text = post.Publicacion_Contenido,
                Font = UIFont.SystemFontOfSize(16),
                LineBreakMode = UILineBreakMode.WordWrap,
                Lines = 0
            };
            int postSize = 30 * Convert.ToInt32(Math.Floor(txtPost.IntrinsicContentSize.Width / (UIScreen.MainScreen.Bounds.Width - 10)));
            txtPost.Frame = new CGRect(10, 110 + totalSize, UIScreen.MainScreen.Bounds.Width - 10, 30 + postSize);
            AddSubview(txtPost);
            totalSize += postSize;
            #region Comentarios
            AddComentarios(post);
            #endregion
        }

        void AddComentarios(PostModel post)
        {
            List<ComentarioModel> comentarios = new Controllers.EscritorioController().GetComentariosPost(post.Publicacion_Id);
            if (comentarios.Count > 0)
            {
                int commentSize = 0;
                int viewSize = 200;
                if (comentarios.Count < 4)
                    viewSize = 60 * comentarios.Count;
                UIView commentView = new UIView(new CGRect(0, 170 + totalSize, UIScreen.MainScreen.Bounds.Width, viewSize));
                UIScrollView commentScroll = new UIScrollView(new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, viewSize));
                foreach (ComentarioModel comentario in comentarios)
                {
                    CommentCard comment = new CommentCard(comentario, owner)
                    {
                        Frame = new CGRect(0, commentSize, UIScreen.MainScreen.Bounds.Width, 80)
                    };
                    PostComments.Add(comment);
                    commentScroll.AddSubview(PostComments[comentarioCount]);

                    UIButton btnCommentDelete = new STLButton(UIImage.FromBundle("ic_clear"))
                    {
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 30, 20 + commentSize, 20, 20)
                    };
                    btnCommentDelete.TouchUpInside += (sender, e) =>
                    {
                        if (comentario.Miembro_Id == storageLocal.Get("Usuario_Id") && comentario.Usuario_Tipo == storageLocal.Get("Usuario_Tipo"))
                        {
                            new MessageDialog().SendConfirmation("Se eliminará el comentario", "Borrar comentario", (obj) =>
                           {
                               if (obj)
                                   if (new Controllers.EscritorioController().OcultarComment(comentario.Comentario_Id, 0))
                                   {
                                       new MessageDialog().SendToast("Comentario eliminado");
                                       commentScroll.RemoveFromSuperview();
                                       AddComentarios(post);
                                   }
                                   else
                                       new MessageDialog().SendToast("Hubo un error, intente de nuevo");
                           });
                        }
                        else
                            new MessageDialog().SendConfirmation("¿Desea reportar el comentario?", "Reportar comentario", (obj) =>
                            {
                                if (obj)
                                {
                                    ReporteController reporteController = (ReporteController)owner.Storyboard.InstantiateViewController("ReporteController");
                                    reporteController.comment_id = comentario.Comentario_Id;
                                    reporteController.Title = "Reportar Post";
                                    owner.NavigationController.PushViewController(reporteController, true);
                                    ((UIButton)sender).BackgroundColor = UIColor.Clear;
                                }
                            });
                    };
                    commentScroll.AddSubview(btnCommentDelete);

                    commentSize += 80;
                    ++comentarioCount;
                }
                commentScroll.ContentSize = new CGSize(UIScreen.MainScreen.Bounds.Width, commentSize);
                commentView.AddSubview(commentScroll);
                commentView.BringSubviewToFront(commentScroll);
                AddSubview(commentView);
                totalSize += viewSize;
            }
        }

        public void ResizeCommentCard()
        {
            foreach (CommentCard comment in PostComments)
            {
                comment.Frame = new CGRect();
            }
        }
    }
}