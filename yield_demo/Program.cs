﻿using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("不使用 yield return 方式的结果");
            foreach (var item in WithoutYield())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("使用 yield return 方式的结果");
            foreach (var item in WithYield())
            {
                Console.WriteLine(item);
            }
            //Method();
            Console.ReadLine();
        }
        /// <summary>
        /// 不使用 yield return
        /// </summary>
        /// <returns></returns>
        static IEnumerable<int> WithoutYield()
        {
            List<int> result = new List<int>();
            foreach (int i in GetData())
            {
                if (i > 2)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        /// <summary>
        /// 使用 yield return
        /// </summary>
        /// <returns></returns>
        static IEnumerable<int> WithYield()
        {
            foreach (int i in GetData())
            {
                if (i > 2)
                {
                    yield return i;
                }
            }
            yield break;
            Console.WriteLine("这里的代码不执行");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> MethodWithoutYield()
        {
            List<int> results = new List<int>();
            int counter = 0;
            int result = 1;

            while (counter++ < 10)
            {
                result = result * 2;
                results.Add(result);
            }
            return results;
        }

        public static IEnumerable<int> MethodWithYield()
        {
            int counter = 0;
            int result = 1;
            while (counter++ < 10)
            {
                result = result * 2;
                yield return result;
            }
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        static IEnumerable<int> GetData()
        {
            return new List<int>() { 1, 2, 3, 4 };
        }
    }
}