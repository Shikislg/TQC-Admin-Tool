using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Dashboard
{
    class UpdateData
    {
        private readonly List<Member> Members = new DataAccess().GetAllMembers();
        public void SaveChanges(Member member)
        {
                SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));
                String query = $"UPDATE Members SET Points = '{member.Points}',EventsParticipated = '{member.EventsParticipated}',EventsAlted = '{member.EventsAlted}',EventsMissed = '{member.EventsMissed}' WHERE DiscordTag = '{member.DiscordTag}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
        }
        public void ResetChanges(Dashboard db)
        {
            GlobalDependencies.members = new DataAccess().GetAllMembers();
            GlobalDependencies.membersToBeAdded.Clear();
        }
        public Boolean DidValuesChange(List<Member> memberCheck)
        {
            if (memberCheck.Count > 0)
            {
                Console.WriteLine(memberCheck[0].Points + " " + Members[0].Points + "\r\n");
                for (int i = 0; i < Members.Count; i++)
                {
                    if (Members[i].Points != memberCheck[i].Points || Members[i].EventsParticipated != memberCheck[i].EventsParticipated || Members[i].EventsAlted != memberCheck[i].EventsAlted || Members[i].EventsMissed != memberCheck[i].EventsMissed)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void InsertData(String Column, String Value)
        {
            String query = $"INSERT INTO Members ({Column},[EventsParticipated],[EventsAlted],[EventsMissed]) VALUES ('{Value}','0','0','0');";
            ExecuteQuery(query);
        }
        public void InsertData(String Column, String Value, int EP, int EA, int EM)
        {
            String query = $"INSERT INTO Members ({Column},EventsParticipated,EventsAlted,EventsMissed) VALUES ('{Value}','{EP}','{EA}','{EM}');";
            ExecuteQuery(query);
        }
        public void InsertData(String ColumnOne, String ColumnTwo, String ValueOne, String ValueTwo, int EP, int EA, int EM)
        {
            String query = $"INSERT INTO Members ({ColumnOne}, {ColumnTwo},EventsParticipated,EventsAlted,EventsMissed) VALUES ('{ValueOne}','{ValueTwo}','{EP}','{EA}','{EM}');";
            ExecuteQuery(query);
        }
        public void DeleteData(String Condition)
        {
            String query = $"DELETE FROM Members WHERE {Condition};";
            ExecuteQuery(query);
        }
        private void ExecuteQuery(string query)
        {
            Console.WriteLine(query + " | is being executed");
            SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}

