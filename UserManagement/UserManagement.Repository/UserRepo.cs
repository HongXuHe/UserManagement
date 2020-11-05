using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.Repository
{
    public class UserRepo:BaseRepo<ApplicationUser>,IUserRepo
    {
        private readonly UserManagementContext _context;

        public UserRepo(UserManagementContext context):base(context)
        {
            _context = context;
        }
    }
}
