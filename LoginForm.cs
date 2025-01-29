namespace Skill_Nova
{
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();
        }

        //private void logInForm_Resize(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        CenterToScreen();
        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            mainForm mainForm = new mainForm();
            adminForm adminForm = new adminForm();
            string userName = loginUsrNameTextBox.Text.ToString().Trim();
            string password = loginPwdTextBox.Text.ToString().Trim();

            bool isLoggedIn = user.userLogin(userName, password);
            bool isAdminLoggedIn = user.adminLogin(userName, password);

            if (isLoggedIn)
            {
                MessageBox.Show("Login Successful");
                mainForm.Visible = true;
                adminForm.Visible = false;
                this.Visible = false;
            }
            else if (isAdminLoggedIn)
            {
                MessageBox.Show("Login Successful");
                adminForm.Visible = true;
                mainForm.Visible = false;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            loginUsrNameTextBox.Text = "";
            loginPwdTextBox.Text = "";
        }

        private void registerLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUpForm signUpBtn = new signUpForm();
            signUpBtn.Visible = true;
            this.Visible = false;
        }
    }
}
