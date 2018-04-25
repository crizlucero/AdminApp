using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class LoginController : DataBaseModel
    {
        /// <summary>
        /// Inicia sesión el usuario
        /// </summary>
        /// <returns>Identificador del usuario</returns>
        /// <param name="email">Correo electrónico</param>
        /// <param name="password">Contraseña</param>
        public List<string> MemberLogin(string email, string password)
        {
            List<string> datos = new List<string>();
            try
            {
                string query = "SELECT Usuario_Id, Usuario_Tipo FROM vw_pro_Usuarios_Accesos where Usuario_Servicio_Usuario = @email and Usuario_Estatus = 1 --and Usuario_Servicio_Contrasena = @password";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", new PassSecurity().EncodePassword(password));
                conn.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader["Usuario_Id"].ToString());
                    datos.Add(reader["Usuario_Tipo"].ToString());
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "MemberLogin");
            }
            finally
            {
                conn.Close();
            }
            return datos;
        }

        /// <summary>
        /// Valida que exista el correo en los miembros inscritos
        /// </summary>
        /// <returns>Nombre e identificador del miembro registrado</returns>
        /// <param name="email">Correo electrónico</param>
        public string ValidateMember(string email)
        {
            try
            {
                conn.Open();

                string query = "SELECT miembro_id, miembro_nombre FROM VW_CAT_MIEMBROS_EMPRESAS WHERE MIEMBRO_CORREO_ELECTRONICO = @email";
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@email", email);
                return command.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message, GetType().Name, "ValidateMember");
            }
            finally
            {
                conn.Close();
            }
            return "";
        }

        /// <summary>
        /// Registra en la base de datos la nueva contraseña del miembro
        /// </summary>
        /// <returns>Si se pudo registrar el usuario</returns>
        /// <param name="email">Correo electrónico</param>
        /// <param name="password">Contraseña nueva</param>
        public bool Registrarenbd(string email, string password)
        {
            string newPassword = new PassSecurity().EncodePassword(password);
            transaction = conn.BeginTransaction();
            try
            {
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Miembros_Update_Password";

                command.Parameters.AddWithValue("@Miembro_contrasena", newPassword);
                command.Parameters.AddWithValue("@Miembro_Correo_Electronico", email);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "Registrarenbd");
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}
