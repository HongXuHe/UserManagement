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
using UserManagement.Repository;
using UserManagement.Utility.Winform;
using UserManagement.Winform.CommonClass;

namespace UserManagement.Winform.Roles
{
    public partial class ModifyRole : Form
    {
        #region Ctor and props
        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;

        public string RoleName { get; set; }
        private ApplicationRole AppRole = null;
        private List<string> _permissionList = new List<string>();
        public ModifyRole(IUnitOfWork.IUnitOfWork unitOfWork, IRoleRepo roleRepo, IPermissionRepo permissionRepo)
        {
            _unitOfWork = unitOfWork;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            InitializeComponent();

        }
        #endregion

        #region Events
        private void ModifyRole_Load(object sender, EventArgs e)
        {
            LoadRole();
            LoadPermission();
        }

        private void treeViewPermission_AfterCheck(object sender, TreeViewEventArgs e)
        {
            PermissionTreeNode.CheckTreeViewNode(e.Node, e.Node.Checked, _permissionList);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var roleCount = _roleRepo.GetCount(x => x.RoleName == txtRoleName.TrimString());
            //no duplicate role
            if (roleCount < 1 || (roleCount == 1 && AppRole.RoleName == txtRoleName.TrimString()))
            {
                SetFormValue();
                _unitOfWork.RoleRepo.Edit(AppRole);
                try
                {
                    _unitOfWork.SaveChanges();
                    Log.Logger.Information("edit role {0}", JsonConvert.SerializeObject(Mapping.Mapper.Map<RoleDto>(AppRole)));
                    this.Close();
                }
                catch (Exception ex)
                {

                    Log.Logger.Fatal("save role error", ex);
                    MessageBox.Show("Save Failed, please try again later");
                }

            }
            else
            {
                MessageBox.Show("Please check yor data and try again");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// load role info into form
        /// </summary>
        private void LoadRole()
        {
            AppRole = _unitOfWork.RoleRepo.FindSingle(x => x.RoleName == RoleName);
            if (AppRole != null)
            {
                txtRoleName.Text = AppRole.RoleName;
                txtRoleDesc.Text = AppRole.RoleDesc;
            }
        }

        private void LoadPermission()
        {
            treeViewPermission.Nodes.Clear();
            List<ApplicationPermission> rolePermissionsFromDb = new List<ApplicationPermission>();
            List<PermissionDto> rolePermissions = new List<PermissionDto>();
            rolePermissionsFromDb = _unitOfWork.RoleRepo.GetRolePermissions(_roleRepo.FindSingle(u => u.RoleName == RoleName).Id).ToList();
            rolePermissions = Mapping.Mapper.Map<List<PermissionDto>>(rolePermissionsFromDb);
            _permissionList = rolePermissions.Select(x => x.PermissionName).ToList();
            var firstLevelPermissionsFromDb = _unitOfWork.PermissionRepo.GetList(x => x.ParentId == null).ToList();
            var firstLevelPermissions = Mapping.Mapper.Map<List<PermissionDto>>(firstLevelPermissionsFromDb);
            var firstAllNode = new TreeNode("All");
            var node = PermissionToTreeView.AddPermissionToTreeView(firstLevelPermissions, rolePermissions, firstAllNode, _permissionRepo);
            treeViewPermission.Nodes.Add(node);
        }

        private void SetFormValue()
        {
            AppRole.RoleName = txtRoleName.TrimString();
            var rolePermissionList = new List<R_Role_Permission>();
            foreach (var per in _unitOfWork.PermissionRepo.GetList(x => true).ToList())
            {
                if (_permissionList.Contains(per.PermissionName))
                {
                    rolePermissionList.Add(new R_Role_Permission() { ApplicationPermissionId = per.Id });
                }
                else
                {
                    rolePermissionList.Remove(new R_Role_Permission() { ApplicationPermissionId = per.Id });
                }
            }
            AppRole.ApplicationPermissions = rolePermissionList;
        } 
        #endregion
    }
}
