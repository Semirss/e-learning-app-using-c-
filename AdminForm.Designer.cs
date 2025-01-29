namespace Skill_Nova
{
    partial class adminForm
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
            components = new System.ComponentModel.Container();
            studBtn = new Button();
            coursesBtn = new Button();
            roomsBtn = new Button();
            adminTopBarPanel = new Panel();
            adminLogoLbl = new Label();
            StudentsPanel = new Panel();
            studentsBackLinkLabel = new LinkLabel();
            studentsLabel = new Label();
            dataGridView1 = new DataGridView();
            fullNameCol = new DataGridViewTextBoxColumn();
            usrNameCol = new DataGridViewTextBoxColumn();
            emailCol = new DataGridViewTextBoxColumn();
            AdminPageCoursesPanel = new Panel();
            addCoursePanel = new Panel();
            button1 = new Button();
            addCourseTitleTxtBx = new TextBox();
            addCourseLbl = new Label();
            addCourseTitleLbl = new Label();
            addCourseDurationTxtBx = new TextBox();
            addCourseDescriptionLbl = new Label();
            addCourseDescTxtBx = new TextBox();
            addCourseDurationLbl = new Label();
            coursesBackLinkLabel = new LinkLabel();
            adminPageCoursesLbl = new Label();
            addCourseBtn = new Button();
            AdminPageRoomsPanel = new Panel();
            backRoomLinkLabel = new LinkLabel();
            addRoom = new Button();
            room2Panel = new Panel();
            deleteRoom2Btn = new Button();
            room2Btn = new Button();
            room2DescriptionLbl = new Label();
            room2TitleLbl = new Label();
            adminPageRoomsLbl = new Label();
            imageList1 = new ImageList(components);
            adminTopBarPanel.SuspendLayout();
            StudentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            AdminPageCoursesPanel.SuspendLayout();
            addCoursePanel.SuspendLayout();
            AdminPageRoomsPanel.SuspendLayout();
            room2Panel.SuspendLayout();
            SuspendLayout();
            // 
            // studBtn
            // 
            studBtn.Location = new Point(130, 120);
            studBtn.Name = "studBtn";
            studBtn.Size = new Size(315, 164);
            studBtn.TabIndex = 0;
            studBtn.Text = "Students";
            studBtn.UseVisualStyleBackColor = true;
            studBtn.Click += studBtn_Click;
            // 
            // coursesBtn
            // 
            coursesBtn.Location = new Point(580, 120);
            coursesBtn.Name = "coursesBtn";
            coursesBtn.Size = new Size(315, 164);
            coursesBtn.TabIndex = 1;
            coursesBtn.Text = "Courses";
            coursesBtn.UseVisualStyleBackColor = true;
            coursesBtn.Click += coursesBtn_Click_1;
            // 
            // roomsBtn
            // 
            roomsBtn.Location = new Point(130, 360);
            roomsBtn.Name = "roomsBtn";
            roomsBtn.Size = new Size(315, 164);
            roomsBtn.TabIndex = 2;
            roomsBtn.Text = "Rooms";
            roomsBtn.UseVisualStyleBackColor = true;
            roomsBtn.Click += roomsBtn_Click;
            // 
            // adminTopBarPanel
            // 
            adminTopBarPanel.BackColor = Color.FromArgb(0, 0, 64);
            adminTopBarPanel.Controls.Add(adminLogoLbl);
            adminTopBarPanel.Location = new Point(0, 0);
            adminTopBarPanel.Name = "adminTopBarPanel";
            adminTopBarPanel.Size = new Size(1306, 62);
            adminTopBarPanel.TabIndex = 3;
            // 
            // adminLogoLbl
            // 
            adminLogoLbl.AutoSize = true;
            adminLogoLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminLogoLbl.ForeColor = Color.White;
            adminLogoLbl.Location = new Point(12, 21);
            adminLogoLbl.Name = "adminLogoLbl";
            adminLogoLbl.Size = new Size(88, 21);
            adminLogoLbl.TabIndex = 0;
            adminLogoLbl.Text = "Skill Nova";
            // 
            // StudentsPanel
            // 
            StudentsPanel.Controls.Add(studentsBackLinkLabel);
            StudentsPanel.Controls.Add(studentsLabel);
            StudentsPanel.Controls.Add(dataGridView1);
            StudentsPanel.Location = new Point(0, 60);
            StudentsPanel.Name = "StudentsPanel";
            StudentsPanel.Size = new Size(1306, 528);
            StudentsPanel.TabIndex = 4;
            StudentsPanel.Visible = false;
            // 
            // studentsBackLinkLabel
            // 
            studentsBackLinkLabel.AutoSize = true;
            studentsBackLinkLabel.Location = new Point(23, 19);
            studentsBackLinkLabel.Name = "studentsBackLinkLabel";
            studentsBackLinkLabel.Size = new Size(32, 15);
            studentsBackLinkLabel.TabIndex = 2;
            studentsBackLinkLabel.TabStop = true;
            studentsBackLinkLabel.Text = "Back";
            studentsBackLinkLabel.LinkClicked += studentsBackLinkLabel_LinkClicked;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentsLabel.Location = new Point(75, 60);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new Size(71, 20);
            studentsLabel.TabIndex = 1;
            studentsLabel.Text = "Students";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fullNameCol, usrNameCol, emailCol });
            dataGridView1.Location = new Point(75, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 66);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // fullNameCol
            // 
            fullNameCol.HeaderText = "Full Name";
            fullNameCol.Name = "fullNameCol";
            fullNameCol.Width = 200;
            // 
            // usrNameCol
            // 
            usrNameCol.HeaderText = "User Name";
            usrNameCol.Name = "usrNameCol";
            usrNameCol.Width = 200;
            // 
            // emailCol
            // 
            emailCol.HeaderText = "Email";
            emailCol.Name = "emailCol";
            emailCol.Width = 200;
            // 
            // AdminPageCoursesPanel
            // 
            AdminPageCoursesPanel.Controls.Add(addCoursePanel);
            AdminPageCoursesPanel.Controls.Add(coursesBackLinkLabel);
            AdminPageCoursesPanel.Controls.Add(adminPageCoursesLbl);
            AdminPageCoursesPanel.Controls.Add(addCourseBtn);
            AdminPageCoursesPanel.Location = new Point(0, 60);
            AdminPageCoursesPanel.Name = "AdminPageCoursesPanel";
            AdminPageCoursesPanel.Size = new Size(1306, 528);
            AdminPageCoursesPanel.TabIndex = 2;
            AdminPageCoursesPanel.Visible = false;
            AdminPageCoursesPanel.Paint += AdminPageCoursesPanel_Paint;
            // 
            // addCoursePanel
            // 
            addCoursePanel.Controls.Add(button1);
            addCoursePanel.Controls.Add(addCourseTitleTxtBx);
            addCoursePanel.Controls.Add(addCourseLbl);
            addCoursePanel.Controls.Add(addCourseTitleLbl);
            addCoursePanel.Controls.Add(addCourseDurationTxtBx);
            addCoursePanel.Controls.Add(addCourseDescriptionLbl);
            addCoursePanel.Controls.Add(addCourseDescTxtBx);
            addCoursePanel.Controls.Add(addCourseDurationLbl);
            addCoursePanel.Location = new Point(65, 115);
            addCoursePanel.Name = "addCoursePanel";
            addCoursePanel.Size = new Size(778, 325);
            addCoursePanel.TabIndex = 17;
            addCoursePanel.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(336, 342);
            button1.Name = "button1";
            button1.Size = new Size(114, 35);
            button1.TabIndex = 13;
            button1.Text = "Add Course";
            button1.UseVisualStyleBackColor = false;
            // 
            // addCourseTitleTxtBx
            // 
            addCourseTitleTxtBx.Location = new Point(120, 76);
            addCourseTitleTxtBx.Multiline = true;
            addCourseTitleTxtBx.Name = "addCourseTitleTxtBx";
            addCourseTitleTxtBx.Size = new Size(287, 33);
            addCourseTitleTxtBx.TabIndex = 12;
            // 
            // addCourseLbl
            // 
            addCourseLbl.AutoSize = true;
            addCourseLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCourseLbl.Location = new Point(20, 21);
            addCourseLbl.Name = "addCourseLbl";
            addCourseLbl.Size = new Size(116, 25);
            addCourseLbl.TabIndex = 1;
            addCourseLbl.Text = "Add Course";
            // 
            // addCourseTitleLbl
            // 
            addCourseTitleLbl.AutoSize = true;
            addCourseTitleLbl.Location = new Point(85, 89);
            addCourseTitleLbl.Name = "addCourseTitleLbl";
            addCourseTitleLbl.Size = new Size(29, 15);
            addCourseTitleLbl.TabIndex = 11;
            addCourseTitleLbl.Text = "Title";
            // 
            // addCourseDurationTxtBx
            // 
            addCourseDurationTxtBx.Location = new Point(120, 281);
            addCourseDurationTxtBx.Multiline = true;
            addCourseDurationTxtBx.Name = "addCourseDurationTxtBx";
            addCourseDurationTxtBx.Size = new Size(287, 33);
            addCourseDurationTxtBx.TabIndex = 7;
            // 
            // addCourseDescriptionLbl
            // 
            addCourseDescriptionLbl.AutoSize = true;
            addCourseDescriptionLbl.Location = new Point(47, 156);
            addCourseDescriptionLbl.Name = "addCourseDescriptionLbl";
            addCourseDescriptionLbl.Size = new Size(67, 15);
            addCourseDescriptionLbl.TabIndex = 6;
            addCourseDescriptionLbl.Text = "Description";
            // 
            // addCourseDescTxtBx
            // 
            addCourseDescTxtBx.Location = new Point(120, 138);
            addCourseDescTxtBx.Multiline = true;
            addCourseDescTxtBx.Name = "addCourseDescTxtBx";
            addCourseDescTxtBx.Size = new Size(541, 118);
            addCourseDescTxtBx.TabIndex = 5;
            // 
            // addCourseDurationLbl
            // 
            addCourseDurationLbl.AutoSize = true;
            addCourseDurationLbl.Location = new Point(61, 299);
            addCourseDurationLbl.Name = "addCourseDurationLbl";
            addCourseDurationLbl.Size = new Size(53, 15);
            addCourseDurationLbl.TabIndex = 9;
            addCourseDurationLbl.Text = "Duration";
            // 
            // coursesBackLinkLabel
            // 
            coursesBackLinkLabel.AutoSize = true;
            coursesBackLinkLabel.Location = new Point(23, 19);
            coursesBackLinkLabel.Name = "coursesBackLinkLabel";
            coursesBackLinkLabel.Size = new Size(32, 15);
            coursesBackLinkLabel.TabIndex = 13;
            coursesBackLinkLabel.TabStop = true;
            coursesBackLinkLabel.Text = "Back";
            coursesBackLinkLabel.LinkClicked += coursesBackLinkLabel_LinkClicked;
            // 
            // adminPageCoursesLbl
            // 
            adminPageCoursesLbl.AutoSize = true;
            adminPageCoursesLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminPageCoursesLbl.Location = new Point(65, 84);
            adminPageCoursesLbl.Name = "adminPageCoursesLbl";
            adminPageCoursesLbl.Size = new Size(69, 21);
            adminPageCoursesLbl.TabIndex = 12;
            adminPageCoursesLbl.Text = "Courses";
            // 
            // addCourseBtn
            // 
            addCourseBtn.BackColor = Color.FromArgb(0, 192, 0);
            addCourseBtn.ForeColor = Color.White;
            addCourseBtn.Location = new Point(65, 446);
            addCourseBtn.Name = "addCourseBtn";
            addCourseBtn.Size = new Size(114, 35);
            addCourseBtn.TabIndex = 11;
            addCourseBtn.Text = "Add Course";
            addCourseBtn.UseVisualStyleBackColor = false;
            addCourseBtn.Click += addCourseBtn_Click;
            // 
            // AdminPageRoomsPanel
            // 
            AdminPageRoomsPanel.Controls.Add(backRoomLinkLabel);
            AdminPageRoomsPanel.Controls.Add(addRoom);
            AdminPageRoomsPanel.Controls.Add(room2Panel);
            AdminPageRoomsPanel.Controls.Add(adminPageRoomsLbl);
            AdminPageRoomsPanel.Location = new Point(0, 60);
            AdminPageRoomsPanel.Name = "AdminPageRoomsPanel";
            AdminPageRoomsPanel.Size = new Size(1306, 528);
            AdminPageRoomsPanel.TabIndex = 13;
            AdminPageRoomsPanel.Visible = false;
            // 
            // backRoomLinkLabel
            // 
            backRoomLinkLabel.AutoSize = true;
            backRoomLinkLabel.Location = new Point(23, 19);
            backRoomLinkLabel.Name = "backRoomLinkLabel";
            backRoomLinkLabel.Size = new Size(32, 15);
            backRoomLinkLabel.TabIndex = 17;
            backRoomLinkLabel.TabStop = true;
            backRoomLinkLabel.Text = "Back";
            backRoomLinkLabel.LinkClicked += backRoomLinkLabel_LinkClicked;
            // 
            // addRoom
            // 
            addRoom.BackColor = Color.FromArgb(0, 192, 0);
            addRoom.ForeColor = Color.White;
            addRoom.Location = new Point(65, 448);
            addRoom.Name = "addRoom";
            addRoom.Size = new Size(99, 33);
            addRoom.TabIndex = 16;
            addRoom.Text = "Add Room";
            addRoom.UseVisualStyleBackColor = false;
            addRoom.Click += addRoom_Click;
            // 
            // room2Panel
            // 
            room2Panel.BackColor = Color.LightGray;
            room2Panel.Controls.Add(deleteRoom2Btn);
            room2Panel.Controls.Add(room2Btn);
            room2Panel.Controls.Add(room2DescriptionLbl);
            room2Panel.Controls.Add(room2TitleLbl);
            room2Panel.Location = new Point(804, 145);
            room2Panel.Name = "room2Panel";
            room2Panel.Size = new Size(402, 255);
            room2Panel.TabIndex = 15;
            room2Panel.Paint += room2Panel_Paint;
            // 
            // deleteRoom2Btn
            // 
            deleteRoom2Btn.BackColor = Color.Red;
            deleteRoom2Btn.ForeColor = Color.White;
            deleteRoom2Btn.Location = new Point(165, 195);
            deleteRoom2Btn.Name = "deleteRoom2Btn";
            deleteRoom2Btn.Size = new Size(99, 31);
            deleteRoom2Btn.TabIndex = 4;
            deleteRoom2Btn.Text = "Delete Button";
            deleteRoom2Btn.UseVisualStyleBackColor = false;
            // 
            // room2Btn
            // 
            room2Btn.BackColor = Color.Lime;
            room2Btn.Location = new Point(25, 195);
            room2Btn.Name = "room2Btn";
            room2Btn.Size = new Size(99, 31);
            room2Btn.TabIndex = 3;
            room2Btn.Text = "View Room";
            room2Btn.UseVisualStyleBackColor = false;
            room2Btn.Click += room2Btn_Click;
            // 
            // room2DescriptionLbl
            // 
            room2DescriptionLbl.AutoSize = true;
            room2DescriptionLbl.Location = new Point(15, 59);
            room2DescriptionLbl.Name = "room2DescriptionLbl";
            room2DescriptionLbl.Size = new Size(67, 15);
            room2DescriptionLbl.TabIndex = 1;
            room2DescriptionLbl.Text = "Description";
            // 
            // room2TitleLbl
            // 
            room2TitleLbl.AutoSize = true;
            room2TitleLbl.Location = new Point(15, 25);
            room2TitleLbl.Name = "room2TitleLbl";
            room2TitleLbl.Size = new Size(29, 15);
            room2TitleLbl.TabIndex = 0;
            room2TitleLbl.Text = "Title";
            // 
            // adminPageRoomsLbl
            // 
            adminPageRoomsLbl.AutoSize = true;
            adminPageRoomsLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminPageRoomsLbl.Location = new Point(65, 84);
            adminPageRoomsLbl.Name = "adminPageRoomsLbl";
            adminPageRoomsLbl.Size = new Size(62, 21);
            adminPageRoomsLbl.TabIndex = 0;
            adminPageRoomsLbl.Text = "Rooms";
            adminPageRoomsLbl.Click += adminPageRoomsLbl_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 588);
            Controls.Add(adminTopBarPanel);
            Controls.Add(AdminPageRoomsPanel);
            Controls.Add(StudentsPanel);
            Controls.Add(AdminPageCoursesPanel);
            Controls.Add(roomsBtn);
            Controls.Add(coursesBtn);
            Controls.Add(studBtn);
            MaximizeBox = false;
            Name = "adminForm";
            Text = "Admin";
            adminTopBarPanel.ResumeLayout(false);
            adminTopBarPanel.PerformLayout();
            StudentsPanel.ResumeLayout(false);
            StudentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            AdminPageCoursesPanel.ResumeLayout(false);
            AdminPageCoursesPanel.PerformLayout();
            addCoursePanel.ResumeLayout(false);
            addCoursePanel.PerformLayout();
            AdminPageRoomsPanel.ResumeLayout(false);
            AdminPageRoomsPanel.PerformLayout();
            room2Panel.ResumeLayout(false);
            room2Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button studBtn;
        private Button coursesBtn;
        private Button roomsBtn;
        private Panel adminTopBarPanel;
        private Label adminLogoLbl;
        private Panel StudentsPanel;
        private DataGridView dataGridView1;
        private Label studentsLabel;
        private DataGridViewTextBoxColumn fullNameCol;
        private DataGridViewTextBoxColumn usrNameCol;
        private DataGridViewTextBoxColumn emailCol;
        private Panel AdminPageCoursesPanel;
        private Label adminPageCoursesLbl;
        private Button addCourseBtn;
        private Panel AdminPageRoomsPanel;
        private Label adminPageRoomsLbl;
        private Panel room2Panel;
        private Button room2Btn;
        private Label room2DescriptionLbl;
        private Label room2TitleLbl;
        private Button addRoom;
        private Button deleteRoom2Btn;
        private LinkLabel backRoomLinkLabel;
        private LinkLabel studentsBackLinkLabel;
        private LinkLabel coursesBackLinkLabel;
        private TextBox addCourseTitleTxtBx;
        private Label addCourseTitleLbl;
        private Label addCourseDurationLbl;
        private TextBox addCourseDurationTxtBx;
        private Label addCourseDescriptionLbl;
        private TextBox addCourseDescTxtBx;
        private Label addCourseLbl;
        private Panel addCoursePanel;
        private Button button1;
        private ImageList imageList1;
    }
}