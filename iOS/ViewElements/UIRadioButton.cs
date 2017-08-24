using System;
using CoreGraphics;
using UIKit;
using WorklabsMx.iOS.Styles;

namespace WorklabsMx.iOS.ViewElements
{
    public class UIRadioButton : UIButton
    {
        public bool IsChecked { get; set; }
        public UIImageView Image { get; set; }
        public int IDRadio { get; set; }
        public UIRadioButton(int x, int y, string message)
        {
            Frame = new CGRect(x, y, 30, 30);
            Layer.CornerRadius = 15;
            IsChecked = false;
            SetImage(UIImage.FromBundle("ic_radiobutton_uncheck"), UIControlState.Normal);
            AddSubview(new STLLabel(message)
            {
                Frame = new CGRect(30, 0, UIScreen.MainScreen.Bounds.Width - (x + 50), 30)
            });
        }

        public UIImage ChangeState()
        {
            if (IsChecked)
                return UIImage.FromBundle("ic_radiobutton_check");
            return (UIImage.FromBundle("ic_radiobutton_uncheck"));
        }
    }
}
