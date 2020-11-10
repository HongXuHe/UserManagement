using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserManagement.Entity
{
    public class R_Role_Permission
    {
        #region Navigation

        /// <summary>
        /// role id
        /// </summary>
        [ForeignKey("ApplicationRole")]
        public Guid ApplicationRoleId { get; set; }

        public virtual ApplicationRole ApplicationRole { get; set; }

        /// <summary>
        /// permission id
        /// </summary>
        [ForeignKey("ApplicationPermission")]
        public Guid ApplicationPermissionId { get; set; }
        public virtual ApplicationPermission ApplicationPermission { get; set; }
        #endregion

    }
}
