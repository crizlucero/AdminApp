using System;
using CoreGraphics;
using UIKit;

namespace WorklabsMx.iOS.Styles
{
    public class STLLabel : UILabel
    {
        public STLLabel(string text, int posY, int fontSize = 16):base()
        {
            Text = text;
            Frame = new CGRect(40, posY, UIScreen.MainScreen.Bounds.Width, 30);
            Font = UIFont.BoldSystemFontOfSize(fontSize);
        }
    }
}
