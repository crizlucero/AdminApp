using System;
using System.IO;
using System.Net;
using Foundation;
using UIKit;
using WorklabsMx.Helpers;
using WorklabsMx.iOS.Styles;
using Plugin.Connectivity;

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
                FtpWebRequest client = (FtpWebRequest)WebRequest.Create("ftp://38.122.16.212/" + imgNombre);
                client.Method = WebRequestMethods.Ftp.UploadFile;
                client.UsePassive = false;
                client.Credentials = new NetworkCredential(@"SRVWLHOSTING\worklabscloud", @"Worklabscloud!");
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

        public UIImage DownloadFileFTP(string Imagen)
        {
            if (Imagen == "")
            {
                return null;
            }
            else
            {
                try
                {
                    string ftphost = "ftp://38.122.16.212/";
                    string ftpfilepath = "/ " + Imagen.Replace("\\", "/");

                    string ftpfullpath = "ftp://" + ftphost + ftpfilepath;

                    using (WebClient request = new WebClient())
                    {
                        request.Credentials = new NetworkCredential(@"SRVWLHOSTING\worklabscloud", @"Worklabscloud!");
                        byte[] fileData = request.DownloadData(ftpfullpath);
                        var data = NSData.FromArray(fileData);
                        UIImage Image = UIImage.LoadFromData(data);
                        return Image;
                    }
                }
                catch
                {
                    return null;
                }
               
            }

        }
    }
}
