using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace NETCoreDI_demo
{
    /*
    Transient： 每一次GetService都会创建一个新的实例
    Scoped：  在同一个Scope内只初始化一个实例 ，可以理解为（ 每一个request级别只创建一个实例，同一个http request会在一个 scope内）
    Singleton ：整个应用程序生命周期以内只创建一个实例 
     * */
    public interface IOperation
    {
        Guid OperationId { get; }
    }
    public interface IOperationSingleton : IOperation { }
    public interface IOperationTransient : IOperation { }
    public interface IOperationScoped : IOperation { }

    public class Operation : IOperationSingleton, IOperationTransient, IOperationScoped
    {
        private Guid _guid;

        public Operation()
        {
            _guid = Guid.NewGuid();
        }

        public Operation(Guid guid)
        {
            _guid = guid;
        }

        public Guid OperationId => _guid;
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //https://www.cnblogs.com/jesse2013/p/di-in-aspnetcore.html
            var services = new ServiceCollection()
            .AddScoped<IOperationScoped, Operation>()
            .AddTransient<IOperationTransient, Operation>()
            .AddSingleton<IOperationSingleton, Operation>();

            var provider = services.BuildServiceProvider();
            using (var scope1 = provider.CreateScope())
            {
                var p = scope1.ServiceProvider;
                var scopeobj1 = p.GetService<IOperationScoped>();
                var transient1 = p.GetService<IOperationTransient>();
                var singleton1 = p.GetService<IOperationSingleton>();

                var scopeobj2 = p.GetService<IOperationScoped>();
                var transient2 = p.GetService<IOperationTransient>();
                var singleton2 = p.GetService<IOperationSingleton>();

                Console.WriteLine(
                    $"scope1: { scopeobj1.OperationId },\r\n" +
                    $"transient1: {transient1.OperationId},\r\n " +
                    $"singleton1: {singleton1.OperationId}\r\n");

                Console.WriteLine($"scope2: { scopeobj2.OperationId },\r\n " +
                    $"transient2: {transient2.OperationId}, \r\n" +
                    $"singleton2: {singleton2.OperationId}\r\n");
            }
            Console.ReadKey();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                //UseUrls方法注册了两个监听地址
                .UseUrls("http://localhost:8888/", "http://localhost:9999/")
                .UseStartup<Startup>()
                .Build();
    }
}
