using System;
using System.Collections.Generic;
using System.Text;

namespace UsingDelegate
{
    public delegate void MyDelegate(string mydelegate);//声明一个delegate对象

    public class TestClass
    {

        //实现有相同参数和返回值的函数
        public void HelloDelegate(string mydelegate)
        {
            Console.WriteLine(mydelegate);
        }

        //实现有相同参数和返回值的静态函数

        public static void HelloStaticDelegate(string mystaticdelegate)
        {
            Console.WriteLine(mystaticdelegate);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            MyDelegate mydelegate = new MyDelegate(testClass.HelloDelegate);//产生delegate对象
            mydelegate("Hello delegate");//调用

            MyDelegate myStaticDelegate = new MyDelegate(TestClass.HelloStaticDelegate);//产生delegate对象
            myStaticDelegate("Hello static delegate");//调用

            Console.ReadKey();
        }
    }
}