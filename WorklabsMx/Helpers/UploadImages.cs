using System;
using System.Net;

namespace WorklabsMx.Helpers
{
    public class UploadImages
    {
        /// <summary>
        /// Sube la imagen al servidor ftp.
        /// </summary>
        /// <param name="imgNombre">Nombre de la imagen.</param>
        /// <param name="image">Bytes de la imagen</param>
        public bool UploadBitmapAsync(string imgNombre, byte[] image) 
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Credentials = new NetworkCredential(@"SRVWLHOSTING\ftp", @"*Admin_FTP*");
                    client.UploadData(new Uri("ftp://38.122.16.212/Pruebas/" + imgNombre), image);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
                throw new Exception(e.Message);

            }
        }
    }
}
