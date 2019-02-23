using LolPcl.Class.Json;
using LolPcl.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolPcl.Class
{
    public class Player : IPlayer
    {
        public static string ApiKey { get; private set; }

        public Player(string apiKey)
        {
            ApiKey = $"?api_key={apiKey}";
        }

        public async Task<RootGameInfo> GetMarhInfoAsync(string accID, string region) => 
                                await GamesInfo.HowManyGamesPlayedAsync(accID, region);

        public string GetProfileImg(string nick) => Links.ImgLink + nick + ".png";

        public Task<RootPlayerInfo> GetPlayerInfoAsync(string nick, string region)
        {
            return PlayerInfo.GetPlayerInfoAsync(nick, region);
        }

    }
}
