using Foundation;
using System;
using UIKit;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS
{
    public partial class PublicarPostViewController : UIViewController
    {

        public PublicarPostViewController (IntPtr handle) : base (handle)
        {
            
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
            var color = new UIColor(1, 0.8f);
            this.View.BackgroundColor = color;
			StyleHelper.Style(btnPublicar.Layer);
			StyleHelper.Style(vwVistaComentar.Layer);
		}


		partial void btnPublicar_TouchUpInside(UIButton sender)
		{
            
			throw new NotImplementedException();
		}

		partial void btnClose_TouchUpInside(UIButton sender)
		{
			this.DismissViewController(true, null);
		}

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            var touch = touches.AnyObject as UITouch;

            var location = touch.LocationInView(this.View);
            if (this.vwVistaComentar.Frame.Contains(location) == false)
            {
                this.DismissViewController(true, null);
            }

        }
    }
}