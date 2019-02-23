using LolPcl.Class.enums;
using LolPcl.Class.Json;
using LolPcl.Class.WebClient;
using LolPcl.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolPcl.Class
{
    internal class GamesInfo
    {
        public static async Task<RootGameInfo> HowManyGamesPlayedAsync(string accID, string region)
        {
            string url = (region + Links.MathLink + accID + Player.ApiKey);
            var Json = await new Web().UrlAsync(url);
            return DesJson.GetObjMathInf(Json);
        }
    }
}
