using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Skill_Nova
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //vScrollBar1.SmallChange = 25;
            //vScrollBar1.LargeChange = 50;
            //vScrollBar1.Scroll += (sender, e) =>
            //{
            //    SettingsPanel.VerticalScroll.Value = vScrollBar1.Value;
            //    SettingsPanel.PerformLayout();
            //};

            //htmlIntroductionTxtBox.Text = "What is HTML?\r\nHTML stands for Hyper Text Markup Language\r\nHTML is the standard markup language for creating Web pages\r\nHTML describes the structure of a Web page\r\nHTML consists of" +
            //    "a series of elements\r\nHTML elements tell the browser how to display the content\r\nHTML elements label pieces of content such as \"this is a heading\", \"this is a paragraph\", \"this is a link\", etc." +
            //    "A Simple HTML Document\r\nExample\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<title>Page Title</title>\r\n</head>\r\n<body>\r\n\r\n<h1>My First Heading</h1>\r\n<p>My first paragraph.</p>\r\n\r\n</body>\r\n</html>" +
            //    "Example Explained\r\nThe <!DOCTYPE html> declaration defines that this document is an HTML5 document\r\nThe <html> element is the root element of an HTML page\r\nThe <head> element contains meta information about the HTML page\r\n" +
            //    "The <title> element specifies a title for the HTML page (which is shown in the browser's title bar or in the page's tab)\r\nThe <body> element defines the document's body, and is a container for all the visible contents, such as headings," +
            //    "paragraphs, images, hyperlinks, tables, lists, etc.\r\nThe <h1> element defines a large heading\r\nThe <p> element defines a paragraph\r\n";
            //htmlIntroductionTxtBox.Text = "ABC";
        }

        private void homeLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public void UpdateGreeting()
        {
            //usrLbl.Text = $"Hello, {userName}!";
            greetingLbl.Text = "AA";
            //if (usrLbl != null)
            //{
            //    usrLbl.Text = $"Hello, {userName}!";
            //}
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            htmlIntroductionTxtBox.Multiline = true;

            htmlIntroductionTxtBox.ScrollBars = ScrollBars.Vertical;

            htmlIntroductionTxtBox.Height = 453;
            //htmlIntroductionTxtBox.Width = 400;

            htmlIntroductionTxtBox.Text = "\r\nWhat is HTML?\r\nHTML stands for Hyper Text Markup Language\r\nHTML is the standard markup language for creating Web pages\r\nHTML describes the structure of a Web page\r\nHTML consists of" +
                "a series of elements\r\nHTML elements tell the browser how to display the content\r\nHTML elements label pieces of content such as \"this is a heading\", \"this is a paragraph\", \"this is a link\", etc." +
                "A Simple HTML Document\r\nExample\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<title>Page Title</title>\r\n</head>\r\n<body>\r\n\r\n<h1>My First Heading</h1>\r\n<p>My first paragraph.</p>\r\n\r\n</body>\r\n</html>" +
                "Example Explained\r\nThe <!DOCTYPE html> declaration defines that this document is an HTML5 document\r\nThe <html> element is the root element of an HTML page\r\nThe <head> element contains meta information about the HTML page\r\n" +
                "The <title> element specifies a title for the HTML page (which is shown in the browser's title bar or in the page's tab)\r\nThe <body> element defines the document's body, and is a container for all the visible contents, such as headings," +
                "paragraphs, images, hyperlinks, tables, lists, etc.\r\nThe <h1> element defines a large heading\r\nThe <p> element defines a paragraph\r\n" +
                "What is an HTML Element?\r\nAn HTML element is defined by a start tag, some content, and an end tag:\r\n\r\n<tagname> Content goes here... </tagname>\r\nThe HTML element is everything from the start tag to the end tag:\r\n\r\n<h1>My First Heading</h1>\r\n<p>My first paragraph.</p>";

        }

        private void LeftSideBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allCoursesLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllCoursesPanel.Visible = true;
            AllRoomsPanel.Visible = false;
            SettingsPanel.Visible = false;
            htmlPanel.Visible = false;

            DataTable dataTable = new DataTable();
            Course courses = new Course();
            dataTable = courses.getCourses();

            int xOffset = 30;
            int yOffset = 80;
            int panelsPerRow = 2;
            int currentPanelCount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                Panel course1Panel = new Panel();
                course1Panel.Location = new Point(xOffset, yOffset);
                course1Panel.Name = "course1Panel";
                //course1Panel.Size = new Size(216, 157);
                course1Panel.Size = new Size(402, 255);
                course1Panel.TabIndex = 7;
                course1Panel.BackColor = Color.LightGray;


                Label course1TitleLbl = new Label();
                course1TitleLbl.AutoSize = true;
                course1TitleLbl.Location = new Point(15, 25);
                course1TitleLbl.Text = row["title"].ToString();
                course1TitleLbl.Name = "course1TitleLbl";
                course1TitleLbl.Size = new Size(0, 15);
                course1TitleLbl.TabIndex = 0;
                course1Panel.Controls.Add(course1TitleLbl);

                Label course1DescLbl = new Label();
                course1DescLbl.AutoSize = true;
                course1DescLbl.Location = new Point(15, 59);
                course1DescLbl.Text = row["description"].ToString();
                course1DescLbl.Name = "course1DescLbl";
                course1DescLbl.Size = new Size(0, 15);
                course1DescLbl.TabIndex = 1;
                course1Panel.Controls.Add(course1DescLbl);

                Label course1DurationLbl = new Label();
                course1DurationLbl.AutoSize = true;
                course1DurationLbl.Location = new Point(15, 96);
                course1DurationLbl.Text = row["duration"].ToString();
                course1DurationLbl.Name = "course1DurationLbl";
                course1DurationLbl.Size = new Size(0, 15);
                course1DurationLbl.TabIndex = 2;
                course1Panel.Controls.Add(course1DurationLbl);

                Button enroll = new Button();
                enroll.BackColor = Color.Green;
                enroll.ForeColor = Color.White;
                enroll.Location = new Point(130, 144);
                enroll.Name = "enrollButton";
                enroll.Size = new Size(99, 31);
                enroll.TabIndex = 4;
                enroll.Text = "Enroll";
                enroll.UseVisualStyleBackColor = false;
                course1Panel.Controls.Add(enroll);

                enroll.Click += (s, args) =>
                {
                    AllCoursesPanel.Visible = false;
                    MessageBox.Show("Enrolled Successfully");
                    htmlPanel.Visible = true;
                };

                //25, 195

                AllCoursesPanel.Controls.Add(course1Panel);

                currentPanelCount++;
                if (currentPanelCount % panelsPerRow == 0)
                {
                    xOffset = 30;
                    yOffset += course1Panel.Height + 50;
                }
                else
                {
                    xOffset += course1Panel.Width + 100;
                }
            }
        }
        private void roomLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllRoomsPanel.Visible = true;
            AllCoursesPanel.Visible = false;
            SettingsPanel.Visible = false;
            htmlPanel.Visible = false;


            DataTable dataTable = new DataTable();
            Rooms room = new Rooms();
            dataTable = room.getRooms();

            int xOffset = 30;
            int yOffset = 80;
            int panelsPerRow = 2;
            int currentPanelCount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                Panel roomPanel = new Panel();
                roomPanel.Location = new Point(xOffset, yOffset);
                roomPanel.Name = "roomPanel";
                //roomPanel.Size = new Size(216, 157);
                roomPanel.Size = new Size(402, 255);
                roomPanel.TabIndex = 7;
                roomPanel.BackColor = Color.LightGray;


                Label roomTitleLbl = new Label();
                roomTitleLbl.AutoSize = true;
                roomTitleLbl.Location = new Point(15, 25);
                roomTitleLbl.Text = row["title"].ToString();
                roomTitleLbl.Name = "roomTitleLbl";
                roomTitleLbl.Size = new Size(0, 15);
                roomTitleLbl.TabIndex = 0;
                roomPanel.Controls.Add(roomTitleLbl);

                Label roomDescLbl = new Label();
                roomDescLbl.AutoSize = true;
                roomDescLbl.Location = new Point(15, 59);
                roomDescLbl.Text = row["description"].ToString();
                roomDescLbl.Name = "roomDescLbl";
                roomDescLbl.Size = new Size(0, 15);
                roomDescLbl.TabIndex = 1;
                roomPanel.Controls.Add(roomDescLbl);

                AllRoomsPanel.Controls.Add(roomPanel);

                currentPanelCount++;
                if (currentPanelCount % panelsPerRow == 0)
                {
                    xOffset = 30;
                    yOffset += roomPanel.Height + 50;
                }
                else
                {
                    xOffset += roomPanel.Width + 100;
                }
            }
        }

        private void settingsLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (User.userId <= 0) { MessageBox.Show("User ID is not set. Please register or log in."); return; }
            SettingsPanel.Visible = true;
            AllCoursesPanel.Visible = false;
            AllRoomsPanel.Visible = false;
            htmlPanel.Visible = false;

            DataTable dataTable = new DataTable();
            User user = new User();
            dataTable = user.getUser();

            foreach (DataRow row in dataTable.Rows)
            {
                profileFullNameLbl.Text = row["fullName"].ToString();
                profileUsrNameLbl.Text = row["userName"].ToString();
                profileEmailLbl.Text = row["email"].ToString();
            }
        }

        private void logoutLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logInForm logInForm = new logInForm();

            logInForm.Visible = true;
            //SettingsPanel.Visible = false;
            //AllCoursesPanel.Visible = false;
            //AllRoomsPanel.Visible = false;
            this.Visible = false;
        }

        //private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    SettingsPanel.VerticalScroll.Value = vScrollBar1.Value;
        //    SettingsPanel.PerformLayout();
        //}

        //private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        //{

        //}

        private void changeProfileBtn_Click(object sender, EventArgs e)
        {
            profilePnl.Visible = false;
            delProfPanel.Visible = false;
            changeProfilepanel.Visible = true;
        }

        private void introBtn_Click(object sender, EventArgs e)
        {
            //htmlIntroductionTxtBox.Text = "What is HTML?\r\nHTML stands for Hyper Text Markup Language\r\nHTML is the standard markup language for creating Web pages\r\nHTML describes the structure of a Web page\r\nHTML consists of a series of elements\r\nHTML elements tell the browser how to display the content\r\nHTML elements label pieces of content such as \"this is a heading\", \"this is a paragraph\", \"this is a link\", etc.";
        }

        private void basicsBtn_Click(object sender, EventArgs e)
        {
            htmlIntroductionTxtBox.Text = "HTML Basic Examples\r\nHTML Documents\r\nAll HTML documents must start with a document type declaration: <!DOCTYPE html>.\r\n\r\n" +
                "The HTML document itself begins with <html> and ends with </html>.\r\n\r\nThe visible part of the HTML document is between <body> and </body>.\r\n\r\nExample\r\n" +
                "<!DOCTYPE html>\r\n<html>\r\n<body>\r\n\r\n<h1>My First Heading</h1>\r\n<p>My first paragraph.</p>\r\n\r\n</body>\r\n</html>\r\nThe <!DOCTYPE> Declaration\r\n" +
                "The <!DOCTYPE> declaration represents the document type, and helps browsers to display web pages correctly.\r\n\r\nIt must only appear once, at the top of the" +
                "page (before any HTML tags).\r\n\r\nThe <!DOCTYPE> declaration is not case sensitive.\r\n\r\nThe <!DOCTYPE> declaration for HTML5 is:\r\n\r\n<!DOCTYPE html>\r\n" +
                "HTML Headings\r\nHTML headings are defined with the <h1> to <h6> tags.\r\n\r\n<h1> defines the most important heading. <h6> defines the least important heading: \r\n\r\n" +
                "Example\r\n<h1>This is heading 1</h1>\r\n<h2>This is heading 2</h2>\r\n<h3>This is heading 3</h3>";

        }

        private void htmlElementsBtn_Click(object sender, EventArgs e)
        {
            htmlIntroductionTxtBox.Text = "HTML Elements\r\nThe HTML element is everything from the start tag to the end tag:\r\n\r\n<tagname>Content goes here...</tagname>\r\nExamples of some HTML elements:\r\n\r\n<h1>My First Heading</h1>\r\n<p>My first paragraph.</p>" +
                "\r\nStart tag\tElement content\tEnd tag\r\n<h1>\tMy First Heading\t</h1>\r\n<p>\tMy first paragraph.\t</p>\r\n<br>\tnone\tnone\r\nNote: Some HTML elements have no content (like the <br> element). These elements are called empty elements. Empty elements do not have an end tag!" +
                "\r\n\r\nNested HTML Elements\r\nHTML elements can be nested (this means that elements can contain other elements).\r\n\r\nAll HTML documents consist of nested HTML elements.\r\n\r\nThe following example contains four HTML elements (<html>, <body>, <h1> and <p>):\r\n\r\nExample" +
                "\r\n<!DOCTYPE html>\r\n<html>\r\n<body>\r\n\r\n<h1>My First Heading</h1>\r\n<p>My first paragraph.</p>\r\n\r\n</body>\r\n</html>\r\nExample Explained\r\nThe <html> element is the root element and it defines the whole HTML document.\r\n\r\nIt has a start tag <html> and an end tag </html>." +
                "\r\n\r\nThen, inside the <html> element there is a <body> element:\r\n\r\n<body>\r\n\r\n<h1>My First Heading</h1>\r\n<p>My first paragraph.</p>\r\n\r\n</body>\r\nThe <body> element defines the document's body.\r\n\r\nIt has a start tag <body> and an end tag </body>.\r\n\r\n" +
                "Then, inside the <body> element there are two other elements: <h1> and <p>:\r\n\r\n<h1>My First Heading</h1>\r\n<p>My first paragraph.</p>\r\nThe <h1> element defines a heading.\r\n\r\nIt has a start tag <h1> and an end tag </h1>:\r\n\r\n<h1>My First Heading</h1>\r\nThe <p> element defines a paragraph." +
                "\r\n\r\nIt has a start tag <p> and an end tag </p>:\r\n\r\n<p>My first paragraph.</p>Never Skip the End Tag\r\nSome HTML elements will display correctly, even if you forget the end tag:\r\n\r\nExample\r\n<html>\r\n<body>\r\n\r\n<p>This is a paragraph\r\n<p>This is a paragraph\r\n\r\n</body>\r\n</html>\r\n" +
                "However, never rely on this! Unexpected results and errors may occur if you forget the end tag!\r\n\r\nEmpty HTML Elements\r\nHTML elements with no content are called empty elements.\r\n\r\nThe <br> tag defines a line break, and is an empty element without a closing tag:\r\n\r\nExample\r\n<p>This is a <br> " +
                "paragraph with a line break.</p>\r\nHTML is Not Case Sensitive\r\nHTML tags are not case sensitive: <P> means the same as <p>.\r\n\r\nThe HTML standard does not require lowercase tags, but W3C recommends lowercase in HTML, and demands lowercase for stricter document types like XHTML.";
        }

        private void htmlAttributesBtn_Click(object sender, EventArgs e)
        {
            htmlIntroductionTxtBox.Text = "HTML Attributes\r\nAll HTML elements can have attributes\r\nAttributes provide additional information about elements\r\nAttributes are always specified in the start tag\r\nAttributes usually come in name/value pairs like: name=\"value\"\r\nThe href Attribute\r\nThe <a>" +
                "tag defines a hyperlink. The href attribute specifies the URL of the page the link goes to:\r\n\r\nExample\r\nVisit W3Schools</a>\r\nYou will learn more about links in our HTML Links chapter.\r\n\r\nThe src Attribute\r\nThe <img> tag is used to embed an image in an HTML page." +
                "The src attribute specifies the path to the image to be displayed:\r\n\r\nExample\r\n<img src=\"img_girl.jpg\">\r\nThere are two ways to specify the URL in the src attribute:\r\n\r\n1. Absolute URL - Links to an external image that is hosted on another website" +
                ".\r\n\r\nNotes: External images might be under copyright. If you do not get permission to use it, you may be in violation of copyright laws. In addition, you cannot control external images; it can suddenly be removed or changed.\r\n\r\n2. Relative URL - Links to an image that is hosted within the website." +
                "Here, the URL does not include the domain name. If the URL begins without a slash, it will be relative to the current page. Example: src=\"img_girl.jpg\". If the URL begins with a slash, it will be relative to the domain. Example: src=\"/images/img_girl.jpg\".\r\n\r\nTip: It is almost always best to use relative URLs. " +
                "They will not break if you change domain.\r\n\r\nThe width and height Attributes\r\nThe <img> tag should also contain the width and height attributes, which specify the width and height of the image (in pixels):\r\n\r\nExample\r\n<img src=\"img_girl.jpg\" width=\"500\" height=\"600\">\r\nThe alt Attribute\r\nThe required " +
                "alt attribute for the <img> tag specifies an alternate text for an image, if the image for some reason cannot be displayed. This can be due to a slow connection, or an error in the src attribute, or if the user uses a screen reader.\r\n\r\nExample\r\n<img src=\"img_girl.jpg\" alt=\"Girl with a jacket\">\r\nExample\r\nSee " +
                "what happens if we try to display an image that does not exist:\r\n\r\n<img src=\"img_typo.jpg\" alt=\"Girl with a jacket\">\r\nThe style Attribute\r\nThe style attribute is used to add styles to an element, such as color, font, size, and more.\r\n\r\nExample\r\n<p style=\"color:red;\">This is a red paragraph.</p>\r\nYou will" +
                "learn more about styles in our HTML Styles chapter.\r\n\r\nThe lang Attribute\r\nYou should always include the lang attribute inside the <html> tag, to declare the language of the Web page. This is meant to assist search engines and browsers.\r\n\r\nThe following example specifies English as the language:\r\n\r\n<!DOCTYPE" +
                "html>\r\n<html lang=\"en\">\r\n<body>\r\n...\r\n</body>\r\n</html>\r\nCountry codes can also be added to the language code in the lang attribute. So, the first two characters define the language of the HTML page, and the last two characters define the country.\r\n\r\nThe following example specifies English as the language and" +
                "United States as the country:\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en-US\">\r\n<body>\r\n...\r\n</body>\r\n</html>\r\nYou can see all the language codes in our HTML Language Code Reference.\r\n\r\nThe title Attribute\r\nThe title attribute defines some extra information about an element.\r\n\r\nThe value of the title attribute will" +
                "be displayed as a tooltip when you mouse over the element:\r\n\r\nExample\r\n<p title=\"I'm a tooltip\">This is a paragraph.</p>\r\nWe Suggest: Always Use Lowercase Attributes\r\nThe HTML standard does not require lowercase attribute names.\r\n\r\nThe title attribute (and all other attributes) can be written with uppercase or lowercase" +
                "like title or TITLE.\r\n\r\nHowever, W3C recommends lowercase attributes in HTML, and demands lowercase attributes for stricter document types like XHTML.\r\n\r\nAt W3Schools we always use lowercase attribute names.\r\n\r\nWe Suggest: Always Quote Attribute Values\r\nThe HTML standard does not require quotes around attribute values.\r\n\r\n" +
                "However, W3C recommends quotes in HTML, and demands quotes for stricter document types like XHTML.\r\n\r\nGood:\r\n Visit our HTML tutorial</a>\r\nBad:\r\nVisit our HTML tutorial</a>\r\nSometimes you have to use quotes. This example will not display the title " +
                "attribute correctly, because it contains a space:\r\n\r\nExample\r\n<p title=Description of W3Schools>";
        }

        private void delAccBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            bool isDeleted = user.deleteUser();
            if (isDeleted)
            {
                signUpForm signUpForm = new signUpForm();
                signUpForm.Visible = true;

                this.Visible = false;
            }
        }

        private void changeProfBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            string fullName = fullNameProfTxtBx.Text.ToString();
            string userName = usrNameProfileTxtBx.Text.ToString();
            string email = emailProfileTxtBx.Text.ToString();
            string password = pwdProfileTextBx.Text.ToString();

            bool isUpdated = user.updateProfile(fullName, userName, email, password);
            if (isUpdated)
            {
                logInForm loginBtn = new logInForm();
                loginBtn.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Error occurred during registration. Please try again.");
            }
            fullNameProfTxtBx.Text = "";
            usrNameProfileTxtBx.Text = "";
            emailProfileTxtBx.Text = "";
            pwdProfileTextBx.Text = "";

        }

        //private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        //{
        //    SettingsPanel.VerticalScroll.Value = vScrollBar1.Value;
        //    SettingsPanel.PerformLayout();
        //}
    }
}
