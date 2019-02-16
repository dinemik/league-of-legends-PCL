using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolPcl.Class
{
    internal static class Links
    {
        //NickName?api_key = YourApiKey
        public static string PlayerLink => @"summoner/v4/summoners/by-name/";
        
        //AccauntID?api_key=YourApiKey
        public static string MathLink => @"match/v4/matchlists/by-account/";
        
        //NickName.png
        public static string ImgLink => @"https://avatar.leagueoflegends.com/EUN1/";
    }
}
