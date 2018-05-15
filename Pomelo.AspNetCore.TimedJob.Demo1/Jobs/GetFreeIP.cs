using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pomelo.AspNetCore.TimedJob.Demo1.Jobs
{
    public class GetFreeIP : Job
    {
        private static BloomFilter<proxy> iplist = new BloomFilter<proxy>(20, 3);

        private static BloomFilter<string> test = new BloomFilter<string>(20, 3);

        [Invoke(Begin = "2018-04-07 15:40", Interval = 10000 * 1, SkipWhileExecuting = true)]
        public void Run()
        {
            if (!test.Contains("1234"))
            {
                test.Add("1234");
            }
            iplist.Add(new proxy(Guid.NewGuid().ToString(),"1234",2));
            System.IO.File.AppendAllTextAsync("d:\\freeIP.txt", $"{DateTime.Now.ToString()}{Environment.NewLine}");            
        }

        [Invoke(Begin = "2018-04-07 15:40", Interval = 10000 * 1, SkipWhileExecuting = true)]
        public void Run1()
        {
            if (!test.Contains("1234"))
            {
                test.Add("1234");
            }
            iplist.Add(new proxy(Guid.NewGuid().ToString(), "1234", 2));
            System.IO.File.AppendAllTextAsync("d:\\freeIP1.txt", $"{DateTime.Now.ToString()}{Environment.NewLine}");
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

    public class GetFreeIpService
    {
        #region Public Events

        /// <summary>
        /// The data received event.
        /// </summary>
        //public event DataReceivedEventHandler DataReceivedEvent;
        public Action<DataReceivedEventArgs> DataReceivedEvent;

        #endregion

    }

    /// <summary>
    /// The add url event args.
    /// </summary>
    public class DataReceivedEventArgs : EventArgs
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        public int Depth { get; set; }


        #endregion
    }

}
