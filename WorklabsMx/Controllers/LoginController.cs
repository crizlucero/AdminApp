using System;
using System.Data;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class LoginController : DataBaseModel
    {
        public LoginController() : base()
        {

        }
        /// <summary>
        /// Inicia sesión el usuario
        /// </summary>
        /// <returns>Identificador del usuario</returns>
        /// <param name="email">Correo electrónico</param>
        /// <param name="password">Contraseña</param>
        public int MemberLogin(string email, string password)
        {
            try
            {
                string query = "SELECT Miembro_Id FROM vw_cat_miembros where Miembro_Correo_Electronico = @email --and Miembro_Contrasena = @password";
                this.command = this.CreateCommand(query);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                this.conn.Open();
                this.reader = command.ExecuteReader();
                while (reader.Read())
                {

                    return reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.conn.Close();
            }
            return -1;
        }

        /// <summary>
        /// Valida que exista el correo en los miembros inscritos
        /// </summary>
        /// <returns>Nombre e identificador del miembro registrado</returns>
        /// <param name="email">Correo electrónico</param>
        public string ValidateMember(string email)
        {
            string miembro = string.Empty;
            try
            {
                conn.Open();

                string query = "SELECT miembro_id, miembro_nombre FROM VW_CAT_MIEMBROS_EMPRESAS WHERE MIEMBRO_CORREO_ELECTRONICO = @email";
                command = this.CreateCommand(query);
                command.Parameters.AddWithValue("@email",email);
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    miembro = reader["Empresa_Miembro_Id"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return miembro;
        }

        /// <summary>
        /// Registra en la base de datos la nueva contraseña del miembro
        /// </summary>
        /// <returns>Si se pudo registrar el usuario</returns>
        /// <param name="email">Correo electrónico</param>
        /// <param name="password">Contraseña nueva</param>
        public bool registrarenbd(string email, string password)
        {

            string newPassword = new PassSecurity().EncodePassword(password);


            transaction = conn.BeginTransaction();
            try
            {

                command = this.CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Miembros_Update_Password";

                command.Parameters.AddWithValue("@Miembro_contrasena", newPassword);
                command.Parameters.AddWithValue("@Miembro_Correo_Electronico", email);


                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
                //clsLog.ReportarError("CARPETA: Sign_In" + Environment.NewLine + "PAGINA: login.aspx" + Environment.NewLine + "PROCESO: bttnActualizarUser_Command" + Environment.NewLine + "ERROR: " + ex.Message);
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
