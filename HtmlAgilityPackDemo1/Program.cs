using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlAgilityPackDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml("http://tcinnerapi.17usoft.net/ghotel/document.aspx");
            var node = doc.DocumentNode;

            string xpathDiv = @"/html/body/div/h2[1]/span";
            //选择不包含class属性的节点  
            var result = node.SelectNodes(".//span[not(@class)]");
            //选择不包含class和id属性的节点  
            var result1 = node.SelectNodes(".//span[not(@class) and not(@id)]");
            //选择不包含class="expire"的span  
            var result2 = node.SelectNodes(".//span[not(contains(@class,'expire'))]");
            //选择包含class="expire"的span  
            var result3 = node.SelectNodes(".//span[contains(@class,'expire')]");

            HtmlNodeCollection allDivs = doc.DocumentNode.SelectNodes(xpathDiv);
        }
    }
}
