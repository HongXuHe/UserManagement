using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Entity
{
    public class R_Role_Permission
    {
        #region Navigation

        /// <summary>
        /// role id
        /// </summary>
        public Guid ApplicationRoleId { get; set; }

        /// <summary>
        /// permission id
        /// </summary>
        public Guid ApplicationPermissionId { get; set; }
        #endregion

    }
}
