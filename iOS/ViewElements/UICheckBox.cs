using CoreGraphics;
using UIKit;

namespace WorklabsMx.iOS.ViewElements
{
    public class UICheckBox : UIView
    {
        public bool IsChecked { get; set; }
        UIImageView Image { get; set; }
        public UICheckBox(int x, int y)
        {
            Frame = new CGRect(x, y, 20, 20);
            Layer.BorderWidth = 1;
            Layer.BorderColor = UIColor.LightGray.CGColor;
            IsChecked = false;
            Image = new UIImageView(UIImage.FromBundle("ic_check")) { Frame = new CGRect(0, 0, 20, 20) };
            Image.Hidden = !IsChecked;
            Add(Image);
        }

        public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            if (touches.AnyObject is UITouch touch)
            {
                IsChecked = !IsChecked;
                Image.Hidden = !IsChecked;
            }
        }
    }
}
