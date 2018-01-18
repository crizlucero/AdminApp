using System;
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
		public bool RegistraInvitado(string nombre, string apellidos, string email, string asunto, DateTime fecha_entrada, string sucursal_id, string usuario_id, string usuario_tipo)
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

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }

            catch (Exception ex)
            {
                SlackLogs.SendMessage(ex.Message);
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            //new Emails().SendMailInvitado(email, nombre, clave);
            return true;
        }
    }
}
