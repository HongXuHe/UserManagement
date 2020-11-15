using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserManagement.Entity;

namespace UserManagement.IRepository
{
    public interface IRoleRepo:IBaseRepo<ApplicationRole>
    {
        /// <summary>
        /// get permissions for specific role
        /// </summary>
        /// <param name="roleId">role id</param>
        /// <returns>permissionlist</returns>
        IQueryable<ApplicationPermission> GetRolePermissions(Guid roleId);
    }
}
