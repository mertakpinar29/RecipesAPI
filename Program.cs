using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace RecipesAPI
{
    public class Program
    {
        // host is an object that encapsulates an app's resources (dependency injection,configuration...)
        // The host is typically configured, built, and run by code in the Program class. The Main method:
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // The host provides services that are available to the Startup class constructor. (IConfiguration)
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
