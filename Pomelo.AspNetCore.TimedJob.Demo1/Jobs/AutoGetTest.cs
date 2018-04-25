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
        [Invoke(Begin = "2018-04-24 15:40", Interval = 1000 * 10, SkipWhileExecuting = true)]
        public void Run()
        {
            System.IO.File.AppendAllTextAsync("d:\\1.txt", "Sleep:"+i.ToString()+":"+System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + Environment.NewLine);
        }

        public async Task<int> ExampleMethodAsync()
        {
            System.Threading.Thread.Sleep(new Random().Next(5000,15000));
            var httpClient = new HttpClient();
            int exampleInt = (await httpClient.GetStringAsync("https://www.baidu.com/")).Length;             
            return exampleInt;
        }

        public async Task<string> WaitAsynchronouslyAsync()
        {
            await Task.Delay(10000);
            return "Finished";
        }

        public async Task<string> WaitSynchronously()
        {
            // Add a using directive for System.Threading.
            Thread.Sleep(10000);
            return "Finished";
        }
    }
}
