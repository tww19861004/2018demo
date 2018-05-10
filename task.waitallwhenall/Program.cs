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
            //创建任务5 task既有传入，又有返回的正确姿势
            Task[] tasks = new Task[2];
            tasks[0] = new Task<Int32>(n => Sum(n), 100);
            tasks[0].Start();//异步的
            tasks[1] = new Task<Int32>(n => Sum(n), 200);
            //tasks[1].RunSynchronously();//阻塞当前线程了
            tasks[1].Start();//阻塞当前线程了
            try
            {                
                //因为task没有启动所有已知会hold住
                Task.WaitAll(tasks);
            }
            catch (Exception err)
            {

            }

            for (int i=0;i<tasks.Length;i++)
            {
                if (tasks[i].IsFaulted)
                {
                    continue;
                }
            }

            Console.ReadKey();
        }

        private static Int32 Sum(object i)
        {
            System.Threading.Thread.Sleep(10000);
            if (Convert.ToInt32(i) != 100)
            {
                throw new Exception("模拟异常");
            }
            return Convert.ToInt32(i) + 1;
        }
    }
}
