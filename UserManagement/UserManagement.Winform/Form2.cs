using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Form2 : Form
    {
        private readonly UserManagementContext _context;
        private readonly IUserRepo _userRepo;
        private readonly IServiceProvider _serviceProvider;

        public Form2(UserManagementContext context, IUserRepo userRepo, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _userRepo = userRepo;
            _serviceProvider = serviceProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userList = _userRepo.GetList(x => true).ToList();
        }
    }
}
