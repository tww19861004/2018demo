using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.waitallwhenall
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建任务5 捕获异常
            Task[] tasks = new Task[2];
            tasks[0] = new Task<Int32>(n => Sum(n), 100);
            tasks[1] = new Task<Int32>(n => Sum(n), 200);
            try
            {
                Task<Int32>.WaitAll(tasks);
            }
            catch (Exception err)
            {

            }
            Console.ReadKey();
        }

        private static Int32 Sum(object i)
        {
            if (Convert.ToInt32(i) != 100)
            {
                //throw new Exception("模拟异常");
            }
            return Convert.ToInt32(i) + 1;
        }
    }
}
