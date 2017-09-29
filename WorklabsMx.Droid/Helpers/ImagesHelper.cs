using System;
using System.IO;
using System.Net;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Media;
using Android.Net;
using WorklabsMx.Helpers;

namespace WorklabsMx.Droid.Helpers
{
    public class ImagesHelper
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
                    var imageBytes = webClient.DownloadData("http://desarrolloworklabs.com/Dashboard_Client/usr_imgs/" + url);
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        bytes = imageBytes;
                        imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                    }
                }
                return imageBitmap;
            }
            return null;
        }
    }
}
