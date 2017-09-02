
using CoreGraphics;
using UIKit;
using WorklabsMx.iOS.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.iOS.ViewElements
{
    public class CommentCard : UIView
    {
        public CommentCard(ComentarioModel comentario)
        {
            UIImageView pstImage = new UIImageView
            {
                Image = ImageGallery.LoadImage(comentario.Miembro_Fotografia),
                Frame = new CGRect(10, 20, 20, 20)
            };
            pstImage.Layer.CornerRadius = 10;
            Add(pstImage);

            Add(new UILabel
            {
                Frame = new CGRect(30, 20, UIScreen.MainScreen.Bounds.Width, 10),
                Text = comentario.Nombre,
                Font = UIFont.BoldSystemFontOfSize(10)
            });

            Add(new UILabel
            {
                Frame = new CGRect(30, 30, UIScreen.MainScreen.Bounds.Width, 8),
                Text = comentario.COMM_FECHA,
                Font = UIFont.SystemFontOfSize(8)
            });

            UILabel txtPost = new UILabel
            {
                Frame = new CGRect(10, 40, UIScreen.MainScreen.Bounds.Width - 10, 20),
                Text = comentario.COMM_CONTENIDO,
                Font = UIFont.SystemFontOfSize(12)
            };
            Add(txtPost);
        }
    }
}
