using System;

namespace Dashboard
{
    public class Member
    {
        #region Model
        public String DiscordTag { get; set; }
        public String Clan { get; set; }
        public int EventsParticipated { get; set; }
        public int EventsAlted { get; set; }
        public int EventsMissed { get; set; }
        public System.Drawing.Color Color { get; set; }
        public int Points { get; set; }
        public int MemberLevel { get; set; }
        public object JoinDate { get; set; }
        public object LastCheckDate { get; set; }
        public string Notes { get; set; }
        public object Absence { get; set; }
        public int EventPoints { get; set; }
        public String FullInfo { get { return $"{ DiscordTag.Trim() } ({ Points }) ({EventsParticipated},{EventsAlted},{EventsMissed})";} }
        public String MyMember { get { return $"{DiscordTag.Trim()}, {Clan.Trim()}, ({EventsParticipated},{EventsAlted},{EventsMissed})"; } }
        #endregion

        #region Constructors
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
        #endregion

        public string CorrectDiscordTag(string tag, bool updateDatabase)
        {
            if (tag.Trim().Length<5)
            {
                return null;
            }
            char[] tagChars = tag.Trim().ToCharArray();
            if(tagChars[tagChars.Length - 4] == '#')//One of these annoying broken bungie tags
            {
                string oldDiscordTag = tag.Trim();
                char[] tagNumbers = new char[5];
                tagNumbers[0] = '#';
                tagNumbers[1] = '0';
                for (int i = 2; i < 5; i++)
                {
                    tagNumbers[i] = tagChars[tagChars.Length - (3 - i + 2)];
                }
                Array.Resize<char>(ref tagChars, tagChars.Length - 4);
                tag = "";
                foreach (char c in tagChars)
                {
                    tag += c;
                }
                foreach (char c in tagNumbers)
                {
                    tag += c;
                }
                if (updateDatabase)
                {
                    DBConnector.ExecuteQuery($"UPDATE Members SET DiscordTag = '{tag}' WHERE DiscordTag = '{oldDiscordTag}'");
                }
                return tag;
            }
            return null;
        }

        public int FindMemberSpotInList(string val)
        {
            int i = 0;
            foreach (Member member in GlobalDependencies.members)
            {
                if (val == member.DiscordTag.Trim())
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public Member FindMember(string val)
        {
            foreach(Member member in GlobalDependencies.members)
            {
                if(val == member.DiscordTag.Trim())
                {
                    return member;
                }
            }
            return null;
        }
        public Member FindMemberWithIncompleteTag(string val)
        {
            foreach (Member member in GlobalDependencies.members)
            {
                if (member.DiscordTag.Trim().Contains(val))
                {
                    return member;
                }
            }
            return null;
        }
        #region Displaying
        public string GetStandardizedLayoutData()
        {
            string s = "";
            string dtOne = "";
            bool isSplit = false;
            //Thanks luna >.> 
            if (DiscordTag.Trim().Length>19)
            {
                isSplit = true;//13
                dtOne = SplitTag(DiscordTag);
            }
            if (GlobalDependencies.settingsFormInstance.sLayout.DiscordTagCheck.Checked) { if (!isSplit) { s += DiscordTag.Trim().PadRight(20); } else { s += dtOne.PadRight(20); } }
            if (GlobalDependencies.settingsFormInstance.sLayout.PointsCheck.Checked) { s += (Points+EventPoints).ToString().PadRight(11);}
            if (GlobalDependencies.settingsFormInstance.sLayout.MemberLevelCheck.Checked) { s += GlobalDependencies.memberTypes[MemberLevel].ToString().PadRight(13); }
            if (GlobalDependencies.settingsFormInstance.sLayout.EventPCheck.Checked) { s += EventsParticipated.ToString().PadRight(3); }
            if (GlobalDependencies.settingsFormInstance.sLayout.EventACheck.Checked) { s += EventsAlted.ToString().PadRight(3); }
            if (GlobalDependencies.settingsFormInstance.sLayout.EventMCheck.Checked) { s += EventsMissed.ToString().PadRight(3); }
            if (GlobalDependencies.settingsFormInstance.sLayout.JoinDateCheck.Checked && JoinDate!=null) { s += JoinDate.ToString().PadRight(11); }
            if (GlobalDependencies.settingsFormInstance.sLayout.LastCheckCheck.Checked && LastCheckDate!=null) { s += LastCheckDate.ToString().PadRight(11); }
            if (GlobalDependencies.settingsFormInstance.sLayout.AbsenceCheck.Checked && Absence!=null) { s += Absence.ToString().PadRight(11); }
            return s;
        }
        public string SplitTag(string item)
        {
            char[] TagCharArray = item.Trim().ToCharArray();
            int len = item.Trim().Length;
            string discordTagNumbers = "";
            for (int i = 5; i > 0; i--)
            {
                discordTagNumbers += TagCharArray[len - i];
            }
            string shortenedTag = "";
            for (int i = 0; i < 10; i++) { shortenedTag += TagCharArray[i]; }
            for (int i = 0; i < GlobalDependencies.cutOffTags.Length; i++)
            {
                if (GlobalDependencies.cutOffTags[i] == null)
                {
                    GlobalDependencies.cutOffTags[i] = item.Trim();
                    break;
                }
            }
            return $"{shortenedTag}..{discordTagNumbers}";
        }
        public string GetStandardizedHeaders()
        {
            string s = ""; 
            if (GlobalDependencies.settingsFormInstance.sLayout.DiscordTagCheck.Checked) {s += "Discord Tag".PadRight(20); }
            if (GlobalDependencies.settingsFormInstance.sLayout.PointsCheck.Checked) { s += "Experience "; }
            if (GlobalDependencies.settingsFormInstance.sLayout.MemberLevelCheck.Checked) { s += "Member Level "; }
            if (GlobalDependencies.settingsFormInstance.sLayout.EventPCheck.Checked) { s += "EP "; }
            if (GlobalDependencies.settingsFormInstance.sLayout.EventACheck.Checked) { s += "EA "; }
            if (GlobalDependencies.settingsFormInstance.sLayout.EventMCheck.Checked) { s += "EM "; }
            if (GlobalDependencies.settingsFormInstance.sLayout.JoinDateCheck.Checked) { s += "Join Date".PadRight(11); }
            if (GlobalDependencies.settingsFormInstance.sLayout.LastCheckCheck.Checked) { s += "Last Check ".PadRight(11); }
            return s;
        }
        #endregion
    }
}
