using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event3demo
{
    //定义一个事件委托
    public delegate void mcEventHandler();
    //定义一个猫类
    class Cat
    {
        string cName;
        //定义一个猫叫事件
        public event mcEventHandler CatCryEvent;
        public Cat(string name)
        {
            cName = name;
        }
        //当猫叫时候，触发事件
        public void Cry()
        {
            Console.WriteLine(cName + "来了");
            Console.ReadLine();
            //触发事件
            CatCryEvent();
        }
    }

    //定义一个鼠类
    class Mouse
    {
        public string mName;
        //在构造函数中进行订阅
        public Mouse(Cat cat)
        {
            //订阅事件的两种形式
            cat.CatCryEvent += Run;
            cat.CatCryEvent += new mcEventHandler(See);
        }

        private void Run()
        {
            Console.WriteLine("猫来了，" + mName + "先走一步");
        }
        private void See()
        {
            Console.WriteLine("看看猫还在不在");
            Console.ReadLine();
        }
    }

    class Dog
    {
        public string mName;
        public Dog(Cat cat)
        {
            //订阅事件的两种形式
            cat.CatCryEvent += Hello;
        }
        private void Hello()
        {
            Console.WriteLine("你好，");
        }
    }

    //主函数中实例化对象
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Tom");
            Mouse m1 = new Mouse(cat1);
            Dog d1 = new Dog(cat1);
            //调用函数，以触发猫叫事件
            cat1.Cry();

            Console.ReadKey();
        }
    }
}
