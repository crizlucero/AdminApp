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
                    client.Credentials = new NetworkCredential("crizlucero", "Ch1nv35l");
                    client.UploadData(new Uri("ftp://10.10.28.68/Plantillas/" + imgNombre), image);
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
