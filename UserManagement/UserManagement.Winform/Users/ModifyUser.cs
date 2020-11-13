using MapperConfig;
using Microsoft.Extensions.DependencyInjection;
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
using UserManagement.UnitOfWok;
using UserManagement.Utility;

namespace UserManagement.Winform.Users
{
    public partial class ModifyUser : Form
    {
        #region props and ctor
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private List<string> _permissionList = new List<string>();

        public string Id { get; set; }
        public UserDto _user { get; set; }
        public ApplicationUser AppUser { get; set; }
        public string _resetPwd = null;
        public ModifyUser(IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo, IServiceProvider serviceProvider, IUnitOfWork.IUnitOfWork unitOfWork)
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
            btnResetPwd.Visible = true;
            LoadUser();
            LoadRole();
            LoadPermission();
            tabUserFrom.SelectedIndex = 0; //will not trigger selecteIndexChange event, have to call loaduser() manually

        }


        private void treeViewPermission_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked, _permissionList);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
            this._resetPwd = null;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._resetPwd = null;
            this.Close();
        }
        #endregion

        #region Methods
        /// <summary>
        /// load user control
        /// </summary>
        private void LoadUser()
        {

            txtUserName.Text = _user?.UserName;
            txtEmail.Text = _user?.Email;
            txtPhone.Text = _user?.PhoneNo;
            dtEffectDate.Value = _user == null ? DateTime.Now : _user.EffectDate;
            txtDesc.Text = _user?.Description;
            if (_user?.ExpireDate == null)
            {
                dtExpireDate.Value = dtExpireDate.MaxDate;
            }
            else
            {
                dtExpireDate.Value = Convert.ToDateTime(_user.ExpireDate);
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
            List<ApplicationRole> userRoles = new List<ApplicationRole>();

            userRoles = _unitOfWork.UserRepo.GetUserRoles(_userRepo.FindSingle(u => u.Id.ToString() == Id).Id).ToList();

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
            List<ApplicationPermission> userPermissionsFromDb = new List<ApplicationPermission>();
            List<PermissionDto> userPermissions = new List<PermissionDto>();
            userPermissionsFromDb = _unitOfWork.UserRepo.GetUserPermissions(_userRepo.FindSingle(u => u.Id.ToString() == Id).Id).ToList();
            userPermissions = Mapping.Mapper.Map<List<PermissionDto>>(userPermissionsFromDb);
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
        public static void CheckTreeViewNode(TreeNode node, bool isChecked, List<string> permissionList)
        {
            //var tableList =_userRepo.GetDataBaseTables(x => true).Select(x => x.Substring(22)).ToList();
            if (node.Nodes.Count == 0)
            {
                PermissionListAddRemove(node, permissionList);
            }
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;
                if (item.Nodes.Count > 0)
                {
                    CheckTreeViewNode(item, item.Checked, permissionList);
                    // PermissionListAddRemove(item);
                }
                PermissionListAddRemove(item, permissionList);

            }
        }

        private void SaveUser()
        {
            if (AppUser != null)
            {

                //make sure unique email and its used by current user
                var countUser = _unitOfWork.UserRepo.GetCount(u => u.Email == txtEmail.Text.Trim());
                if (!(countUser > 1 || (countUser == 1 && AppUser.Email != txtEmail.Text.Trim())))
                {
                    SetModifiedValueToUser();
                    _unitOfWork.UserRepo.Edit(AppUser);
                    try
                    {
                        _unitOfWork.SaveChanges();
                        Log.Information("update user {0}", JsonConvert.SerializeObject(Mapping.Mapper.Map<UserDto>(AppUser)));
                    }
                    catch (Exception ex)
                    {

                        Log.Error(ex, "save user error");
                    }
                    _resetPwd = null;

                }
                else
                {
                    MessageBox.Show("Error occured, please check your input information.eg:unique email");
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
            if (!string.IsNullOrEmpty(_resetPwd)){
                AppUser.Password = _resetPwd;
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
        public static void PermissionListAddRemove(TreeNode node, List<string> permissionList)
        {
            if (node.Nodes.Count == 0)
            {
                if (!permissionList.Contains(node.Text))
                {
                    if (node.Checked)
                    {
                        permissionList.Add(node.Text);
                    }
                }
                else
                {
                    if (!node.Checked)
                    {
                        permissionList.Remove(node.Text);
                    }

                }
            }
        }
        #endregion

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            _resetPwd = null;
            var resetPasswordForm = _serviceProvider.GetRequiredService<ResetPassword>();
            resetPasswordForm.PasswordFunc += x =>
            {
                var resetPwd = Md5Encrypt.GetMD5Hash(AppUser.PasswordSalt + x);
                this._resetPwd = resetPwd;
            };
            var dialogResult = resetPasswordForm.ShowDialog();          
        }
    }
}
