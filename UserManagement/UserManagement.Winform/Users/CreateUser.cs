using MapperConfig;
using Microsoft.Extensions.DependencyInjection;
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
using UserManagement.UnitOfWok;

namespace UserManagement.Winform.Users
{
    public partial class CreateUser : Form
    {
        #region props and ctor
        public bool IsCreate { get; set; }
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUnitOfWork _unitOfWork;
        private List<string> _permissionList = new List<string>();

        public string Id { get; set; }
        public UserDto _user { get; set; }
        public ApplicationUser AppUser { get; set; }
        public CreateUser(IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo, IServiceProvider serviceProvider, IUnitOfWork unitOfWork)
        {            
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            _serviceProvider = serviceProvider;
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }
        #endregion

        #region Event
        private void CreateUser_Load(object sender, EventArgs e)
        {
            AppUser = _unitOfWork.UserRepo.FindSingle(u => u.Id.ToString() == Id);
            _user = Mapping.Mapper.Map<UserDto>(AppUser);
            tabUserFrom.SelectedIndex = 0; //will not trigger selecteIndexChange event, have to call loaduser() manually
            LoadUser();
        }

        /// <summary>
        /// tab change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabUserFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabUserFrom.SelectedIndex)
            {
                case 0:
                    LoadUser();
                    break;
                case 1:
                    LoadRole();
                    break;
                case 2:
                    LoadPermission();
                    break;
                default:
                    LoadUser();
                    break;
            }
        }

        private void treeViewPermission_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Methods
        /// <summary>
        /// load user control
        /// </summary>
        private void LoadUser()
        {
            if (_user != null)
            {
                txtUserName.Text = _user.UserName;
                txtEmail.Text = _user.Email;
                txtPhone.Text = _user.PhoneNo;
                dtEffectDate.Value = _user.EffectDate;
                txtDesc.Text = _user.Description;
                if (_user.ExpireDate == null)
                {
                    dtExpireDate.Value = dtExpireDate.MaxDate;
                }
                else
                {
                    dtExpireDate.Value = Convert.ToDateTime(_user.ExpireDate);
                }
            }


        }

        /// <summary>
        /// load roles for logged in user
        /// </summary>
        private void LoadRole()
        {
            //clear items first
            chcListBox.Items.Clear();
            var AllRoles = _roleRepo.GetList(x => true).ToList();
            var userRoles = _unitOfWork.UserRepo.GetUserRoles(_userRepo.FindSingle(u => u.Id.ToString() == Id).Id);
            //reload roles
            foreach (var item in AllRoles)
            {
                if (userRoles.Any(x => x.Id == item.Id))
                {
                    chcListBox.Items.Add(item, true);
                }
                else
                {
                    chcListBox.Items.Add(item, false);
                }
            }
            chcListBox.DisplayMember = "RoleName";
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadPermission()
        {
            treeViewPermission.Nodes.Clear();
            var userPermissionsFromDb = _unitOfWork.UserRepo.GetUserPermissions(_userRepo.FindSingle(u => u.Id.ToString() == Id).Id).ToList();
            var userPermissions = Mapping.Mapper.Map<List<PermissionDto>>(userPermissionsFromDb);
            var firstLevelPermissionsFromDb = _unitOfWork.PermissionRepo.GetList(x => x.ParentId == null).ToList();
            var firstLevelPermissions = Mapping.Mapper.Map<List<PermissionDto>>(firstLevelPermissionsFromDb);
            var firstAllNode = new TreeNode("All");
            var node = AddPermissionToTreeView(firstLevelPermissions, userPermissions, firstAllNode);
            treeViewPermission.Nodes.Add(node);
        }



        /// <summary>
        /// add nested permissions to permission list
        /// </summary>
        /// <param name="permissions">all permissions</param>
        /// <param name="userPermissions">user's permissions</param>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        private TreeNode AddPermissionToTreeView(List<PermissionDto> permissions, List<PermissionDto> userPermissions, TreeNode treeNode)
        {
            foreach (var permission in permissions)
            {
                // treeNode = new TreeNode(permission.PermissionName);
                treeNode.Nodes.Add(permission.PermissionName);
                if (userPermissions.Any(p => p.PermissionName == permission.PermissionName))
                {
                    treeNode.LastNode.Checked = true;
                    treeNode.Checked = true;
                }
                else
                {
                    treeNode.LastNode.Checked = false;
                }
                var childPermissions = Mapping.Mapper.Map<List<PermissionDto>>(_permissionRepo.GetList(p => p.ParentId == permission.Id.ToString()).ToList());
                AddPermissionToTreeView(childPermissions, userPermissions, treeNode.LastNode);
            }
            return treeNode;
        }

        /// <summary>
        /// check and uncheck treenode according to their parent node
        /// </summary>
        /// <param name="node">parent node</param>
        /// <param name="isChecked">is parent node checked</param>
        private void CheckTreeViewNode(TreeNode node, bool isChecked)
        {
            //var tableList =_userRepo.GetDataBaseTables(x => true).Select(x => x.Substring(22)).ToList();
            if (node.Nodes.Count == 0)
            {
                PermissionListAddRemove(node);
            }
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;
                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, item.Checked);
                   // PermissionListAddRemove(item);
                }
                PermissionListAddRemove(item);

            }
        }

        private void SaveUser()
        {
            if (AppUser != null)
            {

                //make sure unique email and its used by current user
                if (_unitOfWork.UserRepo.GetCount(u => u.Email == txtEmail.Text.Trim()) < 1
                    || (_unitOfWork.UserRepo.GetCount(u => u.Email == txtEmail.Text.Trim()) == 1 && AppUser.Email ==txtEmail.Text.Trim())
                    )
                {
                    SetModifiedValueToUser();
                    _unitOfWork.UserRepo.Edit(AppUser);
                    try
                    {
                        _unitOfWork.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }

                }
                else
                {
                    MessageBox.Show("Error occured, please check your input information.eg:unique email");
                    return;
                }

            }
        }

        private void SetModifiedValueToUser()
        {
            AppUser.UserName = txtUserName.Text.Trim();
            AppUser.Email = txtEmail.Text.Trim();
            AppUser.PhoneNo = txtPhone.Text.Trim();
            AppUser.Description = txtDesc.Text.Trim();
            AppUser.EffectDate = dtEffectDate.Value;
            if (dtExpireDate.Value != dtExpireDate.MaxDate)
            {
                AppUser.ExpireDate = dtExpireDate.Value;
            }
            // add selected roles
            var roleList = new List<R_User_Role>();
            foreach (ApplicationRole role in chcListBox.Items)
            {
                if (chcListBox.CheckedItems.Contains(role))
                {
                    roleList.Add(new R_User_Role() { ApplicationRoleId = role.Id });
                }
                else
                {
                    roleList.Remove(new R_User_Role() { ApplicationRoleId = role.Id });
                }
                AppUser.ApplicationRoles = roleList;
            }
            ////add selected permissions
            var permissionList = new List<R_User_Permission>();
            foreach (var permission in _unitOfWork.PermissionRepo.GetList(x => true).ToList())
            {

                // var permissionFromDb = _unitOfWork.PermissionRepo.FindSingle(x => x.PermissionName == permission.PermissionName);
                if (_permissionList.Contains(permission.PermissionName))
                {
                    permissionList.Add(new R_User_Permission() { ApplicationPermissionId = permission.Id });
                }
                else
                {
                    permissionList.Remove(new R_User_Permission() { ApplicationPermissionId = permission.Id });
                }

            }
            AppUser.ApplicationPermissions = permissionList;
        }

        /// <summary>
        /// permission list add/remove to field in _permissionList
        /// </summary>
        /// <param name="node"></param>
        private void PermissionListAddRemove(TreeNode node)
        {
            if (node.Nodes.Count == 0)
            {
                if (!_permissionList.Contains(node.Text))
                {
                    if (node.Checked)
                    {
                        _permissionList.Add(node.Text);
                    }

                }
                else
                {
                    if (!node.Checked)
                    {
                        _permissionList.Remove(node.Text);
                    }

                }
            }
        }
        #endregion

    }
}
