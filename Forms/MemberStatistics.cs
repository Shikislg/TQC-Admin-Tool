using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Dashboard
{
    public partial class MemberStatistics : Form
    {
        public MemberStatistics()
        {
            InitializeComponent();

            NameSearchTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            ClanSearchTf.AutoCompleteCustomSource = GlobalDependencies.clanTags;
        }

        #region Events
        private void CheckedAllMembersButton_Click(object sender, EventArgs e)
        {
            CheckAllMembers();
        }

        private void CheckedSelectedMemberButton_Click(object sender, EventArgs e)
        {
            if (ResultBox.SelectedItem != null)
            {
                string DiscordTag = FindMemberTagInItem(ResultBox.SelectedItem.ToString());
                SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));
                string query = $"UPDATE Members SET [LastCheckDate] = '{DateTime.Today}' WHERE DiscordTag = '{DiscordTag}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                SearchButton_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("No Item Selected", "Error");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: GlobalDependencies.sortBy = "ORDER BY Points+EventPoints DESC"; break;
                case 1: GlobalDependencies.sortBy = "ORDER BY Points+EventPoints ASC"; break;
                case 2: GlobalDependencies.sortBy = "ORDER BY LastCheckDate DESC"; break;
                case 3: GlobalDependencies.sortBy = "ORDER BY LastCheckDate ASC"; break;
                case 4: GlobalDependencies.sortBy = "ORDER BY JoinDate DESC"; break;
                case 5: GlobalDependencies.sortBy = "ORDER BY JoinDate ASC"; break;
                case 6: GlobalDependencies.sortBy = "ORDER BY MemberLevel DESC"; break;
                case 7: GlobalDependencies.sortBy = "ORDER BY MemberLevel ASC"; break;
            }
            SearchButton_Click(this, new EventArgs());
        }

        private void ResultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultBox.SelectedIndex == -1)
            {
                return;
            }
            if (ResultBox.SelectedIndex == 0 || ResultBox.SelectedItem.ToString().Trim().Equals(""))
            {
                ResultBox.ClearSelected();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search for Members. You can enter a clan for the members to be filtered by, and also enable the Point filter to show only members below a certain" +
                "threshhold. The threshhold can be set in the Settings menu.", "Hint");
        }
        #endregion
        #region Utility Methods
        private void CheckAllMembers()
        {
            if (ResultBox.Items.Count == 0)
            {
                Console.WriteLine("there are no items in this list");
                return;
            }
            if (MessageBox.Show("Are you sure you want to check all members at one? This action cannot be reversed!!", "Careful!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (var item in ResultBox.Items)
                {
                    //If the string is either empty (second row) or the header (first row,
                    //which includes the discord tag written out) don't check the list item
                    if (item.ToString().Trim().Length == 0 || item.ToString().Contains("Discord Tag"))
                    {
                        continue;
                    }
                    string DiscordTag = FindMemberTagInItem(item.ToString());
                    SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));

                    string query;
                    if (GlobalDependencies.loginInstance.loggedInUser.Role.Trim() == "dev")
                    {
                        query = $"UPDATE Members SET [LastCheckDate] = '{DateTime.Today}' WHERE DiscordTag = '{DiscordTag}'";
                    }
                    else
                    {
                        query = $"UPDATE Members SET [LastCheckDate] = '{DateTime.Today}' WHERE DiscordTag = '{DiscordTag}' AND Clan = '{GlobalDependencies.loginInstance.loggedInUser.Clan}'";
                    }
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                SearchButton_Click(this, new EventArgs());
            }
        }

        private void Search()
        {
            if (GlobalDependencies.AccessLvl() > 0)
            {
                ResultBox.Items.Clear();
                ResultBox.Items.Add(new Member().GetStandardizedHeaders());
                ResultBox.Items.Add("");
                DataAccess data = new DataAccess();

                if (NameSearchTf.Text.Length > 0)
                {
                    try
                    {
                        GlobalDependencies.members = data.GetMembersByName(NameSearchTf.Text.PadRight(50));
                        if (GlobalDependencies.members[0].Clan.Trim() != GlobalDependencies.loginInstance.loggedInUser.Clan && GlobalDependencies.loginInstance.loggedInUser.Role != "dev")
                        {
                            if (MessageBox.Show("You don't have the permission to access data from this clan", "Error") == DialogResult.OK)
                            {
                                return;
                            }

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid UserName. Remember this input has to access a database so it's case sensitive and you need to enter the ID as well", "Error");
                    }
                }
                else
                {

                    if (ClanSearchTf.Text.Length == 0)
                    {
                        if (GlobalDependencies.AccessLvl() > 1)
                        {
                            GlobalDependencies.members = data.GetAllMembers();
                        }
                        else
                        {
                            _ = MessageBox.Show("You are not permitted to view stats for all clans", "Error");
                            return;
                        }
                    }
                    else
                    {
                        if (ClanSearchTf.Text.Equals(GlobalDependencies.loginInstance.loggedInUser.Clan) || GlobalDependencies.loginInstance.loggedInUser.Role.Trim() == "dev")
                        {
                            GlobalDependencies.members = data.GetMembersByClanTag(ClanSearchTf.Text);
                        }
                        else
                        {
                            MessageBox.Show("You don't have the permission to access data from this clan", "Error");
                        }
                    }
                }
                foreach (Member member in GlobalDependencies.members)
                {
                    if (PointFilter.Checked)
                    {
                        if (Properties.Settings.Default.minimumPoints <= member.Points + member.EventPoints)
                        {
                            continue;
                        }
                    }
                    if (CheckDateFilter.Checked)
                    {
                        if (Properties.Settings.Default.CheckingPeriod >= Math.Abs((DateTime.Parse(member.LastCheckDate.ToString()) - DateTime.Today).Days))
                        {
                            continue;
                        }
                    }
                    ResultBox.Items.Add(member.GetStandardizedLayoutData());

                }
                if (NameSearchTf.Text.Length > 0 && ResultBox.Items.Count == 3 && GlobalDependencies.settingsFormInstance.sLayout.NotesCheck.Checked)
                {
                    ResultBox.Items.Add("");
                    ResultBox.Items.Add("Notes");
                    if (GlobalDependencies.members[0].Notes != null)
                    {
                        ResultBox.Items.Add(GlobalDependencies.members[0].Notes);
                    }
                }
            }
            else
            {
                MessageBox.Show("You don't have the permission to perform this command", "Error");
            }
        }

        private string FindCutOffTag(string key)
        {
            char[] keyCharArray = key.ToCharArray();
            string letters = "";
            string tagNumber = "";
            for (int i = 0; i < 10; i++)
            {
                letters += keyCharArray[i];
            }
            for (int i = 12; i < 17; i++)
            {
                tagNumber += keyCharArray[i];
            }
            foreach (string item in GlobalDependencies.cutOffTags)
            {
                if (item != null)
                {
                    if (item.Contains(letters) && item.Contains(tagNumber))
                    {
                        return item;
                    }
                }
            }
            Console.WriteLine(tagNumber + " " + letters);
            return null;
        }

        private string FindMemberTagInItem(string item)
        {
            string s = "";
            int tagLength = 0;
            char[] itemChars = item.ToCharArray();
            if (item.Contains(".."))
            {
                s = FindCutOffTag(item);
                if (s != null)
                {
                    return s;
                }
            }
            try
            {
                while (itemChars[tagLength] != '#')
                {
                    tagLength++;
                }
                tagLength += 5;
                for (int i = 0; i < tagLength; i++)
                {
                    s += itemChars[i];
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(item);
                //Console.WriteLine(ie.StackTrace);
            }
            return s;
        }
        #endregion

        private void ResultBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = ResultBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches && ResultBox.SelectedIndex != -1)
            {
                ListBoxRightClick.Show(Cursor.Position);
                ListBoxRightClick.Visible = true;
            }
            else
            {
                ListBoxRightClick.Visible = false;
            }
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
