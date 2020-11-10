using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserManagement.Entity
{
    public class R_User_Permission
    {
        #region Navigation

        /// <summary>
        /// user id
        /// </summary>

        [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// permission id
        /// </summary>
        [ForeignKey("ApplicationPermission")]
        public Guid ApplicationPermissionId { get; set; }
        public virtual ApplicationPermission ApplicationPermission { get; set; }

        #endregion

    }
}
