using System;
using System.Collections.Generic;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class ConfigurationsController : DataBaseModel
    {
        /// <summary>
        /// Obtiene las configuraciones
        /// </summary>
        /// <returns>Configuraciones</returns>
        /// <param name="parametro">Parametro a elegir</param>
        public ConfiguracionesModel GetConfiguraciones(string parametro)
        {
            string query = "SELECT * FROM vw_cat_Parametros_Generales WHERE Parametro_Descripcion = @Parametro";
            ConfiguracionesModel configuracion = new ConfiguracionesModel();
            try
            {
                conn.Open();
                command = this.CreateCommand(query);
                command.Parameters.AddWithValue("@Parametro", parametro);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    configuracion = new ConfiguracionesModel
                    {
                        Parametro_Id = reader["Parametro_Id"].ToString(),
                        Parametro_Descripcion = reader["Parametro_Descripcion"].ToString(),
                        Parametro_Varchar_1 = reader["Parametro_Varchar_1"].ToString(),
                        Parametro_Varchar_2 = reader["Parametro_Varchar_2"].ToString(),
                        Parametro_Varchar_3 = reader["Parametro_Varchar_3"].ToString(),
                        Parametro_Varchar_4 = reader["Parametro_Varchar_4"].ToString(),
                        Parametro_Varchar_5 = reader["Parametro_Varchar_5"].ToString(),
                        Parametro_Int_1 = reader["Parametro_Int_1"].ToString(),
                        Parametro_Int_2 = reader["Parametro_Int_2"].ToString(),
                        Parametro_Int_3 = reader["Parametro_Int_3"].ToString(),
                        Parametro_Int_4 = reader["Parametro_Int_4"].ToString(),
                        Parametro_Int_5 = reader["Parametro_Int_5"].ToString(),
                        Parametro_date_1 = reader["Parametro_date_1"].ToString(),
                        Parametro_date_2 = reader["Parametro_date_2"].ToString(),
                        Parametro_date_3 = reader["Parametro_date_3"].ToString(),
                        Parametro_date_4 = reader["Parametro_date_4"].ToString(),
                        Parametro_date_5 = reader["Parametro_date_5"].ToString(),
                        Parametro_Estatus = reader["Parametro_Estatus"].ToString(),
                        Parametro_Fecha_Alta = reader["Parametro_Fecha_Alta"].ToString(),
                        Parametro_Fecha_Modificacion = reader["Parametro_Fecha_Modificacion"].ToString(),
                        Parametro_Fecha_Baja = reader["Parametro_Fecha_Baja"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

            return configuracion;
        }

        public List<ConfiguracionesModel> GetListConfiguraciones(string parametros)
        {
            string query = "SELECT * FROM vw_cat_Parametros_Generales WHERE Parametro_Descripcion in (" + parametros + ")";
            List<ConfiguracionesModel> configuraciones = new List<ConfiguracionesModel>();
            try
            {
                conn.Open();
                command = this.CreateCommand(query);
                command.Parameters.AddWithValue("@Parametro", parametros);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    configuraciones.Add(new ConfiguracionesModel
                    {
                        Parametro_Id = reader["Parametro_Id"].ToString(),
                        Parametro_Descripcion = reader["Parametro_Descripcion"].ToString(),
                        Parametro_Varchar_1 = reader["Parametro_Varchar_1"].ToString(),
                        Parametro_Varchar_2 = reader["Parametro_Varchar_2"].ToString(),
                        Parametro_Varchar_3 = reader["Parametro_Varchar_3"].ToString(),
                        Parametro_Varchar_4 = reader["Parametro_Varchar_4"].ToString(),
                        Parametro_Varchar_5 = reader["Parametro_Varchar_5"].ToString(),
                        Parametro_Int_1 = reader["Parametro_Int_1"].ToString(),
                        Parametro_Int_2 = reader["Parametro_Int_2"].ToString(),
                        Parametro_Int_3 = reader["Parametro_Int_3"].ToString(),
                        Parametro_Int_4 = reader["Parametro_Int_4"].ToString(),
                        Parametro_Int_5 = reader["Parametro_Int_5"].ToString(),
                        Parametro_date_1 = reader["Parametro_date_1"].ToString(),
                        Parametro_date_2 = reader["Parametro_date_2"].ToString(),
                        Parametro_date_3 = reader["Parametro_date_3"].ToString(),
                        Parametro_date_4 = reader["Parametro_date_4"].ToString(),
                        Parametro_date_5 = reader["Parametro_date_5"].ToString(),
                        Parametro_Estatus = reader["Parametro_Estatus"].ToString(),
                        Parametro_Fecha_Alta = reader["Parametro_Fecha_Alta"].ToString(),
                        Parametro_Fecha_Modificacion = reader["Parametro_Fecha_Modificacion"].ToString(),
                        Parametro_Fecha_Baja = reader["Parametro_Fecha_Baja"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return configuraciones;
        }
    }
}
