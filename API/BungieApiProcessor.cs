using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Dashboard
{
    public class BungieApiProcessor
    {
        public async Task<ReadMemberJson> LoadClanMembers(string clanId)
        {
            string url = $"https://www.bungie.net/Platform/GroupV2/{clanId}/Members/";
            using (HttpResponseMessage response = await APIInit.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonText = await response.Content.ReadAsStringAsync();
                    ReadMemberJson output = JsonConvert.DeserializeObject<ReadMemberJson>(jsonText);
                    return output;
                }
                return null;
            }
        }
    }
}
