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
        public User user;
        public ArrayList mails = new ArrayList();
        public Boolean loggedIn = false;
        public Boolean loaded = false;
        int numberOfMails=0;

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
            loaded = false;
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

                if (numberOfMails < inbox.Count)
                {
                    mails.Clear();
                    for (int i = inbox.Count - 1; i >= 0; i--)
                    {
                        var message = inbox.GetMessage(i);
                        try
                        {
                            string[] row = { message.To.ToString(), message.Subject, message.TextBody };
                            mails.Add(row);
                        }
                        catch (ArgumentNullException)
                        {
                            mails.Add("Empty message");
                        }
                    }
                    numberOfMails = inbox.Count;
                    loaded = true;
                }
                client.Disconnect(true);
            }

        }
    }
}
