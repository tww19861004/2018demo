﻿using System;
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
            System.Threading.Thread.Sleep(2000);
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
                    string str = $"Message:{tasks[i].Exception?.InnerException.Message},StackTrace:{tasks[i].Exception?.InnerException.StackTrace}";
                    continue;
                }
            }

            Console.ReadKey();
        }

        private static Int32 Sum(object i)
        {
            //try
            //{
                System.Threading.Thread.Sleep(100);
                if (Convert.ToInt32(i) != 100)
                {
                    decimal j = 0;
                    decimal k = device(j);
                }
                return Convert.ToInt32(i) + 1;
            //}
            //catch(Exception ex)
            //{
            //    int i11 = ex.LineNumber();
            //    return i11;
            //}
        }

        private static decimal device(decimal i)
        {
            return 100 / i;
        }
    }

    public static class ExceptionHelper
    {
        public static int LineNumber(this Exception e)
        {

            int linenum = 0;
            try
            {
                //linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(":line") + 5));

                //For Localized Visual Studio ... In other languages stack trace  doesn't end with ":Line 12"
                linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(' ')));

            }


            catch
            {
                //Stack trace is not available!
            }
            return linenum;
        }
    }
}
