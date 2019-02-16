using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LolPcl.Class.WebClient
{
    internal class Web
    {
        public async Task<string> UrlAsync(string url)
        {
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                return await wc.DownloadStringTaskAsync(url);
            }
        }
    }
}
