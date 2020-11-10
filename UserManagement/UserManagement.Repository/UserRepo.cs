using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.Repository
{
    public class UserRepo : BaseRepo<ApplicationUser>, IUserRepo
    {
        private readonly UserManagementContext _context;

        public UserRepo(UserManagementContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// retrieve user permissions
        /// </summary>
        /// <param name="userId">user id</param>
        /// <returns>permissions</returns>
        public IQueryable<ApplicationPermission> GetUserPermissions(Guid userId)
        {
            return _context.R_User_Permissions.Where(x => x.ApplicationUserId == userId).Select(x => x.ApplicationPermission);
        }

        /// <summary>
        /// retrieve user roles
        /// </summary>
        /// <param name="userId">user id</param>
        /// <returns>user roles</returns>
        public IQueryable<ApplicationRole> GetUserRoles(Guid userId)
        {
            return _context.R_User_Roles.Where(x => x.ApplicationUserId == userId).Select(x => x.ApplicationRole);
        }
    }
}
