using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threaddemo
{
    class DataReceivedEventArgs : EventArgs
    {

    }
    class Program
    {
        private static readonly Thread[] threads = new Thread[5];
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                var threadStart = new ParameterizedThreadStart(CrawlProcess);
                threads[i] = new Thread(threadStart);
            }
            ServicePointManager.DefaultConnectionLimit = 256;

            for (int i = 0; i < 5; i++)
            {
                threads[i].Start(i);                
            }
            Console.ReadKey();
        }

        private static void CrawlProcess(object obj)
        {
            var currentThreadIndex = (int)obj;
            Console.WriteLine(currentThreadIndex);
        }

    }
}
