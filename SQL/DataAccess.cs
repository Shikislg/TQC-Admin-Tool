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
        public List<Member> GetMembers(string clanTag)
        {
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
                    ConvertToDate(member);
                }
                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].Points < Properties.Settings.Default.minimumPoints)
                    {
                        output[i].Color = Color.FromArgb(174, 32, 18);
                    }
                    else
                    {
                        output[i].Color = Color.FromArgb(0, 171, 102);
                    }
                }
                 return output;
            }
        }
        public List<Member> GetAllMembers()
        {
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
                    ConvertToDate(member);
                }
                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].Points < Properties.Settings.Default.minimumPoints)
                    {
                        output[i].Color = Color.FromArgb(174, 32, 18);
                    }
                    else
                    {
                        output[i].Color = Color.FromArgb(0, 171, 102);
                    }
                }
                return output;
            }
        }
        private void ConvertToDate(Member member)
        {
            char[] joinDateChars = member.JoinDate.ToString().Trim().ToCharArray();
            char[] lastCheckDateChars = member.LastCheckDate.ToString().Trim().ToCharArray();
            int countUp = 0;
            for (int i = joinDateChars.Length - 1; i >= joinDateChars.Length - 12; i--)
            {
                if (joinDateChars[i] != ' ')
                {
                    joinDateChars[i] = ' ';
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
            countUp = 0;
            for (int i = lastCheckDateChars.Length - 1; i >= joinDateChars.Length - 12; i--)
            {
                if (lastCheckDateChars[i] != ' ')
                {
                    lastCheckDateChars[i] = ' ';
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
            member.JoinDate = new String(joinDateChars).Trim();
            member.LastCheckDate = new String(lastCheckDateChars).Trim();
        }
    }
}
