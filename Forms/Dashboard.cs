using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Squirrel;
using System.Diagnostics;
using System.Net;

namespace Dashboard
{

    public partial class Dashboard : Form
    {
        public const Boolean t = true;
        public const Boolean f = false;
        public Login loginInst;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Dashboard()
        {
            InitializeComponent();

            CheckForUpdates();

            MapClans();

            GlobalDependencies.dashboardInstance = this;
            Console.WriteLine("Application Initialized\r\n" + Properties.Settings.Default.isRemembered);

            if (Properties.Settings.Default.isRemembered == true)
            {
                new LoginForm().RememberedLogin();
            }
            //Start page is Member Statistics
            LoadForm(new MemberStatistics());

            ApplicationDesign();

            GlobalDependencies.members = new DataAccess().GetAllMembers();

            this.label1.Text += $" v.{FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion}";
        }
        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager("http://tqcamintool.000webhostapp.com", "TqcAdminTool"))
            {
                await manager.UpdateApp();
            }
        }
        public void LoadForm(object Form)
        {
            if (!Form.GetType().IsInstanceOfType(new LoginForm().GetType()))
            {
                GlobalDependencies.currentForm = Form as Form;
            }
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = f;
            form.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
        }
        public void LoadForm(object Form, DockStyle ds, int y)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = f;
            form.Dock = ds;
            form.Location = new Point(50, y);
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Switched view to the Login Container, which contains the login panel
            LoadForm(GlobalDependencies.loginFormInstance, DockStyle.None, 150);

        }

        private void MStatsButton_Click(object sender, EventArgs e)
        {
            //Navigate to the MemberStats Page
            LoadForm(GlobalDependencies.mStatsInstance);
            MoveNav(MStatsButton);
        }

        private void MStatsButton_Leave(object sender, EventArgs e)
        {
            MStatsButton.BackColor = Properties.Settings.Default.AccentOne;
        }

        private void EManagerButton_Click(object sender, EventArgs e)
        {
            LoadForm(GlobalDependencies.eventManagerInstance);
            MoveNav(EManagerButton);
        }
        private void EManagerButton_Leave(object sender, EventArgs e)
        {
            EManagerButton.BackColor = Properties.Settings.Default.AccentOne;
        }
        private void AMemberButton_Click(object sender, EventArgs e)
        {
            LoadForm(GlobalDependencies.addMembersInstance);
            MoveNav(AMemberButton);
        }
        private void AMemberButton_Leave(object sender, EventArgs e)
        {
            AMemberButton.BackColor = Properties.Settings.Default.AccentOne;
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            LoadForm(GlobalDependencies.settingsFormInstance);
            MoveNav(SettingsButton);
        }
        private void SettingsButton_Leave(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Properties.Settings.Default.AccentOne;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Update Member Data
            foreach (Member member in GlobalDependencies.members)
            {
                new UpdateData().SaveChanges(member);
            }
            //Add all pending Members
            if (GlobalDependencies.membersToBeAdded.Count > 0)
            {
                foreach (Member member in GlobalDependencies.membersToBeAdded)
                {
                    new UpdateData().InsertData("DiscordTag", "Clan", member.DiscordTag, member.Clan, member.EventsParticipated, member.EventsAlted, member.EventsMissed);

                    SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));
                    string query = $"UPDATE Members SET JoinDate = '{member.JoinDate}', LastCheckDate = '{member.LastCheckDate}' WHERE DiscordTag = '{member.DiscordTag}'";
                    Console.WriteLine(query);
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                GlobalDependencies.membersToBeAdded.Clear();
            }
            //Delete all pending Members
            if (GlobalDependencies.membersToBeDeleted.Count > 0)
            {
                foreach (String member in GlobalDependencies.membersToBeDeleted)
                {
                    new UpdateData().DeleteData($"DiscordTag = '{member}'");
                }
                GlobalDependencies.membersToBeDeleted.Clear();
            }
            //Make all traces of unsaved Progress invisible
            SaveButton.Visible = f;
            ResetButton.Visible = f;
            new EventManager().responseLabel.Text = "";
        }
        public void ActivateSaveBtn()
        {
            SaveButton.Visible = t;
        }
        public void ActivateResetBtn()
        {
            ResetButton.Visible = t;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            new UpdateData().ResetChanges(this);
            ResetButton.Visible = f;
            SaveButton.Visible = f;
            new EventManager().responseLabel.Text = "";
        }
        private void MoveNav(Button navButton)
        {
            //Set the Sidebar
            if (navButton != null)
            {
                NavPanel.Height = navButton.Height;
                NavPanel.Top = navButton.Top;
                NavPanel.Left = navButton.Left;
                navButton.BackColor = Color.FromArgb(46, 51, 73);
            }
        }
        private void ApplicationDesign()
        {
            OrangeBar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 3, Width, Height - 17, 10, 10));
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            NavPanel.Height = MStatsButton.Height;
            NavPanel.Top = MStatsButton.Top;
            NavPanel.Left = MStatsButton.Left;
            MStatsButton.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Red;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Properties.Settings.Default.AccentOne;
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.BackColor = Color.LightGray;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.BackColor = Properties.Settings.Default.AccentOne;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaxWinButton_MouseEnter(object sender, EventArgs e)
        {
            MaxWinButton.BackColor = Color.LightGray;
        }

        private void MaxWinButton_MouseLeave(object sender, EventArgs e)
        {
            MaxWinButton.BackColor = Properties.Settings.Default.AccentOne;
        }

        private void MaxWinButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                MaxWinButton.BackgroundImage = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images\\wideMaximizeSmall.png"));
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                Console.WriteLine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images/wideMaximizeSmall.png"));
                MaxWinButton.BackgroundImage = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images\\wideWindowSmall.png"));
            }
        }

        private void ReloadButton_MouseEnter(object sender, EventArgs e)
        {
            ReloadButton.BackColor = Color.LightGray;
        }

        private void ReloadButton_MouseLeave(object sender, EventArgs e)
        {
            ReloadButton.BackColor = Properties.Settings.Default.AccentOne;
        }

        private async void ReloadButton_Click(object sender, EventArgs e)
        {
            //to be implemented when the API comes out
            APIInit.InitializeClient();
            foreach (int key in GlobalDependencies.clans.Keys)
            {
                ReadMemberJson rmj = await new BungieApiProcessor().LoadClanMembers(key.ToString());
                try
                {
                    SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));
                    foreach (results res in rmj.response.results)
                    {
                        string name = res.bungieNetUserInfo.supplementalDisplayName.Replace("\'", "");
                        bool uniqueName = IsNameUnique(name, connection);
                        if (uniqueName)
                        {
                            Console.WriteLine(name + " is being added");
                            new UpdateData().InsertData("DiscordTag", name);
                            string query = $"UPDATE Members SET JoinDate = '{res.joinDate}', LastCheckDate = '{DateTime.Today}', Clan = '{GlobalDependencies.clans[key]}' WHERE DiscordTag = '{name}'";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private bool IsNameUnique(string name, SqlConnection connection)
        {
            string query = $"SELECT * FROM Members WHERE DiscordTag ='{ name }'";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            GlobalDependencies.loginInstance = null;
            UserNameLabel.Text = "not logged in";
            LogoutButton.Visible = false;
            LoginButton.Location = new Point(55, 137);
            Properties.Settings.Default.isRemembered = false;
            Properties.Settings.Default.Save();
        }
        private void MapClans()
        {
            GlobalDependencies.clans.Add(3943760, "Tenacity");
            GlobalDependencies.clans.Add(3853209, "Aegis");
            GlobalDependencies.clans.Add(4129187, "Ethereal");
            GlobalDependencies.clans.Add(4278992, "Celestial");
            GlobalDependencies.clans.Add(4401600, "Majestic");
            GlobalDependencies.clans.Add(3502980, "Defiance");
            GlobalDependencies.clans.Add(3888411, "Vigilant");
            GlobalDependencies.clans.Add(4157005, "Tranquility");
            GlobalDependencies.clans.Add(4278978, "Eternal");
            GlobalDependencies.clans.Add(4401617, "Immortal");
            GlobalDependencies.clans.Add(4279010, "Shadow");
            GlobalDependencies.clans.Add(4402352, "Quantum");
            GlobalDependencies.clans.Add(4129175, "Ephemera");
        }
    }
}
