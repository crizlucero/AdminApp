using System;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class TerritorioController : DataBaseModel
    {
        public TerritorioModel GetTerritorio(string CP)
        {
            TerritorioModel territorio = new TerritorioModel();
            string query = "SELECT Territorio_Id, Territorio_Pais_Descripcion, Territorio_Estado_Descripcion," +
                "Territorio_Municipio_Descripcion, Territorio_Colonia_Descripcion, Territorio_Cp " +
                "FROM vw_cat_Territorios Where Territorio_Cp = @cp";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@cp", CP);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    territorio = new TerritorioModel
                    {
                        Territorio_Id = reader["Territorio_Id"].ToString(),
                        Pais = reader["Territorio_Pais_Descripcion"].ToString(),
                        Estado = reader["Territorio_Estado_Descripcion"].ToString(),
                        Municipio = reader["Territorio_Municipio_Descripcion"].ToString(),
                        Colonia = reader["Territorio_Colonia_Descripcion"].ToString(),
                        CP = reader["Territorio_Cp"].ToString()
                    };
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return territorio;
        }

        public string GetTerritorioId(string cp, string colonia)
        {
            string query = "SELECT Territorio_Id FROM vw_cat_Territorios " +
                "Where Territorio_Cp = @cp AND Territorio_Colonia_Descripcion = @colonia";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@cp", cp);
                command.Parameters.AddWithValue("@colonia", colonia);
                return command.ExecuteScalar().ToString();
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return "";
        }
    }
}
