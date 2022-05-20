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
    public partial class EventManager : Form
    {
        public readonly AutoCompleteStringCollection eventTypes = new AutoCompleteStringCollection();
        public List<Event> events = new List<Event>();
        public Event currentEditedEvent;
        public e_TimeType timeType = new e_TimeType();
        public readonly e_Participants participants = new e_Participants();
        public readonly e_Notes notes = new e_Notes();
        public int currentForm = 0;
        public EventManager()
        {
            InitializeComponent();

            PopulateEventTypes();

            SearchTf.AutoCompleteCustomSource = eventTypes;

            LoadForm(timeType);
        }
        #region Events
        
        public void CreateEventButton_Click(object sender, EventArgs e)
        {
            if (notes.CreateEventButton.Text == "Save Changes")
            {
                DeleteEvent(currentEditedEvent);
                CreateEvent();
                notes.CreateEventButton.Text = "Create Event";
                PopulateEventTypes();
                return;
            }
            CreateEvent();

            PopulateEventTypes();
        }        
        private void DeleteEventButton_Click(object sender, EventArgs e)
        {
            if (EventListBox.SelectedIndex != -1)
            {
                Event selectedEvent = SelectEvent();
                DeleteEvent(selectedEvent);
            }
            else
            {
                MessageBox.Show("No Event selected", "Error");
            }
        }
        private void EditEventButton_Click(object sender, EventArgs e)
        {
            if (EventListBox.SelectedIndex != -1)
            {
                EditEvent();
            }
            else
            {
                MessageBox.Show("No Event selected", "Error");
            }
        }

        private void EventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventListBox.SelectedIndex == 0)
            {
                EventListBox.ClearSelected();
            }
        }
        
        private void QuestionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can create and manage events","Hint");
        }

        private void SearchEventButton_Click(object sender, EventArgs e)
        {
            SearchEvent();
        }

        #endregion
        #region Utility Methods

        private void DeleteEvent(Event @event)
        {
            DBConnector.ExecuteQuery($"DELETE FROM Events WHERE EventCode = '{@event.EventCode}'");
            DBConnector.ExecuteQuery($"DELETE FROM Event_Members WHERE EventID = '{@event.EventCode}'");
        }
        private void CreateEvent()
        {
            int id = 0;
            while (DoesIdExist(id))
            {
                id++;
            }
            string host = "";
            if (participants.DoesMemberExist(participants.HostTf.Text))
            {
                if (new Member().FindMemberSpotInList(participants.HostTf.Text) != -1)
                {
                    if (new Member().FindMember(participants.HostTf.Text).MemberLevel > 2)
                    {
                        host = new Member().FindMember(participants.HostTf.Text).DiscordTag.Trim();
                    }
                    else
                    {
                        MessageBox.Show("This member is not entitled to create clan events", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("This member doesn't exist", "Error");
                }
            }
            if (host.Equals(""))
            {
                foreach (Member member in GlobalDependencies.members)
                {
                    if (GlobalDependencies.loginInstance == null)
                    {
                        MessageBox.Show("Your account does not have the permission to create events", "Error");
                        return;
                    }
                    if (member.DiscordTag.Trim().Contains(GlobalDependencies.loginInstance.loggedInUser.UserName.Trim()) && member.MemberLevel > 2)
                    {
                        host = member.DiscordTag.Trim();
                    }
                }
            }
            if (host.Equals(""))
            {
                MessageBox.Show("Your account does not have the permission to create events", "Error");
                return;
            }
            DBConnector.ExecuteQuery($"INSERT INTO Events (EventCode, DateAndTime, Host, EventType, Notes, Clan) VALUES ('{id}','{timeType.dateTimePicker.Value}','{host}','{timeType.EventTypeTf.Text}','{notes.NotesTf.Text}', '{new Member().FindMember(host).Clan.Trim(),-20}')");
            if (participants.AttendeeList.Items.Count > 0)
            {
                foreach (var item in participants.AttendeeList.Items)
                {
                    DBConnector.ExecuteQuery($"INSERT INTO Event_Members (EventID, MemberID, AttendanceType) VALUES ('{id}','{item}','Attended')");
                }
            }
            if (participants.AltList.Items.Count > 0)
            {
                foreach (var item in participants.AltList.Items)
                {
                    DBConnector.ExecuteQuery($"INSERT INTO Event_Members (EventID, MemberID, AttendanceType) VALUES ('{id}','{item}','Alted')");
                }
            }
            if (participants.NoShowList.Items.Count > 0)
            {
                foreach (var item in participants.NoShowList.Items)
                {
                    DBConnector.ExecuteQuery($"INSERT INTO Event_Members (EventID, MemberID, AttendanceType) VALUES ('{id}','{item}','NoShow')");
                }
            }
        }

        private bool DoesIdExist(int ID)
        {
            SqlDataReader reader = DBConnector.ExecuteReaderQuery($"SELECT EventCode FROM Events");
            try
            {

                while (reader.Read())
                {
                    if ((int)reader["EventCode"] == ID)
                    {
                        reader.Close();
                        return true;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ID", "Error");
            }
            finally
            {
                reader.Close();
                DBConnector.connection.Close();
            }
            return false;
        }
        
        private void EditEvent()
        {
            Event selectedEvent = SelectEvent();
            timeType.dateTimePicker.Value = (DateTime)selectedEvent.DateAndTime;
            participants.HostTf.Text = selectedEvent.Host;
            timeType.EventTypeTf.Text = selectedEvent.EventType;
            notes.NotesTf.Text = selectedEvent.Notes;
            participants.UpdateListBoxes(selectedEvent.EventCode);
            notes.CreateEventButton.Text = "Save Changes";
            currentEditedEvent = selectedEvent;
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

        private void PopulateEventTypes()
        {
            events.Clear();
            SqlDataReader reader = DBConnector.ExecuteReaderQuery($"SELECT EventType FROM Events");
            try
            {
                while (reader.Read())
                {
                    eventTypes.Add(reader["EventType"].ToString().Trim());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                DBConnector.connection.Close();
            }
        }
        
        private Event SelectEvent()
        {
            Event selectedEvent = null;
            string code = "";
            char[] itemChars = EventListBox.SelectedItem.ToString().ToCharArray();
            int i = 0;
            while (Char.IsDigit(itemChars[i]))
            {
                code += itemChars[i];
                i++;
            }
            foreach (Event @event in events)
            {
                if (@event.EventCode == int.Parse(code))
                {
                    selectedEvent = @event;
                }
            }
            return selectedEvent;
        }

        private void SearchEvent()
        {
            bool showingAllEvents = false;
            EventListBox.Items.Clear();
            string query = $"SELECT * FROM Events";
            EventListBox.Size = new Size(501, EventListBox.Size.Height);
            EditEventButton.Location = new Point(510, 400);
            DeleteEventButton.Location = new Point(510, 448);
            if (SearchTf.Text.Trim().Length==0)
            {
                showingAllEvents = true;
                EventListBox.Size = new Size(651, EventListBox.Size.Height);
                EditEventButton.Location = new Point(371, 355);
                DeleteEventButton.Location = new Point(494, 355);
            }
            else
            {
                query += $" WHERE EventType = '{SearchTf.Text}'";
            }
            SqlDataReader reader = DBConnector.ExecuteReaderQuery(query);
            try
            {
                EventListBox.Items.Add(new Event().GetHeaderString(showingAllEvents));
                while (reader.Read())
                {
                    Event clanEvent = new Event((int)reader["EventCode"], reader["DateAndTime"], reader["Host"].ToString(), reader["EventType"].ToString(), reader["Notes"].ToString(), reader["Clan"].ToString());
                    events.Add(clanEvent);
                    EventListBox.Items.Add(clanEvent.PrepareString(showingAllEvents));
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
