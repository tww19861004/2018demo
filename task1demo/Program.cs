using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task1demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main";

            // 使用lambda方式，之间提供一个用户delegate，创建一个Task
            Task task = Task.Run(() =>
            {
                Console.WriteLine($"From thread {Thread.CurrentThread.Name}，执行子线程task");
            });
            // Output a message from the calling thread.
            Console.WriteLine("From thread '{0}'.",
                              Thread.CurrentThread.Name);

            //创建任务1
            Task task1 = new Task(() =>
            {
                Console.WriteLine($"From thread {Thread.CurrentThread.Name},执行子线程task1");
            });
            Console.ReadKey();
            Console.WriteLine("按任意键，执行task1");
            task1.Start();

            //创建任务2
            Task<int> task2 = new Task<int>(() =>
            {
                int sum = 0;
                Console.WriteLine("使用Task2执行异步操作.");
                for (int i = 0; i < 100; i++)
                {
                    sum += i;
                }
                return sum;
            });

            //创建任务3           
            //Task(Func<object, TResult> function, object state);
            Task<Int32> task3 = new Task<Int32>(n => Sum(n), 100);
            task3.Start();            
            int i11 = task3.Result;
            
            //创建任务4
            Task task4 = Task.Run(async() =>
            {
                int i = await test();
            });
            task4.Wait();            


            Console.ReadKey();
        }

        private static async Task<int> test()
        {
            return await Task.Run(()=> { return 1; });
        }

        private static Int32 Sum(object i)
        {
            if (Convert.ToInt32(i)!=100)
            {
                //throw new Exception("模拟异常");
            }
            return Convert.ToInt32(i)+1;
        }
    }
}
