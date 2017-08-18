using System.Data.SqlClient;

namespace WorklabsMx.Models
{
    public abstract class DataBaseModel
    {
        protected SqlConnection conn;
        protected SqlDataReader reader;
        protected SqlCommand command;
        protected SqlTransaction transaction;
        public DataBaseModel() => this.conn = new SqlConnection("Server=184.168.47.17; Database=Worklabs; User=webmaster; Pwd=W3bM4st3r");


        protected SqlCommand CreateCommand(string query)
        {
            return new SqlCommand(query, conn);
        }

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
