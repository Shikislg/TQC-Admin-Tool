using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public void RememberedLogin()
        {
            Login loginInst = new Login(Properties.Settings.Default.UserName);
            try
            {
                GlobalDependencies.dashboardInstance.UserNameLabel.Text = loginInst.loggedInUser.UserName.Trim();
                GlobalDependencies.dashboardInstance.LogoutButton.Visible = true;
                GlobalDependencies.dashboardInstance.LoginButton.Location = new Point(3, 137);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("yeah ik");
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Logging in
            String hashPassword;
            Byte[] hashedPassword;
            hashedPassword = SHA256.Create().ComputeHash(UTF8Encoding.UTF8.GetBytes(PasswordTf.Text));
            hashPassword = BitConverter.ToString(hashedPassword).Replace("-", String.Empty);
            Login loginInst = new Login(UserNameTf.Text, hashPassword);
            string userName = "not logged in";
            try
            {
                if (loginInst.loggedInUser.UserName != null)
                {
                    if (RememberMe.Checked)
                    {
                        Properties.Settings.Default.isRemembered = true;
                        Properties.Settings.Default.UserName = UserNameTf.Text;
                        Properties.Settings.Default.Save();
                    }
                    userName = loginInst.loggedInUser.UserName;
                    GlobalDependencies.dashboardInstance.LogoutButton.Visible = true;
                    GlobalDependencies.dashboardInstance.LoginButton.Location = new Point(3, 137);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Invalid Username or password", "Error");
                return;
            }
            //Properties.Settings.Default.RememberMe = RememberMe.Checked;
            GlobalDependencies.dashboardInstance.UserNameLabel.Text = userName.Trim();
            switch (loginInst.loggedInUser.Role)
            {
                case "dev": GlobalDependencies.dashboardInstance.UserNameLabel.ForeColor = Color.FromArgb(80, 194, 247);break;
                case "admin": GlobalDependencies.dashboardInstance.UserNameLabel.ForeColor = Color.FromArgb(183, 233, 24);break;
                case "founder": GlobalDependencies.dashboardInstance.UserNameLabel.ForeColor = Color.FromArgb(80, 194, 247); break;

            }
            ExitLoginButton_Click(this, new EventArgs());
        }
        private void ExitLoginButton_Click(object sender, EventArgs e)
        {
            GlobalDependencies.dashboardInstance.LoadForm(GlobalDependencies.currentForm);
        }
    }
}
