using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class Member
    {
        public String DiscordTag { get; set; }
        public String Clan { get; set; }
        public int EventsParticipated { get; set; }
        public int EventsAlted { get; set; }
        public int EventsMissed { get; set; }
        public System.Drawing.Color Color { get; set; }
        public int Points { get; set; }
        public object JoinDate { get; set; }
        public object LastCheckDate { get; set; }
        public String FullInfo { get { return $"{ DiscordTag.Trim() } ({ Points }) ({EventsParticipated},{EventsAlted},{EventsMissed})";} }
        public String MyMember { get { return $"{DiscordTag.Trim()}, {Clan.Trim()}, ({EventsParticipated},{EventsAlted},{EventsMissed})"; } }
        public Member()
        {

        }
        public Member(String pDiscordTag, String pClan, int pEventsParticipated, int pEventsAlted, int pEventsMissed, int pPoints)
        {
            DiscordTag = pDiscordTag.Trim();
            Clan = pClan.Trim();
            EventsParticipated = pEventsParticipated;
            EventsAlted = pEventsAlted;
            EventsMissed = pEventsMissed;
            Points = pPoints;
            JoinDate = DateTime.Today;
            LastCheckDate = JoinDate;
        }
        public string GetStandardizedLayoutData()
        {
            string s = "";
            string dtOne = "";
            bool isSplit = false;
            if (DiscordTag.Trim().Length>19)
            {
                isSplit = true;//13
                char[] TagCharArray = DiscordTag.Trim().ToCharArray();
                int len = DiscordTag.Trim().Length;
                string discordTagNumbers="";
                for (int i = 5;i>0;i--)
                {   
                    discordTagNumbers += TagCharArray[len - i];
                }
                string shortenedTag = "";
                for(int i = 0; i < 10; i++) { shortenedTag += TagCharArray[i]; }
                dtOne = $"{shortenedTag}..{discordTagNumbers}";
                for(int i = 0; i < GlobalDependencies.cutOffTags.Length; i++)
                {
                    if (GlobalDependencies.cutOffTags[i]==null)
                    {
                        GlobalDependencies.cutOffTags[i] = DiscordTag.Trim();
                        break;
                    }
                }
            }
            if (GlobalDependencies.settingsFormInstance.DiscordTagCheck.Checked) { if (!isSplit) { s += DiscordTag.Trim().PadRight(20); } else { s += dtOne.PadRight(20); } }
            if (GlobalDependencies.settingsFormInstance.PointsCheck.Checked) { s += Points.ToString().PadRight(7);}
            if (GlobalDependencies.settingsFormInstance.EventPCheck.Checked) { s += EventsParticipated.ToString().PadRight(3); }
            if (GlobalDependencies.settingsFormInstance.EventACheck.Checked) { s += EventsAlted.ToString().PadRight(3); }
            if (GlobalDependencies.settingsFormInstance.EventMCheck.Checked) { s += EventsMissed.ToString().PadRight(3); }
            if (GlobalDependencies.settingsFormInstance.JoinDateCheck.Checked) { s += JoinDate.ToString().PadRight(11); }
            if (GlobalDependencies.settingsFormInstance.LastCheckCheck.Checked) { s += LastCheckDate.ToString().PadRight(11); }
            return s;
        }
        public string GetStandardizedHeaders()
        {
            string s = ""; 
            if (GlobalDependencies.settingsFormInstance.DiscordTagCheck.Checked) {s += "Discord Tag".PadRight(20); }
            if (GlobalDependencies.settingsFormInstance.PointsCheck.Checked) { s += "Points "; }
            if (GlobalDependencies.settingsFormInstance.EventPCheck.Checked) { s += "EP "; }
            if (GlobalDependencies.settingsFormInstance.EventACheck.Checked) { s += "EA "; }
            if (GlobalDependencies.settingsFormInstance.EventMCheck.Checked) { s += "EM "; }
            if (GlobalDependencies.settingsFormInstance.JoinDateCheck.Checked) { s += "Join Date".PadRight(11); }
            if (GlobalDependencies.settingsFormInstance.LastCheckCheck.Checked) { s += "Last Check ".PadRight(11); }
            return s;
        }
    }
}
