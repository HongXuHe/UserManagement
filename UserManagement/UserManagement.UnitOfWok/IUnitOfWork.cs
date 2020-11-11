using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagement.IRepository;

namespace UserManagement.UnitOfWok
{
    public interface IUnitOfWork
    {
        IUserRepo UserRepo { get; }
        IPermissionRepo PermissionRepo { get; }
        int SaveChanges();
        Task<int> SaveChangeAsync();
    }
}
