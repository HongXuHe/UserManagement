using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entity;

namespace UserManagement.UnitOfWok
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserManagementContext _context;

        public UnitOfWork(UserManagementContext context)
        {
            _context = context;
        }
        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
