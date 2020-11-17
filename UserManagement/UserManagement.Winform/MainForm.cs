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
using UserManagement.Winform.CommonClass;
using UserManagement.Winform.CommonControls;
using UserManagement.Winform.Devices;
using UserManagement.Winform.Roles;
using UserManagement.Winform.Users;

namespace UserManagement.Winform
{
    public partial class MainForm : Form
    {
        #region ctor and props
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        private readonly IServiceProvider _ServiceProvider;
        public string UserEmail { get; set; }
        private List<string> _userPermissions = new List<string>();

        public MainForm(IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo, IServiceProvider serviceProvider)
        {
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            _ServiceProvider = serviceProvider;
            InitializeComponent();
        }
        #endregion

        #region Events

        private void button1_Click(object sender, EventArgs e)
        {

            var form = _ServiceProvider.GetRequiredService<Form2>();

            Log.Information("form1{time}", DateTime.Now);
            var list = _userRepo.GetList(x => true).ToList();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _userPermissions = RetrieveUserPermissions.GetPermissions(UserEmail, _userRepo, _roleRepo, _permissionRepo);
            if (!_userPermissions.Contains("User_Create"))
            {
                createUserToolStripMenuItem.Visible = false;
            }
            if (!_userPermissions.Contains("Role_Create"))
            {
                newRoleToolStripMenuItem.Visible = false;
            }

            var bmp = new Bitmap(UserManagement.Winform.Properties.Resources.nwiclient);
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            txtUser.Text = UserEmail;
            plMain.BackgroundImage = UserManagement.Winform.Properties.Resources.bg_MainWindow;
            var btnDataSubList = _userRepo.GetDataBaseTables(x => (!x.Contains("Role") && !x.Contains("ApplicationUser") && !x.Contains("ApplicationPermission") && !x.Contains("R_"))).ToList();
            var btnIdentitySublist = _userRepo.GetDataBaseTables(x => ((x.Contains("ApplicationRole") || x.Contains("ApplicationUser") || x.Contains("ApplicationPermission")) && !x.Contains("R_"))).ToList();
            // dynamically add table into btnData DropDownList
            btnData.DropDownItems.Clear();
            foreach (var item in btnDataSubList)
            {
                btnData.DropDownItems.Add(item.Substring(22));
            }
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

        /// <summary>
        /// load all users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void individualUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userListControl = _ServiceProvider.GetRequiredService<UserListControl>();
            plMain.Controls.Clear();
            userListControl.UserEmail = UserEmail;
            //var userListControl = new UserListControl(null, null, null);
            plMain.Controls.Add(userListControl);
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createUser = _ServiceProvider.GetRequiredService<CreateUser>();

            createUser.ShowDialog();
        }

        private void userRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var roleListControl = _ServiceProvider.GetRequiredService<RoleListControl>();
            plMain.Controls.Clear();
            roleListControl.UserEmail = UserEmail;
            roleListControl.Dock = DockStyle.Fill;
            plMain.Controls.Add(roleListControl);
        }

        private void newRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createRole = _ServiceProvider.GetRequiredService<CreateRole>();

            createRole.ShowDialog();
        }
        private void deviceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deviceListControl = _ServiceProvider.GetRequiredService<DeviceListControl>();
            deviceListControl.Dock = DockStyle.Fill;
            plMain.Controls.Clear();
            deviceListControl.UserEmail = UserEmail;
            plMain.Controls.Add(deviceListControl);
        }
        private void newDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createDevice = _ServiceProvider.GetRequiredService<CreateDevice>();

            createDevice.ShowDialog();
        }
        #endregion


    }
}
