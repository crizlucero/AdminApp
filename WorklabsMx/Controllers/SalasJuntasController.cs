using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
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
        public int AsignarSalaJuntas(string transaccion, string sala_id, string usuario_id, string usuario_tipo, DateTime fecha, string hora_inicio, string hora_fin, string creditos, string personas)
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
                command.Parameters.AddWithValue("@Cantidad_Creditos", creditos);
                command.Parameters.AddWithValue("@Cantidad_Personas", personas);
                command.Parameters.Add("@Sala_Junta_Reservacion_Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                return Convert.ToInt32(command.Parameters["@Sala_Junta_Reservacion_Id"].Value);
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "AsignarSalaJuntas");
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
                SlackLogs.SendMessage(e.Message, GetType().Name, "CancelarSalaJuntas");
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
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetSalaJuntas"); }
            finally { conn.Close(); }
            return salas;
        }

        public List<SalaJuntasModel> GetSalaJuntas(string sucursal_id, string fecha, string hora_inicio, string hora_fin, string capacidad = null)
        {
            List<SalaJuntasModel> salas = new List<SalaJuntasModel>();
            DateTime fecha_inicio;
            DateTime fecha_fin;
            fecha_inicio = DateTime.Parse(fecha + " " + hora_inicio, new CultureInfo("es-MX"));
            int HoraFin = int.Parse(hora_fin.Split(':')[0]);
            if (HoraFin == 24)
            {
                fecha_fin = DateTime.Parse(fecha).AddDays(1);
            }
            else
            {
                fecha_fin = DateTime.Parse(fecha + " " + hora_fin, new CultureInfo("es-MX"));
            }


            try
            {
                conn.Open();
                command = CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_vw_pro_Salas_Juntas_Disponibles";
                command.Connection = conn;
                command.Parameters.AddWithValue("@sucursal_id", sucursal_id);
                command.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                command.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                command.Parameters.AddWithValue("@capacidad", capacidad);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    salas.Add(new SalaJuntasModel
                    {
                        Sala_Descripcion = reader["Sala_Descripcion"].ToString(),
                        Sala_Id = reader["Sala_Id"].ToString(),
                        Sala_Estatus = reader["Sala_Estatus"].ToString(),
                        Sala_Capacidad = reader["Sala_Capacidad"].ToString(),
                        Sala_Nivel = reader["Sala_Nivel"].ToString(),
                        Sucursal_Id = reader["Sucursal_Id"].ToString(),
                        Sucursal_Descripcion = reader["Sucursal_Descripcion"].ToString(),
                        Sucursal_Estatus = reader["Sucursal_Estatus"].ToString(),
                        Sala_Fotografia = reader["Sala_Fotografia"].ToString()
                    });
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetSalaJuntas"); }
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
        public List<SalaJuntasReservacionModel> GetReservaciones(string usuario_id, string usuario_tipo, string reservacion_estatus)
        {
            List<SalaJuntasReservacionModel> salas = new List<SalaJuntasReservacionModel>();
            try
            {
                conn.Open();
                string estatus = string.Empty;
                reservacion_estatus.Split(',').AsParallel().ToList().ForEach(estado =>
                {
                    estatus += estado + ",";
                });
                string query = "SELECT * FROM vw_pro_Salas_Juntas_Reservaciones " +
                    "WHERE Sala_Estatus = 1 AND Sucursal_Estatus = 1 AND Usuario_Id = @usuario_id " +
                    "AND Usuario_Tipo = @usuario_tipo AND Sala_Junta_Reservacion_Estatus in (" + estatus.Substring(0, estatus.Length - 1) + ") " +
                    "Order by Sala_Junta_Hora_Inicio";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@usuario_id", usuario_id);
                command.Parameters.AddWithValue("@usuario_tipo", usuario_tipo);
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
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetReservaciones"); }
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
                command.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));
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
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetHorasNoDisponibles"); }
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
                    niveles.Add("Nivel " + reader["Sala_Nivel"], reader["Sala_Nivel"].ToString());
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetNivelesSucursal"); }
            finally { conn.Close(); }
            return niveles;
        }

        public int GetCreditosDisponibles(string usuario_id)
        {
            try
            {
                conn.Open();
                command = CreateCommand();
                command.CommandText = "sp_pro_Miembro_Creditos";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;
                command.Parameters.AddWithValue("@Miembro_Id", usuario_id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int CreditosUsados;
                    int CreditosDisponibles;
                    if (reader["Creditos_Usados"] == DBNull.Value)
                    {
                        CreditosUsados = 0;
                    }
                    else
                    {
                        CreditosUsados = Convert.ToInt32(reader["Creditos_Usados"]);
                    }
                    if (reader["Creditos_Disponibles"] == DBNull.Value)
                    {
                        CreditosDisponibles = 0;
                    }
                    else
                    {
                        CreditosDisponibles = Convert.ToInt32(reader["Creditos_Disponibles"]);
                    }
                    return Convert.ToInt32(CreditosDisponibles - CreditosUsados);
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetCreditosDisponibles"); }
            finally { conn.Close(); }


            return 0;
        }

        public SalaJuntasModel GetSalaJuntasInfo(string sala_id)
        {
            SalaJuntasModel sala = new SalaJuntasModel();

            try
            {
                conn.Open();
                string query = "SELECT * FROM vw_cat_Salas_Juntas WHERE Sala_Id = @sala_id";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@sala_id", sala_id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sala = new SalaJuntasModel
                    {
                        Sala_Descripcion = reader["Sala_Descripcion"].ToString(),
                        Sala_Nivel = reader["Sala_Nivel"].ToString(),
                        Sala_Capacidad = reader["Sala_Capacidad"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetSalaJuntas");
            }
            finally { conn.Close(); }

            return sala;
        }

        public int CountReservaciones(string usuario_id, string usuario_tipo)
        {

            try
            {
                conn.Open();
                string query = "SELECT count(*) FROM vw_pro_Salas_Juntas_Reservaciones " +
                    "WHERE Sala_Estatus = 1 AND Sucursal_Estatus = 1 AND Usuario_Id = @usuario_id " +
                    "AND Usuario_Tipo = @usuario_tipo";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@usuario_id", usuario_id);
                command.Parameters.AddWithValue("@usuario_tipo", usuario_tipo);
                reader = command.ExecuteReader();
                while (reader.Read())
                    return reader.GetInt32(0);
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetReservaciones"); }
            finally { conn.Close(); }
            return 0;
        }

        public SalaJuntasReservacionModel GetReservacion(string reservacion_id)
        {
            SalaJuntasReservacionModel sala = new SalaJuntasReservacionModel();
            try
            {
                conn.Open();
                string estatus = string.Empty;
                string query = "SELECT * FROM vw_pro_Salas_Juntas_Reservaciones " +
                    "WHERE Sala_Junta_Reservacion_Id = @reservacion_id";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@reservacion_id", reservacion_id);
                reader = command.ExecuteReader();
                while (reader.Read())
                    sala = new SalaJuntasReservacionModel
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
                    };
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetReservacion"); }
            finally { conn.Close(); }
            return sala;
        }

        public int ModificarSalaJuntas(string transaccion, string sala_id, DateTime fecha, string hora_inicio, string hora_fin, string creditos, string personas)
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
                command.Parameters.AddWithValue("@Sala_Junta_Fecha", fecha);
                command.Parameters.AddWithValue("@Sala_Junta_Hora_Inicio", hora_inicio);
                command.Parameters.AddWithValue("@Sala_Junta_Hora_Fin", hora_fin);
                command.Parameters.AddWithValue("@Cantidad_Creditos", creditos);
                command.Parameters.AddWithValue("@Cantidad_Personas", personas);
                command.Parameters.Add("@Sala_Junta_Reservacion_Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                return Convert.ToInt32(command.Parameters["@Sala_Junta_Reservacion_Id"].Value);
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "ModificarSalaJuntas");
                return -1;
            }
            finally { conn.Close(); }
        }
    }
}
