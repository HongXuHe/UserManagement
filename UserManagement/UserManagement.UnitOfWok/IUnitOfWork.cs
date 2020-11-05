using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.UnitOfWok
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangeAsync();
    }
}
