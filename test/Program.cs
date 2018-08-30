using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace test
{    
    class Program
    {
        private static readonly string template_mappping = "{\"11123\":\"117\",\"11251\":\"118\",\"11252\":\"119\",\"11253\":\"120\",\"11254\":\"121\",\"11255\":\"122\",\"12256\":\"123\",\"12265\":\"124\",\"12266\":\"125\",\"12267\":\"126\",\"12300\":\"127\",\"12301\":\"128\",\"12302\":\"129\",\"12303\":\"130\",\"12304\":\"131\",\"12305\":\"132\",\"12306\":\"133\",\"12307\":\"134\",\"12308\":\"135\",\"12309\":\"136\",\"12310\":\"137\",\"11042\":\"300\",\"11125\":\"301\",\"11126\":\"302\",\"11127\":\"303\",\"11129\":\"304\",\"11609\":\"305\",\"11610\":\"306\",\"12264\":\"307\",\"12257\":\"308\",\"12258\":\"309\",\"12259\":\"310\",\"12260\":\"311\",\"12261\":\"312\",\"11192\":\"313\",\"12273\":\"314\",\"12274\":\"315\",\"11191\":\"162\"}";
        static void Main(string[] args)
        {
            var res = JsonConvert.DeserializeObject<JObject>(template_mappping);
            if(res.ContainsKey("111233"))
            {

            }
            if (res.ContainsKey("11123"))
            {

            }
        }

    }
}
