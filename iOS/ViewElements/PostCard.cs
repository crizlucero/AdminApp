using System;
using System.Collections.Generic;
using CoreGraphics;
using PerpetualEngine.Storage;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.iOS.Styles;
using WorklabsMx.Models;

namespace WorklabsMx.iOS.ViewElements
{
    public class PostCard : UIView
    {
        public int totalSize;
        public List<CommentCard> PostComments;
        public int comentarioCount;
        public int comentarioSize;
        public UIButton lblNombre;
        public int usrTipo;
        public UIButton btnDelete;
		public PostCard(PostModel post)
        {
            PostComments = new List<CommentCard>();
            UIButton pstImage = new UIButton()
            {

                Frame = new CGRect(10, 20, 50, 50)
            };
            pstImage.SetImage(ImageGallery.LoadImage(post.Miembro_Fotografia), UIControlState.Normal);
            pstImage.Layer.MasksToBounds = true;
            pstImage.Layer.CornerRadius = 25;
            pstImage.TouchUpInside += (sender, e) =>
            {
                new MessageDialog().ShowImage(ImageGallery.LoadImage(post.Miembro_Fotografia));
            };
            Add(pstImage);

            lblNombre = new STLButton(post.Miembro_Nombre + " " + post.Miembro_Apellidos)
            {
                Frame = new CGRect(65, 25, UIScreen.MainScreen.Bounds.Width, 20),
                Font = UIFont.BoldSystemFontOfSize(16),
                BackgroundColor = UIColor.Clear,
                HorizontalAlignment = UIControlContentHorizontalAlignment.Left
            };
            lblNombre.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            Add(lblNombre);

            //Delete or report post
            btnDelete = new STLButton(UIImage.FromBundle("ic_clear"))
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.Width - 30, 25, 20,20) 
            };
            Add(btnDelete);

            UILabel lblfecha = new STLLabel(post.POST_FECHA, 45, 12)
            {
                Frame = new CGRect(65, 35, UIScreen.MainScreen.Bounds.Width, 50)
            };
            Add(lblfecha);

            //Likes
            using (UIButton btnLike = new STLButton(new Controllers.EscritorioController().GetLikes(post.POST_ID) + " Like(s)", UIImage.FromBundle("ic_thumb_up"))
            {
                Frame = new CGRect(10, 75, UIScreen.MainScreen.Bounds.Width - 100, 20),
                Font = UIFont.SystemFontOfSize(10),
                BackgroundColor = UIColor.White,

            })
            {
                btnLike.TouchUpInside += (sender, e) =>
                 {
                     btnLike.BackgroundColor = UIColor.White;
                     if (new Controllers.EscritorioController().PostLike(post.POST_ID, SimpleStorage.EditGroup("Login").Get("Usuario_Id"), SimpleStorage.EditGroup("Login").Get("Usuario_Tipo")))
                         btnLike.SetTitle(new Controllers.EscritorioController().GetLikes(post.POST_ID) + " Like(s)", UIControlState.Normal);
                 };
                btnLike.TouchDown += (sender, e) =>
                {
                    btnLike.BackgroundColor = UIColor.LightGray;

                };
                Add(btnLike);
            }

            if (post.POST_FOTO_URL != "")
            {
                UIImageView imgPost = new STLImageView(110, post.POST_FOTO_URL)
                {
                    Frame = new CGRect(10, 140, UIScreen.MainScreen.Bounds.Width - 100, 100)
                };
                Add(imgPost);
                totalSize += 160;
            }

            UILabel txtPost = new UILabel
            {
                Frame = new CGRect(10, 110 + totalSize, UIScreen.MainScreen.Bounds.Width - 10, 30),
                Text = post.POST_CONTENIDO,
                Font = UIFont.SystemFontOfSize(16),
                LineBreakMode = UILineBreakMode.WordWrap,
                Lines = 0
            };
            int postSize = 30 * Convert.ToInt32(Math.Floor(txtPost.IntrinsicContentSize.Width / (UIScreen.MainScreen.Bounds.Width - 10)));
            txtPost.Frame = new CGRect(10, 110 + totalSize, UIScreen.MainScreen.Bounds.Width - 10, 30 + postSize);
            Add(txtPost);
            totalSize += postSize;


            #region Comentarios
            UIScrollView commentScroll = new UIScrollView(new CGRect(0, 170 + totalSize, UIScreen.MainScreen.Bounds.Width, 100));
            foreach (ComentarioModel comentario in new Controllers.EscritorioController().GetComentariosPost(post.POST_ID))
            {
                PostComments.Add(new CommentCard(comentario)
                {
                    Frame = new CGRect(0, 170 + totalSize, UIScreen.MainScreen.Bounds.Width, 100)
                });
                AddSubview(PostComments[comentarioCount]);
                totalSize += 60;
                ++comentarioCount;

            }
            #endregion
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