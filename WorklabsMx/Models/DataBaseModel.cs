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
<<<<<<< HEAD
            conn = new SqlConnection("Server=38.122.16.212\\WLSQLSERVER; Database=WorklabsTest; User=developer; Pwd=d3p3l0p3r!");        
=======
            conn = new SqlConnection(@"Server=38.122.16.212\WLSQLSERVER; Database=WorklabsTest; User=developer; Pwd=d3p3l0p3r!");        
>>>>>>> 3723f0d35d11539a64fe7514c5e574dddfa2e09b
        }

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
