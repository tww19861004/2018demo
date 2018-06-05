using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        static void Main(string[] args)
        {
            string strFrom = GetTimeStamp(new DateTime(2018, 6, 4, 0, 0, 0, 0));
            string strTo = GetTimeStamp(new DateTime(2018, 6, 5, 23, 59, 59, 0));
            HttpClient hc = new HttpClient();
            var task = hc.GetStringAsync($"12345?appName=12345&from={strFrom}&to={strTo}&agentId=&env=1");
            task.Wait();
            string str = task.Result;
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
