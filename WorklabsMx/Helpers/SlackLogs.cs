using System;
using System.IO;
using System.Net;
using System.Text;

namespace WorklabsMx.Helpers
{
    public static class SlackLogs
    {
        public static void SendMessage(string msg)
        {
#if DEBUG
            try
            {
                string data = "token=xoxp-213367599047-211854966112-319762779383-04e001237fc72d6f672c626661c12160&channel=logs&text=" + msg;
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
#endif
        }
    }
}
