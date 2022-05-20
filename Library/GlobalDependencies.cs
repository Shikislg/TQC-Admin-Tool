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
        #region Global Variables
        public static List<Member> membersToBeAdded = new List<Member>();   
        public static List<String> membersToBeDeleted = new List<String>();
        public static List<Member> members = new List<Member>();
        public static AutoCompleteStringCollection memberTags = new AutoCompleteStringCollection();
        public static Color[,] defaultSchemes = new Color[2, 8] { { Color.FromArgb(0, 18, 25), Color.FromArgb(0, 98, 115), Color.FromArgb(238, 155, 0), Color.FromArgb(46, 51, 73), Color.FromArgb(200, 200, 200), Color.Black, Color.White, Color.FromArgb(0, 98, 115) },
        {Color.FromArgb(0, 0, 0),Color.FromArgb(255,255,255),Color.FromArgb(155,155,155),Color.FromArgb(52, 52, 52),Color.FromArgb(255,255,255),Color.FromArgb(255,255,255),Color.FromArgb(255,255,255),Color.FromArgb(25,25,25)} };
        public static Login loginInstance;
        public static Dashboard dashboardInstance;
        public static MemberStatistics mStatsInstance = new MemberStatistics();
        public static LoginForm loginFormInstance = new LoginForm();
        public static EventManager eventManagerInstance = new EventManager();
        public static EditMembers editMembersInstance = new EditMembers();
        public static SettingsForm settingsFormInstance = new SettingsForm();
        public static object currentForm;
        public static string[] cutOffTags = new string[500];
        public static string sortBy;
        public static string pointHandlingMode;
        public static AutoCompleteStringCollection clanTags = new AutoCompleteStringCollection() { "Tenacity", "Aegis", "Ethereal", "Celestial",
        "Majestic","Defiance","Vigilant","Tranquility","Eternal","Immortal","Shadow","Quantum"};
        public static Dictionary<int, string> clans = new Dictionary<int, string>() {
            {3943760, "Tenacity" },
            {3853209, "Aegis" },
            {4129187, "Ethereal" },
            {4278992, "Celestial" },
            {4401600, "Majestic" },
            {3502980, "Defiance" },
            {3888411, "Vigilant" },
            {4157005, "Tranquility" },
            {4278978, "Eternal" },
            {4401617, "Immortal" },
            {4279010, "Shadow" },
            {4402352, "Quantum" },
            {4129175, "Ephemera" }
        };

        public static Dictionary<int, string> memberTypes = new Dictionary<int, string>() {
            { 0, "Error" },
            { 1,"Beginner"},
            { 2,"Member" },
            { 3,"Admin"},
            { 5,"Founder" }
        };

        public static Dictionary<string, Color> roleColors = new Dictionary<string, Color>()
        {
            {"admin",Color.FromArgb(117, 233, 248)},
            {"dev",Color.FromArgb(238, 155, 0)},
            {"founder",Color.FromArgb(80, 194, 247)},
        };
        #endregion

        #region Global Methods
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
                switch (loginInstance.loggedInUser.Role.Trim())
                {
                    case "admin": return 1;
                    case "founder": return 2;
                    case "dev": return 2;
                }
            }
            return 0;
        }
        #endregion
    }
}
