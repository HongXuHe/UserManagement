using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserManagement.Entity
{
    public class BaseEntity
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// create time
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// created by 
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// modified time  
        /// </summary>
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// modified by
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// soft delete
        /// </summary>
        public bool SoftDelete { get; set; } = false;

        /// <summary>
        /// remark
        /// </summary>
        public string Remark { get; set; }
    }
}
