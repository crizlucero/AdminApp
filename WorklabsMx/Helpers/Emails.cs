using System;
using System.Net;
using System.Net.Mail;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;


namespace WorklabsMx
{
    public class Emails
    {
        readonly ConfiguracionesModel configuracion;
        public Emails()
        {
            configuracion = new ConfigurationsController().GetConfiguraciones("CORREO ELECTRÓNICO PARA NOTIFICACIONES");
        }
        /// <summary>
        /// Envia el correo electrónico con los datos del cliente
        /// </summary>
        /// <param name="email">Correo electrónico</param>
        /// <param name="name">Nombre de la persona que se le enviará el correo</param>
        /// <param name="password">Contraseña</param>
        public void SendMail(string email, string name, string password)
        {

            MailMessage message = new MailMessage(configuracion.Parametro_Varchar_1, email);
            message.Subject = "Recuperación de contraseña";
            message.Body = "Hola " + name + "\n Tu contraseña nueva es: " + password;
            message.IsBodyHtml = true;
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
                SlackLogs.SendMessage(ex.Message);
            }
        }
        /// <summary>
        /// Envia el correo electrónico de la invitación
        /// </summary>
        /// <param name="email">Correo electrónico</param>
        /// <param name="cc">CC</param>
        /// <param name="name">Nombre</param>
        /// <param name="clave">Clave de acceso</param>
        public void SendMailInvitado(string email, string cc, string name, string clave)
        {

            MailMessage message = new MailMessage(configuracion.Parametro_Varchar_1, email);
            message.Subject = "Recuperación de contraseña";
            message.Body = "Hola " + name + "\n Tu código de acceso es: \n<img src='https://api.qrserver.com/v1/create-qr-code/?data=" + clave + "&amp;size=60x60'/>";
            //MailKit client = new MailKit();
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
                SlackLogs.SendMessage(ex.Message);
            }
        }
    }
}
