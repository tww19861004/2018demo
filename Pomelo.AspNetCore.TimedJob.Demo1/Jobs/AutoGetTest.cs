using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Pomelo.AspNetCore.TimedJob;

namespace Pomelo.AspNetCore.TimedJob.Demo1.Jobs
{
    public class AutoGetTest : Job
    {
        // Begin 起始时间；Interval执行时间间隔，单位是毫秒，建议使用以下格式，此处为10秒；
        //SkipWhileExecuting是否等待上一个执行完成，true为等待；
        [Invoke(Begin = "2018-04-24 15:40", Interval = 1000 * 1, SkipWhileExecuting = true)]
        public void Run()
        {                       
            ExampleMethodAsync();            
        }

        public async Task<int> ExampleMethodAsync()
        {
            await System.IO.File.AppendAllTextAsync("d:\\1.txt", $"{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}:ExampleMethodAsync-当前线程id:{System.Threading.Thread.CurrentThread.ManagedThreadId}{Environment.NewLine}");            
            int exampleInt = (await WaitAsynchronouslyAsync()).Length;             
            return exampleInt;
        }

        public async Task<string> WaitAsynchronouslyAsync()
        {
            await System.IO.File.AppendAllTextAsync("d:\\1.txt", $"{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}:WaitAsynchronouslyAsync-当前线程id:{System.Threading.Thread.CurrentThread.ManagedThreadId}{Environment.NewLine}");
            //await Task.Delay(10000);
            Thread.Sleep(10000);
            return "Finished";
        }
    }
}
