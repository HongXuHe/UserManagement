using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UserManagement.Utility.AutofacModule
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemRepo = Assembly.Load("UserManagement.Repository");
            builder.RegisterAssemblyTypes(assemRepo).Where(t => t.Name.EndsWith("Repo") && t.Name != "BaseRepo")
                .AsImplementedInterfaces();
            var assemUOW = Assembly.Load("UserManagement.UnitOfWok");
            builder.RegisterAssemblyTypes(assemUOW).Where(t => !t.IsInterface).AsImplementedInterfaces();
          //  builder.RegisterType(typeof(UnitOfWork)).As<IUnitOfWork>();
        }
    }
}
