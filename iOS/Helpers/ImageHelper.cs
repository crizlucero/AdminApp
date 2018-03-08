﻿using System;
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


        public static UIImage ReescalImage(UIImage ImagenOrigen)
        {
            var withImage = ImagenOrigen.Size.Width;
            var heightImage = ImagenOrigen.Size.Height;
            if (withImage > 440)
            {
                var newWithScale = (440 * 100) / withImage;
                var newHeigth = (newWithScale * heightImage) / 100;
                CGSize newSizeImage = new CGSize(440, newHeigth);
                ImagenOrigen = ImagenOrigen.Scale(newSizeImage);
            }
            return ImagenOrigen;
        }

    }
}
