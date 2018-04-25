using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event4demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //实例化对象
            Mom mom = new Mom();
            Dad dad = new Dad();
            Child child = new Child();

            //将爸爸和孩子的Eat方法注册到妈妈的Eat事件
            //订阅妈妈开饭的消息
            mom.Eat += dad.Eat;
            mom.Eat += child.Eat;

            //调用妈妈的Cook事件
            mom.Cook();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }

    public class Mom
    {
        //定义Eat事件，用于发布吃饭消息
        public event Action Eat;

        public void Cook()
        {
            Console.WriteLine("妈妈 : 饭好了");
            //饭好了，发布吃饭消息
            Eat?.Invoke();
        }
    }

    public class Dad
    {
        public void Eat()
        {
            //爸爸去吃饭
            Console.WriteLine("爸爸 : 吃饭了。");
        }
    }

    public class Child
    {
        public void Eat()
        {
            //熊孩子LOL呢，打完再吃
            Console.WriteLine("孩子 : 打完这局再吃。");
        }
    }
}
