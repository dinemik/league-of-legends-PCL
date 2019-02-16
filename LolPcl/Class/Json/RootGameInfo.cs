using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolPcl.Class.Json
{
    public class RootGameInfo
    {
        [JsonProperty("matches")]
        public Match[] Matches { get; set; }

        [JsonProperty("startIndex")]
        public long StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public long EndIndex { get; set; }

        [JsonProperty("totalGames")]
        public long TotalGames { get; set; }
    }

    public partial class Match
    {
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("champion")]
        public long Champion { get; set; }

        [JsonProperty("queue")]
        public long Queue { get; set; }

        [JsonProperty("season")]
        public long Season { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }
    }
}
