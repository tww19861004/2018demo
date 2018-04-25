using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "orderId=14431&orderNoOfSupplier=1412&status=1&supplierForeignCurrencyCode=CNY&supplierOrderCode=1313411,3212&takeOff=3231&totalAmount=32324.23&totalSupplierForeignAmount=32324.23&md5Key=TE";
            string i = MD5Encrypt1(str);
            string j = "F2AA963ABB871E17E6BEB8381BC5085F";
            int test = string.Compare(i, j, true);
        }

        public static string MD5Encrypt1(string pToEncrypt)
        {
            var md5 = new MD5CryptoServiceProvider();
            var t = md5.ComputeHash(Encoding.UTF8.GetBytes(pToEncrypt));
            var sb = new StringBuilder(32);
            for (var i = 0; i < t.Length; i++)
                sb.Append(t[i].ToString("x").PadLeft(2, '0'));
            return sb.ToString();
        }
    }
}
