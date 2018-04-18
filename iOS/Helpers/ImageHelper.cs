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
            const float MaximunWithHeigth = 646;
            var withImage = ImagenOrigen.Size.Width;
            var heightImage = ImagenOrigen.Size.Height;
            if (withImage > MaximunWithHeigth)
            {
                var newHeigth = (heightImage * MaximunWithHeigth) / withImage;
                CGSize newSizeImage = new CGSize(MaximunWithHeigth, newHeigth);
                ImagenOrigen = ImagenOrigen.Scale(newSizeImage);
            }
            else if(heightImage > MaximunWithHeigth)
            {
                var newWith = (MaximunWithHeigth * withImage) / heightImage;
                CGSize newSizeImage = new CGSize(newWith, MaximunWithHeigth);
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
            const float MaximunWidth = 1500;
            const float Maximunheight = 500;
            var withImage = ImagenOrigen.Size.Width;
            var heightImage = ImagenOrigen.Size.Height;
            if (withImage > MaximunWidth)
            {
                var newHeigth = (heightImage * MaximunWidth) / withImage;
                CGSize newSizeImage = new CGSize(MaximunWidth, newHeigth);
                ImagenOrigen = ImagenOrigen.Scale(newSizeImage);
            }
            if (heightImage > Maximunheight)
            {
                var newWith = (Maximunheight * withImage) / heightImage;
                CGSize newSizeImage = new CGSize(newWith, Maximunheight);
                ImagenOrigen = ImagenOrigen.Scale(newSizeImage);
            }
            return ImagenOrigen;
        }

    }
}
