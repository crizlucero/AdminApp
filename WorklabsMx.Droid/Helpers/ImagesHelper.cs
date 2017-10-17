using System;
using System.Net;
using Android.Graphics;
using WorklabsMx.Helpers;

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
                    catch (Exception e) { SlackLogs.SendMessage(e.Message); }
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
        public static Bitmap LoadAndResizeBitmap(this string fileName, int width, int height)
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
    }
}
