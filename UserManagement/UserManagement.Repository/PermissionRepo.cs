using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.Repository
{
    public class PermissionRepo:BaseRepo<ApplicationPermission>,IPermissionRepo
    {
        private readonly UserManagementContext _context;

        public PermissionRepo(UserManagementContext context) : base(context)
        {
            _context = context;
        }
    }
}
