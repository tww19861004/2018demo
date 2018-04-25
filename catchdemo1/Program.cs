using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catchdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = string.Empty;
            string s2 = s1 + "tww";
            try
            {
                TryCatchtest();
            }
            catch (Exception ex)
            {

            }
            Console.ReadKey();
        }

        static void TryCatchtest()
        {
            try
            {
                int i = 0;
                decimal result = 10 / i;
            }
            catch
            {

            }
        }
    }
}
