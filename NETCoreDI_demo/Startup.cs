using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreDI_demo
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {

        }
        //IServiceCollection 负责注册
        //IServiceProvider 负责提供实例
        public void ConfigureServices(IServiceCollection services)
        {
            var serviceCollection = new ServiceCollection()
              // 默认构造
              .AddTransient<IOperationSingleton, Operation>()
              // 自定义传入Guid空值
              .AddSingleton<IOperationSingleton>(new Operation(Guid.Empty))
              // 自定义传入一个New的Guid
              .AddSingleton<IOperationSingleton>(new Operation(Guid.NewGuid()));

            var provider = services.BuildServiceProvider();

            //我们对IOperationSingleton注册了三次，最后获取两次，
            //大家要注意到我们获取到的始终都是我们最后一次注册的那个给了一个Guid的实例，前面的会被覆盖。

            // 输出singletone1的Guid
            var singletone1 = provider.GetService<IOperationSingleton>();
            Console.WriteLine($"signletone1: {singletone1.OperationId}");

            // 输出singletone2的Guid
            var singletone2 = provider.GetService<IOperationSingleton>();
            Console.WriteLine($"signletone2: {singletone2.OperationId}");
            Console.WriteLine($"singletone1 == singletone2 ? : { singletone1 == singletone2 }");

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

        }
    }
}
