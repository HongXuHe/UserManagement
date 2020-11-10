using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace UserManagement.Dtos
{
    public class UserDto
    {
        public string UserName { get; set; }
        public DateTime EffectDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Description { get; set; }
        public UserStatus UserState { get; set; }
    }
}
