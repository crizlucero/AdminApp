using CoreGraphics;
using UIKit;

namespace WorklabsMx.iOS.Styles
{
    public class STLLabel : UILabel
    {
        public STLLabel(string text, int posY = 0, int fontSize = 16) : base()
        {
            Text = text;
            Frame = new CGRect(20, posY, UIScreen.MainScreen.Bounds.Width - 20, 30);
            Font = UIFont.BoldSystemFontOfSize(fontSize);
            LineBreakMode = UILineBreakMode.WordWrap;
        }
    }
}
