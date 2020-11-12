using System.Threading.Tasks;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.UnitOfWok
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserManagementContext _context;
        public IUserRepo UserRepo { get; }
        public IPermissionRepo PermissionRepo { get; }

        public UnitOfWork(UserManagementContext context,IUserRepo userRepo, IPermissionRepo permissionRepo)
        {
            _context = context;
            UserRepo = userRepo;
            PermissionRepo = permissionRepo;
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
