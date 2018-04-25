using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event2demo
{
    // 定义Event前必须先定义Delegate
    public delegate void SendMsg(string msg);

    // 模拟服务端 推送消息
    public class Server
    {
        // 事件是委托的实例对象
        public static event SendMsg sendMsgEvent;

        // 服务器端推送消息给客户端的方法
        public void SendMsg(string msg)
        {
            Console.WriteLine("服务器端开始推送消息！");

            // sendMsgEvent由客户端初始化，如果它不为空，即表示客户端订阅了该事件
            // 执行委托（执行事件，就是执行它注册的方法）
            sendMsgEvent?.Invoke(msg);
        }
    }

    // 表示手机客户端 订阅消息推送事件
    class Client
    {
        // 订阅事件：客户端订阅服务端推送消息的功能
        public void Subscription()
        {
            Console.WriteLine("客户端订阅了推送事件！");
            Server.sendMsgEvent += Server_sendMsgEvent; // 实例化，给事件绑定方法
        }

        private void Server_sendMsgEvent(string msg)
        {
            Console.WriteLine("客户端接收到的推送消息：" + msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Server server = new Server();

            // 客户端订阅消息
            client.Subscription();
            // 服务端推送消息
            server.SendMsg("我就是推送的消息！");

            Console.ReadKey();
        }
    }
}
