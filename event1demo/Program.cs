using System;
using System.Collections.Generic;
using System.Text;

namespace UsingEvent
{
    //https://www.cnblogs.com/zhangchenliang/archive/2012/09/19/2694430.html
    //https://blog.csdn.net/qq_18995513/article/details/54960293

    public delegate void ClickEventHandler(object sender, ClickEvnentArgs e);//声明一个代表：请看文章最后面Note

    public class ClickEvnentArgs: EventArgs
    {
        public int id { get; set; }
    }

    public class MyButton              //创建MyButton
    {
        public event ClickEventHandler ClickEvent;//声明一个事件

        public void Click()                                 //单击MyButton
        {
            if (ClickEvent != null)
            {
                Console.WriteLine("MyButton: 我被单击了");
                ClickEvent(this, new ClickEvnentArgs() { id = System.Threading.Thread.CurrentThread.ManagedThreadId});                          //抛出事件，给所有相应者
            }
        }
    }

    public class MyForm
    {
        public MyButton myButton = new MyButton();

        public MyForm()
        {
            //添加事件到myButton中，当myButton被单击的时候就会调用相应的处理函数
            myButton.ClickEvent += new ClickEventHandler(OnClickEvent);
        }

        //事件处理函数
        void OnClickEvent(object sender, ClickEvnentArgs e)
        {
            Console.WriteLine("MyForm: 我知道你被单击了！"+e.id.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();//生成一个MyForm

            form.myButton.Click();//单击MyForm中的鼠标，效果就出来了

            Console.ReadKey();
        }
    }
}
