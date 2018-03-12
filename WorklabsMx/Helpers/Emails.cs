using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;


namespace WorklabsMx
{
    public class Emails
    {
        readonly ConfiguracionesModel configuracion;
        public Emails() => configuracion = new ConfigurationsController().GetConfiguraciones("CORREO ELECTRÓNICO PARA NOTIFICACIONES");

        /// <summary>
        /// Envia el correo electrónico con los datos del cliente
        /// </summary>
        /// <param name="email">Correo electrónico</param>
        /// <param name="name">Nombre de la persona que se le enviará el correo</param>
        /// <param name="html">Texto html para el correo</param>
        /// <param name="subject">Asunto del correo</param>
        public void SendMail(string email, string name, string html, string subject)
        {
            Task.Run(() =>
            {
                try
                {
                    MimeMessage msg = new MimeMessage
                    {
                        Subject = subject,
                        Body = new TextPart(MimeKit.Text.TextFormat.Html)
                        {
                            Text = html
                        }
                    };
                    msg.From.Add(new MailboxAddress("Worklabs", "desarrollo@worklabs.mx"));
                    msg.To.Add(new MailboxAddress(name, email));

                    using (SmtpClient client = new SmtpClient())
                    {
                        client.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("desarrollo@worklabs.mx", "worklabs1000");
                        client.Send(msg);
                        client.Disconnect(true);
                    }
                }
                catch (Exception e)
                {
                    SlackLogs.SendMessage(e.Message, GetType().Name, "SendMail");
                }
            });

        }
    }
}
