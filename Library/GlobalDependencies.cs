using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public static class GlobalDependencies
    {
        public static List<Member> membersToBeAdded = new List<Member>();
        public static List<String> membersToBeDeleted = new List<String>();
        public static List<Member> members = new List<Member>();
        public static Color[,] defaultSchemes = new Color[2, 8] { { Color.FromArgb(0, 18, 25), Color.FromArgb(0, 98, 115), Color.FromArgb(238, 155, 0), Color.FromArgb(46, 51, 73), Color.FromArgb(200, 200, 200), Color.Black, Color.White, Color.FromArgb(0, 98, 115) },
        {Color.FromArgb(0, 0, 0),Color.FromArgb(255,255,255),Color.FromArgb(155,155,155),Color.FromArgb(52, 52, 52),Color.FromArgb(255,255,255),Color.FromArgb(255,255,255),Color.FromArgb(255,255,255),Color.FromArgb(25,25,25)} };
        public static Login loginInstance;
        public static Dashboard dashboardInstance;
        public static MemberStatistics mStatsInstance = new MemberStatistics();
        public static LoginForm loginFormInstance = new LoginForm();
        public static EventManager eventManagerInstance = new EventManager();
        public static AddMembers addMembersInstance = new AddMembers();
        public static SettingsForm settingsFormInstance = new SettingsForm();
        public static object currentForm;
        public static string[] cutOffTags = new string[20];
        public static string[] validClans = { "Tenacity", "Aegis", "Ethereal", "Celestial", "Majestic", "Defiance", "Vigilant", "Tranquility", "Eternal", "Immortal", "Shadow", "Quantum", "Ephemera" };
        public static string sortBy;
        public static string pointHandlingMode;
        public static Dictionary<int, string> clans = new Dictionary<int, string>();
        public static int AccessLvl()
        {
            if (loginInstance == null)
            {
                return 0;
            }
            else if (loginInstance.loggedInUser == null)
            {
                return 0;
            }
            else
            {
                switch (loginInstance.loggedInUser.Role.Replace(" ", ""))
                {
                    case "admin": return 1;
                    case "founder": return 2;
                    case "dev": return 2;
                }
            }
            return 0;
        }
    }
}
