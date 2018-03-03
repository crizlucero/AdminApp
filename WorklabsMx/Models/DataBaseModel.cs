using System.Data.SqlClient;

namespace WorklabsMx.Models
{
    public abstract class DataBaseModel
    {
        protected SqlConnection conn;

        protected string IP;

        protected SqlDataReader reader;
        protected SqlCommand command;
        protected SqlTransaction transaction;

        protected DataBaseModel() => conn = new SqlConnection(@"Data Source=desarrolloworklabs.com,1443; Network Library=DBMSSOCN; Initial Catalog=WorklabsTest; User ID=developer; Pwd=d3p3l0p3r!");

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
