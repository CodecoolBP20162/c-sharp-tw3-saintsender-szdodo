using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class SaintSenderForm : Form
    {
        EmailSender Sender;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public SaintSenderForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        //testElekCC testElek00
        //some encrypting would be nice

        private void SaintSenderForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("userconfig.dat")) LoadUser(); else LoginDisplay();
        }

        private void StartTimer()
        {
            t.Interval = 2000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (Sender.loaded) ShowMails();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!Validation.CorrectEmailAddress(EmailTxt.Text) || Validation.EmptyInput(PasswordTxt.Text))
            {
                MessageBox.Show("Please fill in every field correctly");
                return;
            }
            User newUser = new User(EmailTxt.Text, PasswordTxt.Text);
            Sender = new EmailSender(newUser);
            Thread first = new Thread(new ThreadStart(Sender.RetrieveMail));
            first.Start();
            first.Join();
            ShowMails();
            if (Sender.loggedIn) MailDisplay(); else LoginDisplay();
        }


        private void MailDisplay()
        {
            LoginPanel.Visible = false;
            MailPanel.Visible = true;
            NewPanel.Visible = false;
            AutoRefresh();
        }

        private void NewDisplay()
        {
            t.Stop();
            ToTxt.Clear();
            SubjectTxt.Clear();
            MsgTxt.Clear();
            LoginPanel.Visible = false;
            MailPanel.Visible = false;
            NewPanel.Visible = true;
        }

        private void LoginDisplay()
        {
            t.Stop();
            EmailTxt.Clear();
            PasswordTxt.Clear();
            LoginPanel.Visible = true;
            MailPanel.Visible = false;
            NewPanel.Visible = false;
        }

        private void NewMailBtn_Click(object sender, EventArgs e)
        {
            NewDisplay();
        }

        
        private void SendBtn_Click(object sender, EventArgs e)
        {
            User user = new User("testElekCC@gmail.com", "testElek00");
            string toAddress = ToTxt.Text;
            if (!Validation.CorrectEmailAddress(toAddress))
            {
                MessageBox.Show("Incorrect email address");
                return;
            }
            if (Validation.EmptyInput(SubjectTxt.Text) || Validation.EmptyInput(MsgTxt.Text))
            {
                MessageBox.Show("Please fill in every field");
                return;
            }
            Sender.SendMail(toAddress, SubjectTxt.Text, MsgTxt.Text);
            MailDisplay();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (Sender.loaded)
            {
                ShowMails();
            }
        }

        private void AutoRefresh()
        {
            Thread first = new Thread(new ThreadStart(Sender.RetrieveMail));
            first.Start();
            StartTimer();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            MailDisplay();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Sender = null;
            File.Delete("userconfig.dat");
            LoginDisplay();
        }

        private void ShowMails()
        {
            Sender.loaded = false;
            MailBox.Items.Clear();

            foreach (string[] mail in Sender.mails)
            {
                var listViewItem = new ListViewItem(mail);
                MailBox.Items.Add(listViewItem);
            }
            MailBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            Sender.user.Serialize();
        }

        private void LoadUser()
        {
            t.Stop();
            User oldUser = User.Deserialize();
            EmailTxt.Text = oldUser.EmailAddress;
            PasswordTxt.Text = oldUser.Password;
            LoginPanel.Visible = true;
            MailPanel.Visible = false;
            NewPanel.Visible = false;
        }
    }
}
