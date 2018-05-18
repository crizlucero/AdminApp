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
#if DEBUG
		protected DataBaseModel() => conn = new SqlConnection(@"Data Source=38.122.16.213,1443; Initial Catalog=Worklabs; User ID=developer; Pwd=d3p3l0p3r!");
#else
        protected DataBaseModel() => conn = new SqlConnection(@"Data Source=desarrolloworklabs.com,1443; Network Library=DBMSSOCN; Initial Catalog=WorklabsTest; User ID=developer; Pwd=d3p3l0p3r!");
#endif
        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
