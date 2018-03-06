using System;
using System.IO;
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
        public bool UploadBitmapAsync(string imgNombre, byte[] image, string path)
        {
            try
            {
                FtpWebRequest client = (FtpWebRequest)WebRequest.Create("ftp://38.122.16.212/" + path + imgNombre);
                client.Method = WebRequestMethods.Ftp.UploadFile;
                client.UsePassive = true;
                client.Credentials = new NetworkCredential(@"worklabscloud", @"Worklabscloud!");
                Stream requestStream = client.GetRequestStream();
                requestStream.Write(image, 0, image.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)client.GetResponse();
                response.Close();
                return true;

            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                return false;
            }
        }

        public byte[] DownloadFileFTP(string imgNombre, string path)
        {
            MemoryStream ms = new MemoryStream();
            if (!string.IsNullOrEmpty(imgNombre))
            {
                try
                {
                    FtpWebRequest client = (FtpWebRequest)WebRequest.Create("ftp://38.122.16.212/" + path + imgNombre.Replace("\\", "/"));
                    client.Method = WebRequestMethods.Ftp.DownloadFile;
                    client.UsePassive = true;
                    client.Credentials = new NetworkCredential(@"worklabscloud", @"Worklabscloud!");
                    client.Timeout = 2000;
                    Stream responseStream = ((FtpWebResponse)client.GetResponse()).GetResponseStream();

                    responseStream.CopyTo(ms);
                }
                catch (Exception e)
                {
                    SlackLogs.SendMessage(e.Message);
                }
            }
            return ms.ToArray();
        }


    }
}
