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
        void CreateUser(String UserName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigData.CnnVal("LoginDB")))
            { 
                String query = $"SELECT * FROM Login WHERE UserName = '{UserName}';";
                List<User> output = connection.Query<User>(query).ToList();
                loggedInUser = output[0];
                Console.WriteLine("Application Role: "+loggedInUser.Role);
            }
        }
    }
}
