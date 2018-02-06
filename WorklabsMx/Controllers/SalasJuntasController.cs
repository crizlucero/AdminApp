using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class SalasJuntasController : DataBaseModel
    {
        /// <summary>
		/// Crea la reservación de la sala de juntas.
        /// </summary>
        /// <returns>Identificador de la reservación de la sala de juntas.</returns>
        /// <param name="transaccion">Tipo de transaccion.</param>
        /// <param name="sala_id">Identificador de la sala de juntas.</param>
        /// <param name="usuario_id">Identificador del usuario.</param>
        /// <param name="usuario_tipo">Tipo de usuario.</param>
        /// <param name="fecha">Fecha seleccionada.</param>
        /// <param name="hora_inicio">Hora de inicio.</param>
        /// <param name="hora_fin">Hora de fin.</param>
        public int AsignarSalaJuntas(string transaccion, string sala_id, string usuario_id, string usuario_tipo, DateTime fecha, string hora_inicio, string hora_fin)
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
                command.Parameters.Add("@Sala_Junta_Reservacion_Id", SqlDbType.Int).Direction = ParameterDirection.Output;

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

        /// <summary>
        /// Cancela la reservación de la sala de juntas.
        /// </summary>
        /// <returns><c>true</c>, si la reservación fue cancelada, <c>false</c> existió un error.</returns>
        /// <param name="transaccion">Tipo de transacción.</param>
        /// <param name="reservacion_id">Identificador de la reservación.</param>
        public bool CancelarSalaJuntas(string transaccion, string reservacion_id)
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
                command.Parameters.AddWithValue("@Sala_Junta_Reservacion_Id", reservacion_id);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally { conn.Close(); }
            return true;
        }

        /// <summary>
        /// Obtiene las salas de juntas de la sucursal
        /// </summary>
        /// <returns>Listado de salas de juntas.</returns>
        /// <param name="sucursal_id">Identificador de la sucursal.</param>
        public List<SalaJuntasModel> GetSalaJuntas(string sucursal_id, string nivel = "7")
        {
            List<SalaJuntasModel> salas = new List<SalaJuntasModel>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM vw_cat_Salas_Juntas WHERE Sala_Estatus = 1 AND Sucursal_Id = @sucursal_id AND Sala_Nivel = @nivel";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@sucursal_id", sucursal_id);
                command.Parameters.AddWithValue("@nivel", nivel);
                reader = command.ExecuteReader();
                while (reader.Read())
                    salas.Add(new SalaJuntasModel
                    {
                        Sala_Descripcion = reader["Sala_Descripcion"].ToString(),
                        Sala_Id = reader["Sala_Id"].ToString(),
                        Sala_Estatus = reader["Sala_Estatus"].ToString(),
                        Sala_Capacidad = reader["Sala_Capacidad"].ToString(),
                        Sala_Nivel = reader["Sala_Nivel"].ToString(),
                        Sucursal_Id = reader["Sucursal_Id"].ToString(),
                        Sucursal_Descripcion = reader["Sucursal_Descripcion"].ToString(),
                        Sucursal_Estatus = reader["Sucursal_Estatus"].ToString()
                    });
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return salas;
        }

        /// <summary>
        /// Obtiene el historial de las reservaciones de las salas de juntas realizadas por el usuario
        /// </summary>
        /// <returns>Listado de las reservaciones de las salas de juntas.</returns>
        /// <param name="usuario_id">Identificador del usuario.</param>
        /// <param name="usuario_tipo">Tipo de usuario.</param>
        /// <param name="reservacion_estatus">Estado de la reservación.</param>
        public List<SalaJuntasReservacionModel> GetReservaciones(string usuario_id, string usuario_tipo, int reservacion_estatus)
        {
            List<SalaJuntasReservacionModel> salas = new List<SalaJuntasReservacionModel>();
            try
            {
                conn.Open();
                string query = "SELECT * FROM vw_pro_Salas_Juntas_Reservaciones " +
                    "WHERE Sala_Estatus = 1 AND Sucursal_Estatus = 1 AND Usuario_Id = @usuario_id " +
                    "AND Usuario_Tipo = @usuario_tipo AND Sala_Junta_Reservacion_Estatus = @reservacion_estatus " +
                    "Order by Sala_Junta_Hora_Inicio";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@usuario_id", usuario_id);
                command.Parameters.AddWithValue("@usuario_tipo", usuario_tipo);
                command.Parameters.AddWithValue("@reservacion_estatus", reservacion_estatus);
                reader = command.ExecuteReader();
                while (reader.Read())
                    salas.Add(new SalaJuntasReservacionModel
                    {
                        Sala_Descripcion = reader["Sala_Descripcion"].ToString(),
                        Sala_Id = reader["Sala_Id"].ToString(),
                        Sala_Estatus = reader["Sala_Estatus"].ToString(),
                        Sala_Capacidad = reader["Sala_Capacidad"].ToString(),
                        Sala_Nivel = reader["Sala_Nivel"].ToString(),
                        Sala_Fecha = reader["Sala_Junta_Fecha"].ToString(),
                        Sala_Hora_Inicio = reader["Sala_Junta_Hora_Inicio"].ToString(),
                        Sala_Hora_Fin = reader["Sala_Junta_Hora_Fin"].ToString(),
                        Sucursal_Id = reader["Sucursal_Id"].ToString(),
                        Sucursal_Descripcion = reader["Sucursal_Descripcion"].ToString(),
                        Sucursal_Estatus = reader["Sucursal_Estatus"].ToString(),
                        Usuario_Id = reader["Usuario_Id"].ToString(),
                        Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                        Sala_Reservacion_Estatus = reader["Sala_Junta_Reservacion_Estatus"].ToString(),
                        Sala_Junta_Reservacion_Id = reader["Sala_Junta_Reservacion_Id"].ToString()
                    });
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return salas;
        }

        /// <summary>
        /// Se obtienen las horas ya reservadas en el día seleccionado
        /// </summary>
        /// <returns>Listado de horas reservadas.</returns>
        /// <param name="fecha">Fecha seleccionada.</param>
        /// <param name="sala_id">Identificador de la sala de juntas</param>
        public List<SalaJuntasReservacionModel> GetHorasNoDisponibles(string fecha, string sala_id)
        {
            List<SalaJuntasReservacionModel> salas = new List<SalaJuntasReservacionModel>();
            try
            {
                conn.Open();
                string query = "SELECT Sala_Junta_Reservacion_Id, Sala_Junta_Hora_Inicio, Sala_Junta_Hora_Fin, Usuario_Id, Usuario_Tipo FROM vw_pro_Salas_Juntas_Reservaciones " +
                    "WHERE Sala_id = @sala_id AND Sala_Junta_Reservacion_Estatus = 1 AND Sala_Junta_Fecha = @fecha";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@sala_id", sala_id);
                command.Parameters.AddWithValue("@fecha", fecha);
                reader = command.ExecuteReader();
                while (reader.Read())
                    salas.Add(new SalaJuntasReservacionModel
                    {
                        Sala_Hora_Inicio = reader["Sala_Junta_Hora_Inicio"].ToString(),
                        Sala_Hora_Fin = reader["Sala_Junta_Hora_Fin"].ToString(),
                        Usuario_Id = reader["Usuario_Id"].ToString(),
                        Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                        Sala_Junta_Reservacion_Id = reader["Sala_Junta_Reservacion_Id"].ToString()
                    });

            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return salas;
        }

        public Dictionary<string, string> GetNivelesSucursal(string sucursal_id)
        {
            Dictionary<string, string> niveles = new Dictionary<string, string>();
            try
            {
                conn.Open();
                string query = "SELECT Sala_Nivel FROM vw_cat_Salas_Juntas WHERE Sala_Estatus = 1 AND Sucursal_Id = @sucursal_id GROUP BY Sala_Nivel";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@sucursal_id", sucursal_id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    niveles.Add("Nivel " + reader["Sala_Nivel"].ToString(), reader["Sala_Nivel"].ToString());
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return niveles;
        }
    }
}
