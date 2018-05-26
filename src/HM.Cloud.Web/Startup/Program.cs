using System;
using System.IO;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HM.Cloud.Web.Startup
{
    [DependsOn(typeof(CloudEntityFrameworkCoreModule))]
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();


            host.Run();
        }
    }
}
