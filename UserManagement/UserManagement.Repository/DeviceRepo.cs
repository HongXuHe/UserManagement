using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.Repository
{
    public class DeviceRepo:BaseRepo<Device>, IDeviceRepo
    {
        private readonly UserManagementContext _context;

        public DeviceRepo(UserManagementContext context):base(context)
        {
            _context = context;
        }
    }
}
