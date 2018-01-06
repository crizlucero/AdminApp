using System.Data.SqlClient;

namespace WorklabsMx.Models
{
    public abstract class DataBaseModel
    {
        protected SqlConnection conn;
        protected SqlConnection connIPV6;


        protected SqlDataReader reader;
        protected SqlCommand command;
        protected SqlTransaction transaction;

        protected DataBaseModel()
        {
            conn = new SqlConnection("Server=184.168.47.17:1433; Database=Worklabs; User=webmaster; Pwd=W3bM4st3r; Trusted_Connection=False");
            connIPV6 = new SqlConnection("Server=0:0:0:0:0:FFFF:B8A8:2F11,1433; Database=Worklabs; User=webmaster; Pwd=W3bM4st3r; Trusted_Connection=False");
        }

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommandIPV6(string query) => new SqlCommand(query, connIPV6);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
