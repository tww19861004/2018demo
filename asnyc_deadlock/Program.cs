using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace asnyc_deadlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("step1,线程ID:{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);

            AsyncDemo demo = new AsyncDemo();
            //demo.AsyncSleep().Wait();//Wait会阻塞当前线程直到AsyncSleep返回
            demo.AsyncSleep();//不会阻塞当前线程

            Console.WriteLine("step5,线程ID:{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.ReadLine();
        }
    }

    public class AsyncDemo
    {
        public async Task AsyncSleep()
        {
            Console.WriteLine("step2,线程ID:{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);

            //await关键字表示“等待”Task.Run传入的逻辑执行完毕，此时(等待时)AsyncSleep的调用方能继续往下执行（准确地说，是当前线程不会被阻塞）
            //Task.Run将开辟一个新线程执行指定逻辑
            Task.Run(() => Sleep(10));

            Console.WriteLine("step4,线程ID:{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
        }

        private void Sleep(int second)
        {
            Console.WriteLine("step3,线程ID:{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(second * 1000); 
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
