using System;
using System.Net;
using Android.Graphics;

namespace WorklabsMx.Droid.Helpers
{
    public static class ImagesHelper
    {
        public static Android.Net.Uri GetPerfilImagen(string imagen) =>
             Android.Net.Uri.Parse("http://desarrolloworklabs.com/Dashboard_Client/usr_imgs/" + imagen);

        public static Bitmap GetImageBitmapFromUrl(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                Bitmap imageBitmap = null;
                byte[] bytes = null;

                using (var webClient = new WebClient())
                {
                    try
                    {
                        var imageBytes = webClient.DownloadData("http://desarrolloworklabs.com/Dashboard_Client/usr_imgs/" + url);
                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            bytes = imageBytes;
                            imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }
                return imageBitmap;
            }
            return null;
        }
        /// <summary>
        /// Carga y redimensiona la imagen
        /// </summary>
        /// <returns>Imagen redimensionada</returns>
        /// <param name="fileName">Nombre del archivo</param>
        /// <param name="width">Ancho</param>
        /// <param name="height">Alto</param>
        public static Bitmap LoadAndResizeBitmap(this string fileName, int width , int height )
        {
            // First we get the the dimensions of the file on disk
            BitmapFactory.Options options = new BitmapFactory.Options { InJustDecodeBounds = true };
            BitmapFactory.DecodeFile(fileName, options);

            // Next we calculate the ratio that we need to resize the image by
            // in order to fit the requested dimensions.
            int outHeight = options.OutHeight;
            int outWidth = options.OutWidth;
            int inSampleSize = 1;

            if (outHeight > height || outWidth > width)
            {
                inSampleSize = outWidth > outHeight
                                   ? outHeight / height
                                   : outWidth / width;
            }

            // Now we will load the image and have BitmapFactory resize it for us.
            options.InSampleSize = inSampleSize;
            options.InJustDecodeBounds = false;
            Bitmap resizedBitmap = BitmapFactory.DecodeFile(fileName, options);

            return resizedBitmap;
        }

        public static Bitmap GetRoundedShape(Bitmap scaleBitmapImage)
        {
            int targetWidth = scaleBitmapImage.Width/2;
            int targetHeight = scaleBitmapImage.Width/2;
            Bitmap targetBitmap = Bitmap.CreateBitmap(targetWidth,
                targetHeight, Bitmap.Config.Argb8888);

            Canvas canvas = new Canvas(targetBitmap);
            Path path = new Path();
            path.AddCircle(((float)targetWidth - 1) / 2,
                ((float)targetHeight - 1) / 2,
                (Math.Min(((float)targetWidth),
                    ((float)targetHeight)) / 2),
                Path.Direction.Ccw);

            canvas.ClipPath(path);
            Bitmap sourceBitmap = scaleBitmapImage;
            canvas.DrawBitmap(sourceBitmap,
                new Rect(0, 0, sourceBitmap.Width,
                    sourceBitmap.Height),
                new Rect(0, 0, targetWidth, targetHeight), null);
            return targetBitmap;
        }
    }
}
