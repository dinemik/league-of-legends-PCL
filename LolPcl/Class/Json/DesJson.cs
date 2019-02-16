using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolPcl.Class.Json
{
    internal static class DesJson
    {
        public static RootPlayerInfo GetObjPlayerInf(string json) => JsonConvert.DeserializeObject<RootPlayerInfo>(json);

        public static RootGameInfo GetObjMathInf(string json) => JsonConvert.DeserializeObject<RootGameInfo>(json);
    }
}
