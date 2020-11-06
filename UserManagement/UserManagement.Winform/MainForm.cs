﻿using Microsoft.EntityFrameworkCore;
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
using UserManagement.Winform.CommonControls;

namespace UserManagement.Winform
{
    public partial class MainForm : Form
    {
        private readonly IUserRepo _userRepo;
        private readonly IServiceProvider _ServiceProvider;
        public string UserEmail { get; set; }

        public MainForm(IUserRepo userRepo,IServiceProvider serviceProvider)
        {
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(UserManagement.Winform.Properties.Resources.nwiclient);
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            txtUser.Text = UserEmail;
            plMain.BackgroundImage = UserManagement.Winform.Properties.Resources.bg_MainWindow;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            plMain.Controls.Clear();
            plMain.BackgroundImage = UserManagement.Winform.Properties.Resources.bg_MainWindow;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
}
