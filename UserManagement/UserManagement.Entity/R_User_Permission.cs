using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Entity
{
    public class R_User_Permission
    {
        #region Navigation

        /// <summary>
        /// user id
        /// </summary>
        public Guid ApplicationUserId { get; set; }

        /// <summary>
        /// permission id
        /// </summary>
        public Guid ApplicationPermissionId { get; set; }

        #endregion

    }
}
