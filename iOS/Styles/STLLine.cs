using CoreGraphics;
using UIKit;

namespace WorklabsMx.iOS.Styles
{
    public class STLLine :UIView
    {
        public STLLine(int height = 5)
        {
            Frame = new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, height);
            BackgroundColor = UIColor.FromRGB(101, 216, 250);
        }
    }
}
