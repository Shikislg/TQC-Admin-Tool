using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class ReadMemberJson
    {
        public Response response { get; set; }
    }
    public class Response
    {
        public results[] results { get; set; }
    }
    public class results
    {
        public bungieNetUserInfo bungieNetUserInfo { get; set; }
        public destinyUserInfo destinyUserInfo { get; set; }
        public string joinDate { get; set; }
        public int memberType { get; set; }
    }
    public  class bungieNetUserInfo
    {
        public string supplementalDisplayName { get; set; }
        public string iconPath { get; set; }
    }
    public class destinyUserInfo
    {
        public string bungieGlobalDisplayName { get; set; }
        public int bungieGlobalDisplayNameCode { get; set; }
    }

}
