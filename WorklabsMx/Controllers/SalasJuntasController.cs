using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class SalasJuntasController : DataBaseModel
    {
        public int AsignarSalaJuntas(string transaccion, string sala_id, string usuario_id, string usuario_tipo, string fecha, string hora_inicio, string hora_fin, string reservacion_id = null)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Salas_Juntas_Reservacion";
                command.Connection = conn;
                command.Parameters.AddWithValue("@Trasaccion", transaccion);
                command.Parameters.AddWithValue("@Sala_Junta_Id", sala_id);
                command.Parameters.AddWithValue("@Usuario_Id", usuario_id);
                command.Parameters.AddWithValue("@Usuario_Tipo", usuario_tipo);
                command.Parameters.AddWithValue("@Sala_Junta_Fecha", fecha);
                command.Parameters.AddWithValue("@Sala_Junta_Hora_Inicio", hora_inicio);
                command.Parameters.AddWithValue("@Sala_Junta_Hora_Fin", hora_fin);
                command.Parameters.AddWithValue("@Sala_Junta_Reservacion_Id", reservacion_id).Direction = ParameterDirection.InputOutput;

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                return Convert.ToInt32(command.Parameters["@Sala_Junta_Reservacion_Id"].Value);
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                return -1;
            }
            finally { conn.Close(); }
        }

        public List<SalaJuntasModel> GetSalaJuntas()
        {
            List<SalaJuntasModel> salas = new List<SalaJuntasModel>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM vw_cat_Salas_Juntas WHERE Sala_Estatus = 1 AND Sucursal_Estatus = 1";
                command = CreateCommand(query);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    salas.Add(new SalaJuntasModel
                    {
                        Sala_Descripcion = reader["Sala_Descripcion"].ToString(),
                        Sala_Id = reader["Sala_Id"].ToString(),
                        Sala_Estatus = reader["Sala_Descripcion"].ToString(),
                        Sala_Capacidad = reader["Sala_Capacidad"].ToString(),
                        Sala_Nivel = reader["Sala_Nivel"].ToString(),
                        Sucursal = new SucursalModel
                        {
                            Sucursal_Id = reader["Sucursal_Id"].ToString(),
                            Sucursal_Descripcion = reader["Sucursal_Id"].ToString(),
                            Sucursal_Estatus = reader["Sucursal_Estatus"].ToString()
                        }
                    });
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return salas;
        }
    }
}
