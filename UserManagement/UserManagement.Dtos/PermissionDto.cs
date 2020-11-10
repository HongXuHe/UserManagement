using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagement.Dtos
{
    public class PermissionDto
    {
        public Guid Id { get; set; }
        /// <summary>
        /// permissionName
        /// </summary>
        [Required]
        public string PermissionName { get; set; }

        /// <summary>
        /// permission value
        /// </summary>
        [Required]
        public string PermissionValue { get; set; }


        public string ParentId { get; set; }
    }
}
