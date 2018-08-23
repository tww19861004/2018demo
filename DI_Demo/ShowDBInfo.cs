using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Demo
{
    public class ShowDBInfo: IShowDBInfo
    {
        public void Show()
        {
            Console.WriteLine("show db info");
        }
    }
}
