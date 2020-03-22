using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Claire
{
    public class Program
    {
        public static void Main()
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntergration()
            .UseStartup<Startup>()
            .Build();

            host.Run();
        }
    }
}