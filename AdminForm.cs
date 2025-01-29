using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Nova
{
    public partial class adminForm : Form
    {
        private Panel adminCoursePanel;
        public adminForm()
        {
            InitializeComponent();
        }

        //private void coursesBtn_Click(object sender, EventArgs e)
        //{
        //    AdminPageCoursesPanel.Visible = true;
        //    AdminPageRoomsPanel.Visible = false;
        //    StudentsPanel.Visible = false;
        //}
        private void coursesBtn_Click_1(object sender, EventArgs e)
        {
            AdminPageCoursesPanel.Visible = true;
            AdminPageRoomsPanel.Visible = false;
            StudentsPanel.Visible = false;

            DataTable dataTable = new DataTable();
            Course courses = new Course();
            dataTable = courses.getCourses();

            int xOffset = 65;
            int yOffset = 135;
            int panelsPerRow = 2;
            int currentPanelCount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                adminCoursePanel = new Panel();
                adminCoursePanel.Location = new Point(xOffset, yOffset);
                adminCoursePanel.Name = "course1Panel";
                //adminCoursePanel.Size = new Size(216, 157);
                adminCoursePanel.Size = new Size(402, 255);
                adminCoursePanel.TabIndex = 7;
                adminCoursePanel.BackColor = Color.LightGray;


                Label courseTitleLbl = new Label();
                courseTitleLbl.AutoSize = true;
                courseTitleLbl.Location = new Point(15, 25);
                courseTitleLbl.Text = row["title"].ToString();
                courseTitleLbl.Name = "course1TitleLbl";
                courseTitleLbl.Size = new Size(0, 15);
                courseTitleLbl.TabIndex = 0;
                adminCoursePanel.Controls.Add(courseTitleLbl);

                Label courseDescLbl = new Label();
                courseDescLbl.AutoSize = true;
                courseDescLbl.Location = new Point(15, 59);
                courseDescLbl.Text = row["description"].ToString();
                courseDescLbl.Name = "course1DescLbl";
                courseDescLbl.Size = new Size(0, 15);
                courseDescLbl.TabIndex = 1;
                adminCoursePanel.Controls.Add(courseDescLbl);

                Label courseDurationLbl = new Label();
                courseDurationLbl.AutoSize = true;
                courseDurationLbl.Location = new Point(15, 96);
                courseDurationLbl.Text = row["duration"].ToString();
                courseDurationLbl.Name = "course1DurationLbl";
                courseDurationLbl.Size = new Size(0, 15);
                courseDurationLbl.TabIndex = 2;
                adminCoursePanel.Controls.Add(courseDurationLbl);


                AdminPageCoursesPanel.Controls.Add(adminCoursePanel);

                currentPanelCount++;
                if (currentPanelCount % panelsPerRow == 0)
                {
                    xOffset = 30;
                    yOffset += adminCoursePanel.Height + 50;
                }
                else
                {
                    xOffset += adminCoursePanel.Width + 100;
                }
            }
        }

        //private void RepositionPanels(Panel parentPanel)
        //{
        //    int xOffset = 30;
        //    int yOffset = 80;
        //    int panelsPerRow = 2;
        //    int currentPanelCount = 0;

        //    foreach (Control control in parentPanel.Controls)
        //    {
        //        if (control is Panel)
        //        {
        //            control.Location = new Point(xOffset, yOffset);
        //            currentPanelCount++;
        //            if (currentPanelCount % panelsPerRow == 0)
        //            {
        //                xOffset = 30;
        //                yOffset += control.Height + 50;
        //            }
        //            else
        //            {
        //                xOffset += control.Width + 100;
        //            }
        //        }
        //    }
        //}
        private void roomsBtn_Click(object sender, EventArgs e)
        {
            AdminPageCoursesPanel.Visible = false;
            AdminPageRoomsPanel.Visible = true;
            StudentsPanel.Visible = false;

            DataTable dataTable = new DataTable();
            Rooms rooms = new Rooms();
            dataTable = rooms.getRooms();

            //int xOffset = 30;
            //int yOffset = 80;
            int xOffset = 65;
            int yOffset = 135;
            int panelsPerRow = 2;
            int currentPanelCount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                Panel adminRoomPanel = new Panel();
                adminRoomPanel.Location = new Point(xOffset, yOffset);
                adminRoomPanel.Name = "course1Panel";
                //adminRoomPanel.Size = new Size(300, 157);
                adminRoomPanel.Size = new Size(402, 255);
                adminRoomPanel.TabIndex = 7;
                adminRoomPanel.BackColor = Color.LightGray;


                Label roomTitleLbl = new Label();
                roomTitleLbl.AutoSize = true;
                roomTitleLbl.Location = new Point(15, 25);
                roomTitleLbl.Text = row["title"].ToString();
                roomTitleLbl.Name = "course1TitleLbl";
                roomTitleLbl.Size = new Size(0, 15);
                roomTitleLbl.TabIndex = 0;
                adminRoomPanel.Controls.Add(roomTitleLbl);

                Label roomDescLbl = new Label();
                roomDescLbl.AutoSize = true;
                roomDescLbl.Location = new Point(15, 59);
                roomDescLbl.Text = row["description"].ToString();
                roomDescLbl.Name = "course1DescLbl";
                roomDescLbl.Size = new Size(0, 15);
                roomDescLbl.TabIndex = 1;
                adminRoomPanel.Controls.Add(roomDescLbl);

                Button deleteRoomBtn = new Button();
                deleteRoomBtn.BackColor = Color.Red;
                deleteRoomBtn.ForeColor = Color.White;
                deleteRoomBtn.Location = new Point(130, 124);
                deleteRoomBtn.Name = "deleteRoom2Btn";
                deleteRoomBtn.Size = new Size(99, 31);
                deleteRoomBtn.TabIndex = 4;
                deleteRoomBtn.Text = "Delete Room";
                deleteRoomBtn.UseVisualStyleBackColor = false;

                //Button addRoomBtn = new Button();
                //addRoomBtn.BackColor = Color.Green;
                //addRoomBtn.ForeColor = Color.White;
                //addRoomBtn.Location = new Point(30, 20);
                //addRoomBtn.Name = "addRoomBtn";
                //addRoomBtn.Size = new Size(99, 31);
                //addRoomBtn.TabIndex = 5;
                //addRoomBtn.Text = "Add Room";
                //addRoomBtn.UseVisualStyleBackColor = false;
                //AdminPageRoomsPanel.Controls.Add(addRoomBtn);
                //addRoomBtn.Click += (s, args) =>
                //{
                //    // Logic to add a new room
                //    // Example: Open a new form to input room details
                //    AddRoomForm addRoomForm = new AddRoomForm();
                //    if (addRoomForm.ShowDialog() == DialogResult.OK)
                //    {
                //        // Refresh the rooms panel after adding a new room
                //        AdminPageRoomsPanel.Controls.Clear();
                //        roomsBtn_Click(sender, e);
                //    }
                //};
                //adminRoomPanel.Controls.Add(deleteRoomBtn);

                deleteRoomBtn.Click += (s, args) =>
                {
                    if (rooms.deleteRoomByID(Convert.ToInt32(row["roomId"])))
                    {
                        AdminPageRoomsPanel.Controls.Remove(adminRoomPanel);
                        //RepositionPanels(AdminPageRoomsPanel);
                    }
                };

                //    private void RepositionPanels(Panel parentPanel)
                //    {
                //        int xOffset = 30;
                //        int yOffset = 80;
                //        int panelsPerRow = 2;
                //        int currentPanelCount = 0;

                //        foreach (Control control in parentPanel.Controls)
                //    {
                //        if (control is Panel)
                //        {
                //            control.Location = new Point(xOffset, yOffset);
                //            currentPanelCount++;
                //            if (currentPanelCount % panelsPerRow == 0)
                //            {
                //                xOffset = 30;
                //                yOffset += control.Height + 50;
                //            }
                //            else
                //            {
                //                xOffset += control.Width + 100;
                //            }
                //        }
                //    }
                //}

                AdminPageRoomsPanel.Controls.Add(adminRoomPanel);

                currentPanelCount++;
                if (currentPanelCount % panelsPerRow == 0)
                {
                    xOffset = 30;
                    yOffset += adminRoomPanel.Height + 50;
                }
                else
                {
                    xOffset += adminRoomPanel.Width + 100;
                }
            }
        }

        //private void DeleteRoom(int roomID) {
        //    Rooms rooms = new Rooms();
        //    rooms.deleteRoomByID(roomID);
        //    AdminPageRoomsPanel.Controls.Clear();
        //    roomsBtn_Click(null, null);
        //}

        private void studBtn_Click(object sender, EventArgs e)
        {
            AdminPageCoursesPanel.Visible = false;
            AdminPageRoomsPanel.Visible = false;
            StudentsPanel.Visible = true;

        }

        //private void backRoomLinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        //{

        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void coursesBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPageCoursesPanel.Visible = false;
            AdminPageRoomsPanel.Visible = false;
            StudentsPanel.Visible = false;
        }

        private void studentsBackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPageCoursesPanel.Visible = false;
            AdminPageRoomsPanel.Visible = false;
            StudentsPanel.Visible = false;
        }

        private void backRoomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPageCoursesPanel.Visible = false;
            AdminPageRoomsPanel.Visible = false;
            StudentsPanel.Visible = false;
        }

        private void AdminPageCoursesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addRoom_Click(object sender, EventArgs e)
        {

        }

        private void room1Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void room2Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void room2Btn_Click(object sender, EventArgs e)
        {

        }

        private void adminPageRoomsLbl_Click(object sender, EventArgs e)
        {

        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            adminCoursePanel.Visible = false;
            addCoursePanel.Visible = true;
        }
    }
}
