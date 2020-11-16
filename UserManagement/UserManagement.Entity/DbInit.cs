using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserManagement.Utility;

namespace UserManagement.Entity
{
    public class DbInit
    {
        public static void InitDb(UserManagementContext context)
        {

            context.Database.EnsureCreated();
            if (context.ApplicationUsers.Any()) return;
            var role = new ApplicationRole()
            {
                RoleName = "Admin",
            };
            var user = new ApplicationUser()
            {
                Email = "Matt@gmail.com",
                UserName = "MattHe",
                PhoneNo = "12345678",                 
            };
            var user2 = new ApplicationUser()
            {
                Email = "Matt1@gmail.com",
                UserName = "MattHe1",
                PhoneNo = "12345678",
            };
            var permissionUser = new ApplicationPermission()
            {
                PermissionName = "User",
                PermissionValue = "User"
            };
            var permissionRole = new ApplicationPermission()
            {
                PermissionName = "Role",
                PermissionValue = "Role"
            };
            var permissionUserCreate = new ApplicationPermission()
            {
                PermissionName = "User_Create",
                PermissionValue = "User_Create",
                ParentId =permissionUser.Id.ToString()
            };
            var permissionUserEdit = new ApplicationPermission()
            {
                PermissionName = "User_Edit",
                PermissionValue = "User_Edit",
                ParentId = permissionUser.Id.ToString()
            };
            var permissionUserDelete = new ApplicationPermission()
            {
                PermissionName = "User_Delete",
                PermissionValue = "User_Delete",
                ParentId = permissionUser.Id.ToString()
            };
            var permissionRoleCreate = new ApplicationPermission()
            {
                PermissionName = "Role_Create",
                PermissionValue = "Role_Create",
                ParentId = permissionRole.Id.ToString()
            };
            var permissionRoleEdit = new ApplicationPermission()
            {
                PermissionName = "Role_Edit",
                PermissionValue = "Role_Edit",
                ParentId = permissionRole.Id.ToString()
            };
            var permissionRoleDelete = new ApplicationPermission()
            {
                PermissionName = "Role_Delete",
                PermissionValue = "Role_Delete",
                ParentId = permissionRole.Id.ToString()
            };
            user.Password = Md5Encrypt.GetMD5Hash(user.PasswordSalt + "1234");
            context.ApplicationUsers.Add(user);
            context.ApplicationUsers.Add(user2);
            context.ApplicationRoles.Add(role);
            context.ApplicationPermissions.Add(permissionUser);
            context.ApplicationPermissions.Add(permissionRole);
            context.ApplicationPermissions.Add(permissionUserCreate);
            context.ApplicationPermissions.Add(permissionUserEdit);
            context.ApplicationPermissions.Add(permissionUserDelete);
            context.ApplicationPermissions.Add(permissionRoleCreate);
            context.ApplicationPermissions.Add(permissionRoleEdit);
            context.ApplicationPermissions.Add(permissionRoleDelete);
            context.R_User_Roles.Add(new R_User_Role() { ApplicationRoleId = role.Id, ApplicationUserId = user.Id });
            context.SaveChanges();
        }
    }
}
