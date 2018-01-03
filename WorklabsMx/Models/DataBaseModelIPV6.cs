using System.Data.SqlClient;

namespace WorklabsMx.Models
{
    public abstract class DataBaseModelIPV6
    {
        protected SqlConnection conn;
        protected SqlDataReader reader;
        protected SqlCommand command;
        protected SqlTransaction transaction;

        protected DataBaseModelIPV6() => conn = new SqlConnection("Server=0:0:0:0:0:FFFF:B8A8:2F11; Database=Worklabs; User=webmaster; Pwd=W3bM4st3r");

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
