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

<<<<<<< HEAD
        protected DataBaseModel()
        {
            try
            {
                conn = new SqlConnection(@"Server=worklabs.mx,1443; Database=WorklabsTest; User=developer; Pwd=d3p3l0p3r!");
            }catch(Exception e){
                SlackLogs.SendMessage(e.Message + " " + e.Source + " " + e.StackTrace);
            }
        }
=======
        protected DataBaseModel() =>
                conn = new SqlConnection(@"Data Source=worklabs.mx,1443; Network Library=DBMSSOCN; Initial Catalog=WorklabsTest; User ID=developer; Pwd=d3p3l0p3r!");
>>>>>>> b4f6906dae127c5421adcc2afa783f99d759c281

        protected SqlCommand CreateCommand(string query) => new SqlCommand(query, conn);

        protected SqlCommand CreateCommand() => new SqlCommand();
    }
}
