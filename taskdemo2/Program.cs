using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Async3(() =>
            {
                Console.WriteLine("Async3完毕，执行了回调");
            });

            Console.WriteLine("...............按任意键退出");
            Console.ReadKey();
        }
        static void Async3(Action callback)
        {
            //Console.WriteLine("异步");
            //callback();
            Task.Run(() =>
            {
                Console.WriteLine("异步");
                callback();
            });
        }
    }
}
