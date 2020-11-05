using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UserManagement.UnitOfWok;

namespace UserManagement.Web.AutoFacModules
{
    public class RepoModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemRepo = Assembly.Load("UserManagement.Repository");            
            builder.RegisterAssemblyTypes(assemRepo).Where(t => t.Name.EndsWith("Repo") && t.Name != "BaseRepo")
                .AsImplementedInterfaces();
            builder.RegisterType(typeof(UnitOfWork)).As<IUnitOfWork>();
        }
    }
}
