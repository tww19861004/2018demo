using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catchdemo2
{
    using static TryCatch;

    class Program
    {
        public static async Task<int> Method1()
        {
            return await TryExecuteAsync(async () =>
            {
                return await SomeOperation();
            }, "Method1");
        }

        static void Main(string[] args)
        {
            //try
            //{
            //    string text = System.IO.File.ReadAllText("demo.txt");
            //    Console.WriteLine(text);
            //}
            //catch (System.IO.IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            string text = Try(() => { return System.IO.File.ReadAllText("demo.txt"); });
            Console.WriteLine(text);

        }        
    }

    public static class TryCatch
    {
        /// <summary>
        /// //这个 Try 方法接受两个委托作为参数，第一个是要执行的代码，第二个是出现了异常也好返回一个 Exception 类型给调用方，并且它是一个可为 null 类型的参数，也就是可选参数。
        /// </summary>
        /// <param name="act"></param>
        /// <param name="errorCallback"></param>
        //public static void Try(Action act, Action<Exception> errorCallback = null)
        //{
        //    try
        //    {
        //        act();
        //    }
        //    catch (Exception ex)
        //    {
        //        errorCallback?.Invoke(ex);
        //    }
        //}

        public static T Try<T>(Func<T> func, Func<Exception, T> errorCallback = null)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                if (errorCallback != null)
                {
                    return errorCallback(ex);
                }
                return default(T);
            }
        }

        /// <summary>
        /// 支持.NET 4.5 async await关键词的：
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="funcName"></param>
        /// <returns></returns>
        public static async Task<T> TryAsync<T>(Func<Task<T>> func, string funcName = null)
        {
            try
            {
                return await func();
            }
            catch (Exception e)
            {
                //Logger.Error(string.Format("{0}() Blow Up.", funcName), e);
                return default(T);
            }
        }

        /// <summary>
        /// 自定义包裹类的，比如Request/Response模式：
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="funcName"></param>
        /// <returns></returns>
        public Response<T> TryExecute<T>(Func<Response<T>> func, string funcName = null)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                Logger.Error(string.Format("{0}() Blow Up.", funcName), e);
                return new Response<T>
                {
                    Item = default(T),
                    Message = e.Message
                };
            }
        }

    }
}
