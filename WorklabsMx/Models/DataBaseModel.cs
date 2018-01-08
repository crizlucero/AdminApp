using System.Data.SqlClient;
using System.Net;

namespace WorklabsMx.Models
{
    public abstract class DataBaseModel
    {
        protected SqlConnection conn;
        protected SqlConnection connIPV6;

        protected string IP;

        protected SqlDataReader reader;
        protected SqlCommand command;
        protected SqlTransaction transaction;

        protected DataBaseModel()
        {
            IP = this.toip("184.168.47.17");
            conn = new SqlConnection("Server=184.168.47.17; Database=Worklabs; User=webmaster; Pwd=W3bM4st3r; Trusted_Connection=False");
            connIPV6 = new SqlConnection("Server=" + IP + "; Database=Worklabs; User=webmaster; Pwd=W3bM4st3r; Trusted_Connection=False");
        }

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommandIPV6(string query) => new SqlCommand(query, connIPV6);

        protected SqlCommand CreateCommand() => new SqlCommand();


        private string toip(string input)
        {
            IPAddress address;
            if (IPAddress.TryParse(input, out address))
            {
                switch (address.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        // we have IPv4, map it to IPv6
                        IPAddress ip = IPAddress.Parse(input).MapToIPv6();
                        return ip.ToString();
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        // we have IPv6, leave it as is
                        return input;

                }
            }
            return input;
        }
    }
}
