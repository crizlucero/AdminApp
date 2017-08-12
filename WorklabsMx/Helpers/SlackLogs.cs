using System.IO;
using System.Net;
using System.Text;

namespace WorklabsMx.Helpers
{
    public class SlackLogs
    {
        public static void SendMessage(string msg)
        {
            string data = "token=xoxp-213367599047-211854966112-224276554563-723f48fe23f6f5dd27325c74cb34b523&channel=logs&text="+msg;
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
    }
}
