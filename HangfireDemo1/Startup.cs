using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace HangfireDemo1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddHangfire(r => r.UseSqlServerStorage("Data Source=.;Initial Catalog=HangfireDemo;User ID=sa;Password=123456"));            
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            //指定Hangfire使用内存存储后台任务信息
            GlobalConfiguration.Configuration.UseMemoryStorage();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //启用HangfireServer这个中间件（它会自动释放）
            //app.UseHangfireServer();
            //启用Hangfire的仪表盘（可以看到任务的状态，进度等信息）
            //app.UseHangfireDashboard();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
