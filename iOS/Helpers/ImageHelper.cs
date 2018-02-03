using System;
using UIKit;
using CoreGraphics;

namespace WorklabsMx.iOS.Helpers
{
    public class ImageHelper
    {
        public static UIImage ResizeUIImage(UIImage sourceImage, float widthToScale, float heightToScale)
        {
            var sourceSize = sourceImage.Size;
            var maxResizeFactor = Math.Max(widthToScale / sourceSize.Width, heightToScale / sourceSize.Height);
            if (maxResizeFactor > 1) return sourceImage;
            var width = maxResizeFactor * sourceSize.Width;
            var height = maxResizeFactor * sourceSize.Height;
            UIGraphics.BeginImageContext(new CGSize(width, height));
            sourceImage.Draw(new CGRect(0, 0, width, height));
            var resultImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return resultImage;
        }
    }
}
