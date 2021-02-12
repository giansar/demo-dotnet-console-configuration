using System;
using Microsoft.Extensions.Configuration;

namespace demo_dotnet_console_configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
            Console.WriteLine(configuration["name"]);
        }
    }
}
