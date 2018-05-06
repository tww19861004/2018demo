using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace webdemo1
{
    //https://www.cnblogs.com/TeemoHQ/p/6826022.html
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var config = new ConfigurationBuilder()
.AddInMemoryCollection()    //将配置文件的数据加载到内存中
.SetBasePath(Directory.GetCurrentDirectory())   //指定配置文件所在的目录
.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)  //指定加载的配置文件
.Build();    //编译成对象 

            Console.WriteLine(config["test"]);  //获取配置中的数据
            config["test"] = "test test";   //修改配置对象的数据，配置对象的数据是可以被修改的
            Console.WriteLine(config["test11"]);    //获取配置文件中不存在数据也是不会报错的
            Console.WriteLine(config["theKey:nextKey"]);    //获取：theKey -> nextKey 的值
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
