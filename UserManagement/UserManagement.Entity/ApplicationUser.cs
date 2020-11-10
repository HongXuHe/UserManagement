using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Utility;

namespace UserManagement.Entity
{
    public class ApplicationUser:BaseEntity
    {
        #region Attributes

        /// <summary>
        /// user name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// password Salt
        /// </summary>
        public string PasswordSalt { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// user hashed password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// start effective date
        /// </summary>
        public DateTime EffectDate { get; set; } = DateTime.Now;

        /// <summary>
        /// user expire date if exists
        /// </summary>
        public DateTime? ExpireDate { get; set; }

        /// <summary>
        /// login email unique
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// user phone
        /// </summary>
        public string PhoneNo { get; set; }

        /// <summary>
        /// user description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// user state
        /// </summary>
        public UserStatus UserState { get; set; } = UserStatus.Normal;

        public int FalseLogInCount { get; set; } = 0;

        public bool EmailConfirmed { get; set; } = false;
        public DateTime? FrozenTime { get; set; }
        #endregion

        #region Navigation
        public ICollection<R_User_Role> ApplicationRoles { get; set; } = new List<R_User_Role>();
        public ICollection<R_User_Permission> ApplicationPermissions { get; set; } = new List<R_User_Permission>();
        #endregion
    }
}
