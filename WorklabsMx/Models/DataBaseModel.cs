using System.Data.SqlClient;
using System.Net;

namespace WorklabsMx.Models
{
    public abstract class DataBaseModel
    {
        protected SqlConnection conn;

        protected string IP;

        protected SqlDataReader reader;
        protected SqlCommand command;
        protected SqlTransaction transaction;

        protected DataBaseModel()
        {
            conn = new SqlConnection("Server=ip-184-168-47-17.ip.secureserver.net; Database=Worklabs; User=webmaster; Pwd=W3bM4st3r");
        }

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
