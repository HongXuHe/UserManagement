﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.IRepository;
using MapperConfig;
using UserManagement.Dtos;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Winform.Users;
using Microsoft.Extensions.Logging;
using Serilog;
using Microsoft.EntityFrameworkCore;
using UserManagement.UnitOfWok;
using UserManagement.IUnitOfWork;
using UserManagement.Winform.CommonClass;

namespace UserManagement.Winform.CommonControls
{
    public partial class UserListControl : UserControl
    {
        #region Ctor and props
        private readonly IUserRepo _userRepo;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;

        public string UserEmail { get; set; }
        private List<string> _userPermissions = new List<string>();

        public UserListControl(IUserRepo userRepo, IServiceProvider serviceProvider, IUnitOfWork.IUnitOfWork unitOfWork, IRoleRepo roleRepo, IPermissionRepo permissionRepo)
        {
            _userRepo = userRepo;
            _serviceProvider = serviceProvider;
            _unitOfWork = unitOfWork;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            InitializeComponent();
        }
        #endregion

        #region Events
        private void UserListControl_Load(object sender, EventArgs e)
        {
            //load all the users
            LoadDataToUserControl();
            _userPermissions = RetrieveUserPermissions.GetPermissions(UserEmail, _userRepo, _roleRepo, _permissionRepo);

        }

        private void dgvUserList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //no permission will return
            if (!_userPermissions.Contains("User_Edit"))
            {
                return;
            }
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                DataGridViewRow dataGridViewRow = dgvUserList.Rows[e.RowIndex];
                var userId = dataGridViewRow.Cells["Id"].Value.ToString();                

                var modifyForm = _serviceProvider.GetRequiredService<ModifyUser>();
                modifyForm.Id = userId;
                var dialogRes = modifyForm.ShowDialog();
                LoadDataToUserControl();

            }
            catch (Exception ex)
            {
                Log.Error(ex, "create user from null");

            }

        }

        private void dgvUserList_VisibleChanged(object sender, EventArgs e)
        {
            LoadDataToUserControl();
        }
        #endregion

        #region Methods
        private void LoadDataToUserControl()
        {
            var userFromDb = _userRepo.GetList(x => true).ToList();
            var userList = Mapping.Mapper.Map<List<UserDto>>(userFromDb);
            dgvUserList.DataSource = null;
            dgvUserList.DataSource = userList;
            dgvUserList.Rows[0].Selected = false;
            this.Dock = DockStyle.Fill;
            dgvUserList.ClearSelection();
        } 
        #endregion
    }
}
