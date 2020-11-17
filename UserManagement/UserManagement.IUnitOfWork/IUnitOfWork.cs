using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagement.IRepository;

namespace UserManagement.IUnitOfWork
{
      public interface IUnitOfWork
    {
        IUserRepo UserRepo { get; }
        IRoleRepo RoleRepo { get; }
        IPermissionRepo PermissionRepo { get; }
        IDeviceRepo DeviceRepo { get; }
        int SaveChanges();
        Task<int> SaveChangeAsync();
    }
}
