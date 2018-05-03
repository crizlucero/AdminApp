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
                FtpWebRequest client = (FtpWebRequest)WebRequest.Create("ftp://cloud.worklabs.mx/" + path + imgNombre);
                client.Method = WebRequestMethods.Ftp.UploadFile;
                client.UsePassive = true;
                client.Credentials = new NetworkCredential(@"worklabscloud", @"Worklabscloud!");
                Stream requestStream = client.GetRequestStream();
                requestStream.Write(image, 0, image.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)client.GetResponse();
                response.Close();
                response.Dispose();
                client = null;
                GC.Collect();
                //client.Abort();
                return true;

            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "UploadBitmapAsync");
                return false;
            }
        }

        public byte[] DownloadFileFTP(string imgNombre, string path)
        {
            MemoryStream ms = new MemoryStream();
            Stream responseStream = null;
            FtpWebRequest client = null;
            if (!string.IsNullOrEmpty(imgNombre))
            {
                try
                {
                    client = (FtpWebRequest)WebRequest.Create("ftp://cloud.worklabs.mx/" + path + imgNombre.Replace("\\", "/"));
                    client.Method = WebRequestMethods.Ftp.DownloadFile;
                    client.UsePassive = true;
                    client.Credentials = new NetworkCredential(@"worklabscloud", @"Worklabscloud!");
                    client.Timeout = System.Threading.Timeout.Infinite;
                    responseStream = ((FtpWebResponse)client.GetResponse()).GetResponseStream();
                    responseStream.CopyTo(ms);
                    responseStream.Close();
                    /*responseStream.Dispose();
                    client = null;
                    GC.Collect();*/
                }
                catch (Exception e)
                {
                    SlackLogs.SendMessage(e.Message, GetType().Name, "DownloadFileFTP");
                   
                    return ms.ToArray();
                }
                finally
                {
                    if (responseStream != null)
                    {
                        responseStream.Close();
                        responseStream.Dispose();
                    }
                    if (client != null)
                        client = null;
                    GC.Collect();
                }

            }
            return ms.ToArray();
        }

        public bool DeleteFileFTP(string imgNombre, string path)
        {
            if (!string.IsNullOrEmpty(imgNombre))
            {
                try
                {
                    FtpWebRequest client = (FtpWebRequest)WebRequest.Create("ftp://cloud.worklabs.mx/" + path + imgNombre.Replace("\\", "/"));
                    client.Method = WebRequestMethods.Ftp.DeleteFile;
                    client.UsePassive = true;
                    client.Credentials = new NetworkCredential(@"worklabscloud", @"Worklabscloud!");
                    client.Timeout = 2500;
                    Console.WriteLine(((FtpWebResponse)client.GetResponse()).StatusDescription);
                }
                catch (Exception e)
                {
                    SlackLogs.SendMessage(e.Message, GetType().Name, "DeleteFileFTP");
                    return false;
                }
            }
            return true;
        }
    }
}
