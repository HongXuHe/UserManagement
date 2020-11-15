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
using UserManagement.Utility.Winform;
using UserManagement.Winform.CommonClass;

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
            // CheckTreeViewNode(e.Node, e.Node.Checked, _permissionList);
            PermissionTreeNode.CheckTreeViewNode(e.Node, e.Node.Checked, _permissionList);
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
            _permissionList = userPermissions.Select(x => x.PermissionName).ToList();
            var firstLevelPermissionsFromDb = _unitOfWork.PermissionRepo.GetList(x => x.ParentId == null).ToList();
            var firstLevelPermissions = Mapping.Mapper.Map<List<PermissionDto>>(firstLevelPermissionsFromDb);
            var firstAllNode = new TreeNode("All");
            var node = PermissionToTreeView.AddPermissionToTreeView(firstLevelPermissions, userPermissions, firstAllNode, _permissionRepo);
            treeViewPermission.Nodes.Add(node);
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
            if (!string.IsNullOrEmpty(_resetPwd))
            {
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


        #endregion

       
    }
}
