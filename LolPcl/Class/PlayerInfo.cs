using LolPcl.Class.enums;
using LolPcl.Class.Json;
using LolPcl.Class.WebClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolPcl.Class
{
    internal class PlayerInfo
    {
        public static async Task<RootPlayerInfo> GetPlayerInfoAsync(string nick, string region)
        {
            var url = (region + Links.PlayerLink + nick + Player.ApiKey);
            var jsonStr = await new Web().UrlAsync(url);
            return DesJson.GetObjPlayerInf(jsonStr);
        }
    }
}
