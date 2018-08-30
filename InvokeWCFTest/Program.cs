using InvokeWCFTest.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace InvokeWCFTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string url = "xxx.svc";
            var proxy = WcfInvokeFactory.CreateServiceByUrl<InvokeWCFTest.ServiceReference1.ITemplateWebservice>(url);
            var result = proxy.GetTemplateInfo(new GetTemplateInfoRequest() { templateNo = "12011" });

            return;

            TemplateWebserviceClient client = null;
            TemplateInfo template1 = null;
            try
            {
                client = new TemplateWebserviceClient();
                template1 = new TemplateInfo();
                var res1 = client.GetTemplate("12219", BuildTemplateTagDataCollection(new Dictionary<string, string>() {
                { "checkInDate","2018-09-01 00:00:00.0"}}));
                //var res2 = client.GetTemplateInfo("12011", out template1);

                if (template1!=null)
                {
                    if(template1.TemplateTagsk__BackingField!=null 
                        && template1.TemplateTagsk__BackingField.Any())
                    {
                        foreach (var item in template1.TemplateTagsk__BackingField)
                        {

                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                if(client!=null)
                {
                    client.Close();
                }
            }
                                    
            //string url = "http://hotelapi.vip.elong.com/TemplateService/TemplateService.svc";
            //GetTemplateInfoRequest request = new GetTemplateInfoRequest() { templateNo = "12011" };
            //var proxy = WcfInvokeFactory.CreateServiceByUrl<ITemplateWebservice>(url);
            //try
            //{
            //    var response1 = proxy.GetTemplateInfo(request);                
            //    Response response = proxy.GetTemplate("12011", null);
            //}
            //catch (Exception ex)
            //{

            //}
        }

        /// <summary>
        /// 获取模板对象
        /// </summary>
        /// <param name="templateParams"></param>
        /// <returns></returns>
        public static TemplateTagDataCollection BuildTemplateTagDataCollection(
                Dictionary<String, String> templateParams)
        {
            // 模板的业务对象
            TemplateTagDataCollection tagDataCollection = new TemplateTagDataCollection();
            tagDataCollection.Dictionary = new Dictionary<string, TemplateTagData>();

            foreach (var entry in templateParams)
            {
                if (entry.Value == null)
                {
                    continue;
                }
                if (entry.Value.StartsWith("LISTS:"))
                {
                    // 判断入参是list,list里边是一个map

                    // 模板数据集合
                    TemplateTagData valueDate = new TemplateTagData();
                    List<TemplateTagDataCollection> childTags = new List<TemplateTagDataCollection>();
                    string json = (entry.Value).Trim().Substring(
                                    "LISTS:".Length,
                                    entry.Value.Length);
                    List<Dictionary<string, string>> paramsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(json);

                    // 设置集合的lists
                    valueDate.TagKey = entry.Key.Trim();

                    foreach (var paraMaps in paramsList)
                    {
                        childTags.Add(BuildTemplateTagDataCollection(paraMaps));

                    }
                    valueDate.ChildTag = childTags.ToArray();
                    tagDataCollection.Dictionary.Add(entry.Key.Trim(), valueDate);

                }
                else
                {
                    // 模板内容对象

                    TemplateTagData valueDate = new TemplateTagData();
                    valueDate.TagValue = entry.Value != null ? entry.Value.Trim() : null;
                    valueDate.TagKey = (null);// 默认为null
                    valueDate.ChildTag = (null);// 默认为null

                    tagDataCollection.Dictionary.Add(entry.Key.Trim(), valueDate);

                }
            }
            return tagDataCollection;
        }
    }
}
