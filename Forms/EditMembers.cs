using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class EditMembers : Form
    {
        private Member memberToBeEdited;
        public EditMembers()
        {
            InitializeComponent();

            discordTagTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
        }
        #region Events
        private void EditMemberButton_Click(object sender, EventArgs e)
        {
            if (GlobalDependencies.AccessLvl() > 0)
            {
                try
                {
                    memberToBeEdited = FindMember();
                    EnableEditing();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("You don't have the permission to perform this command", "Error");
            }
        }

        private void RemoveMemberButton_Click(object sender, EventArgs e)
        {

            if (GlobalDependencies.AccessLvl() > 1)
            {
                RemoveMember();
            }
            else
            {
                MessageBox.Show("You don't have the permission to perform this command", "Error");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Members SET ";
            if (PointsTf.Text.Length > 0)
            {
                try
                {
                    if (AddCheck.Checked)
                    {
                        query += $"Points = '{memberToBeEdited.Points + int.Parse(PointsTf.Text)}' ";
                    }
                    else
                    {
                        query += $"Points = '{int.Parse(PointsTf.Text)}' ";
                    }
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (NotesTf.Text.Length>0)
            {
                if (PointsTf.Text.Length>0)
                {
                    query += $",Notes = '{NotesTf.Text.Replace("'","")}'";
                }
                else
                {
                    query += $"Notes = '{NotesTf.Text.Replace("'", "")}'";
                }
            }
            if(AbsenceCheck.Checked)
            {
                if (NotesTf.Text.Length > 0 || PointsTf.Text.Length > 0)
                {
                    query += $",Abscence = '{dateTimePicker.Value}'";
                }
                else
                {
                    query += $"Abscence = '{dateTimePicker.Value}'";
                }
            }
            if (!query.Equals("UPDATE Members SET "))
            {
                query += $" WHERE DiscordTag = '{memberToBeEdited.DiscordTag,-50}'";
                DBConnector.ExecuteQuery(query);
            }
        }

        #endregion
        #region Utility Methods
        private Member FindMember()
        {
            foreach (Member member in GlobalDependencies.members)
            {
                if (member.DiscordTag.Trim().Equals(discordTagTf.Text.Trim()))
                {
                    return member;
                }
            }
            return null;
        }
        
        private void EnableEditing()
        {
            EditPanel.Visible = true;
            TagLabel.Text = memberToBeEdited.DiscordTag.Trim();
        }
        
        private void RemoveMember()
        {
            //Append a Member to the List of Members to be deleted
            foreach (Member member in new DataAccess().GetAllMembers())
            {
                if (discordTagTf.Text.Trim().Equals(member.DiscordTag.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    GlobalDependencies.membersToBeDeleted.Add(member.DiscordTag.Trim());
                    new ChangedData().SetBoolean(true);
                    return;
                }
            }
            MessageBox.Show("This Discord User Doesn't exist", "Error");
        }
        #endregion
    }
}
