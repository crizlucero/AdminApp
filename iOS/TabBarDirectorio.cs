using Foundation;
using System;
using UIKit;
using SWRevealViewControllerBinding;

namespace WorklabsMx.iOS
{
    public partial class TabBarDirectorio : UITabBarController
    {
        public TabBarDirectorio (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        partial void btnBack_Touch(UIBarButtonItem sender)
        {
            this.RevealViewController().RevealToggleAnimated(true);
            View.AddGestureRecognizer(this.RevealViewController().PanGestureRecognizer);
        }
    }
}