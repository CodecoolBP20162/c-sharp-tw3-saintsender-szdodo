using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class SaintSenderForm : Form
    {
        public SaintSenderForm()
        {
            InitializeComponent();
        }

        //testElekCC testElek00
        private void SenderTest()
        {
            User use = new User("testElekCC@gmail.com", "testElek00");
            EmailSender.SendMail(use.EmailAddress, use.EmailAddress, use.Password, "Hey sexy Mama", "You are AAAWSOME");
        }

        //külön szálra h ne csússzon el a display amíg tölt
        private void RetriverTest()
        {
            using (var client = new ImapClient())
            {
                // For demo-purposes, accept all SSL certificates
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("imap.gmail.com", 993, true);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate("testElekCC", "testElek00");

                // The Inbox folder is always available on all IMAP servers...
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                MailBox.Items.Add(inbox.Count.ToString());
                MailBox.Items.Add("Recent messages: " + inbox.Recent);

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    MailBox.Items.Add("Subject: " + message.Subject);
                }

                client.Disconnect(true);
            }


        }

        private void SaintSenderForm_Load(object sender, EventArgs e)
        {
            LoginDisplay();
            //SenderTest();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            User newUser = new User(EmailTxt.Text, PasswordTxt.Text);
            MailDisplay();
            RetriverTest();
        }

        private void MailDisplay()
        {
            LoginPanel.Visible = false;
            MailPanel.Visible = true;
            NewPanel.Visible = false;
        }

        private void NewDisplay()
        {
            LoginPanel.Visible = false;
            MailPanel.Visible = false;
            NewPanel.Visible = true;
        }

        private void LoginDisplay()
        {
            LoginPanel.Visible = true;
            MailPanel.Visible = false;
            NewPanel.Visible = false;
        }

        private void NewMailBtn_Click(object sender, EventArgs e)
        {
            NewDisplay();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
        }

        private Boolean CorrectEmailAddress(string Address)
        {
            if (Regex.IsMatch(Address, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                return true;
            else
                return false;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            User use = new User("testElekCC@gmail.com", "testElek00");
            string toAddress = ToTxt.Text;
            if (!CorrectEmailAddress(toAddress)) return;
            EmailSender.SendMail(use.EmailAddress, toAddress, use.Password, SubjectTxt.Text, MsgTxt.Text);
        }
    }
}
