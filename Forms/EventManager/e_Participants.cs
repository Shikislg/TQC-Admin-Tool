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
    public partial class e_Participants : Form
    {
        public e_Participants()
        {
            InitializeComponent();

            AddAltTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            AddAttendeeTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            AddNoShowTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            HostTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
        }
        #region Events
        private void AddAttendeeButton_Click(object sender, EventArgs e)
        {
            AddMemberToList(AddAttendeeTf, AttendeeList);
        }
        private void RemoveAttendeeButton_Click(object sender, EventArgs e)
        {
            if (AttendeeList.SelectedIndex != -1)
            {
                AttendeeList.Items.RemoveAt(AttendeeList.SelectedIndex);
                AttendeeList.Text = "";
            }
        }

        private void AddAltButton_Click(object sender, EventArgs e)
        {
            AddMemberToList(AddAltTf, AltList);
        }
        private void RemoveAltButton_Click(object sender, EventArgs e)
        {
            if (AltList.SelectedIndex != -1)
            {
                AltList.Items.RemoveAt(AltList.SelectedIndex);
                AltList.Text = "";
            }
        }

        private void AddNoShowButton_Click(object sender, EventArgs e)
        {
            AddMemberToList(AddNoShowTf, NoShowList);
        }
        private void RemoveNoShowButton_Click(object sender, EventArgs e)
        {
            if (NoShowList.SelectedIndex != -1)
            {
                NoShowList.Items.RemoveAt(NoShowList.SelectedIndex);
                NoShowList.Text = "";
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            GlobalDependencies.eventManagerInstance.currentForm++;
            GlobalDependencies.eventManagerInstance.LoadForm(GlobalDependencies.eventManagerInstance.notes);
        }
        #endregion
        #region Utility Methods

        private void AddMemberToList(TextBox tf, ListBox lb)
        {
            if (tf.Text.Length > 0)
            {
                if (DoesMemberExist(tf.Text.Trim()))
                {
                    foreach (var item in lb.Items)
                    {
                        if (tf.Text.Trim() == item.ToString())
                        {
                            _ = MessageBox.Show("Cannot add the same Member twice!", "Error");
                        }
                    }
                    if (new Member().FindMember(tf.Text.Trim()).Clan.Trim() == GlobalDependencies.loginInstance.loggedInUser.Clan.Trim())
                    {
                        lb.Items.Add(tf.Text);
                        lb.SelectedItem = lb.Items[lb.Items.Count - 1];
                        tf.Text = "";
                    }
                    else
                    {
                        _ = MessageBox.Show("The user is from a different clan. Clan events can only give points to members of the respective clan", "Error");
                    }
                }
                else
                {

                    MessageBox.Show("The member you are trying to add doesn't exist. This is case sensitive, so if you had a" +
                        "wrongly capitalized letter before you filled the suggestion it will not recognize the name!", "Error");
                }
            }
        }

        public bool DoesMemberExist(string tag)
        {
            foreach (Member member in GlobalDependencies.members)
            {
                if (member.DiscordTag.Trim().Equals(tag))
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdateListBoxes(int EventCode)
        {
            AttendeeList.Items.Clear();
            AttendeeList.Text = "";
            AltList.Items.Clear();
            AltList.Text = "";
            NoShowList.Items.Clear();
            NoShowList.Text = "";
            SqlDataReader reader = DBConnector.ExecuteReaderQuery($"SELECT MemberID, AttendanceType FROM Event_Members WHERE EventID = '{EventCode}'");
            try
            {
                while (reader.Read())
                {
                    if (new Member().FindMember(reader["MemberID"].ToString().Trim()) == null)
                    {
                        _ = MessageBox.Show("Member doesn't exist: " + reader["MemberID"].ToString());
                    }
                    else
                    {
                        if (reader["AttendanceType"].ToString().Trim().Equals("Attended"))
                        {
                            AttendeeList.Items.Add(new Member().FindMember(reader["MemberID"].ToString().Trim()).DiscordTag.Trim());
                            AttendeeList.SelectedIndex = 0;
                        }
                        if (reader["AttendanceType"].ToString().Trim().Equals("Alted"))
                        {
                            AltList.Items.Add(new Member().FindMember(reader["MemberID"].ToString().Trim()).DiscordTag.Trim());
                            AltList.SelectedIndex = 0;
                        }
                        if (reader["AttendanceType"].ToString().Trim().Equals("NoShow"))
                        {
                            NoShowList.Items.Add(new Member().FindMember(reader["MemberID"].ToString().Trim()).DiscordTag.Trim());
                            NoShowList.SelectedIndex = 0;
                        }
                    }
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                reader.Close();
                DBConnector.connection.Close();
            }
        }
        #endregion
    }
}
