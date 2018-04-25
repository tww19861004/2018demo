using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace queuetest
{
    public class User
    {
        public int Id { get; set; }
    }

    class Program
    {
        static readonly ConcurrentQueue<User> queue = new ConcurrentQueue<User>();//微软写的
        static readonly SecurityQueue<User> queue1 = new SecurityQueue<User>();//我自己写的
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.For(1, 4000, i =>
            {
                var workItem = new User { Id = i };
                queue.Enqueue(workItem);//入列
                //Console.WriteLine("Thread:{0},Task {1} has been posted", Thread.CurrentThread.ManagedThreadId, workItem.Id);
            });
            sw.Stop();
            Console.WriteLine($"并发4000ConcurrentQueue入队耗时：{sw.Elapsed.TotalMilliseconds},distinct.count:{queue.Distinct().Count()}");

            //sw.Restart();
            //sw.Start();
            //int failcount = 0;
            //foreach (var item in queue)
            //{
            //    try
            //    {
            //        User demo = null;
            //        queue.TryDequeue(out demo);
            //    }
            //    catch { failcount++; }                
            //}
            //sw.Stop();
            //Console.WriteLine($"并发4000ConcurrentQueue出队耗时：{sw.Elapsed.TotalMilliseconds},failcount:{failcount}");

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            Parallel.For(1, 4000, i =>
            {
                var workItem = new User { Id = i };
                queue1.EnQueue(workItem);//入列                
            });
            sw1.Stop();
            Console.WriteLine($"并发4000SecurityQueue入队耗时：{sw1.Elapsed.TotalMilliseconds},distinct.count:{queue1.Count}");
            //sw1.Restart();
            //sw1.Start();
            //while (queue1.Count>0)
            //{
            //    queue1.DeQueue();
            //}
            //sw1.Stop();
            //Console.WriteLine($"并发4000SecurityQueue出队耗时：{sw1.Elapsed.TotalMilliseconds},distinct.count:{queue1.Count}");
            Console.ReadKey();
        }
    }
}
