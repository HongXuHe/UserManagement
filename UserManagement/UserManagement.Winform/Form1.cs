using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.Winform
{
    public partial class Form1 : Form
    {
        private readonly IUserRepo _userRepo;
        private readonly UserManagementContext _context;

        public Form1(UserManagementContext context)
        {
            
            InitializeComponent();
            _context = context;
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            Log.Information("form1{time}",DateTime.Now);
            var list = _context.ApplicationUsers.ToList();
        }
    }
}
