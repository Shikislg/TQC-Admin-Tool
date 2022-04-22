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
    public partial class AddMembers : Form
    {
        public AddMembers()
        {
            InitializeComponent();

        }

        private void AddMember()
        {
            //Append a new Member to the List of members that would be added, should the changes be saved
            if (discordTagTf.Text.Length>0)
            {
                if (clanTf.Text.Length > 0)
                {
                    if (GlobalDependencies.validClans.Contains(clanTf.Text))
                    {
                        if (eventPTf.Text.Length > 0 && eventATf.Text.Length > 0 && eventMTf.Text.Length > 0)
                        {
                            GlobalDependencies.membersToBeAdded.Add(new Member(discordTagTf.Text, clanTf.Text, int.Parse(eventPTf.Text), int.Parse(eventATf.Text), int.Parse(eventMTf.Text), 0));
                            new ChangedData().SetBoolean(true);
                        }
                        else
                        {
                            GlobalDependencies.membersToBeAdded.Add(new Member(discordTagTf.Text, clanTf.Text, 0, 0, 0, 0));
                            new ChangedData().SetBoolean(true);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"{clanTf.Text} is not a valid Clan name. Try entering the clan name again", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("You need to enter a clan name", "Error");
                }
            }
            else
            {
                MessageBox.Show("You need to enter at least a discord tag to add a member to the clan","Error");
            }
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

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            if (GlobalDependencies.AccessLvl() > 0)
            {
                try
                {
                    AddMember();
                    DisplayToBeAdded();
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
                DisplayToBeAdded();
            }
            else
            {
                MessageBox.Show("You don't have the permission to perform this command", "Error");
            }
        }

        private void DisplayToBeAdded()
        {
            string s = "";
            int i = 0;
            while (GlobalDependencies.membersToBeAdded.Count > i || GlobalDependencies.membersToBeDeleted.Count > i)
            {
                s += "\r\n";
                if (GlobalDependencies.membersToBeAdded.Count > i)
                {
                    s += GlobalDependencies.membersToBeAdded.ElementAt(i).DiscordTag.PadRight(30);
                }
                else
                {
                    s += "".PadRight(30);
                }
                if (GlobalDependencies.membersToBeDeleted.Count > i)
                {
                    s += GlobalDependencies.membersToBeDeleted.ElementAt(i).PadRight(30);
                }
                i++;
            }
            ToBeAddedLabel.Text = s;
        }
    }
}
