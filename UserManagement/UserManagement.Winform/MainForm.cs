using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class MainForm : Form
    {
        private readonly IUserRepo _userRepo;
        private readonly IServiceProvider _ServiceProvider;
        private readonly UserManagementContext _context;

        public MainForm(UserManagementContext context,IUserRepo userRepo,IServiceProvider serviceProvider)
        {
            _context = context;
            _userRepo = userRepo;
            _ServiceProvider = serviceProvider;
            InitializeComponent();     
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
           var form = _ServiceProvider.GetRequiredService<Form2>();
           
            Log.Information("form1{time}",DateTime.Now);
            var list = _userRepo.GetList(x => true).ToList();
            form.Show();
          //  MessageBox.Show(list.Count.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(UserManagement.Winform.Properties.Resources.nwiclient);
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
