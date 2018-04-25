using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        static void Main(string[] args)
        {

            string str = " ";
            Console.WriteLine(string.IsNullOrEmpty(str.Trim()));
            var supplierOrderCodes = str.Trim().Split('|');
            Console.ReadKey();
            return;

            try
            {
                int i = 0;
                decimal k = 12 / i;
            }
            catch
            {
                return;
            }
            Console.WriteLine("test12345");

            ReceiveDelegateArgsFunc((i) => 
            {
                return (i + 1).ToString();
            });
            Console.ReadKey();
        }

        public static void ReceiveDelegateArgsFunc(Func<int, string> func)
        {
            Console.WriteLine(func(21));
        }
    }
}
