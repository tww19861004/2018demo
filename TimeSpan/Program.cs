using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpan1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            System.Threading.Thread.Sleep(1000);
            DateTime d2 = DateTime.Now.AddDays(2);
            TimeSpan ts = d2 - d1;
            var s = ts.ToString(@"dd\:hh\:mm\:ss");
            var s1 = TimeSpan.FromMilliseconds(ts.TotalMilliseconds).ToString(@"dd\:hh\:mm\:ss");
        }
    }
}
