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
                int i = ex.LineNumber();
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
            catch(Exception ex)
            {
                int i1 = ex.LineNumber();
                //throw; // 19行的 ex.stacktrack捕获不到具体报错
                //throw new Exception("出错啦！", ex);
                //throw;
                throw new Exception("出错啦！");
            }
        }
    }

    public static class ExceptionHelper
    {
        public static int LineNumber(this Exception e)
        {

            int linenum = 0;
            try
            {
                //linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(":line") + 5));

                //For Localized Visual Studio ... In other languages stack trace  doesn't end with ":Line 12"
                linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(' ')));

            }


            catch
            {
                //Stack trace is not available!
            }
            return linenum;
        }
    }
}
