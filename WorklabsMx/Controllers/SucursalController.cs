using System;
using System.Collections.Generic;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class SucursalController : DataBaseModel
    {
        /// <summary>
        /// Obtiene los nombres de las sucursales
        /// </summary>
        /// <returns>Listado de las sucursales.</returns>
        public List<string> GetSucursalNombres()
        {
            List<string> sucursales = new List<string>();
            string query = "SELECT Sucursal_Descripcion FROM vw_cat_Sucursales";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sucursales.Add(reader.GetString(0));
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return sucursales;
        }
        /// <summary>
        /// Obtiene la información de la sucursal
        /// </summary>
        /// <returns>Información de la sucursal.</returns>
        public Dictionary<string, string> GetSucursalInfo()
        {
            Dictionary<string, string> sucursales = new Dictionary<string, string>();
            string query = "SELECT Sucursal_Id, Sucursal_Descripcion FROM vw_cat_Sucursales";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sucursales.Add(reader["Sucursal_Descripcion"].ToString(), reader["Sucursal_Id"].ToString());
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return sucursales;
        }
        /// <summary>
        /// Obtiene el identificador de la sucursal.
        /// </summary>
        /// <returns>Identificador de la sucursal.</returns>
        /// <param name="sucursal">Nombre de la sucursal.</param>
        public int GetSucursalId(string sucursal)
        {
            string query = "SELECT Sucursal_Id FROM vw_cat_Sucursales WHERE Sucursal_Descripcion = @sucursal";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@sucursal", sucursal);
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return -1;
        }

        /// <summary>
        /// Obtiene las sucursales
        /// </summary>
        /// <returns>Lista de sucursales.</returns>
        public List<SucursalModel> GetSucursales()
        {
            List<SucursalModel> sucursales = new List<SucursalModel>();
            string query = "SELECT Sucursal_Id, Sucursal_Domicilio, Sucursal_Descripcion, Territorio_Colonia_Descripcion FROM vw_cat_Sucursales";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sucursales.Add(new SucursalModel
                    {
                        Sucursal_Id = reader["Sucursal_Id"].ToString(),
                        Sucursal_Domicilio = reader["Sucursal_Domicilio"].ToString(),
                        Sucursal_Descripcion = reader["Sucursal_Descripcion"].ToString(),
                        Territorio = new TerritorioModel
                        {
                            Colonia = reader["Territorio_Colonia_Descripcion"].ToString()
                        }
                        //Sucursal_Imagen = reader["Sucursal_Imagen"].ToString()                                               
                    });
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return sucursales;
        }

    }
}
