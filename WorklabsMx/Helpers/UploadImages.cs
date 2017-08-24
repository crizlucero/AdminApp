using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace WorklabsMx.Helpers
{
    public class UploadImages
    {
        public bool UploadBitmapAsync(byte[] image)
        {
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundaryBytes = System.Text.Encoding.ASCII.GetBytes("--" + boundary + "\r\n");

            WebRequest request = WebRequest.Create("");
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";

            using (Stream requestStream = request.GetRequestStream())
            {
                // write boundary bytes
                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);

                // write header bytes.
                string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
                string header = string.Format(headerTemplate, "MyName", "MyFileName", "content type");
                byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                requestStream.Write(headerbytes, 0, headerbytes.Length);

                using (MemoryStream memoryStream = new MemoryStream(image))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead = 0;
                    while ((bytesRead = memoryStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        requestStream.Write(buffer, 0, bytesRead);
                    }
                }

                // write trailing boundary bytes.
                byte[] trailerBytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
                requestStream.Write(trailerBytes, 0, trailerBytes.Length);

            }
            using (HttpWebResponse wr = (HttpWebResponse)request.GetResponse())
            {
                using (Stream response = wr.GetResponseStream())
                {
                }
            }
            return false;
        }
    }
}
