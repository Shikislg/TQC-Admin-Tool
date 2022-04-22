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
    public partial class EventManager : Form
    {
        String responseString = "Changes have been presaved. Click the save button in the bottom left corner to apply the changes to the database. Note: You cannot reset your changes after you applied them to the database, so don't do this lightly! ";
        public EventManager()
        {
            InitializeComponent();
        }


        private void EventParticipatedButton_Click(object sender, EventArgs e)
        {
            if (GlobalDependencies.AccessLvl() > 0)
            {
                //Adds an entry of participated Event with the selected Member
                EventParticipated(SelectMember());
            }
        }

        private void EventAltedButton_Click(object sender, EventArgs e)
        {
            EventAlted(SelectMember());
        }

        private void EventMissedButton_Click(object sender, EventArgs e)
        {
            if (GlobalDependencies.AccessLvl() > 0)
            {
                //Adds an entry of missed Event with the selected Member
                EventMissed(SelectMember());
            }
        }
        private void EventParticipated(int selectedMember)
        {
            if (Properties.Settings.Default.pointHandlingMode == 1)
            {
                GlobalDependencies.members[selectedMember].Points += 50;
            }
            GlobalDependencies.members[selectedMember].EventsParticipated += 1;
            responseLabel.Text = responseString; 
            new ChangedData().SetBoolean(true);
        }
        private void EventAlted(int selectedMember)
        {
            if (Properties.Settings.Default.pointHandlingMode == 1)
            {
                GlobalDependencies.members[selectedMember].Points += 50;
            }
            GlobalDependencies.members[selectedMember].EventsAlted += 1;
            responseLabel.Text = responseString;
            new ChangedData().SetBoolean(true);
        }

        private void EventMissed(int selectedMember)
        {
            GlobalDependencies.members[selectedMember].EventsMissed += 1;
            responseLabel.Text = responseString;
            new ChangedData().SetBoolean(true);
        }
        private int SelectMember()
        {
            int selectedMember = 0;
            DataAccess db = new DataAccess();
            GlobalDependencies.members = db.GetAllMembers();
            for (int i = 0; i < GlobalDependencies.members.Count; i++)
            {
                if (GlobalDependencies.members[i].DiscordTag.Contains(ENameInput.Text))
                {
                    {
                        selectedMember = i;
                        break;
                    }
                }
            }
            return selectedMember;
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can save event participations, enter the UserName of the players that joined/missed the event" +
                " and click save to update the database and automatically apply points.","Hint");
        }
    }
}
