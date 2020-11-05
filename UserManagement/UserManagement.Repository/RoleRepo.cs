using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.Repository
{
    public class RoleRepo:BaseRepo<ApplicationRole>,IRoleRepo
    {
        private readonly UserManagementContext _context;

        public RoleRepo(UserManagementContext context):base(context)
        {
            _context = context;
        }
    }
}
