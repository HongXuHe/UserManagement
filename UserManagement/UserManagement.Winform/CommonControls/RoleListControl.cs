using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapperConfig;
using UserManagement.Dtos;
using Serilog;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Winform.Roles;
using UserManagement.IRepository;
using UserManagement.Winform.CommonClass;

namespace UserManagement.Winform.CommonControls
{
    public partial class RoleListControl : UserControl
    {
        #region Ctor and props
        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        public string UserEmail { get; set; }
        private List<string> _userPermissions = new List<string>();

        public RoleListControl(IUnitOfWork.IUnitOfWork unitOfWork, IServiceProvider serviceProvider,IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo)
        {
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            InitializeComponent();
        }
        #endregion

        #region Events
        private void dgvRoleList_VisibleChanged(object sender, EventArgs e)
        {
            LoadRolesIntoDgv();
        }

        private void dgvRoleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_userPermissions.Contains("Role_Edit"))
            {
                return;
            }
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                DataGridViewRow dataGridViewRow = dgvRoleList.Rows[e.RowIndex];
                var roleName = dataGridViewRow.Cells["RoleName"].Value.ToString();
                var modifyForm = _serviceProvider.GetRequiredService<ModifyRole>();
                modifyForm.RoleName = roleName;
                var dialogRes = modifyForm.ShowDialog();
                LoadRolesIntoDgv();

            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "load specific role error");

            }

        }

        private void RoleListControl_Load(object sender, EventArgs e)
        {
            LoadRolesIntoDgv();
        }
        #endregion

        #region Methods
        private void LoadRolesIntoDgv()
        {
            _userPermissions = RetrieveUserPermissions.GetPermissions(UserEmail, _userRepo, _roleRepo, _permissionRepo);
            var roles = Mapping.Mapper.Map<List<RoleDto>>(_unitOfWork.RoleRepo.GetList(x => true));
            dgvRoleList.DataSource = null;
            dgvRoleList.DataSource = roles;
            dgvRoleList.Rows[0].Selected = false;
            dgvRoleList.ClearSelection();

        } 
        #endregion
    }
}
