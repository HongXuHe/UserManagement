﻿using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entity;

namespace UserManagement.IRepository
{
    public interface IUserRepo : IBaseRepo<ApplicationUser>
    {
    }
}
