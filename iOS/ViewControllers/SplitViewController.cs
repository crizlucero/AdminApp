using System;
using UIKit;

namespace WorklabsMx.iOS.ViewControllers
{
    public partial class SplitViewController : UISplitViewController
    {
        
        public SplitViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

