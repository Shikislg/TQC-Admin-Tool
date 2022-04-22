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
        }

        private void MemberStatistics_Load(object sender, EventArgs e)
        {

        }
        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (GlobalDependencies.AccessLvl() > 0)
            {
                ResultBox.Items.Clear();
                ResultBox.Items.Add(new Member().GetStandardizedHeaders());
                ResultBox.Items.Add("");
                DataAccess data = new DataAccess();
                if (ClanSearchTf.Text.Length == 0)
                {
                    GlobalDependencies.members = data.GetAllMembers();
                }
                else
                {
                    GlobalDependencies.members = data.GetMembers(ClanSearchTf.Text);
                }

                foreach (Member member in GlobalDependencies.members)
                {
                    if (filter.Checked)
                    {
                        if (Properties.Settings.Default.minimumPoints < member.Points)
                        {
                            continue;
                        }
                    }
                    ResultBox.Items.Add(member.GetStandardizedLayoutData());
                }
            }
            else
            {
                MessageBox.Show("You don't have the permission to perform this command", "Error");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: GlobalDependencies.sortBy = "ORDER BY Points DESC";break;
                case 1: GlobalDependencies.sortBy = "ORDER BY Points ASC"; break;
                case 2: GlobalDependencies.sortBy = "ORDER BY LastCheckDate DESC"; break;
                case 3: GlobalDependencies.sortBy = "ORDER BY LastCheckDate ASC"; break;
                case 4: GlobalDependencies.sortBy = "ORDER BY JoinDate DESC"; break;
                case 5: GlobalDependencies.sortBy = "ORDER BY JoinDate ASC"; break;
            }
            SearchButton_Click(this, new EventArgs());
        }

        private string FindMemberTagInItem(string item)
        {
            string s = "";
            int tagLength = 0;
            char[] itemChars = item.ToCharArray();
            if (item.Contains(".."))
            {
                s = FindCutOffTag(item);
            }
            else
            {

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
                catch (IndexOutOfRangeException ie)
                {
                    Console.WriteLine(ie.StackTrace);
                }
            }
            return s;
        }
        private string FindCutOffTag(string key)
        {
            char[] keyCharArray = key.ToCharArray();
            string letters = "";
            string tagNumber = "";
            for (int i = 0; i < 7; i++)
            {
                letters += keyCharArray[i];
            }
            for(int i = 9; i < 14; i++)
            {
                tagNumber += keyCharArray[i];
            }
            foreach (string item in GlobalDependencies.cutOffTags)
            {
                if (item!=null)
                {
                    if (item.Contains(letters) && item.Contains(tagNumber))
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        private void CheckedAllMembersButton_Click(object sender, EventArgs e)
        {
            foreach (var item in ResultBox.Items)
            {
                //If the string is either empty (second row) or the header (first row,
                //which includes the discord tag written out) don't check the list item
                if (item.ToString().Trim().Length==0 || item.ToString().Contains("Discord Tag"))
                {
                    continue;
                }
                string DiscordTag = FindMemberTagInItem(item.ToString());
                SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));
                //query depends on access level (dev can check all clans, everyone else cannot)
                string query = $"UPDATE Members SET [LastCheckDate] = '{DateTime.Today}' WHERE DiscordTag = '{DiscordTag}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            SearchButton_Click(this, new EventArgs());
        }

        private void CheckedSelectedMemberButton_Click(object sender, EventArgs e)
        {
            if (ResultBox.SelectedItem!=null)
            {
                string DiscordTag = FindMemberTagInItem(ResultBox.SelectedItem.ToString());
                Console.WriteLine(DiscordTag);
                SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));
                string query = $"UPDATE Members SET [LastCheckDate] = '{DateTime.Today.Day}/{DateTime.Today.Month}/{DateTime.Today.Year}' WHERE DiscordTag = '{DiscordTag}'";
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

        private void ResultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultBox.SelectedIndex==0 || ResultBox.SelectedIndex == 1)
            {
                ResultBox.SelectedIndex = -1;
            }
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search for Members. You can enter a clan for the members to be filtered by, and also enable the Point filter to show only members below a certain" +
                "threshhold. The threshhold can be set in the Settings menu.","Hint");
        }
    }
}
