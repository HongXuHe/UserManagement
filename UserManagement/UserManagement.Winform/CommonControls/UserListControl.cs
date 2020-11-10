using System;
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

namespace UserManagement.Winform.CommonControls
{
    public partial class UserListControl : UserControl
    {
        private readonly IUserRepo _userRepo;
        private readonly IServiceProvider _serviceProvider;

        public UserListControl(IUserRepo userRepo, IServiceProvider serviceProvider)
        {
            _userRepo = userRepo;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void UserListControl_Load(object sender, EventArgs e)
        {
            //load all the users
            var userFromDb = _userRepo.GetList(x => true).ToList();
            var userList = Mapping.Mapper.Map<List<UserDto>>(userFromDb);
            dgvUserList.DataSource = userList;
            dgvUserList.Rows[0].Selected = false;
            this.Dock = DockStyle.Fill;
            dgvUserList.ClearSelection();
        }

        private void dgvUserList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                DataGridViewRow dataGridViewRow = dgvUserList.Rows[e.RowIndex];
                var userEmail = dataGridViewRow.Cells["Email"].Value.ToString();

                var createForm = _serviceProvider.GetRequiredService<CreateUser>();
                createForm.Email = userEmail;
                createForm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "create user from null");

            }

        }
    }
}
