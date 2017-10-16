using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class DetailCommentImage : UIViewController
    {

        public UIImageView ImagenPost;


        public override void ViewDidLoad()
        {
            this.imgCommnet.Image = ImagenPost.Image;
        }

        public DetailCommentImage (IntPtr handle) : base (handle)
        {
        }

        partial void btnBack_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}