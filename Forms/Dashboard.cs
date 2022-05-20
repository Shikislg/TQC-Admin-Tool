using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Squirrel;
using System.Diagnostics;
using System.Net;
using System.Drawing.Drawing2D;

namespace Dashboard
{

    public partial class Dashboard : Form
    {
        public Login loginInst;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr one, int two, int three, int four);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Dashboard()
        {
            InitializeComponent();

            GlobalDependencies.dashboardInstance = this;

            CheckForUpdates();

            TryLogin();

            TryPullData();

            LoadForm(new MemberStatistics());

            ApplicationDesign();

            GlobalDependencies.members = new DataAccess().GetAllMembers();

            DBConnector.EventPointHandler();

            PopulateTagList();

            this.label1.Text += $" v.{FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion}";
        }
        #region Events
        private void AMemberButton_Click(object sender, EventArgs e)
        {
            LoadForm(GlobalDependencies.editMembersInstance);
            MoveNav(AMemberButton);
        }
        private void AMemberButton_Leave(object sender, EventArgs e)
        {
            AMemberButton.BackColor = Properties.Settings.Default.AccentOne;
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
        
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Red;
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Properties.Settings.Default.AccentOne;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            GlobalDependencies.loginInstance = null;
            UserNameLabel.Text = "not logged in";
            LogoutButton.Visible = false;
            LoginButton.Location = new Point(55, 137);
            Properties.Settings.Default.isRemembered = false;
            Properties.Settings.Default.Save();
            ApplyImage("https://hol-admin.000webhostapp.com//Images/holLogoTurqoiseStretched.png");
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Switched view to the Login Container, which contains the login panel
            LoadForm(GlobalDependencies.loginFormInstance, DockStyle.None, 150);

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
                var request = WebRequest.Create("https://hol-admin.000webhostapp.com/Images/wideMaximizeSmall.png");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    MaxWinButton.BackgroundImage = Bitmap.FromStream(stream);
                }
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                var request = WebRequest.Create("https://hol-admin.000webhostapp.com/Images/wideWindowSmall.png");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    MaxWinButton.BackgroundImage = Bitmap.FromStream(stream);
                }
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminProfile(new Member().FindMemberWithIncompleteTag(GlobalDependencies.loginInstance.loggedInUser.UserName.Trim())));
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
            await ReloadData();
            _ = MessageBox.Show("Members have been updated/added, and points have been adjusted", "Info", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }
       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveData();
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

        #endregion
        #region Utility Methods
        private void ApplicationDesign()
        {
            OrangeBar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 3, Width, Height - 17, 10, 10));
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            NavPanel.Height = MStatsButton.Height;
            NavPanel.Top = MStatsButton.Top;
            NavPanel.Left = MStatsButton.Left;
            MStatsButton.BackColor = Color.FromArgb(46, 51, 73);
        }
        public void ApplyImage(string url)
        {
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Image img = Bitmap.FromStream(stream);
                img = Resize(img, 98);
                pictureBox1.BackgroundImage = RoundCorners(img, 50, Properties.Settings.Default.AccentOne);
            }
        }
        private async Task CheckForUpdates()
        {
            using (var manager = new UpdateManager("https://hol-admin.000webhostapp.com/Releases", "TqcAdminTool"))
            {
                await manager.UpdateApp();
            }
        }
        
        private async void CleanseDatabase()
        {
            //For incorrect Tags
            List<string> markedForNegation = new List<string>();
            try
            {
                SqlDataReader reader = DBConnector.ExecuteReaderQuery("select DiscordTag from Members");
                while (reader.Read())
                {
                    if (reader["DiscordTag"].ToString().Trim().Length>4)
                    {
                        if (reader["DiscordTag"].ToString().Trim().ToCharArray()[reader["DiscordTag"].ToString().Trim().ToCharArray().Length - 4] == '#')
                        {
                            markedForNegation.Add(reader["DiscordTag"].ToString().Trim());
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, "Errors");
            }
            finally
            {
                DBConnector.connection.Close();
            }
            foreach (string trashTag in markedForNegation)
            {
                DBConnector.ExecuteQuery($"delete from Members where DiscordTag like '{trashTag}%'");
            }

            //For mistakenly transmitted bungie tags
            List<int> brokenMemberTags = new List<int>();
            foreach (Member member in GlobalDependencies.members)
            {
                if (int.TryParse(member.DiscordTag.Trim(), out int a))
                {
                    brokenMemberTags.Add(int.Parse(member.DiscordTag.Trim()));
                }
            }
            APIInit.InitializeClient();
            foreach (int ID in brokenMemberTags)
            {
                Models.ReadUserJson user = await new BungieApiProcessor().GetUserByID(ID);
                if (IsNameUnique(user.response.displayName))
                {
                    DBConnector.ExecuteQuery($"update Members set DiscordTag = '{user.response.displayName}' where DiscordTag = '{ID}'");
                }
            }
        }

        private bool IsNameUnique(string name)
        {
            return !DBConnector.DoesColumnExist($"SELECT * FROM Members WHERE DiscordTag like '{name.Trim()}%'");
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
            form.TopLevel = false;
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
            form.TopLevel = false;
            form.Dock = ds;
            form.Location = new Point(50, y);
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
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
        public Image RoundCorners(Image StartImage, int CornerRadius, Color BackgroundColor)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);
            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Brush brush = new TextureBrush(StartImage);
                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);
                return RoundedImage;
            }
        }
        public new Image Resize(Image img, int size)
        {
            Bitmap b = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, 0, 0, size, size);
            g.Dispose();
            return b;
        }
        public void PopulateTagList()
        {
            GlobalDependencies.memberTags.Clear();
            foreach (Member member in GlobalDependencies.members)
            {
                GlobalDependencies.memberTags.Add(member.DiscordTag.Trim());
            }
        }

        public async Task ReloadData()
        {
            if (GlobalDependencies.AccessLvl() > 0)
            {
                progressBar.Visible = true;
                //to be implemented when the API comes out
                APIInit.InitializeClient();
                foreach (int key in GlobalDependencies.clans.Keys)
                {
                    if (GlobalDependencies.loginInstance.loggedInUser.Role == "dev" || GlobalDependencies.loginInstance.loggedInUser.Clan == GlobalDependencies.clans[key])
                    {
                        label1.Text = "Loading Clan: " + GlobalDependencies.clans[key];
                        ReadMemberJson rmj = await new BungieApiProcessor().LoadClanMembers(key.ToString());
                        double i = 1;
                        foreach(results res in rmj.response.results)
                        {
                            string query = "";
                            double progress = (i / rmj.response.results.Count()) * 100;
                            progressBar.Value = (int)progress;
                            string name = "";
                            if (res.bungieNetUserInfo == null)
                            {
                                name = $"{res.destinyUserInfo.bungieGlobalDisplayName}#{res.destinyUserInfo.bungieGlobalDisplayNameCode}";
                            }
                            else
                            {
                                name = res.bungieNetUserInfo.supplementalDisplayName.Replace("\'", "");
                            }
                            name = new Member().CorrectDiscordTag(name, false);
                            if (name == null)
                            {
                                i++;
                                continue;
                            }
                            if (IsNameUnique(name))
                            {
                                DBConnector.ExecuteQuery($"INSERT INTO Members (DiscordTag) VALUES ('{name}')");
                                if (name.Contains("Shikuro"))
                                {
                                    query = $"UPDATE Members SET Clan = '{GlobalDependencies.clans[key]}', MemberLevel = '{res.memberType}', Points = '0', EventPoints = 0, WHERE DiscordTag = '{name}'";
                                }
                                else
                                {
                                    query = $"UPDATE Members SET JoinDate = '{res.joinDate}', LastCheckDate = '{res.joinDate}', Clan = '{GlobalDependencies.clans[key]}', MemberLevel = '{res.memberType}', Points = '0', EventPoints = 0 WHERE DiscordTag = '{name}'";
                                }
                                DBConnector.ExecuteQuery(query);
                            }
                            else
                            {
                                query = $"UPDATE Members SET JoinDate = '{res.joinDate}', Clan = '{GlobalDependencies.clans[key]}', MemberLevel = '{res.memberType}', Points = '0' WHERE DiscordTag = '{name}'";
                                DBConnector.ExecuteQuery(query);
                            }
                            i++;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You don't have the permission to perform this command", "Error");
            }
            CleanseDatabase();

            progressBar.Visible = false;

            this.label1.Text = $"HoL Admin Tool v.{FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion}";
        }
        
        private void ResetButton_Click(object sender, EventArgs e)
        {
            DBConnector.ResetChanges();
            ResetButton.Visible = false;
            SaveButton.Visible = false;
        }
        
        private void SaveData()
        {
            //Update Member Data
            foreach (Member member in GlobalDependencies.members)
            {
                DBConnector.SaveChanges(member);
            }
            //Add all pending Members
            if (GlobalDependencies.membersToBeAdded.Count > 0)
            {
                foreach (Member member in GlobalDependencies.membersToBeAdded)
                {
                    DBConnector.ExecuteQuery($"INSERT INTO Members (DiscordTag, Clan, EventsParticipated,EventsAlted,EventsMissed) VALUES ({member.DiscordTag},{member.Clan},{member.EventsParticipated},{member.EventsAlted},{member.EventsMissed})");
                    DBConnector.ExecuteQuery($"UPDATE Members SET JoinDate = '{member.JoinDate}', LastCheckDate = '{member.LastCheckDate}' WHERE DiscordTag = '{member.DiscordTag}'");
                }
                GlobalDependencies.membersToBeAdded.Clear();
            }
            //Delete all pending Members
            if (GlobalDependencies.membersToBeDeleted.Count > 0)
            {
                foreach (String member in GlobalDependencies.membersToBeDeleted)
                {
                    DBConnector.ExecuteQuery($"DELETE FROM Members WHERE DiscordTag = '{member}'");
                }
                GlobalDependencies.membersToBeDeleted.Clear();
            }
            //Make all traces of unsaved Progress invisible
            SaveButton.Visible = false;
            ResetButton.Visible = false;
        }
        
        private void TryLogin()
        {
            if (Properties.Settings.Default.isRemembered)
            {
                GlobalDependencies.loginFormInstance.RememberedLogin();
            }
        }
        private async void TryPullData()
        {
            if (Properties.Settings.Default.PullDataOnOpen)
            {
                await ReloadData();
            }
        }
        #endregion
    }

}
