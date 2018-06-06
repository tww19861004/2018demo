using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace NewtonsoftDemo
{
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

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
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
    class Program
    {
        static void Main(string[] args)
        {
            DateTime begin = DateTime.Now.AddHours(-72);
            DateTime end = DateTime.Now;

            var handler = new HttpClientHandler() { UseCookies = true };
            handler.CookieContainer = new CookieContainer();
            handler.CookieContainer.Add(new Cookie() { Name = "userJob1NO", Value = "12345", Domain = "xxxxxx" });
            handler.CookieContainer.Add(new Cookie() { Name = "userNam2e", Value = "%E5%94%90%E4%BC%9F%E4%BC%9F", Domain = "xxxxxx" });
            handler.CookieContainer.Add(new Cookie() { Name = "userTok3en", Value = "92add0a4ee8", Domain = "xxxxxx" });
            HttpClient hc = new HttpClient(handler);

            var handler1 = new HttpClientHandler() { UseCookies = true };
            HttpClient hc1 = new HttpClient(handler1);
            handler1.CookieContainer = new CookieContainer();
            handler1.CookieContainer.Add(new Cookie() { Name = "__tctma", Value = "1527748740333.6", Domain = "xxxxxxxxxx" });
            handler1.CookieContainer.Add(new Cookie() { Name = "access_token", Value = "54ae269", Domain = "xxxxxxx" });
            handler1.CookieContainer.Add(new Cookie() { Name = "state", Value = "78e46bd2b8", Domain = "xxxxxxx" });

            StringBuilder sb = new StringBuilder();
            sb.Append($"方法名,调用次数,上级调用,产品线,应用名,责任人,运维负责人{Environment.NewLine}");
            foreach (var item in zhixiao1)
            {
                var param = Newtonsoft.Json.JsonConvert.SerializeObject(
                new
                {
                    agentId = "",
                    appName = "test12345",
                    entryPoint = item.DestId,
                    env = 1,
                    from = GetTimeStamp(begin),
                    to = GetTimeStamp(end)
                });
                HttpContent contentPost = new StringContent(param, Encoding.UTF8, "application/json");
                var result = hc.PostAsync("xxxxxxxxxxxxxxxxxxx", contentPost).Result;
                var res1 = result.Content.ReadAsStringAsync().Result;
                Welcome[] r1 = Welcome.FromJson(res1);
                if (r1 != null && r1.Any() && r1.First().Result.Any())
                {
                    foreach (var item1 in r1.First().Result)
                    {
                        if (item1.DestId != "USER")
                        {
                            var res = hc1.GetStringAsync($"xxxxxxxxxxxxxxxxxxxxxxxxxxxxx").Result;
                            dynamic res1234 = JsonConvert.DeserializeObject<JObject>(res);
                            if (res1234.result.rows == 0)
                            {
                                sb.Append($"{item.DestId},{item.Count},{item1.DestId},,,,{Environment.NewLine}");
                            }
                            else if (res1234.result.rows == 1)
                            {
                                sb.Append($"{item.DestId},{item.Count},{item1.DestId},{res1234.result.list[0].productLineName},{res1234.result.list[0].aChname},{res1234.result.list[0].aLinkMan},{res1234.result.list[0].aOpsMaintenanceName}{Environment.NewLine}");
                            }
                            //筛选出多个的情况
                            else
                            {
                                int j = Convert.ToInt32(res1234.result.rows);
                                for (int i = 0; i < j; i++)
                                {
                                    if (res1234.result.list[i].aUk == item1.DestId)
                                    {
                                        sb.Append($"{item.DestId},{item.Count},{item1.DestId},{res1234.result.list[i].productLineName},{res1234.result.list[i].aChname},{res1234.result.list[i].aLinkMan},{res1234.result.list[i].aOpsMaintenanceName}{Environment.NewLine}");
                                    }
                                }

                            }
                        }
                    }
                }
                else
                {
                    sb.Append($"{item.DestId},{item.Count},,,,,{Environment.NewLine}");
                }
            }
            System.IO.File.WriteAllText($"d:\\被调用的列表4.txt", sb.ToString());
        }

        public static string GetTimeStamp(DateTime dt)
        {
            TimeSpan ts = dt - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

        //配置供应商id走OA
        private static readonly List<Result> zhixiao1 = new List<Result>()
        {
            new Result(){ DestId = "1234",Count = 128540947},
            new Result(){ DestId = "1234",Count = 45979869},
            new Result(){ DestId = "12341234",Count = 29785698},
        };
        private static readonly List<Result> fenxiao1 = new List<Result>()
        {
            new Result(){ DestId = "12341234",Count = 6037446},
            new Result(){ DestId = "1234",Count = 1479485},
        };
    }
}
