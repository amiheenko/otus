using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace k8s.homework
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args)
                .Build()
                .RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://0.0.0.0:8000");
                    webBuilder.UseStartup<Startup>();
                });
    }
}