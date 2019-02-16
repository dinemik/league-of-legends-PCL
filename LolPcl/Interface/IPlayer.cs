using LolPcl.Class.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolPcl.Interface
{
    interface IPlayer
    {
        Task<RootGameInfo> GetMarhInfoAsync(string accID, string region);

        Task<RootPlayerInfo> GetPlayerInfoAsync(string nick, string region);

        string GetProfileImg(string nick);
    }
}
