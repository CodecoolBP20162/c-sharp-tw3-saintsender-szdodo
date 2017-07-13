using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    class EmailSender
    {
        User user;
        public ArrayList mails = new ArrayList();
        public Boolean loggedIn = false;

        public EmailSender(User user)
        {
            this.user = user;
        }

        public void SendMail(string to, string subject, string emailMessage)
        {
            var message = new MailMessage(user.EmailAddress, to);
            message.Subject = subject;
            message.Body = emailMessage;
            SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587);
            mailer.Credentials = new NetworkCredential(user.EmailAddress, user.Password);
            mailer.EnableSsl = true;
            mailer.Send(message);
        }

        public void RetrieveMail()
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("imap.gmail.com", 993, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                try
                {
                    client.Authenticate(user.UserName, user.Password);
                }
                catch (MailKit.Security.AuthenticationException)
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }
                catch (ProtocolException)
                {
                    MessageBox.Show("Login failed");
                    return;
                }
                loggedIn = true;
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                //MailBox.Items.Add("Total messages: " + inbox.Count.ToString());
                //MailBox.Items.Add("Recent messages: " + inbox.Recent);


                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    try
                    {
                        string[] row = { message.To.ToString(), message.Subject, message.TextBody};
                        mails.Add(row);
                    }
                    catch (ArgumentNullException)
                    {
                        mails.Add("Empty message");
                    }
                }

                client.Disconnect(true);
            }

        }
    }
}
