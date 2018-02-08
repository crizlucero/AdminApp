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

        protected DataBaseModel() => conn = new SqlConnection(@"Server=mssql.worklabs.mx\WLSQLSERVER; Database=WorklabsTest; User=developer; Pwd=d3p3l0p3r!");

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
