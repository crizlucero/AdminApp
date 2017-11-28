using Foundation;
using System;
using UIKit;

namespace WorklabsMx.iOS
{
    public partial class GeneroViewController : UIViewController
    {
        public GeneroViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var color = new UIColor(1, 0.8f);
            this.View.BackgroundColor = color;
        }


        partial void btnCancelar_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnSeleccionar_TouchUpInside(UIButton sender)
        {
        }
    }
}