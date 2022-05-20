using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Dashboard
{
    public class Login
    {
        public User loggedInUser;

        #region Constructors
        public Login(String User, String Password)
        {
            GlobalDependencies.loginInstance = this;
            SqlConnection connection = new SqlConnection(ConfigData.CnnVal("LoginDB"));
            String query = $"SELECT Password FROM Login WHERE UserName = '{User}';";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open(); 
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                byte[] bytes = (byte[])reader["Password"];
                String checkPw = BitConverter.ToString(bytes).Replace("-", String.Empty);
                Console.WriteLine(checkPw + " vs " + Password);
                if (checkPw.Equals(Password))
                {
                    CreateUser(User);
                    Console.WriteLine("Successfully logged in");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("User doesn't exist");
            }
            reader.Close();
        }
        public Login(String User)
        {
            GlobalDependencies.loginInstance = this;
            try
            {
                CreateUser(User);
            }
            catch (Exception)
            {
                Console.WriteLine("i get it");
            }
        }
        #endregion
        #region Utility Methods
        async void CreateUser(String UserName)
        {
            using (IDbConnection connection = new SqlConnection(ConfigData.CnnVal("LoginDB")))
            { 
                String query = $"SELECT * FROM Login WHERE UserName = '{UserName}';";
                List<User> output = connection.Query<User>(query).ToList();
                loggedInUser = output[0];
                loggedInUser.UserName = loggedInUser.UserName.Trim();
                if (loggedInUser.Clan!=null)
                {
                    loggedInUser.Clan = loggedInUser.Clan.Trim();
                }
                loggedInUser.Role = loggedInUser.Role.Trim();
                GlobalDependencies.dashboardInstance.UserNameLabel.ForeColor = GlobalDependencies.roleColors[output[0].Role];
            }
            //Set Profile picture
            APIInit.InitializeClient();
            int clanId = 0;
            foreach (int key in GlobalDependencies.clans.Keys)
            {
                if (GlobalDependencies.clans[key].Trim().Equals(loggedInUser.Clan.Trim()))
                {
                    clanId = key;
                    break;
                }
            }
            ReadMemberJson rmj = await new BungieApiProcessor().LoadClanMembers(clanId.ToString());
            int index = 0;
            int resIndex = 0;
            foreach (results res in rmj.response.results)
            {
                if (res.bungieNetUserInfo.supplementalDisplayName.Replace("'","").Contains(loggedInUser.UserName))
                {
                    resIndex = index;
                }
                index++;
            }
            Console.WriteLine(rmj.response.results[resIndex].bungieNetUserInfo.iconPath);
            GlobalDependencies.dashboardInstance.ApplyImage("https://bungie.net"+rmj.response.results[resIndex].bungieNetUserInfo.iconPath);
        }
        #endregion
    }
}
