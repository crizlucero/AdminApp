using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class InvitadosController : DataBaseModel
    {
        /// <summary>
        /// Registro de invitado
        /// </summary>
        /// <returns><c>true</c>, Si invitado fue registrado, <c>false</c> Existió algún error</returns>
        /// <param name="nombre">Nombre.</param>
        /// <param name="apellidos">Apellidos.</param>
        /// <param name="email">Email.</param>
        /// <param name="asunto">Asunto.</param>
        /// <param name="fecha_entrada">Fecha entrada.</param>
        /// <param name="sucursal_id">Sucursal identifier.</param>
        /// <param name="usuario_id">Usuario identifier.</param>
        /// <param name="usuario_tipo">Usuario tipo.</param>
		public int RegistraInvitado(string nombre, string apellidos, string email, string asunto, DateTime fecha_entrada, string sucursal_id, string usuario_id, string usuario_tipo)
        {
            string clave = new PassSecurity().GeneraIdentifier(20);

            try
            {
                conn.Open();

                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Visitas";

                command.Parameters.AddWithValue("@Trasaccion", "ALTA");
                command.Parameters.AddWithValue("@Visita_Nombre", nombre);
                command.Parameters.AddWithValue("@Visita_Apellidos", apellidos);

                command.Parameters.AddWithValue("@Visita_Fecha_Entrada", fecha_entrada);
                command.Parameters.AddWithValue("@Visita_Email", email);
                command.Parameters.AddWithValue("@Visita_Asunto", asunto);
                command.Parameters.AddWithValue("@Visita_Codigo_Acceso", clave);

                command.Parameters.AddWithValue("@Sucursal_Id", sucursal_id);
                if (usuario_tipo == ((int)TiposUsuarios.Miembro).ToString())
                {
                    command.Parameters.AddWithValue("@Miembro_Id", usuario_id);
                    command.Parameters.AddWithValue("@Colaborador_Id", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Miembro_Id", DBNull.Value);
                    command.Parameters.AddWithValue("@Colaborador_Id", usuario_id);
                }

                command.Parameters.Add("@Visita_Id", SqlDbType.Int).Direction = ParameterDirection.Output;

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                return Convert.ToInt32(command.Parameters["@Visita_Id"].Value);
            }

            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "RegistraInvitado");
                transaction.Rollback();
                Console.WriteLine(e.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
            //new Emails().SendMailInvitado(email, nombre, clave);
        }

        /// <summary>
        /// Obtiene la información de los invitados
        /// </summary>
        /// <returns>Lista de invitados.</returns>
        /// <param name="invitaciones_id">Lista de los identificadores de invitados.</param>
        public List<VisitaModel> GetInvitados(List<int> invitaciones_id)
        {
            List<VisitaModel> invitados = new List<VisitaModel>();
            string invitaciones = string.Empty;
            invitaciones_id.ForEach(key =>
            {
                invitaciones += key + ",";
            });
            string query = "select * from vw_pro_Visitas where visita_id in (" + invitaciones.Substring(0, invitaciones.Length - 1) + ")";
            try
            {
                command = CreateCommand(query);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    invitados.Add(new VisitaModel
                    {
                        Visita_Id = reader["Visita_Id"].ToString(),
                        Visita_Nombre = reader["Visita_Nombre"].ToString(),
                        Visita_Apellidos = reader["Visita_Apellidos"].ToString(),
                        Visita_Email = reader["Visita_Email"].ToString(),
                        Visita_Fecha_Entrada = reader["Visita_Fecha_Entrada"].ToString(),
                        Visita_Codigo_Acceso = reader["Visita_Codigo_Acceso"].ToString(),
                        Sucursal = new SucursalModel
                        {
                            Sucursal_Id = reader["Sucursal_Id"].ToString(),
                            Sucursal_Correo = reader["Sucursal_Correo_1"].ToString(),
                            Sucursal_Descripcion = reader["Sucursal_Descripcion"].ToString(),
                            Sucursal_Domicilio = reader["Sucursal_Calle"].ToString(),
                            Sucursal_No_Exterior = reader["Sucursal_No_Exterior"].ToString(),
                            Sucursal_No_Interior = reader["Sucursal_No_Interior"].ToString(),
                            Territorio = new TerritorioModel
                            {
                                Colonia = reader["Territorio_Colonia_Descripcion"].ToString(),
                                Municipio = reader["Territorio_Municipio_Descripcion"].ToString(),
                                Estado = reader["Territorio_Estado_Descripcion"].ToString(),
                                Pais = reader["Territorio_Pais_Descripcion"].ToString()
                            }
                        }
                    });
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetInvitados");
            }
            finally
            {
                conn.Close();
            }
            return invitados;
        }
    }
}
