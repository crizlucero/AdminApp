using System;
using CoreGraphics;
using UIKit;

namespace WorklabsMx.iOS.ViewElements
{
    public class UICheckBox : UIView
    {
        public bool IsChecked { get; set; }
        UIImageView Image { get; set; }
        public UICheckBox(string label, int x, int y) : base()
        {
            Frame = new CGRect(x, y, 20, 20);
            Layer.BorderWidth = 1;
            Layer.BorderColor = UIColor.LightGray.CGColor;
            //Layer.CornerRadius = 10;
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
                /*if (IsChecked)
                {
                    IsChecked = false;
                }
                else
                {
                    IsChecked = true;
                }*/
                Image.Hidden = !IsChecked;
            }
        }
    }
}
