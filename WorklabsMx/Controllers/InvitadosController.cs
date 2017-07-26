using System;
using System.Data;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class InvitadosController : DataBaseModel
    {
        public InvitadosController() : base()
        {
        }

        /// <summary>
        /// Registro de invitado
        /// </summary>
        /// <returns><c>true</c>, Si invitado fue registrado, <c>false</c> Existió algún error</returns>
        /// <param name="nombre">Nombre del invitado</param>
        /// <param name="asunto">Asunto.</param>
        /// <param name="email">Email.</param>
        /// <param name="emailcc">Emailcc.</param>
        /// <param name="horaEntrada">Hora entrada.</param>
        /// <param name="horaSalida">Hora salida.</param>
        /// <param name="Fecha">Fecha.</param>
		public bool RegistraInvitado(string nombre, string asunto, string email, string emailcc, DateTime horaEntrada, DateTime horaSalida, DateTime Fecha)
        {
            string clave = new PassSecurity().GeneraIdentifier(20);
            var ent_ampm = horaEntrada.ToString("tt");
            var sal_ampm = horaSalida.ToString("tt");

            char estatus = '0';
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {

                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_cat_Visitas";

                command.Parameters.AddWithValue("@Visita_Nombre", nombre);

                command.Parameters.AddWithValue("@Visita_Entrada", Fecha.ToString("yyyy-MM-dd ") + horaEntrada.ToString("hh:mm:ss"));
                command.Parameters.AddWithValue("@Visita_Entrada_AMPM", ent_ampm);
                command.Parameters.AddWithValue("@Visita_Salida", Fecha.ToString("yyyy-MM-dd ") + horaSalida.ToString("hh:mm:ss"));
                command.Parameters.AddWithValue("@Visita_Salida_AMPM", sal_ampm);
                command.Parameters.AddWithValue("@Visita_Host", emailcc);
                command.Parameters.AddWithValue("@Visita_Email", email);
                command.Parameters.AddWithValue("@Visita_Estatus", estatus);
                command.Parameters.AddWithValue("@Visita_Codigo_QR", clave);

                command.Parameters.AddWithValue("@Visita_Asunto", asunto);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }

            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                return false;
                //clsLog.ReportarError("CARPETA: Dashboard_Cliente" + Environment.NewLine + "PAGINA: registrarinvitados.aspx" + Environment.NewLine + "PROCESO: registrarenbd" + Environment.NewLine + "ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            new Emails().SendMailInvitado(email, emailcc, nombre, clave);
            return true;
        }
    }
}
