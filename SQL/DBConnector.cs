using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dashboard
{
    public static class DBConnector
    {
        public static SqlConnection connection = new SqlConnection(ConfigData.CnnVal("MembersDB"));
        public static SqlDataReader ExecuteReaderQuery(string query)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteReader();
        }
        public static void ExecuteQuery(string query)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static bool DoesColumnExist(string query)
        {
            SqlDataReader reader = ExecuteReaderQuery(query);
            if (reader.HasRows)
            {
                reader.Close();
                connection.Close();
                return true;
            }
            else
            {
                reader.Close();
                connection.Close();
                return false;
            }

        }
        public static void SaveChanges(Member member)
        {
            ExecuteQuery($"UPDATE Members SET Points = '{member.Points}',EventsParticipated = '{member.EventsParticipated}',EventsAlted = '{member.EventsAlted}',EventsMissed = '{member.EventsMissed}' WHERE DiscordTag = '{member.DiscordTag}'");
        }
        public static void ResetChanges()
        {
            GlobalDependencies.members = new DataAccess().GetAllMembers();
            GlobalDependencies.membersToBeAdded.Clear();
        }
        public static void EventPointHandler()
        {
            ExecuteQuery("update Members set Points = '0', EventPoints = '0', EventsParticipated = '0', EventsAlted = '0', EventsMissed = '0'");
            foreach (Member member in GlobalDependencies.members)
            {
                member.EventsParticipated = 0;
                member.EventsAlted = 0;
                member.EventsMissed = 0;
                member.EventPoints = 0;
            }
            string[,] memberDict = new string[2,2000];
            SqlDataReader reader = ExecuteReaderQuery("select MemberID, AttendanceType from Event_Members");
            try
            {
                int i = 0;
                while (reader.Read())
                {
                    memberDict[0, i] = reader["MemberID"].ToString().Trim();
                    memberDict[1, i] = reader["AttendanceType"].ToString().Trim();
                    i++;
                }
            }
            catch (Exception ex)
            {
                reader.Close();
                Console.WriteLine(ex.Message);
            }
            reader.Close();
            connection.Close();
            for (int i =0; i<memberDict.Length/2;i++)
            {
                Console.WriteLine(memberDict[0,i]);
                if (memberDict[0,i]==null)
                {
                    break;
                }
                if (new Member().FindMember(memberDict[0,i])==null)
                {
                    continue;
                }
                switch (memberDict[1,i])
                {
                    case "Attended":ExecuteQuery($"update Members set EventsParticipated = '{new Member().FindMember(memberDict[0, i]).EventsParticipated +1}' where DiscordTag like '{memberDict[0, i]}%'"); new Member().FindMember(memberDict[0, i]).EventsParticipated++; break;
                    case "Alted": ExecuteQuery($"update Members set EventsAlted = '{new Member().FindMember(memberDict[0, i]).EventsAlted + 1}' where DiscordTag like '{memberDict[0, i]}%'"); new Member().FindMember(memberDict[0, i]).EventsAlted++; break;
                    case "NoShow": ExecuteQuery($"update Members set EventsMissed = '{new Member().FindMember(memberDict[0, i]).EventsMissed + 1}' where DiscordTag like '{memberDict[0, i]}%'"); new Member().FindMember(memberDict[0, i]).EventsMissed ++; break;
                }
                if (Properties.Settings.Default.pointHandlingMode == 1 && memberDict[1, i] != "NoShow")
                {
                    ExecuteQuery($"update Members set EventPoints = '{new Member().FindMember(memberDict[0, i]).EventPoints+ 50}' where DiscordTag like '{memberDict[0, i]}%'");
                    new Member().FindMember(memberDict[0, i]).EventPoints+=50;
                }
            }
        }
    }
}
