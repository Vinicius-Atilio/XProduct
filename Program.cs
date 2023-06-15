using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;

namespace api {
    public class Program {
        public static void Main(string[] args) {
            try {
                BuildWebHost(args).Run();
            } catch (Exception) {
                throw;
            }
        }

        private static IWebHost BuildWebHost(string[] args) {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("hosting.json", optional : true)
                .Build();
            return new WebHostBuilder()
                .CaptureStartupErrors(true)
                .UseSetting("detailedErrors", "true")
                .UseKestrel(opt => {
                    opt.AddServerHeader = false;
                })
                .UseConfiguration(config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
        }
    }
}