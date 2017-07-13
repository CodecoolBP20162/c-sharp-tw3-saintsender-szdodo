using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public SaintSenderForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        //testElekCC testElek00
        //külön szálra h ne csússzon el a display amíg tölt
        //autorefresh

        private void SaintSenderForm_Load(object sender, EventArgs e)
        {
            LoginDisplay();
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
        }

        private void NewDisplay()
        {
            ToTxt.Clear();
            SubjectTxt.Clear();
            MsgTxt.Clear();
            LoginPanel.Visible = false;
            MailPanel.Visible = false;
            NewPanel.Visible = true;
        }

        private void LoginDisplay()
        {
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //serialize the message
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
            Thread first = new Thread(new ThreadStart(Sender.RetrieveMail));
            first.Start();
            ShowMails();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            MailDisplay();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Sender = null;
            LoginDisplay();
        }

        private void ShowMails()
        {
            MailBox.Items.Clear();
            foreach(string[] mail in Sender.mails)
            {
                var listViewItem = new ListViewItem(mail);
                MailBox.Items.Add(listViewItem);
            }
            MailBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}
