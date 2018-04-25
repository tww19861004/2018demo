using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Type"] = "GET";
                client.Headers["Accept"] = "application/json";
                client.Encoding = Encoding.UTF8;
                client.DownloadStringCompleted += (senderobj, es) =>
                {
                    var obj = es.Result;
                };
                client.DownloadStringAsync(new Uri("https://www.baidu.com/"));
            }
        }
    }
}
