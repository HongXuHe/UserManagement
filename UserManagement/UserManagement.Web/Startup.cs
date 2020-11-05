using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UserManagement.Entity;
using UserManagement.Repository;
using UserManagement.Utility.AutofacModule;
using UserManagement.Web.AutoFacModules;
using Utility;

namespace UserManagement.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<UserManagementContext>(config =>
            {
               var sqlType = Configuration.GetSection("DbType").Value;
                var connstr = Configuration.GetConnectionString("connStr");

                switch (sqlType)
                {

                    case "SqlServer":
                        config.UseSqlServer(connstr);
                        break;
                    case "MySql":
                        config.UseMySql(connstr);
                        break;
                    default: config.UseSqlServer(connstr);
                        break;
                }
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            // builder.RegisterModule<RepoModule>();
            builder.RegisterModule<RepositoryModule>();
        }
      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");               
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }     
    }
}
