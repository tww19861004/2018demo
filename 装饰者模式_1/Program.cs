using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式_1
{
    public interface IComponent
    {
        void Operation();//一个抽象的职责
    }
    public static class ComponentExtends
    {
        public static void Discription(this IComponent component)
        {
            Console.WriteLine("装饰操作：");
            component.Operation();
        }
    }
    public class ObjectA : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("对象A的操作");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ObjectA a = new ObjectA();
            a.Discription();
            Console.ReadKey();
        }
    }
}
