using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace httpclientdemo
{
    //double d = 2，Json.NET轉成"2.0"，而decimal有個有趣特性，小數尾端的零會被原原本本保存，例如: decimal d = 1.200M，d.ToString()為"1.200"，JSON結果也是"1.200"。
    class Program
    {
        static void Main(string[] args)
        {
            string posturl = "http://servicegw.qa.ly.com/gateway/eordercallback/test/";
            HttpClient hc = new HttpClient();

            EOrderCallBackRequest request = new EOrderCallBackRequest();
            request.orderId = "14431";
            request.status = 1;
            request.orderNoOfSupplier = "1412";
            request.supplierForeignCurrencyCode = "CNY";
            request.roomInfoList = new List<RoomInfo>();
            request.roomInfoList.Add(new RoomInfo()
            {
                supplierConfirmationNo = "1313411"
            });
            request.roomInfoList.Add(new RoomInfo()
            {
                supplierConfirmationNo = "3212"
            });
            request.sign = "F2AA963ABB871E17E6BEB8381BC5085F";
            request.takeOff = 3231;
            request.totalAmount = 32324.23M;
            request.totalSupplierForeignAmount = 32324.23M;
            request.supplierOrderCode = "1313411,3212";

            var param = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            HttpContent contentPost = new StringContent(param, Encoding.UTF8, "application/json");

            hc.DefaultRequestHeaders.Add("Labrador-Token", "468e7ff1-ed20-47a7-b6b1-45c85a4ad62f");
            hc.DefaultRequestHeaders.Add("Labrador-Passthrough", "true");
            var result =hc.PostAsync(posturl, contentPost).Result;

            string str = result.Content.ReadAsStringAsync().Result;
            
        }
    }

    public class EOrderCallBackRequest
    {
        /// <summary>
        /// MD5签名
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 供应商确认号（有的没有确认号）
        /// </summary>
        public string supplierOrderCode { get; set; }

        /// <summary>
        /// 酒店订单号
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 佣金
        /// </summary>
        public decimal takeOff { get; set; }

        /// <summary>
        /// 供应商订单号
        /// </summary>
        public string orderNoOfSupplier { get; set; }

        /// <summary>
        /// 房间集合
        /// </summary>
        public List<RoomInfo> roomInfoList { get; set; }

        /// <summary>
        /// 总价（人民币）
        /// </summary>
        public decimal totalAmount { get; set; }

        /// <summary>
        /// 供应商外币总价
        /// </summary>
        public decimal totalSupplierForeignAmount { get; set; }

        /// <summary>
        /// 供应商外币币种
        /// </summary>
        public String supplierForeignCurrencyCode { get; set; }
    }

    public class RoomInfo
    {
        /// <summary>
        /// 每间房间确认号
        /// </summary>
        public string supplierConfirmationNo { get; set; }
    }

}
