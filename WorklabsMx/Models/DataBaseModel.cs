using System;
using System.Data.SqlClient;
using WorklabsMx.Helpers;

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
            try
            {
                conn = new SqlConnection(@"Server=worklabs.mx,1443; Database=WorklabsTest; User=developer; Pwd=d3p3l0p3r!");
            }catch(Exception e){
                SlackLogs.SendMessage(e.Message + " " + e.Source + " " + e.StackTrace);
            }
        }

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
