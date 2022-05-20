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
    public partial class AdminProfile : Form
    {
        public AdminProfile(Member adminMember)
        {
            InitializeComponent();

            ListAdminEvents(adminMember);
        }


        #region Utility Methods
        private void ListAdminEvents(Member member)
        {
            SqlDataReader reader = DBConnector.ExecuteReaderQuery($"Select * from Events Where Host LIKE '{member.DiscordTag.Trim()}%'");
            try
            {
                EventListBox.Items.Clear();
                EventListBox.Items.Add(new Event().GetHeaderString(true));
                EventListBox.Items.Add("");
                while (reader.Read())
                {
                    EventListBox.Items.Add(new Event((int)reader["EventCode"],reader["DateAndTime"],reader["Host"].ToString(),reader["EventType"].ToString(), reader["Notes"].ToString(),reader["Clan"].ToString()).PrepareString(true));
                }
            }catch (Exception ex)
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
