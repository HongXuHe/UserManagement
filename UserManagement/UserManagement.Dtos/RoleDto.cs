using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagement.Dtos
{
    public class RoleDto
    {
        /// <summary>
        /// role name
        /// </summary>
        [Required]
        public string RoleName { get; set; }

        /// <summary>
        /// role desc
        /// </summary>
        public string RoleDesc { get; set; }
    }
}
