using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class Event
    {
        #region Model 
        public int EventCode { get; set; }
        public object DateAndTime { get; set; }
        public string Host { get; set; }
        public string EventType { get; set; }
        public string Notes { get; set; }
        public string Clan { get; set; }
        #endregion
        #region Constructors
        public Event()
        {

        }
        public Event(int EventCode, object DateAndTime, string Host, string EventType, string Notes, string Clan)
        {
            this.EventCode = EventCode;
            this.DateAndTime = DateAndTime;
            this.Host = Host;
            this.EventType = EventType;
            this.Notes = Notes;
            this.Clan = Clan;
        }
        #endregion
        #region Utility Methods
        public string GetHeaderString(bool showingAllEvents)
        {
            if (!showingAllEvents)
            {
                return $"EventCode DateAndTime  {"Host",-20}{"Clan",-15}";
            }
            else
            {
                return $"EventCode DateAndTime  {"Host",-20}{"Clan",-12}{"Name",-20}";
            }
        }

        public string PrepareString(bool showingAllEvents)
        {
            string output = "";

            output += EventCode.ToString().Trim().PadRight(10);
            Member mem = new Member("", "", 0, 0, 0, 0)
            {
                JoinDate = DateAndTime,
                LastCheckDate = DateAndTime
            };
            new DataAccess().ConvertToDate(mem);
            output += mem.JoinDate.ToString().PadRight(13);
            if (Host.Trim().Length > 19)
            {
                output += new Member().SplitTag(Host.Trim()).PadRight(20);
            }
            else
            {
                output += Host.Trim().PadRight(20);
            }
            output += Clan.Trim().PadRight(12);
            if (showingAllEvents)
            {
                output += EventType.Trim();
            }
            return output;
        }
        #endregion  
    }
}
