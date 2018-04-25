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
<<<<<<< HEAD

        protected DataBaseModel() => conn = new SqlConnection(@"Data Source=desarrolloworklabs.com,1443; Network Library=DBMSSOCN; Initial Catalog=Worklabs; User ID=developer; Pwd=d3p3l0p3r!");

=======
#if DEBUG
        protected DataBaseModel() => conn = new SqlConnection(@"Data Source=desarrolloworklabs.com,1443; Network Library=DBMSSOCN; Initial Catalog=Worklabs; User ID=developer; Pwd=d3p3l0p3r!");
#else
        protected DataBaseModel() => conn = new SqlConnection(@"Data Source=desarrolloworklabs.com,1443; Network Library=DBMSSOCN; Initial Catalog=WorklabsTest; User ID=developer; Pwd=d3p3l0p3r!");
#endif
>>>>>>> 266002acd46bba471dc218d4a1b81155b14368a3
        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
