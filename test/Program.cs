using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public static class class1
    {
        public static IEnumerable<T> DistinctBy2<T, TResult>(this IEnumerable<T> source, Func<T, TResult> where)
        {
            HashSet<TResult> hashSetData = new HashSet<TResult>();
            foreach (T item in source)
            {
                //哈希在插入数据会自行判断的
                if (hashSetData.Add(where(item)))
                {
                    yield return item;
                }
            }
        }
    }
    class test
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<test> lst = new List<test>();
            lst.Add(new test() { id = 1, name = "tww1" });
            lst.Add(new test() { id = 1, name = "tww2" });
            lst.Add(new test() { id = 2, name = "tww3" });
            var newlist = lst.DistinctBy2(r => r.id).ToList();
        }

        /// 获取时间戳  
        /// </summary>  
        public static string GetTimeStamp(DateTime dt)
        {
            TimeSpan ts = dt - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }
    }
}
