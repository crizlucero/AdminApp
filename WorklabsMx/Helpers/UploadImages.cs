using System;
using System.Net;

namespace WorklabsMx.Helpers
{
    public class UploadImages
    {

        public bool UploadBitmapAsync(string imgNombre, byte[] image)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Credentials = new NetworkCredential("crizlucero", "Ch1nv35l");
                    client.UploadData(new Uri("ftp://10.10.28.68/Plantillas/" + imgNombre), image);
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            return false;
        }
    }
}
