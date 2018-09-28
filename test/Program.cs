using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TCGHotel.Common;

namespace test
{
    class Program
    {        
        static void Main(string[] args)
        {
            SMSAPIService.SendSms("11129", "240000000405936657", "1", new Dictionary<string, string>()
                {
                    { "mobile","15062437243"},
                    { "uid","240000000405936657"}
                });
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
