using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {        
        static void Main(string[] args)
        {
            string s1 = null;
            string s2 = s1 ?? string.Empty;
            int j = 8784;
            long i = long.Parse(( j * 60 * 60 * 1000).ToString());
            DateTime dt = ConvertLongToDateTime(i);
            
            long k = long.Parse(DateTime.UtcNow.Subtract(DateTime.Parse("1970-1-1")).TotalMilliseconds.ToString());
        }

        // long --> DateTime
        public static DateTime ConvertLongToDateTime(long d)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(d + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            DateTime dtResult = dtStart.Add(toNow);
            return dtResult;
        }

    }
}
