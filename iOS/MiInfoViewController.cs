using System;
using UIKit;
using CoreGraphics;

namespace WorklabsMx.iOS
{
    public partial class MiInfoViewController : UIViewController
    {
        public MiInfoViewController (IntPtr handle) : base (handle)
        {
        }

       public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            if(this.lblHabTag1.Hidden == false)
            {
                this.ReziseLabel(lblHabTag1);
            }
            if (this.lblHabTag2.Hidden == false)
            {
                this.ReziseLabel(lblHabTag2);
            }
            if (this.lblHabTag3.Hidden == false)
            {
                this.ReziseLabel(lblHabTag3);
            }
            if (this.lblHabTag4.Hidden == false)
            {
                this.ReziseLabel(lblHabTag4);
            }
            if (this.lblHabTag5.Hidden == false)
            {
                this.ReziseLabel(lblHabTag5);
            }

        }

        private void ReziseLabel(UILabel label)
        {
            label.SizeToFit();
            /*var newFrame = new CGRect(label.Frame.X, label.Frame.Y, label.Frame.Width, label.Frame.Height);
            label.Frame = newFrame;
            label.LineBreakMode = UILineBreakMode.TailTruncation;*/
        }
    }
}