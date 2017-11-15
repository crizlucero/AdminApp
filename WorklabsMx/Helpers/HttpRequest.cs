using System;
using System.IO;
using System.Net;
using System.Text;

namespace WorklabsMx.Helpers
{
    public class HttpRequest
    {
        public string POST(string url, string datos){
            var request = (HttpWebRequest)WebRequest.Create(url);

            var postData = datos;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        public string GET(string url){
            var request = (HttpWebRequest)WebRequest.Create(url);

            var response = (HttpWebResponse)request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}
