using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagement.Entity
{
    public class ApplicationRole:BaseEntity
    {
        #region Attribute

        /// <summary>
        /// role name
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// role desc
        /// </summary>
        public string RoleDesc { get; set; }
        #endregion

        #region Navigation
        public IReadOnlyCollection<R_User_Role> ApplicationUsers { get; set; } = new List<R_User_Role>();
        public IReadOnlyCollection<R_Role_Permission> ApplicationPermissions { get; set; } = new List<R_Role_Permission>();
        #endregion

    }
}
