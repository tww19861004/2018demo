using InvokeWCFTest.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvokeWCFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "1111";
            
            var proxy = WcfInvokeFactory.CreateServiceByUrl<ITemplateWebservice>(url);
            Response response = proxy.GetTemplate("12011", null);
                
                int result = 1;
        }
    }
}
