using System;
using CoreGraphics;
using UIKit;

namespace WorklabsMx.iOS.Styles
{
    public class STLImageLabel : UIView
    {
        public STLImageLabel(UIView view, string text, int posY, string image, int fontSize = 16) : base()
        {
			view.Add(new UIImageView
			{
				Image = UIImage.FromBundle(image),
                Frame = new CGRect(40, posY, 30, 30)
			});

            UILabel lblSocial = new STLLabel(text, 960);
            lblSocial.Frame = new CGRect(80, posY, UIScreen.MainScreen.Bounds.Width, 30);
            view.Add(lblSocial);
        }
    }
}
