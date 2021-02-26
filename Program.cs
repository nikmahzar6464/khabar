using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Domains;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace Khabar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var host = WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
            using (var scope = host.Services.CreateScope())
            {

                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Customer>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<CustomerRole>>();
                MyIdentityDataInitializer.SeedData(userManager, roleManager);
            }
            return host;
        }



    }

}
