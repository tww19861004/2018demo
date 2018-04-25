using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semaphore1
{

    class Program
    {
        //创建一个可授权2个许可证的信号量，且初始值为2
        static Semaphore _semaphore = new Semaphore(2, 2);

        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => DoWork());
            Task.Factory.StartNew(() => DoWork());
            Task.Factory.StartNew(() => DoWork());

            Console.ReadLine();
        }

        static void DoWork()
        {
            try
            {
                Console.WriteLine(string.Format("Thread {0} 正在等待一个许可证……", Thread.CurrentThread.ManagedThreadId));
                _semaphore.WaitOne();
                Console.WriteLine(string.Format("Thread {0} 申请到许可证……", Thread.CurrentThread.ManagedThreadId));
                Thread.Sleep(5000);
                Console.WriteLine(string.Format("Thread {0} 释放许可证……", Thread.CurrentThread.ManagedThreadId));
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}

