using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace httpclientdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = get().Result;
            Console.WriteLine("test12345");
        }

        public async static Task<string> get()
        {
            string result = string.Empty;
            HttpClient hc = new HttpClient();
            //HttpContent contentPost = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await hc.GetAsync("https://www.baidu.com/");
            try
            {
                response.EnsureSuccessStatusCode();
                result = await response.Content.ReadAsStringAsync();
                // Handle success
            }
            catch (HttpRequestException ex)
            {
                result = ex.Message;
                // Handle failure
            }
            return result;
        }
    }
}
