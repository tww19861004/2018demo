using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic在net下运行js函数
{
    class Program
    {
        static void Main(string[] args)
        {
            var eng = new Jurassic.ScriptEngine();
            eng.Evaluate("function text(){return JSON.stringify( {'a':10,'b':20});}");
            var rs = eng.CallGlobalFunction<string>("text");
            //var model = Util.SerializerJsonOrEntity.GetObject<model>(rs);
            //Console.WriteLine(model.a);
            Console.Read();
        }
    }
    public class model
    {
        public int a { get; set; }
        public int b { get; set; }
    }
}
