using MapperConfig;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UserManagement.Dtos;
using UserManagement.Entity;
using UserManagement.IRepository;
using UserManagement.Utility;
using UserManagement.Utility.Winform;
using UserManagement.Winform.CommonClass;

namespace UserManagement.Winform.Users
{
    public partial class CreateUser : Form
    {
        #region props and ctor
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private List<string> _permissionList = new List<string>();
        public ApplicationUser AppUser { get; set; }
        public CreateUser(IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo, IServiceProvider serviceProvider, IUnitOfWork.IUnitOfWork unitOfWork)
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
            this.AppUser = new ApplicationUser();
            LoadRole();
            LoadPermission();
            tabUserFrom.SelectedIndex = 0; //will not trigger selecteIndexChange event, have to call loaduser() manually

        }


        private void treeViewPermission_AfterCheck(object sender, TreeViewEventArgs e)
        {
            PermissionTreeNode.CheckTreeViewNode(e.Node, e.Node.Checked, _permissionList);
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
        /// load roles for logged in user
        /// </summary>
        private void LoadRole()
        {
            //clear items first
            chcListBox.Items.Clear();
            var AllRoles = _roleRepo.GetList(x => true).ToList();
            //reload roles
            foreach (var item in AllRoles)
            {
                chcListBox.Items.Add(item, false);
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
            userPermissions = Mapping.Mapper.Map<List<PermissionDto>>(userPermissionsFromDb);
            var firstLevelPermissionsFromDb = _unitOfWork.PermissionRepo.GetList(x => x.ParentId == null).ToList();
            var firstLevelPermissions = Mapping.Mapper.Map<List<PermissionDto>>(firstLevelPermissionsFromDb);
            var firstAllNode = new TreeNode("All");
            var node = PermissionToTreeView.AddPermissionToTreeView(firstLevelPermissions, userPermissions, firstAllNode, _permissionRepo);
            treeViewPermission.Nodes.Add(node);
        }

        private void SaveUser()
        {
            if (txtEmail.TrimString() == string.Empty || txtUserName.TrimString() == string.Empty ||
                txtPassword.TrimString() == string.Empty)
            {
                MessageBox.Show("Please fill in all the fields and try again");
                return;
            }
            //make sure unique email and its used by current user
            var countUser = _unitOfWork.UserRepo.GetCount(u => u.Email == txtEmail.Text.Trim());
            if (countUser < 1)
            {
                SetModifiedValueToUser();
                _unitOfWork.UserRepo.Create(AppUser);
                try
                {
                    _unitOfWork.SaveChanges();
                    Log.Information("add user {0}", JsonConvert.SerializeObject(Mapping.Mapper.Map<UserDto>(AppUser)));
                }
                catch (Exception ex)
                {

                    Log.Error(ex, "save user error");
                }

            }
            else
            {
                MessageBox.Show("Error occured, please check your input information.eg:unique email");
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
            var password = Md5Encrypt.GetMD5Hash(AppUser.PasswordSalt + txtPassword.Text.Trim());
            AppUser.Password = password;
            // add selected roles
            var roleList = new List<R_User_Role>();
            foreach (ApplicationRole role in chcListBox.CheckedItems)
            {
                roleList.Add(new R_User_Role() { ApplicationRoleId = role.Id });
            }
            AppUser.ApplicationRoles = roleList;
            ////add selected permissions
            var permissionList = new List<R_User_Permission>();
            foreach (var permission in _unitOfWork.PermissionRepo.GetList(x => true).ToList())
            {
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
