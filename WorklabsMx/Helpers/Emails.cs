using System;
using System.Net;
using System.Net.Mail;
using WorklabsMx.Models;

namespace WorklabsMx
{
    public class Emails
    {
        private Configuraciones configuracion;
        public Emails()
        {
            configuracion = new DataBase().GetConfiguraciones("CORREO ELECTRÓNICO PARA NOTIFICACIONES");
        }

        public void SendMail(string email, string name, string password)
        {

            MailMessage message = new MailMessage(configuracion.Parametro_Varchar_1, email);
            message.Subject = "Recuperación de contraseña";
            message.Body = "Hola " + name + "\n Tu contraseña nueva es: " + password;
            SmtpClient client = new SmtpClient();
            client.Port = Convert.ToInt32(configuracion.Parametro_Int_1);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(configuracion.Parametro_Varchar_1, "worklabs1000");
            client.Host = configuracion.Parametro_Varchar_3;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción enviando el correo: {0}",
                                  ex.Message);
            }
        }
    }
}
