using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserManagement.Entity;

namespace UserManagement.IRepository
{
    public interface IUserRepo : IBaseRepo<ApplicationUser>
    {
        /// <summary>
        /// get user roles
        /// </summary>
        /// <param name="userId">user id</param>
        /// <returns>application role list</returns>
        IQueryable<ApplicationRole> GetUserRoles(Guid userId);

        /// <summary>
        /// get user permissions
        /// </summary>
        /// <param name="userId">user id</param>
        /// <returns>list of permissions</returns>
        IQueryable<ApplicationPermission> GetUserPermissions(Guid userId);
    }
}
