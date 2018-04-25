using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<Int32> t = new Task<Int32>(n => Sum((Int32)n), 1000000000);            

            //可以现在开始，也可以以后开始             
            t.Start();
            //Wait显式的等待一个线程完成

            t.Wait();
            Console.WriteLine("The Sum is:" + t.Result);
            Console.ReadKey();
        }
        private static Int32 Sum(Int32 i)
        {
            Int32 sum = 0;
            for (; i > 0; i--)
                checked { sum += i; }
            return sum;
        }
    }
}
