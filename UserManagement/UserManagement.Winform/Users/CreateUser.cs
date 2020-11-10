using MapperConfig;
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

namespace UserManagement.Winform.Users
{
    public partial class CreateUser : Form
    {
        #region props and ctor
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        private readonly IServiceProvider _serviceProvider;

        public string Email { get; set; }
        public UserDto _user { get; set; }
        public CreateUser(IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            _serviceProvider = serviceProvider;
        }
        #endregion

        #region Event
        private void CreateUser_Load(object sender, EventArgs e)
        {
            _user = Mapping.Mapper.Map<UserDto>(_userRepo.FindSingle(u => u.Email == Email));
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
            var userRoles = _userRepo.GetUserRoles(_userRepo.FindSingle(u => u.Email == Email).Id);
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
            var userPermissionsFromDb = _userRepo.GetUserPermissions(_userRepo.FindSingle(u => u.Email == Email).Id).ToList();
            var userPermissions = Mapping.Mapper.Map<List<PermissionDto>>(userPermissionsFromDb);
            var firstLevelPermissionsFromDb = _permissionRepo.GetList(x => x.ParentId == null).ToList();
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
                    treeNode.Checked = true;
                }
                else
                {
                    treeNode.Checked = false;
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
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;
                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, item.Checked);
                }
            }
        }
        #endregion
      
    }
}
