using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.DrawingCore;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Pomelo.AspNetCore.TimedJob;

namespace Pomelo.AspNetCore.TimedJob.Demo1.Jobs
{
    public class GetProductSOAFunctionList : Job
    {
        private static HttpClient _httpClient;
        public HttpClient httpClient
        {
            get
            {
                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();
                }
                return _httpClient;
            }
        }
        // Begin 起始时间；Interval执行时间间隔，单位是毫秒，建议使用以下格式，此处为10秒；
        //SkipWhileExecuting是否等待上一个执行完成，true为等待；
        //模拟高并发
        [Invoke(Begin = "2018-06-05 15:10", Interval = 30*1000, SkipWhileExecuting = true)]
        public void Run()
        {
            //先从文件中读取
            //FileStream fs = new FileStream("d:\\SOA线上还在被调用的列表.txt", FileMode.Open,FileAccess.Read);
            //StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            //string strLine = "";
            //while ((strLine = sr.ReadLine()) != null)
            //{

            //}

            string strFrom = GetTimeStamp(DateTime.UtcNow.AddHours(-6));
            string strTo = GetTimeStamp(DateTime.UtcNow);            
            var task = httpClient.GetStringAsync($"http://apm.17usoft.com/api/web/state1?appName=gny.tcinnerapi.ghotel&from={strFrom}&to={strTo}&agentId=&env=1");
            task.Wait();
            string str = task.Result;
            Welcome[] r1 = Welcome.FromJson(str);
            StringBuilder strBuilder = null;
            if (r1!=null && r1.Any() && r1.First().Result.Any())
            {
                strBuilder = new StringBuilder();
                strBuilder.Append($"Web请求,访问量{Environment.NewLine}");
                foreach (var item in r1.First().Result)
                {
                    strBuilder.Append($"{item.DestId},{item.Count}{Environment.NewLine}");
                }                
            }
            if(strBuilder!=null)
            {
                System.IO.File.AppendAllTextAsync("d:\\SOA线上还在被调用的列表.txt", strBuilder.ToString());
            }                       
        }
        /// 获取时间戳  
        /// </summary>  
        public static string GetTimeStamp(DateTime dt)
        {
            TimeSpan ts = dt - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

    }

    public partial class Welcome
    {
        [JsonProperty("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonProperty("result")]
        public Result[] Result { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("elapsed")]
        public long Elapsed { get; set; }

        [JsonProperty("errs")]
        public long Errs { get; set; }

        [JsonProperty("destId")]
        public string DestId { get; set; }
    }

    public partial class Welcome
    {
        public static Welcome[] FromJson(string json) => JsonConvert.DeserializeObject<Welcome[]>(json, Converter.Settings);
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
