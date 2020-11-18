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
using UserManagement.Winform.CommonClass;
using MapperConfig;
using UserManagement.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using UserManagement.Winform.Devices;

namespace UserManagement.Winform.CommonControls
{
    public partial class DeviceListControl : UserControl
    {
        #region ctor and props
        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        private readonly IDeviceRepo _deviceRepo;

        public string UserEmail { get; set; }
        private List<string> _userPermissions = new List<string>();

        public DeviceListControl(IUnitOfWork.IUnitOfWork unitOfWork, IServiceProvider serviceProvider, IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo, IDeviceRepo deviceRepo)
        {
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            _deviceRepo = deviceRepo;
            InitializeComponent();
        }
        #endregion

        #region Events

        private void DeviceListControl_Load(object sender, EventArgs e)
        {
            LoadDeviceIntoDgv();
        }




        private void dgvDeviceList_VisibleChanged(object sender, EventArgs e)
        {
            LoadDeviceIntoDgv();
        }

        private void dgvDeviceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (!_userPermissions.Contains("Role_Edit"))
            //{
            //    return;
            //}
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                DataGridViewRow dataGridViewRow = dgvDeviceList.Rows[e.RowIndex];
                var deviceId = dataGridViewRow.Cells["Id"].Value.ToString();
                var modifyForm = _serviceProvider.GetRequiredService<ModifyDevice>();
                modifyForm.Device = _deviceRepo.FindSingle(x=>x.Id.ToString() ==deviceId);
                var dialogRes = modifyForm.ShowDialog();
                LoadDeviceIntoDgv();

            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex, "load specific role error");

            }
        }


        #endregion

        #region Private methods
        private void LoadDeviceIntoDgv()
        {
            _userPermissions = RetrieveUserPermissions.GetPermissions(UserEmail, _userRepo, _roleRepo, _permissionRepo);
            var devices = Mapping.Mapper.Map<List<DeviceDto>>(_unitOfWork.DeviceRepo.GetList(x => true).ToList());
            dgvDeviceList.DataSource = null;
            dgvDeviceList.DataSource = devices;
            dgvDeviceList.ClearSelection();

        } 
        #endregion
    }
}
