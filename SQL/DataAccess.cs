using System;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Dashboard
{
    public class DataAccess
    {
        public void ConvertToDate(Member member)
        {
            char[] joinDateChars = null;
            char[] lastCheckDateChars = null;
            char[] absenceChars = null;
            try
            {
                if (member.JoinDate != null)
                {
                    joinDateChars = member.JoinDate.ToString().Trim().ToCharArray();
                }
                if (member.LastCheckDate != null)
                {
                    lastCheckDateChars = member.LastCheckDate.ToString().Trim().ToCharArray();
                }
                if (member.Absence != null)
                {
                    absenceChars = member.Absence.ToString().Trim().ToCharArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            if (member.JoinDate != null)
            {
                member.JoinDate = CutCharArray(joinDateChars);
            }
            if (member.LastCheckDate != null)
            {
                member.LastCheckDate = CutCharArray(lastCheckDateChars);
            }
            if (member.Absence != null)
            {
                member.Absence = CutCharArray(absenceChars);
            }
        }
        private string CutCharArray(char[] seq)
        {
            int countUp = 0;
            for (int i = seq.Length - 1; i >= seq.Length - 12; i--)
            {
                if (seq[i] != ' ')
                {
                    seq[i] = ' ';
                }
                else
                {
                    countUp++;
                    if (countUp == 2)
                    {
                        break;
                    }
                }
            }
            return new String(seq).Trim();
        }

        public List<Member> GetMembersByClanTag(string clanTag)
        {
            DBConnector.EventPointHandler();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigData.CnnVal("MembersDB")))
            {
                List<Member> output;
                if (GlobalDependencies.sortBy!=null)
                {
                    output = connection.Query<Member>($"SELECT * FROM Members WHERE Clan ='{ clanTag }' {GlobalDependencies.sortBy}").ToList();
                }
                else
                {
                    output = connection.Query<Member>($"SELECT * FROM Members WHERE Clan ='{ clanTag }'").ToList();
                }
                foreach (Member member in output)
                {
                    member.CorrectDiscordTag(member.DiscordTag, true);
                    ConvertToDate(member);
                }
                DBConnector.EventPointHandler();
                return output;
            }
        }
        public List<Member> GetMembersByName(string name)
        {
            DBConnector.EventPointHandler();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigData.CnnVal("MembersDB")))
            {
                List<Member> output;
                if (GlobalDependencies.sortBy != null)
                {
                    output = connection.Query<Member>($"SELECT * FROM Members WHERE DiscordTag ='{ name }' {GlobalDependencies.sortBy}").ToList();
                }
                else
                {
                    output = connection.Query<Member>($"SELECT * FROM Members WHERE DiscordTag ='{ name }'").ToList();
                }
                foreach (Member member in output)
                {
                    member.CorrectDiscordTag(member.DiscordTag, true);
                    ConvertToDate(member);
                }
                DBConnector.EventPointHandler();
                return output;
            }
        }
        public List<Member> GetAllMembers()
        {
            DBConnector.EventPointHandler();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigData.CnnVal("MembersDB")))
            {
                List<Member> output;
                if (GlobalDependencies.sortBy != null)
                {
                    output = connection.Query<Member>($"SELECT * FROM Members {GlobalDependencies.sortBy}").ToList();
                }
                else
                {
                    output = connection.Query<Member>($"SELECT * FROM Members").ToList();
                }
                foreach (Member member in output)
                {
                    member.CorrectDiscordTag(member.DiscordTag, true);
                    ConvertToDate(member);
                }
                DBConnector.EventPointHandler();
                return output;
            }
        } 
    }
}
