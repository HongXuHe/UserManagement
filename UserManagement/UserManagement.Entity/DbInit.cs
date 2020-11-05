using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserManagement.Utility;

namespace UserManagement.Entity
{
    public class DbInit
    {
        public static void InitDb(UserManagementContext context)
        {

            context.Database.EnsureCreated();
            if (context.ApplicationUsers.Any()) return;
            var user = new ApplicationUser()
            {
                Email = "Matt@gmail.com",
                UserName = "MattHe",
                PhoneNo = "12345678"
            };
            user.Password = Md5Encrypt.GetMD5Hash(user.PasswordSalt + "1234");
            context.ApplicationUsers.Add(user);
            context.SaveChanges();
        }
    }
}
