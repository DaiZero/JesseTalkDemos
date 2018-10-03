using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace OptionsBind
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)//默认读取appsettings.json文件
                .UseStartup<Startup>();
    }
}