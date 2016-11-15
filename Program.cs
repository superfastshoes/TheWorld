using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace TheWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build a web host that will start listening for request
            var host = new WebHostBuilder()
                //Name of server that you will probably be using under ASP.Net Core
                .UseKestrel()
                //Tells you where the content is for this project, currentDirectory
                .UseContentRoot(Directory.GetCurrentDirectory())
                //Support for several things, including authentication
                .UseIISIntegration()
                //Going to have a class called startup, and instantiate it when you start the webhost 
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
