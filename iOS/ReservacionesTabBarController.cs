using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class ReservacionesTabBarController : UITabBarController
    {
        
        public ReservacionesTabBarController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }

        partial void btnMenu_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }
    }
}