using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagement.Entity
{
    public class ApplicationPermission : BaseEntity
    {
        #region Attribute

        /// <summary>
        /// permission name
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// permission value
        /// </summary>       
        public string PermissionValue { get; set; }

        /// <summary>
        /// parent permission
        /// </summary>
        public string ParentId { get; set; }
        #endregion

        #region Navigation
        public IReadOnlyCollection<R_User_Permission> ApplicationUsers { get; set; } = new List<R_User_Permission>();
        public IReadOnlyCollection<R_Role_Permission> ApplicationRoles { get; set; } = new List<R_Role_Permission>();
        #endregion

    }
}
