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
                //client.DownloadStringCompleted += OnDownloadStringCompleted;
                client.DownloadStringCompleted += (senderobj, es) =>
                {
                    Console.WriteLine(es.Result);
                };
                client.DownloadStringAsync(new Uri("https://www.baidu.com/"));
            }
            Console.ReadKey();
        }

        private static void OnDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }

    }
}
