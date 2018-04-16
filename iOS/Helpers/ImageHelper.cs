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


        public static UIImage ReescalImage(UIImage ImagenOrigen)
        {
  
            var withImage = ImagenOrigen.Size.Width;
            var heightImage = ImagenOrigen.Size.Height;
            if (withImage > 646)
            {
                var newWithScale = (440 * 100) / withImage;
                var newHeigth = (newWithScale * heightImage) / 100;
                CGSize newSizeImage = new CGSize(440, newHeigth);
                ImagenOrigen = ImagenOrigen.Scale(newSizeImage);
            }
            else if(heightImage > 646)
            {
                var newHeightScale = (440 * 100) / heightImage;
                var newWith = (newHeightScale * withImage) / 100;
                CGSize newSizeImage = new CGSize(newWith, 440);
                ImagenOrigen = ImagenOrigen.Scale(newSizeImage);
            }
            return ImagenOrigen;
        }

        public static UIImage ReescalProfileImage(UIImage ImagenOrigen)
        {
            var withImage = ImagenOrigen.Size.Width;
            var heightImage = ImagenOrigen.Size.Height;
            if (withImage > 400 || heightImage > 400)
            {
                CGSize newSizeImage = new CGSize(400, 400);
                ImagenOrigen = ImagenOrigen.Scale(newSizeImage);
            }
            return ImagenOrigen;
        }

        public static UIImage ReescalProfileBackImage(UIImage ImagenOrigen)
        {
            var withImage = ImagenOrigen.Size.Width;
            var heightImage = ImagenOrigen.Size.Height;
            if (withImage > 1500)
            {
                var newWithScale = (1500 * 100) / withImage;
                var newHeigth = (newWithScale * heightImage) / 100;
                CGSize newSizeImage = new CGSize(1500, newHeigth);
                ImagenOrigen = ImagenOrigen.Scale(newSizeImage);
            }
            return ImagenOrigen;
        }

    }
}
