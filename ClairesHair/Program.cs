using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Claire
{
    public class Program
    {
        public static void Main()
        {
            var host = new WebHostBuilder()
            .useKestrel()
        }
    }
}