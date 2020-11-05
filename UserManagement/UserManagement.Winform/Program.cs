using Autofac;
using Autofac.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Entity;
using UserManagement.Utility.AutofacModule;

namespace UserManagement.Winform
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                 {
                     services.AddDbContext<UserManagementContext>(config =>
                     {
                         var connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                         config.UseSqlServer(connStr);
                     });
                     services.AddScoped<Form1>();
                    // Bootstrap();

                     var logger = new LoggerConfiguration()
                         .WriteTo.File("logs\\log.txt",rollingInterval:RollingInterval.Day)
                         .CreateLogger();
                     Log.Logger = logger;
                 });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    Log.Logger.Information("Application Starts");
                    var form1 = services.GetRequiredService<Form1>();
                    Application.Run(form1);
                   
                }
                catch (Exception ex)
                {
                    Log.Logger.Fatal("Application Failed to Start");
                }
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }

      
    }
}
