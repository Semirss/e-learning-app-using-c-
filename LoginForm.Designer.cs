namespace Skill_Nova
{
    partial class logInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginLbl = new Label();
            usrNameLbl = new Label();
            pwdLbl = new Label();
            loginUsrNameTextBox = new TextBox();
            loginPwdTextBox = new TextBox();
            loginBtn = new Button();
            label1 = new Label();
            registerLinkLbl = new LinkLabel();
            SuspendLayout();
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLbl.Location = new Point(295, 89);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(41, 15);
            loginLbl.TabIndex = 0;
            loginLbl.Text = "Log In";
            loginLbl.Click += label1_Click;
            // 
            // usrNameLbl
            // 
            usrNameLbl.AutoSize = true;
            usrNameLbl.Location = new Point(206, 132);
            usrNameLbl.Name = "usrNameLbl";
            usrNameLbl.Size = new Size(65, 15);
            usrNameLbl.TabIndex = 1;
            usrNameLbl.Text = "User Name";
            // 
            // pwdLbl
            // 
            pwdLbl.AutoSize = true;
            pwdLbl.Location = new Point(206, 188);
            pwdLbl.Name = "pwdLbl";
            pwdLbl.Size = new Size(57, 15);
            pwdLbl.TabIndex = 2;
            pwdLbl.Text = "Password";
            // 
            // loginUsrNameTextBox
            // 
            loginUsrNameTextBox.Location = new Point(206, 150);
            loginUsrNameTextBox.Name = "loginUsrNameTextBox";
            loginUsrNameTextBox.Size = new Size(233, 23);
            loginUsrNameTextBox.TabIndex = 3;
            // 
            // loginPwdTextBox
            // 
            loginPwdTextBox.Location = new Point(206, 206);
            loginPwdTextBox.Name = "loginPwdTextBox";
            loginPwdTextBox.PasswordChar = '*';
            loginPwdTextBox.Size = new Size(233, 23);
            loginPwdTextBox.TabIndex = 4;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DarkBlue;
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(206, 244);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(233, 33);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 290);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 6;
            label1.Text = "Don't have an account?";
            // 
            // registerLinkLbl
            // 
            registerLinkLbl.AutoSize = true;
            registerLinkLbl.Location = new Point(348, 290);
            registerLinkLbl.Name = "registerLinkLbl";
            registerLinkLbl.Size = new Size(75, 15);
            registerLinkLbl.TabIndex = 7;
            registerLinkLbl.TabStop = true;
            registerLinkLbl.Text = "Register here";
            registerLinkLbl.LinkClicked += registerLinkLbl_LinkClicked;
            // 
            // logInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(registerLinkLbl);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(loginPwdTextBox);
            Controls.Add(loginUsrNameTextBox);
            Controls.Add(pwdLbl);
            Controls.Add(usrNameLbl);
            Controls.Add(loginLbl);
            MaximizeBox = false;
            Name = "logInForm";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLbl;
        private Label usrNameLbl;
        private Label pwdLbl;
        private TextBox loginUsrNameTextBox;
        private TextBox loginPwdTextBox;
        private Button loginBtn;
        private Label label1;
        private LinkLabel registerLinkLbl;
    }
}
