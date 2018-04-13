using System;
using System.IO;
using System.Net;
using System.Text;

namespace WorklabsMx.Helpers
{
    public static class SlackLogs
    {
        public static void SendMessage(string msg, string sourceClass, string sourceMethod)
        {
            try
            {
                string data = string.Format("token=xoxp-213367599047-211854966112-347471631750-0b71e1d3a42c60f943266ef6ddf71a29&channel=logs&text={0}.{1}: {2}", sourceClass, sourceMethod, msg);
                var post = Encoding.ASCII.GetBytes(data);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://slack.com/api/chat.postMessage");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = post.Length;

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(post, 0, post.Length);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
