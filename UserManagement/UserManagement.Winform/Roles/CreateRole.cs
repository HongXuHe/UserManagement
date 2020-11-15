using MapperConfig;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Dtos;
using UserManagement.Entity;
using UserManagement.IRepository;
using UserManagement.Utility.Winform;
using UserManagement.Winform.CommonClass;

namespace UserManagement.Winform.Roles
{
    public partial class CreateRole : Form
    {
        #region ctor and props
        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;

        public string RoleName { get; set; }
        private ApplicationRole AppRole = null;
        private List<string> _permissionList = new List<string>();
        public CreateRole(IUnitOfWork.IUnitOfWork unitOfWork, IRoleRepo roleRepo, IPermissionRepo permissionRepo)
        {
            _unitOfWork = unitOfWork;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            InitializeComponent();

        }
        #endregion

        #region Events
        private void CreateRole_Load(object sender, EventArgs e)
        {
            LoadAllPermissions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoleName.TrimString()))
            {
                MessageBox.Show("RoleNme cannot be empty");
                return;
            }
            if (_unitOfWork.RoleRepo.GetCount(x => x.RoleName.ToUpper() == txtRoleName.TrimString().ToUpper()) >= 1)
            {
                MessageBox.Show("Role Already exists");
                return;
            }
            SaveRole();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeViewPermissions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            PermissionTreeNode.CheckTreeViewNode(e.Node, e.Node.Checked, _permissionList);
        }
        #endregion

        #region Common Methods
        /// <summary>
        /// load all permissions to permission tab
        /// </summary>
        private void LoadAllPermissions()
        {
            treeViewPermissions.Nodes.Clear();
            List<ApplicationPermission> rolePermissionsFromDb = new List<ApplicationPermission>();
            List<PermissionDto> rolePermissions = new List<PermissionDto>();
            _permissionList = rolePermissions.Select(x => x.PermissionName).ToList();
            var firstLevelPermissionsFromDb = _unitOfWork.PermissionRepo.GetList(x => x.ParentId == null).ToList();
            var firstLevelPermissions = Mapping.Mapper.Map<List<PermissionDto>>(firstLevelPermissionsFromDb);
            var firstAllNode = new TreeNode("All");
            var node = PermissionToTreeView.AddPermissionToTreeView(firstLevelPermissions, rolePermissions, firstAllNode, _permissionRepo);
            treeViewPermissions.Nodes.Add(node);
        }

        private void SaveRole()
        {
            var appRole = new ApplicationRole();
            appRole.RoleName = txtRoleName.TrimString();
            appRole.RoleDesc = txtRoleDesc.TrimString();
            ////add selected permissions
            var permissionList = new List<R_Role_Permission>();
            foreach (var permission in _unitOfWork.PermissionRepo.GetList(x => true).ToList())
            {
                if (_permissionList.Contains(permission.PermissionName))
                {
                    permissionList.Add(new R_Role_Permission() { ApplicationPermissionId = permission.Id, ApplicationRoleId = appRole.Id });
                }
                else
                {
                    permissionList.Remove(new R_Role_Permission() { ApplicationPermissionId = permission.Id, ApplicationRoleId = appRole.Id });
                }

            }
            appRole.ApplicationPermissions = permissionList;
            _unitOfWork.RoleRepo.Create(appRole);
            try
            {
                _unitOfWork.SaveChanges();
                Log.Information("add user {0}", JsonConvert.SerializeObject(Mapping.Mapper.Map<RoleDto>(appRole)));
            }
            catch (Exception ex)
            {

                Log.Error(ex, "add role error");
                MessageBox.Show("There is an error save role. Please try again later");
            }

        } 
        #endregion


    }
}
