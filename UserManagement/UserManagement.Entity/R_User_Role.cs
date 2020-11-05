using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Entity
{
    public class R_User_Role
    {
        #region Navigation

        /// <summary>
        /// userid
        /// </summary>
        public Guid ApplicationUserId { get; set; }

        public Guid ApplicationRoleId { get; set; }

        #endregion

    }
}
