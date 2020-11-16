using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.IRepository;

namespace UserManagement.Winform.CommonClass
{
    /// <summary>
    /// get user permissions
    /// </summary>
    public class RetrieveUserPermissions
    {
        public static List<string> Permissions = new List<string>();
        public static List<string> GetPermissions(string userEmail, IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo)
        {
            var user = userRepo.FindSingle(x => x.Email == userEmail);
            if (user != null)
            {
                //add user-role-permissions
                var userRoles = roleRepo.GetList(r => user.ApplicationRoles.Select(x => x.ApplicationRoleId).Contains(r.Id)).ToList();
                foreach (var rolePermission in userRoles)
                {
                    var permissions = roleRepo.GetRolePermissions(rolePermission.Id).ToList();
                    foreach (var per in permissions)
                    {
                        if (!Permissions.Contains(per.PermissionName))
                        {
                            Permissions.Add(per.PermissionName);
                        }

                    }

                }
                //add user-permissions
                var userPermissions = userRepo.GetUserPermissions(user.Id).ToList();
                foreach (var per in userPermissions)
                {
                    if (!Permissions.Contains(per.PermissionName))
                    {
                        Permissions.Add(per.PermissionName);
                    }
                }
            }
            return Permissions;
        } 
    }
}
