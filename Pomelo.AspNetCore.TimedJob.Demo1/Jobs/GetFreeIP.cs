using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pomelo.AspNetCore.TimedJob.Demo1.Jobs
{
    public class GetFreeIP : Job
    {
        private static BloomFilter<proxy> iplist = new BloomFilter<proxy>(20, 3);

        [Invoke(Begin = "2018-04-07 15:40", Interval = 10000 * 1, SkipWhileExecuting = true)]
        public void Run()
        {
            iplist.Add(new proxy(Guid.NewGuid().ToString(),"1234",2));
            System.IO.File.AppendAllTextAsync("d:\\freeIP.txt", $"{DateTime.Now.ToString()}{Environment.NewLine}");            
        }
    }

    public class proxy
    {
        public string ip;

        public string port;
        public int speed;

        public proxy(string pip, string pport, int pspeed)

        {
            this.ip = pip;
            this.port = pport;
            this.speed = pspeed;
        }
    }
}
