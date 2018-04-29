using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pomelo.AspNetCore.TimedJob;

namespace Pomelo.AspNetCore.TimedJob.Demo1.Jobs
{
    public class AutoGetTest : Job
    {
        private static HttpClient hc = new HttpClient();
        private Regex _regex = new Regex(@"\{.*\}", RegexOptions.IgnoreCase);

        private static string _token;
        public string Token
        {
            get
            {
                if (string.IsNullOrEmpty(_token))
                {
                    _token = GetToken();
                }
                return _token;
            }
        }
        // Begin 起始时间；Interval执行时间间隔，单位是毫秒，建议使用以下格式，此处为10秒；
        //SkipWhileExecuting是否等待上一个执行完成，true为等待；
        [Invoke(Begin = "2018-04-24 15:40", Interval = 600 * 1, SkipWhileExecuting = true)]
        public void Run()
        {
            System.IO.File.AppendAllTextAsync("d:\\1.txt", $"{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}:百度token:{Token}{Environment.NewLine}");
        }

        private string GetToken()
        {
            string res = string.Empty;
            var nvc = new NameValueCollection
                {
                    {"tpl", "tb"},
                    {"apiver", "v3"},
                    {"tt", GetTimeStamp()},
                    {"class", "login"},
                    {"gid", Guid.NewGuid().ToString()},
                    {"logintype", "dialogLogin"},
                    {"callback", "bd__cbs__123"},
                };
            Task<HttpResponseMessage> task = hc.GetAsync(new Uri("https://passport.baidu.com/v2/api/?getapi&" + nvc.ToQueryString()));
            task.Wait();
            var response = task.Result;            
            response.EnsureSuccessStatusCode();
            String Result = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode.Equals(HttpStatusCode.OK))
            {
                if (_regex.IsMatch(Result))
                {
                    //不是纯json需要match一下
                    dynamic result = JsonConvert.DeserializeObject<JObject>(_regex.Match(Result).Value);
                    var no = result.errInfo.no.Value;
                    if (no.Equals("0"))
                    {
                        res = result.data.token.Value;                        
                    }
                }
            }
            return res;
        }

        /// 获取时间戳  
        /// </summary>  
        public string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

        private void GetValidImage()
        {
            var nvc = new NameValueCollection
            {
                {"token", Token},
                {"tpl", "mn"},
                {"apiver", "v3"},
                {"tt", GetTimeStamp()},
                {"fr", "login"},
                //{"vcodetype", "7ea7JrZpMpKLyZu112UWT4NIYUCa8eOetNIn0rP8P6FMti58cJ8BIl1lnRqX9fdeYp84BbSMmr+yLUGUd/Do8yDrI/YV0uaa400z"},
                {"callback", "bd__cbs__1234"},
            };
            HttpResponseMessage response = hc.GetAsync(new Uri("https://passport.baidu.com/v2/?reggetcodestr&" + nvc.ToQueryString())).Result;
            response.EnsureSuccessStatusCode();
            String result = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode.Equals(HttpStatusCode.OK))
            {
                if (_regex.IsMatch(result))
                {
                    //不是纯json需要match一下
                    dynamic obj = JsonConvert.DeserializeObject<JObject>(_regex.Match(result).Value);
                    var no = obj.errInfo.no.Value;
                    if (no.Equals("0"))
                    {
                        string verifyStr = obj.data.verifyStr.Value;
                        response = hc.GetAsync(new Uri("https://passport.baidu.com/cgi-bin/genimage?" + obj.data.verifyStr.Value)).Result;
                        response.EnsureSuccessStatusCode();
                        if (response.StatusCode.Equals(HttpStatusCode.OK))
                        {
                         //   return Image.FromStream(response.Content.ReadAsStreamAsync().Result);
                        }                        
                    }
                }                
            }            
        }

        public async Task<int> ExampleMethodAsync()
        {
            await System.IO.File.AppendAllTextAsync("d:\\1.txt", $"1:{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}:ExampleMethodAsync-当前线程id:{System.Threading.Thread.CurrentThread.ManagedThreadId}{Environment.NewLine}");
            //int exampleInt = (await WaitAsynchronouslyAsync()).Length;             
            //return exampleInt;
            return 1;
        }

        public async Task<string> WaitAsynchronouslyAsync()
        {
            await System.IO.File.AppendAllTextAsync("d:\\1.txt", $"{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}:WaitAsynchronouslyAsync-当前线程id:{System.Threading.Thread.CurrentThread.ManagedThreadId}{Environment.NewLine}");
            //await Task.Delay(10000);
            Thread.Sleep(10000);
            return "Finished";
        }
    }
}
