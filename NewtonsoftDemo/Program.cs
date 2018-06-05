using System.Linq;
using System.Text;

namespace NewtonsoftDemo
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Globalization;
    using System.Net.Http;
    //https://app.quicktype.io/#l=cs&r=json2csharp
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

    public static class Serialize
    {
        public static string ToJson(this Welcome[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
    class Program
    {
        static void Main(string[] args)
        {            
            //直销
            HttpClient httpClient = new HttpClient();
            string strFrom = GetTimeStamp(DateTime.UtcNow.AddHours(-72));
            string strTo = GetTimeStamp(DateTime.UtcNow);
            string url = $"12345?appName=12345&from={strFrom}&to={strTo}&agentId=&env=1";
            var task = httpClient.GetStringAsync(url);
            task.Wait();
            string str = task.Result;
            Welcome[] r1 = Welcome.FromJson(str);
            StringBuilder strBuilder = null;
            if (r1 != null && r1.Any() && r1.First().Result.Any())
            {
                strBuilder = new StringBuilder();
                strBuilder.Append($"Web请求,访问量{Environment.NewLine}");
                foreach (var item in r1.First().Result)
                {
                    strBuilder.Append($"{item.DestId},{item.Count}{Environment.NewLine}");
                }
            }
            if (strBuilder != null)
            {
                System.IO.File.WriteAllText("d:\\SOA线上直销还在被调用的列表.txt", strBuilder.ToString());
            }
            //分销
            url = $"12345?appName=hotel.12345&from={strFrom}&to={strTo}&agentId=&env=1";
            var task1 = httpClient.GetStringAsync(url);
            task1.Wait();
            r1 = Welcome.FromJson(task1.Result);
            if (r1 != null && r1.Any() && r1.First().Result.Any())
            {
                if (strBuilder == null)
                {
                    strBuilder = new StringBuilder();
                }
                else
                {
                    strBuilder.Clear();
                }
                strBuilder.Append($"Web请求,访问量{Environment.NewLine}");
                foreach (var item in r1.First().Result)
                {
                    strBuilder.Append($"{item.DestId},{item.Count}{Environment.NewLine}");
                }
            }
            if (strBuilder != null)
            {
                System.IO.File.WriteAllText("d:\\SOA线上分销还在被调用的列表.txt", strBuilder.ToString());
            }
        }
        public static string GetTimeStamp(DateTime dt)
        {
            TimeSpan ts = dt - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

        public static void Execute(bool iszhixiao,int days)
        {            
            HttpClient httpClient = new HttpClient();
            string strFrom = GetTimeStamp(DateTime.UtcNow.AddHours(-72));
            string strTo = GetTimeStamp(DateTime.UtcNow);                        
            string url = iszhixiao?$"12345?appName=12345&from={strFrom}&to={strTo}&agentId=&env=1"
                : $"12345?appName=hotel.12345&from={strFrom}&to={strTo}&agentId=&env=1";
            var task = httpClient.GetStringAsync(url);
            task.Wait();
            string str = task.Result;
            Welcome[] r1 = Welcome.FromJson(str);
            StringBuilder strBuilder = null;
            if (r1 != null && r1.Any() && r1.First().Result.Any())
            {
                strBuilder = new StringBuilder();
                strBuilder.Append($"Web请求,访问量{Environment.NewLine}");
                foreach (var item in r1.First().Result)
                {
                    strBuilder.Append($"{item.DestId},{item.Count}{Environment.NewLine}");
                }
            }
            if (strBuilder != null)
            {
                if (iszhixiao)
                {
                    System.IO.File.WriteAllText($"d:\\SOA线上直销还在被调用的列表.txt", strBuilder.ToString());
                }
                else
                {
                    System.IO.File.WriteAllText($"d:\\SOA线上分销还在被调用的列表.txt", strBuilder.ToString());
                }                
            }
        }
    }
}
