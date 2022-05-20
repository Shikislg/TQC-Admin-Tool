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
        #region Events
        private void ExitLoginButton_Click(object sender, EventArgs e)
        {
            GlobalDependencies.dashboardInstance.LoadForm(GlobalDependencies.currentForm);
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
            ExitLoginButton_Click(this, new EventArgs());
        }
        #endregion 
        #region Utility Methods
        public void RememberedLogin()
        {
            Login loginInst = new Login(Properties.Settings.Default.UserName);
            try
            {
                Dashboard dbInstance = GlobalDependencies.dashboardInstance;
                dbInstance.UserNameLabel.Text = loginInst.loggedInUser.UserName.Trim();
                dbInstance.LogoutButton.Visible = true;
                dbInstance.LoginButton.Location = new Point(3, 137);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("yeah ik");
            }
        }
        #endregion
    }
}
