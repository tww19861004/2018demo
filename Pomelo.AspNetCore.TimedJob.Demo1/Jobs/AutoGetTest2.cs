using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pomelo.AspNetCore.TimedJob.Demo1.Jobs
{
    public class AutoGetTest2 : Job
    {
        [Invoke(Begin = "2018-04-24 15:40", Interval = 1000 * 1, SkipWhileExecuting = true)]
        public void Run()
        {
            System.IO.File.AppendAllTextAsync("d:\\2.txt", $"2:{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}:ExampleMethodAsync-当前线程id:{System.Threading.Thread.CurrentThread.ManagedThreadId}{Environment.NewLine}");
        }        
    }
}
