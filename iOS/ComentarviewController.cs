using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class ComentarviewController : UIViewController
    {
        public ComentarviewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var color = new UIColor(0, 0.0f);
            this.View.BackgroundColor = color;
        }

        partial void btnCamara_TouchUpInside(UIButton sender)
        {
        }

        partial void btnComentar_TouchUpInside(UIButton sender)
        {
        }

        partial void btnClose_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}