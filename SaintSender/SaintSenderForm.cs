using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
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

        private void RetriverTest()
        {
            /*
            var client = new POPClient();
            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate("admin@bendytree.com", "YourPasswordHere");
            var count = client.GetMessageCount();
            Message message = client.GetMessage(count);
            Console.WriteLine(message.Headers.Subject);
            */


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
    }
}
