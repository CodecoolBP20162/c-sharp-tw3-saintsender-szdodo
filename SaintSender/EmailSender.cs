using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class EmailSender
    {

        public static void SendMail(string from, string to, string password, string subject, string emailMessage)
        {
            var message = new MailMessage(from, to);
            message.Subject = subject;
            message.Body = emailMessage;
            SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587);
            mailer.Credentials = new NetworkCredential(from, password);
            mailer.EnableSsl = true;
            mailer.Send(message);
        }
    }
}
