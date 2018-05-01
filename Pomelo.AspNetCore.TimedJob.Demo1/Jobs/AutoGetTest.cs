using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.DrawingCore;
using System.IO;
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
        private static HttpClient _httpClient;

        public HttpClient httpClient
        {
            get
            {
                if (_httpClient == null)
                {                    
                    HttpClientHandler httpClientHandler = new HttpClientHandler { AllowAutoRedirect = false };
                    httpClientHandler.CookieContainer = new CookieContainer();
                    _httpClient = new HttpClient(httpClientHandler);
                    _httpClient.MaxResponseContentBufferSize = 256000;
                    //_httpClient.DefaultRequestHeaders.Add("user-agent", UserAgent);
                    Task<HttpResponseMessage> task =_httpClient.GetAsync("http://www.baidu.com");
                    task.Wait();
                    var response = task.Result;
                    var t1 = response.Headers.GetValues("Set-Cookie").ToList();
                    for (int i = 0; i < t1.Count(); i++)
                    {
                        string[] demo = t1[i].Split(new char[] { ';' });
                        if (demo != null && demo.Length == 5)
                        {
                            httpClientHandler.CookieContainer.Add(new Cookie()
                            {
                                Expires = DateTime.Now.AddDays(2),
                                Domain = demo[4].Substring(demo[4].IndexOf("=") + 1, demo[4].Length - demo[4].IndexOf("=") - 1),
                                Name = demo[0].Substring(0, demo[0].IndexOf("=")),
                                Value = demo[0].Substring(demo[0].IndexOf("=") + 1, demo[0].Length - demo[0].IndexOf("=") - 1),
                                Path = demo[3].Substring(demo[3].IndexOf("=") + 1, demo[3].Length - demo[3].IndexOf("=") - 1)
                            });
                        }
                    }
                }
                return _httpClient;
            }
        }

        private Regex _regex = new Regex(@"\{.*\}", RegexOptions.IgnoreCase);

        private static string _token;
        public string Token
        {
            get
            {
                if (string.IsNullOrEmpty(_token) || _token == "the fisrt two args should be string type:0,1!")
                {
                    httpClient.GetAsync("https://www.baidu.com/");
                    _token = GetToken();
                }
                return _token;
                //return GetToken();
            }
        }
        // Begin 起始时间；Interval执行时间间隔，单位是毫秒，建议使用以下格式，此处为10秒；
        //SkipWhileExecuting是否等待上一个执行完成，true为等待；
        //模拟高并发
        [Invoke(Begin = "2018-04-24 15:40", Interval = 1000 * 1, SkipWhileExecuting = true)]
        public void Run()
        {
            System.IO.File.AppendAllTextAsync("d:\\1.txt", $"{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}:百度token:{Token}{Environment.NewLine}");
            GetValidImage();
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
            Task<HttpResponseMessage> task = httpClient.GetAsync(new Uri("https://passport.baidu.com/v2/api/?getapi&" + nvc.ToQueryString()));
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
            HttpResponseMessage response = httpClient.GetAsync(new Uri("https://passport.baidu.com/v2/?reggetcodestr&" + nvc.ToQueryString())).Result;
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
                        response = httpClient.GetAsync(new Uri("https://passport.baidu.com/cgi-bin/genimage?" + obj.data.verifyStr.Value)).Result;
                        response.EnsureSuccessStatusCode();
                        if (response.StatusCode.Equals(HttpStatusCode.OK))
                        {
                            Task<Stream> taskStream= response.Content.ReadAsStreamAsync();
                            taskStream.Wait();

                            Image image = Image.FromStream(taskStream.Result);
                            image.Save($"d:\\test\\{Guid.NewGuid().ToString()}.png");

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
