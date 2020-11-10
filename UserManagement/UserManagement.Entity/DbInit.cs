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
            var permissionWeighing = new ApplicationPermission()
            {
                PermissionName = "Weighing",
                PermissionValue = "Weighing"
            };
            var permissionProduct = new ApplicationPermission()
            {
                PermissionName = "Product",
                PermissionValue = "Product"
            };
            var permissionWeighingCreate = new ApplicationPermission()
            {
                PermissionName = "Weighing_Create",
                PermissionValue = "Weighing_Create",
                ParentId =permissionWeighing.Id.ToString()
            };
            var permissionWeighingEdit = new ApplicationPermission()
            {
                PermissionName = "Weighing_Edit",
                PermissionValue = "Weighing_Edit",
                ParentId = permissionWeighing.Id.ToString()
            };
            var permissionWeighingDelete = new ApplicationPermission()
            {
                PermissionName = "Weighing_Delete",
                PermissionValue = "Weighing_Delete",
                ParentId = permissionWeighing.Id.ToString()
            };
            var permissionProductCreate = new ApplicationPermission()
            {
                PermissionName = "Product_Create",
                PermissionValue = "Product_Create",
                ParentId = permissionProduct.Id.ToString()
            };
            var permissionProductEdit = new ApplicationPermission()
            {
                PermissionName = "Product_Edit",
                PermissionValue = "Product_Edit",
                ParentId = permissionProduct.Id.ToString()
            };
            var permissionProductDelete = new ApplicationPermission()
            {
                PermissionName = "Product_Delete",
                PermissionValue = "Product_Delete",
                ParentId = permissionProduct.Id.ToString()
            };
            user.Password = Md5Encrypt.GetMD5Hash(user.PasswordSalt + "1234");
            context.ApplicationUsers.Add(user);
            context.ApplicationUsers.Add(user2);
            context.ApplicationRoles.Add(role);
            context.ApplicationPermissions.Add(permissionWeighing);
            context.ApplicationPermissions.Add(permissionProduct);
            context.ApplicationPermissions.Add(permissionWeighingCreate);
            context.ApplicationPermissions.Add(permissionWeighingEdit);
            context.ApplicationPermissions.Add(permissionWeighingDelete);
            context.ApplicationPermissions.Add(permissionProductCreate);
            context.ApplicationPermissions.Add(permissionProductEdit);
            context.ApplicationPermissions.Add(permissionProductDelete);
            context.R_User_Roles.Add(new R_User_Role() { ApplicationRoleId = role.Id, ApplicationUserId = user.Id });
            context.SaveChanges();
        }
    }
}
