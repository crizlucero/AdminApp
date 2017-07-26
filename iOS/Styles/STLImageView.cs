using System;
using CoreGraphics;
using UIKit;
using WorklabsMx.iOS.Helpers;

namespace WorklabsMx.iOS.Styles
{
    public class STLImageView : UIImageView
    {
        public STLImageView(int posY, string imageSource)
        {
            Frame = new CGRect(40, posY, 50, 50);
            Image = ImageGallery.LoadImage(imageSource);
        }
    }
}
