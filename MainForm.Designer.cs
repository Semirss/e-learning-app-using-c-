namespace Skill_Nova
{
    partial class mainForm
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
            LeftSideBarPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            logoutLinkLbl = new LinkLabel();
            settingsLinkLbl = new LinkLabel();
            roomLinkLabel = new LinkLabel();
            allCoursesLinkLbl = new LinkLabel();
            homeLinkLbl = new LinkLabel();
            leftSideBarLogo = new Label();
            AllCoursesPanel = new Panel();
            coursesLbl = new Label();
            AllRoomsPanel = new Panel();
            roomsLbl = new Label();
            topBarPanel = new Panel();
            greetingLbl = new Label();
            vScrollBar1 = new VScrollBar();
            SettingsPanel = new Panel();
            changeProfilepanel = new Panel();
            fullNameProfTxtBx = new TextBox();
            changeProfBtn = new Button();
            fullNameProfLbl = new Label();
            pwdProfileTxtBx = new Label();
            emailProfileLbl = new Label();
            pwdProfileTextBx = new TextBox();
            emailProfileTxtBx = new TextBox();
            usrNameProfileLbl = new Label();
            usrNameProfileTxtBx = new TextBox();
            changeProfLbl = new Label();
            delProfPanel = new Panel();
            delAccBtn = new Button();
            profilePnl = new Panel();
            changeProfileBtn = new Button();
            panel4 = new Panel();
            label9 = new Label();
            profileUsrNameLbl = new Label();
            panel3 = new Panel();
            label10 = new Label();
            profileEmailLbl = new Label();
            panel2 = new Panel();
            label8 = new Label();
            profileFullNameLbl = new Label();
            profileLbl = new Label();
            settingsLbl = new Label();
            htmlPanel = new Panel();
            htmlIntroductionTxtBox = new TextBox();
            htmlSidePanel = new Panel();
            htmlCommentsBtn = new Button();
            htmlCssBtn = new Button();
            htmlLinksBtn = new Button();
            htmlStylesBtn = new Button();
            htmlFormattingBtn = new Button();
            htmlParagraphsBtn = new Button();
            htmlHeadingsBtn = new Button();
            htmlAttributesBtn = new Button();
            htmlElementsBtn = new Button();
            basicsBtn = new Button();
            introBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            LeftSideBarPanel.SuspendLayout();
            AllCoursesPanel.SuspendLayout();
            AllRoomsPanel.SuspendLayout();
            topBarPanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            changeProfilepanel.SuspendLayout();
            delProfPanel.SuspendLayout();
            profilePnl.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            htmlPanel.SuspendLayout();
            htmlSidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftSideBarPanel
            // 
            LeftSideBarPanel.BackColor = Color.FromArgb(0, 0, 64);
            LeftSideBarPanel.Controls.Add(flowLayoutPanel1);
            LeftSideBarPanel.Controls.Add(logoutLinkLbl);
            LeftSideBarPanel.Controls.Add(settingsLinkLbl);
            LeftSideBarPanel.Controls.Add(roomLinkLabel);
            LeftSideBarPanel.Controls.Add(allCoursesLinkLbl);
            LeftSideBarPanel.Controls.Add(homeLinkLbl);
            LeftSideBarPanel.Controls.Add(leftSideBarLogo);
            LeftSideBarPanel.Location = new Point(0, 0);
            LeftSideBarPanel.Name = "LeftSideBarPanel";
            LeftSideBarPanel.Size = new Size(166, 589);
            LeftSideBarPanel.TabIndex = 0;
            LeftSideBarPanel.Paint += LeftSideBarPanel_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(162, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(620, 52);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // logoutLinkLbl
            // 
            logoutLinkLbl.AutoSize = true;
            logoutLinkLbl.LinkColor = Color.White;
            logoutLinkLbl.Location = new Point(46, 551);
            logoutLinkLbl.Name = "logoutLinkLbl";
            logoutLinkLbl.Size = new Size(45, 15);
            logoutLinkLbl.TabIndex = 6;
            logoutLinkLbl.TabStop = true;
            logoutLinkLbl.Text = "Logout";
            logoutLinkLbl.LinkClicked += logoutLinkLbl_LinkClicked;
            // 
            // settingsLinkLbl
            // 
            settingsLinkLbl.AutoSize = true;
            settingsLinkLbl.LinkColor = Color.White;
            settingsLinkLbl.Location = new Point(42, 281);
            settingsLinkLbl.Name = "settingsLinkLbl";
            settingsLinkLbl.Size = new Size(49, 15);
            settingsLinkLbl.TabIndex = 5;
            settingsLinkLbl.TabStop = true;
            settingsLinkLbl.Text = "Settings";
            settingsLinkLbl.LinkClicked += settingsLinkLbl_LinkClicked;
            // 
            // roomLinkLabel
            // 
            roomLinkLabel.AutoSize = true;
            roomLinkLabel.LinkColor = Color.White;
            roomLinkLabel.Location = new Point(42, 218);
            roomLinkLabel.Name = "roomLinkLabel";
            roomLinkLabel.Size = new Size(44, 15);
            roomLinkLabel.TabIndex = 4;
            roomLinkLabel.TabStop = true;
            roomLinkLabel.Text = "Rooms";
            roomLinkLabel.LinkClicked += roomLinkLabel_LinkClicked;
            // 
            // allCoursesLinkLbl
            // 
            allCoursesLinkLbl.AutoSize = true;
            allCoursesLinkLbl.LinkColor = Color.White;
            allCoursesLinkLbl.Location = new Point(42, 158);
            allCoursesLinkLbl.Name = "allCoursesLinkLbl";
            allCoursesLinkLbl.Size = new Size(66, 15);
            allCoursesLinkLbl.TabIndex = 3;
            allCoursesLinkLbl.TabStop = true;
            allCoursesLinkLbl.Text = "All Courses";
            allCoursesLinkLbl.LinkClicked += allCoursesLinkLbl_LinkClicked;
            // 
            // homeLinkLbl
            // 
            homeLinkLbl.AutoSize = true;
            homeLinkLbl.BackColor = Color.FromArgb(0, 0, 64);
            homeLinkLbl.ForeColor = Color.White;
            homeLinkLbl.LinkColor = Color.White;
            homeLinkLbl.Location = new Point(42, 98);
            homeLinkLbl.Name = "homeLinkLbl";
            homeLinkLbl.Size = new Size(40, 15);
            homeLinkLbl.TabIndex = 1;
            homeLinkLbl.TabStop = true;
            homeLinkLbl.Text = "Home";
            homeLinkLbl.LinkClicked += homeLinkLbl_LinkClicked;
            // 
            // leftSideBarLogo
            // 
            leftSideBarLogo.AutoSize = true;
            leftSideBarLogo.ForeColor = Color.White;
            leftSideBarLogo.Location = new Point(23, 36);
            leftSideBarLogo.Name = "leftSideBarLogo";
            leftSideBarLogo.Size = new Size(59, 15);
            leftSideBarLogo.TabIndex = 0;
            leftSideBarLogo.Text = "Skill Nova";
            // 
            // AllCoursesPanel
            // 
            AllCoursesPanel.BackColor = Color.White;
            AllCoursesPanel.Controls.Add(coursesLbl);
            AllCoursesPanel.Location = new Point(162, 52);
            AllCoursesPanel.Name = "AllCoursesPanel";
            AllCoursesPanel.Size = new Size(1144, 537);
            AllCoursesPanel.TabIndex = 5;
            // 
            // coursesLbl
            // 
            coursesLbl.AutoSize = true;
            coursesLbl.Location = new Point(27, 46);
            coursesLbl.Name = "coursesLbl";
            coursesLbl.Size = new Size(66, 15);
            coursesLbl.TabIndex = 6;
            coursesLbl.Text = "All Courses";
            // 
            // AllRoomsPanel
            // 
            AllRoomsPanel.BackColor = Color.White;
            AllRoomsPanel.Controls.Add(roomsLbl);
            AllRoomsPanel.Location = new Point(162, 52);
            AllRoomsPanel.Name = "AllRoomsPanel";
            AllRoomsPanel.Size = new Size(1144, 537);
            AllRoomsPanel.TabIndex = 10;
            AllRoomsPanel.Visible = false;
            // 
            // roomsLbl
            // 
            roomsLbl.AutoSize = true;
            roomsLbl.Location = new Point(27, 46);
            roomsLbl.Name = "roomsLbl";
            roomsLbl.Size = new Size(61, 15);
            roomsLbl.TabIndex = 11;
            roomsLbl.Text = "All Rooms";
            // 
            // topBarPanel
            // 
            topBarPanel.BackColor = Color.White;
            topBarPanel.Controls.Add(greetingLbl);
            topBarPanel.Location = new Point(162, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(1144, 52);
            topBarPanel.TabIndex = 11;
            // 
            // greetingLbl
            // 
            greetingLbl.AutoSize = true;
            greetingLbl.Location = new Point(21, 19);
            greetingLbl.Name = "greetingLbl";
            greetingLbl.Size = new Size(30, 15);
            greetingLbl.TabIndex = 0;
            greetingLbl.Text = "User";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(765, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(0, 0);
            vScrollBar1.TabIndex = 12;
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.White;
            SettingsPanel.Controls.Add(changeProfilepanel);
            SettingsPanel.Controls.Add(delProfPanel);
            SettingsPanel.Controls.Add(profilePnl);
            SettingsPanel.Controls.Add(settingsLbl);
            SettingsPanel.Location = new Point(162, 52);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(1144, 537);
            SettingsPanel.TabIndex = 9;
            SettingsPanel.Visible = false;
            // 
            // changeProfilepanel
            // 
            changeProfilepanel.Controls.Add(fullNameProfTxtBx);
            changeProfilepanel.Controls.Add(changeProfBtn);
            changeProfilepanel.Controls.Add(fullNameProfLbl);
            changeProfilepanel.Controls.Add(pwdProfileTxtBx);
            changeProfilepanel.Controls.Add(emailProfileLbl);
            changeProfilepanel.Controls.Add(pwdProfileTextBx);
            changeProfilepanel.Controls.Add(emailProfileTxtBx);
            changeProfilepanel.Controls.Add(usrNameProfileLbl);
            changeProfilepanel.Controls.Add(usrNameProfileTxtBx);
            changeProfilepanel.Controls.Add(changeProfLbl);
            changeProfilepanel.Location = new Point(30, 88);
            changeProfilepanel.Name = "changeProfilepanel";
            changeProfilepanel.Size = new Size(601, 404);
            changeProfilepanel.TabIndex = 4;
            changeProfilepanel.Visible = false;
            // 
            // fullNameProfTxtBx
            // 
            fullNameProfTxtBx.Location = new Point(114, 84);
            fullNameProfTxtBx.Multiline = true;
            fullNameProfTxtBx.Name = "fullNameProfTxtBx";
            fullNameProfTxtBx.Size = new Size(287, 33);
            fullNameProfTxtBx.TabIndex = 12;
            // 
            // changeProfBtn
            // 
            changeProfBtn.BackColor = Color.FromArgb(0, 192, 0);
            changeProfBtn.ForeColor = Color.White;
            changeProfBtn.Location = new Point(206, 335);
            changeProfBtn.Name = "changeProfBtn";
            changeProfBtn.Size = new Size(119, 39);
            changeProfBtn.TabIndex = 4;
            changeProfBtn.Text = "Change Profile";
            changeProfBtn.UseVisualStyleBackColor = false;
            changeProfBtn.Click += changeProfBtn_Click;
            // 
            // fullNameProfLbl
            // 
            fullNameProfLbl.AutoSize = true;
            fullNameProfLbl.Location = new Point(47, 93);
            fullNameProfLbl.Name = "fullNameProfLbl";
            fullNameProfLbl.Size = new Size(61, 15);
            fullNameProfLbl.TabIndex = 11;
            fullNameProfLbl.Text = "Full Name";
            // 
            // pwdProfileTxtBx
            // 
            pwdProfileTxtBx.AutoSize = true;
            pwdProfileTxtBx.Location = new Point(51, 261);
            pwdProfileTxtBx.Name = "pwdProfileTxtBx";
            pwdProfileTxtBx.Size = new Size(57, 15);
            pwdProfileTxtBx.TabIndex = 10;
            pwdProfileTxtBx.Text = "Password";
            // 
            // emailProfileLbl
            // 
            emailProfileLbl.AutoSize = true;
            emailProfileLbl.Location = new Point(72, 210);
            emailProfileLbl.Name = "emailProfileLbl";
            emailProfileLbl.Size = new Size(36, 15);
            emailProfileLbl.TabIndex = 9;
            emailProfileLbl.Text = "Email";
            // 
            // pwdProfileTextBx
            // 
            pwdProfileTextBx.Location = new Point(114, 258);
            pwdProfileTextBx.Multiline = true;
            pwdProfileTextBx.Name = "pwdProfileTextBx";
            pwdProfileTextBx.PasswordChar = '*';
            pwdProfileTextBx.Size = new Size(287, 33);
            pwdProfileTextBx.TabIndex = 8;
            // 
            // emailProfileTxtBx
            // 
            emailProfileTxtBx.Location = new Point(114, 201);
            emailProfileTxtBx.Multiline = true;
            emailProfileTxtBx.Name = "emailProfileTxtBx";
            emailProfileTxtBx.Size = new Size(287, 33);
            emailProfileTxtBx.TabIndex = 7;
            // 
            // usrNameProfileLbl
            // 
            usrNameProfileLbl.AutoSize = true;
            usrNameProfileLbl.Location = new Point(43, 152);
            usrNameProfileLbl.Name = "usrNameProfileLbl";
            usrNameProfileLbl.Size = new Size(65, 15);
            usrNameProfileLbl.TabIndex = 6;
            usrNameProfileLbl.Text = "User Name";
            // 
            // usrNameProfileTxtBx
            // 
            usrNameProfileTxtBx.Location = new Point(114, 144);
            usrNameProfileTxtBx.Multiline = true;
            usrNameProfileTxtBx.Name = "usrNameProfileTxtBx";
            usrNameProfileTxtBx.Size = new Size(287, 33);
            usrNameProfileTxtBx.TabIndex = 5;
            // 
            // changeProfLbl
            // 
            changeProfLbl.AutoSize = true;
            changeProfLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeProfLbl.Location = new Point(24, 31);
            changeProfLbl.Name = "changeProfLbl";
            changeProfLbl.Size = new Size(143, 25);
            changeProfLbl.TabIndex = 1;
            changeProfLbl.Text = "Change Profile";
            // 
            // delProfPanel
            // 
            delProfPanel.BackColor = Color.LightGray;
            delProfPanel.Controls.Add(delAccBtn);
            delProfPanel.Location = new Point(27, 427);
            delProfPanel.Name = "delProfPanel";
            delProfPanel.Size = new Size(604, 65);
            delProfPanel.TabIndex = 3;
            // 
            // delAccBtn
            // 
            delAccBtn.BackColor = Color.Red;
            delAccBtn.ForeColor = Color.White;
            delAccBtn.Location = new Point(13, 17);
            delAccBtn.Name = "delAccBtn";
            delAccBtn.Size = new Size(112, 33);
            delAccBtn.TabIndex = 0;
            delAccBtn.Text = "Delete Account";
            delAccBtn.UseVisualStyleBackColor = false;
            delAccBtn.Click += delAccBtn_Click;
            // 
            // profilePnl
            // 
            profilePnl.BackColor = Color.LightGray;
            profilePnl.Controls.Add(changeProfileBtn);
            profilePnl.Controls.Add(panel4);
            profilePnl.Controls.Add(panel3);
            profilePnl.Controls.Add(panel2);
            profilePnl.Controls.Add(profileLbl);
            profilePnl.Location = new Point(27, 85);
            profilePnl.Name = "profilePnl";
            profilePnl.Size = new Size(604, 305);
            profilePnl.TabIndex = 1;
            // 
            // changeProfileBtn
            // 
            changeProfileBtn.BackColor = Color.FromArgb(0, 192, 0);
            changeProfileBtn.ForeColor = Color.White;
            changeProfileBtn.Location = new Point(15, 249);
            changeProfileBtn.Name = "changeProfileBtn";
            changeProfileBtn.Size = new Size(119, 39);
            changeProfileBtn.TabIndex = 3;
            changeProfileBtn.Text = "Change Profile";
            changeProfileBtn.UseVisualStyleBackColor = false;
            changeProfileBtn.Click += changeProfileBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(profileUsrNameLbl);
            panel4.Location = new Point(15, 121);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 46);
            panel4.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 26);
            label9.Name = "label9";
            label9.Size = new Size(50, 12);
            label9.TabIndex = 1;
            label9.Text = "User Name";
            // 
            // profileUsrNameLbl
            // 
            profileUsrNameLbl.AutoSize = true;
            profileUsrNameLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileUsrNameLbl.Location = new Point(8, 9);
            profileUsrNameLbl.Name = "profileUsrNameLbl";
            profileUsrNameLbl.Size = new Size(0, 17);
            profileUsrNameLbl.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(profileEmailLbl);
            panel3.Location = new Point(15, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 46);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 28);
            label10.Name = "label10";
            label10.Size = new Size(27, 12);
            label10.TabIndex = 1;
            label10.Text = "Email";
            // 
            // profileEmailLbl
            // 
            profileEmailLbl.AutoSize = true;
            profileEmailLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileEmailLbl.Location = new Point(9, 11);
            profileEmailLbl.Name = "profileEmailLbl";
            profileEmailLbl.Size = new Size(0, 17);
            profileEmailLbl.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(profileFullNameLbl);
            panel2.Location = new Point(15, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 46);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 28);
            label8.Name = "label8";
            label8.Size = new Size(45, 12);
            label8.TabIndex = 1;
            label8.Text = "Full Name";
            // 
            // profileFullNameLbl
            // 
            profileFullNameLbl.AutoSize = true;
            profileFullNameLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileFullNameLbl.Location = new Point(9, 11);
            profileFullNameLbl.Name = "profileFullNameLbl";
            profileFullNameLbl.Size = new Size(0, 17);
            profileFullNameLbl.TabIndex = 0;
            // 
            // profileLbl
            // 
            profileLbl.AutoSize = true;
            profileLbl.Location = new Point(15, 16);
            profileLbl.Name = "profileLbl";
            profileLbl.Size = new Size(41, 15);
            profileLbl.TabIndex = 0;
            profileLbl.Text = "Profile";
            // 
            // settingsLbl
            // 
            settingsLbl.AutoSize = true;
            settingsLbl.Location = new Point(21, 46);
            settingsLbl.Name = "settingsLbl";
            settingsLbl.Size = new Size(49, 15);
            settingsLbl.TabIndex = 0;
            settingsLbl.Text = "Settings";
            // 
            // htmlPanel
            // 
            htmlPanel.Controls.Add(panel1);
            htmlPanel.Controls.Add(htmlIntroductionTxtBox);
            htmlPanel.Controls.Add(htmlSidePanel);
            htmlPanel.Location = new Point(162, 52);
            htmlPanel.Name = "htmlPanel";
            htmlPanel.Size = new Size(1144, 537);
            htmlPanel.TabIndex = 4;
            htmlPanel.Visible = false;
            // 
            // htmlIntroductionTxtBox
            // 
            htmlIntroductionTxtBox.Location = new Point(209, 46);
            htmlIntroductionTxtBox.Multiline = true;
            htmlIntroductionTxtBox.Name = "htmlIntroductionTxtBox";
            htmlIntroductionTxtBox.ReadOnly = true;
            htmlIntroductionTxtBox.Size = new Size(932, 453);
            htmlIntroductionTxtBox.TabIndex = 1;
            // 
            // htmlSidePanel
            // 
            htmlSidePanel.Controls.Add(htmlCommentsBtn);
            htmlSidePanel.Controls.Add(htmlCssBtn);
            htmlSidePanel.Controls.Add(htmlLinksBtn);
            htmlSidePanel.Controls.Add(htmlStylesBtn);
            htmlSidePanel.Controls.Add(htmlFormattingBtn);
            htmlSidePanel.Controls.Add(htmlParagraphsBtn);
            htmlSidePanel.Controls.Add(htmlHeadingsBtn);
            htmlSidePanel.Controls.Add(htmlAttributesBtn);
            htmlSidePanel.Controls.Add(htmlElementsBtn);
            htmlSidePanel.Controls.Add(basicsBtn);
            htmlSidePanel.Controls.Add(introBtn);
            htmlSidePanel.Controls.Add(label1);
            htmlSidePanel.Location = new Point(0, 0);
            htmlSidePanel.Name = "htmlSidePanel";
            htmlSidePanel.Size = new Size(210, 537);
            htmlSidePanel.TabIndex = 0;
            // 
            // htmlCommentsBtn
            // 
            htmlCommentsBtn.Location = new Point(27, 382);
            htmlCommentsBtn.Name = "htmlCommentsBtn";
            htmlCommentsBtn.Size = new Size(141, 33);
            htmlCommentsBtn.TabIndex = 12;
            htmlCommentsBtn.Text = "HTML Comments";
            htmlCommentsBtn.UseVisualStyleBackColor = true;
            // 
            // htmlCssBtn
            // 
            htmlCssBtn.Location = new Point(27, 424);
            htmlCssBtn.Name = "htmlCssBtn";
            htmlCssBtn.Size = new Size(141, 33);
            htmlCssBtn.TabIndex = 11;
            htmlCssBtn.Text = "HTML CSS";
            htmlCssBtn.UseVisualStyleBackColor = true;
            // 
            // htmlLinksBtn
            // 
            htmlLinksBtn.Location = new Point(30, 466);
            htmlLinksBtn.Name = "htmlLinksBtn";
            htmlLinksBtn.Size = new Size(141, 33);
            htmlLinksBtn.TabIndex = 10;
            htmlLinksBtn.Text = "HTML Links";
            htmlLinksBtn.UseVisualStyleBackColor = true;
            // 
            // htmlStylesBtn
            // 
            htmlStylesBtn.Location = new Point(27, 298);
            htmlStylesBtn.Name = "htmlStylesBtn";
            htmlStylesBtn.Size = new Size(141, 33);
            htmlStylesBtn.TabIndex = 9;
            htmlStylesBtn.Text = "HTML Styles";
            htmlStylesBtn.UseVisualStyleBackColor = true;
            // 
            // htmlFormattingBtn
            // 
            htmlFormattingBtn.Location = new Point(27, 340);
            htmlFormattingBtn.Name = "htmlFormattingBtn";
            htmlFormattingBtn.Size = new Size(141, 33);
            htmlFormattingBtn.TabIndex = 8;
            htmlFormattingBtn.Text = "HTML Formatting";
            htmlFormattingBtn.UseVisualStyleBackColor = true;
            // 
            // htmlParagraphsBtn
            // 
            htmlParagraphsBtn.Location = new Point(27, 256);
            htmlParagraphsBtn.Name = "htmlParagraphsBtn";
            htmlParagraphsBtn.Size = new Size(141, 33);
            htmlParagraphsBtn.TabIndex = 6;
            htmlParagraphsBtn.Text = "HTML Paragraphs";
            htmlParagraphsBtn.UseVisualStyleBackColor = true;
            // 
            // htmlHeadingsBtn
            // 
            htmlHeadingsBtn.Location = new Point(25, 214);
            htmlHeadingsBtn.Name = "htmlHeadingsBtn";
            htmlHeadingsBtn.Size = new Size(141, 33);
            htmlHeadingsBtn.TabIndex = 5;
            htmlHeadingsBtn.Text = "HTML Headings";
            htmlHeadingsBtn.UseVisualStyleBackColor = true;
            // 
            // htmlAttributesBtn
            // 
            htmlAttributesBtn.Location = new Point(25, 172);
            htmlAttributesBtn.Name = "htmlAttributesBtn";
            htmlAttributesBtn.Size = new Size(141, 33);
            htmlAttributesBtn.TabIndex = 4;
            htmlAttributesBtn.Text = "HTML Attributes";
            htmlAttributesBtn.UseVisualStyleBackColor = true;
            htmlAttributesBtn.Click += htmlAttributesBtn_Click;
            // 
            // htmlElementsBtn
            // 
            htmlElementsBtn.Location = new Point(25, 130);
            htmlElementsBtn.Name = "htmlElementsBtn";
            htmlElementsBtn.Size = new Size(141, 33);
            htmlElementsBtn.TabIndex = 3;
            htmlElementsBtn.Text = "HTML Elements";
            htmlElementsBtn.UseVisualStyleBackColor = true;
            htmlElementsBtn.Click += htmlElementsBtn_Click;
            // 
            // basicsBtn
            // 
            basicsBtn.Location = new Point(25, 88);
            basicsBtn.Name = "basicsBtn";
            basicsBtn.Size = new Size(141, 33);
            basicsBtn.TabIndex = 2;
            basicsBtn.Text = "HTML Basic";
            basicsBtn.UseVisualStyleBackColor = true;
            basicsBtn.Click += basicsBtn_Click;
            // 
            // introBtn
            // 
            introBtn.Location = new Point(25, 46);
            introBtn.Name = "introBtn";
            introBtn.Size = new Size(141, 33);
            introBtn.TabIndex = 1;
            introBtn.Text = "HTML Introduction";
            introBtn.UseVisualStyleBackColor = true;
            introBtn.Click += introBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "HTML Tutorial";
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 537);
            panel1.TabIndex = 2;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 588);
            Controls.Add(htmlPanel);
            Controls.Add(SettingsPanel);
            Controls.Add(AllCoursesPanel);
            Controls.Add(vScrollBar1);
            Controls.Add(AllRoomsPanel);
            Controls.Add(topBarPanel);
            Controls.Add(LeftSideBarPanel);
            MaximizeBox = false;
            Name = "mainForm";
            Text = "MainForm";
            Load += mainForm_Load;
            LeftSideBarPanel.ResumeLayout(false);
            LeftSideBarPanel.PerformLayout();
            AllCoursesPanel.ResumeLayout(false);
            AllCoursesPanel.PerformLayout();
            AllRoomsPanel.ResumeLayout(false);
            AllRoomsPanel.PerformLayout();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            SettingsPanel.ResumeLayout(false);
            SettingsPanel.PerformLayout();
            changeProfilepanel.ResumeLayout(false);
            changeProfilepanel.PerformLayout();
            delProfPanel.ResumeLayout(false);
            profilePnl.ResumeLayout(false);
            profilePnl.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            htmlPanel.ResumeLayout(false);
            htmlPanel.PerformLayout();
            htmlSidePanel.ResumeLayout(false);
            htmlSidePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftSideBarPanel;
        private LinkLabel allCoursesLinkLbl;
        private LinkLabel homeLinkLbl;
        private Label leftSideBarLogo;
        private LinkLabel roomLinkLabel;
        private LinkLabel logoutLinkLbl;
        private LinkLabel settingsLinkLbl;
        private Panel AllCoursesPanel;
        private Label coursesLbl;
        private Panel AllRoomsPanel;
        private Label roomsLbl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel topBarPanel;
        public Label greetingLbl;
        private VScrollBar vScrollBar1;
        private Panel SettingsPanel;
        private Panel profilePnl;
        private Label profileLbl;
        private Label settingsLbl;
        private Panel panel4;
        private Label profileUsrNameLbl;
        private Panel panel3;
        private Label profileEmailLbl;
        private Panel panel2;
        private Label profileFullNameLbl;
        private Label label9;
        private Label label10;
        private Label label8;
        private Button changeProfileBtn;
        private Panel delProfPanel;
        private Button delAccBtn;
        private Panel htmlPanel;
        private Panel htmlSidePanel;
        private Label label1;
        private Button introBtn;
        private Button htmlStylesBtn;
        private Button htmlFormattingBtn;
        private Button htmlParagraphsBtn;
        private Button htmlHeadingsBtn;
        private Button htmlAttributesBtn;
        private Button htmlElementsBtn;
        private Button basicsBtn;
        private Button htmlCommentsBtn;
        private Button htmlCssBtn;
        private Button htmlLinksBtn;
        private TextBox htmlIntroductionTxtBox;
        private Panel changeProfilepanel;
        private Button button1;
        private Panel panel7;
        private Label changeProfLbl;
        private TextBox pwdProfileTextBx;
        private TextBox textBox2;
        private Label usrNameProfileLbl;
        private TextBox emailProfileTxtBx;
        private Button changeProfBtn;
        private TextBox usrNameProfileTxtBx;
        private Label pwdProfileTxtBx;
        private Label emailProfileLbl;
        private Label label3;
        private TextBox fullNameProfTxtBx;
        private Label fullNameProfLbl;
        private Panel panel1;
    }
}