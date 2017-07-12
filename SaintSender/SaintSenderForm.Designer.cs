namespace SaintSender
{
    partial class SaintSenderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.MailPanel = new System.Windows.Forms.Panel();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.MailView = new System.Windows.Forms.ListView();
            this.NewMailBtn = new System.Windows.Forms.Button();
            this.NewPanel = new System.Windows.Forms.Panel();
            this.toLbl = new System.Windows.Forms.Label();
            this.SubjectLbl = new System.Windows.Forms.Label();
            this.MsgLbl = new System.Windows.Forms.Label();
            this.ToTxt = new System.Windows.Forms.TextBox();
            this.SubjectTxt = new System.Windows.Forms.TextBox();
            this.MsgTxt = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.MailPanel.SuspendLayout();
            this.NewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.PasswordTxt);
            this.LoginPanel.Controls.Add(this.EmailTxt);
            this.LoginPanel.Controls.Add(this.PasswordLbl);
            this.LoginPanel.Controls.Add(this.emailLbl);
            this.LoginPanel.Controls.Add(this.RegisterBtn);
            this.LoginPanel.Controls.Add(this.LoginBtn);
            this.LoginPanel.Location = new System.Drawing.Point(24, 24);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(248, 226);
            this.LoginPanel.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(32, 100);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(166, 20);
            this.PasswordTxt.TabIndex = 5;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(32, 40);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(166, 20);
            this.EmailTxt.TabIndex = 4;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(29, 84);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(29, 24);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(72, 13);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email address";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(93, 202);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(93, 156);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // MailPanel
            // 
            this.MailPanel.Controls.Add(this.NewPanel);
            this.MailPanel.Controls.Add(this.NewMailBtn);
            this.MailPanel.Controls.Add(this.MailView);
            this.MailPanel.Controls.Add(this.RefreshBtn);
            this.MailPanel.Location = new System.Drawing.Point(24, 24);
            this.MailPanel.Name = "MailPanel";
            this.MailPanel.Size = new System.Drawing.Size(465, 281);
            this.MailPanel.TabIndex = 1;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(16, 37);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 0;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // MailView
            // 
            this.MailView.Location = new System.Drawing.Point(118, 24);
            this.MailView.Name = "MailView";
            this.MailView.Size = new System.Drawing.Size(344, 225);
            this.MailView.TabIndex = 1;
            this.MailView.UseCompatibleStateImageBehavior = false;
            // 
            // NewMailBtn
            // 
            this.NewMailBtn.Location = new System.Drawing.Point(16, 79);
            this.NewMailBtn.Name = "NewMailBtn";
            this.NewMailBtn.Size = new System.Drawing.Size(75, 23);
            this.NewMailBtn.TabIndex = 2;
            this.NewMailBtn.Text = "New";
            this.NewMailBtn.UseVisualStyleBackColor = true;
            this.NewMailBtn.Click += new System.EventHandler(this.NewMailBtn_Click);
            // 
            // NewPanel
            // 
            this.NewPanel.Controls.Add(this.SaveBtn);
            this.NewPanel.Controls.Add(this.SendBtn);
            this.NewPanel.Controls.Add(this.MsgTxt);
            this.NewPanel.Controls.Add(this.SubjectTxt);
            this.NewPanel.Controls.Add(this.ToTxt);
            this.NewPanel.Controls.Add(this.MsgLbl);
            this.NewPanel.Controls.Add(this.SubjectLbl);
            this.NewPanel.Controls.Add(this.toLbl);
            this.NewPanel.Location = new System.Drawing.Point(0, 0);
            this.NewPanel.Name = "NewPanel";
            this.NewPanel.Size = new System.Drawing.Size(465, 281);
            this.NewPanel.TabIndex = 3;
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(29, 21);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(23, 13);
            this.toLbl.TabIndex = 0;
            this.toLbl.Text = "To:";
            // 
            // SubjectLbl
            // 
            this.SubjectLbl.AutoSize = true;
            this.SubjectLbl.Location = new System.Drawing.Point(26, 63);
            this.SubjectLbl.Name = "SubjectLbl";
            this.SubjectLbl.Size = new System.Drawing.Size(46, 13);
            this.SubjectLbl.TabIndex = 2;
            this.SubjectLbl.Text = "Subject:";
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.Location = new System.Drawing.Point(26, 107);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(53, 13);
            this.MsgLbl.TabIndex = 3;
            this.MsgLbl.Text = "Message:";
            // 
            // ToTxt
            // 
            this.ToTxt.Location = new System.Drawing.Point(95, 21);
            this.ToTxt.Name = "ToTxt";
            this.ToTxt.Size = new System.Drawing.Size(212, 20);
            this.ToTxt.TabIndex = 4;
            // 
            // SubjectTxt
            // 
            this.SubjectTxt.Location = new System.Drawing.Point(95, 63);
            this.SubjectTxt.Name = "SubjectTxt";
            this.SubjectTxt.Size = new System.Drawing.Size(212, 20);
            this.SubjectTxt.TabIndex = 6;
            // 
            // MsgTxt
            // 
            this.MsgTxt.Location = new System.Drawing.Point(95, 107);
            this.MsgTxt.Multiline = true;
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.Size = new System.Drawing.Size(330, 130);
            this.MsgTxt.TabIndex = 7;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(350, 255);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 8;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(222, 255);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // SaintSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 326);
            this.Controls.Add(this.MailPanel);
            this.Controls.Add(this.LoginPanel);
            this.Name = "SaintSenderForm";
            this.Text = "SaintSender";
            this.Load += new System.EventHandler(this.SaintSenderForm_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.MailPanel.ResumeLayout(false);
            this.NewPanel.ResumeLayout(false);
            this.NewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel MailPanel;
        private System.Windows.Forms.Button NewMailBtn;
        private System.Windows.Forms.ListView MailView;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Panel NewPanel;
        private System.Windows.Forms.TextBox MsgTxt;
        private System.Windows.Forms.TextBox SubjectTxt;
        private System.Windows.Forms.TextBox ToTxt;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Label SubjectLbl;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button SendBtn;
    }
}

