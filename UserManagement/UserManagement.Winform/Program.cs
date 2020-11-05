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
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Entity;
using UserManagement.IRepository;
using UserManagement.Repository;
using UserManagement.UnitOfWok;
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
                     #region Dependency Injection

                     var formsAssem = Assembly.Load("UserManagement.Winform");
                     foreach (var formType in formsAssem.GetTypes().Where(t => t.IsSubclassOf(typeof(Form))))
                     {
                         services.AddScoped(formType);
                     }
                     services.AddScoped<IUnitOfWork, UnitOfWok.UnitOfWork>();
                     var assIRepos = Assembly.Load("UserManagement.IRepository");
                     var assRepos = Assembly.Load("UserManagement.Repository");
                     foreach (var itype in assIRepos.GetTypes().Where(t => t.IsInterface && !t.IsGenericType))
                     {
                         foreach (var type in assRepos.GetTypes().Where(t => t.Name.EndsWith("Repo")))
                         {
                             if (itype.IsAssignableFrom(type))
                             {
                                 services.AddScoped(itype, type);
                             }
                         }
                     };
                     #endregion



                     #region Logger
                     var logger = new LoggerConfiguration()
                                    .WriteTo.File("logs\\log.txt", rollingInterval: RollingInterval.Day)
                                    .CreateLogger();
                     Log.Logger = logger;
                     #endregion
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
                    Log.Logger.Fatal("Application Failed to Start,{reason}", ex.InnerException);
                }
            }
        }

    }
}
