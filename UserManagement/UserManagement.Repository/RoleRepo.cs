using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.Repository
{
    public class RoleRepo : BaseRepo<ApplicationRole>, IRoleRepo
    {
        private readonly UserManagementContext _context;

        public RoleRepo(UserManagementContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// get permission for certain role
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns>list of permissions</returns>
        public IQueryable<ApplicationPermission> GetRolePermissions(Guid roleId)
        {
            return _context.R_Role_Permissions.Include(x => x.ApplicationPermission)
                .Where(x => x.ApplicationRoleId == roleId).Select(x => x.ApplicationPermission);

        }
        public override ApplicationRole FindSingle(Expression<Func<ApplicationRole, bool>> whereLambda)
        {
            return _context.ApplicationRoles.Include(x => x.ApplicationUsers).ThenInclude(y => y.ApplicationUser).Include(x => x.ApplicationPermissions).ThenInclude(z => z.ApplicationPermission)
                  .SingleOrDefault(whereLambda);
        }
    }
}
