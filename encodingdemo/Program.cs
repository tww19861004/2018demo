using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encodingdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "百顺打家截道进城旱";
            int i = System.Text.Encoding.Default.GetBytes(str).Length;
            int j = str.Length;


            string input = "唐伟伟";
            var result = Encoding.Default.GetBytes(input);
        }
    }
}
