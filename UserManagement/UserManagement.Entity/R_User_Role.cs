using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserManagement.Entity
{
    public class R_User_Role
    {
        #region Navigation

        /// <summary>
        /// userid
        /// </summary>
         [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("ApplicationRole")]
        public Guid ApplicationRoleId { get; set; }
        public virtual ApplicationRole ApplicationRole { get; set; }

        #endregion

    }
}
