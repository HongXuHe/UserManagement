using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Entity
{
    public class UserManagementContext:DbContext
    {
        public UserManagementContext(DbContextOptions<UserManagementContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ApplicationUser
            modelBuilder.Entity<ApplicationUser>(x =>
            {
                x.HasKey(u => u.Id);
                x.Property(u => u.UserName).IsRequired().HasMaxLength(150);
                x.Property(u => u.Email).IsRequired().HasMaxLength(150);                
            });
            #endregion

            #region ApplicationRole
            modelBuilder.Entity<ApplicationRole>(x =>
            {
                x.HasKey(r => r.Id);
                x.Property(r => r.RoleName).IsRequired().HasMaxLength(150);
            });
            #endregion

            #region ApplicationPermission
            modelBuilder.Entity<ApplicationPermission>(x =>
            {
                x.HasKey(p => p.Id);
                x.Property(p => p.PermissionName).IsRequired().HasMaxLength(200);
                x.Property(p => p.PermissionValue).IsRequired().HasMaxLength(200);
            });
            #endregion

            #region R_User_Role
            modelBuilder.Entity<R_User_Role>(x =>
            {
                x.HasKey(u =>  new { u.ApplicationUserId, u.ApplicationRoleId });
                //x.HasOne(u => u.ApplicationUser).WithMany(z => z.ApplicationRoles).HasForeignKey(x=>x.ApplicationUserId);
                //x.HasOne(r => r.ApplicationRole).WithMany(z => z.ApplicationUsers).HasForeignKey(r => r.ApplicationRoleId);
            });
            #endregion

            #region R_User_Permission
            modelBuilder.Entity<R_User_Permission>(x =>
            {
                x.HasKey(k => new { k.ApplicationUserId, k.ApplicationPermissionId });
            //    x.HasOne(z => z.ApplicationUser).WithMany(c => c.ApplicationPermissions).HasForeignKey(y => y.ApplicationUserId);
            //    x.HasOne(z => z.ApplicationPermission).WithMany(c => c.ApplicationUsers).HasForeignKey(y => y.ApplicationPermissionId);
            });
            #endregion

            #region R_Role_Permission
            modelBuilder.Entity<R_Role_Permission>(x =>
            {
                x.HasKey(k => new { k.ApplicationRoleId, k.ApplicationPermissionId });
                // x.HasOne(z => z.ApplicationRole).WithMany(c => c.ApplicationPermissions).HasForeignKey(y => y.ApplicationRoleId);
               // x.HasOne(z => z.ApplicationPermission).WithMany(c => c.ApplicationRoles).HasForeignKey(y => y.ApplicationPermissionId);
            });
            #endregion
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationPermission> ApplicationPermissions { get; set; }
        public DbSet<R_User_Permission> R_User_Permissions { get; set; }
        public DbSet<R_User_Role> R_User_Roles { get; set; }
        public DbSet<R_Role_Permission> R_Role_Permissions { get; set; }
    }
}
