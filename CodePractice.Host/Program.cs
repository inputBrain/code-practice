using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CodePractice.Host
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var webHost = BuildWebHost(args);
            await InitWebServices(webHost);
            
        }
        
        private static async Task<int> InitWebServices(IWebHost webHost)
        {
            await Task.WhenAll(
                webHost.RunAsync()
            );

            Console.Read();
            await Task.WhenAll(
                webHost.StopAsync()
            );
            Environment.Exit(0);
            return 0;
        }
        
        public static IWebHost BuildWebHost(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
//                .UseUrls(config.GetSection("Url").Value)
                .Build();
        }
    }
    
    
    
}