using MapperConfig;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.Dtos;
using UserManagement.Entity;
using UserManagement.IRepository;
using UserManagement.Utility.Winform;

namespace UserManagement.Winform.Devices
{
    public partial class ModifyDevice : Form
    {

        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        private readonly IDeviceRepo _deviceRepo;

        public string UserEmail { get; set; }
        private List<string> _userPermissions = new List<string>();
        public Device Device { get; set; }
        public ModifyDevice(IUnitOfWork.IUnitOfWork unitOfWork, IServiceProvider serviceProvider, IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo, IDeviceRepo deviceRepo)
        {
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            _deviceRepo = deviceRepo;
            InitializeComponent();
        }

        private void ModifyDevice_Load(object sender, EventArgs e)
        {
            LoadDataIntoControl();
            LoadValueToDevice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtDevice.TrimString() == string.Empty)
            {
                MessageBox.Show("Please fill in all the fields and try again");
                return;
            }
            //make sure unique email and its used by current user
            var countDevice = _unitOfWork.DeviceRepo.GetCount(u => u.DeviceName == txtDevice.Text.Trim());
            if (!(countDevice > 1 || (countDevice == 1 && Device.DeviceName != txtDevice.Text.Trim())))
            {
                _unitOfWork.DeviceRepo.Edit(Device);
                SetValueToDevice();
                try
                {
                    _unitOfWork.SaveChanges();
                    Log.Logger.Information("add device {0}", JsonConvert.SerializeObject(Mapping.Mapper.Map<DeviceDto>(Device)));                    
                }
                catch (Exception ex)
                {

                    Log.Logger.Error(ex, "save device error");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occured, please Make sure device name is unique");
            }
        }

        private void LoadDataIntoControl()
        {
            string[] ports = SerialPort.GetPortNames();
            cboCom.Items.Clear();
            cboCom.Items.AddRange(ports);
            cboParity.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(Parity)))
            {
                cboParity.Items.Add(item);
            }
            cboStopBits.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(StopBits)))
            {
                cboStopBits.Items.Add(item);
            }
        }

        private void LoadValueToDevice()
        {
            txtDevice.Text = Device.DeviceName;
            txtDescription.Text = Device.DeviceDes;
            cboCom.Text= Device.COM;
            txtBaudRate.Value = (decimal)Device.BaudRate;
            txtDataBits.Value = (decimal)Device.DataBits;
            cboStopBits.Text = Device.StopBits.ToString();
            cboParity.Text = Device.Parity.ToString();
        }

        private void SetValueToDevice()
        {
            Device.DeviceName = txtDevice.Text.Trim();
            Device.DeviceDes = txtDescription.TrimString();
            Device.COM = cboCom.Text.Trim();
            Device.BaudRate = Convert.ToInt32(txtBaudRate.Value);
            Device.DataBits = Convert.ToInt32(txtDataBits.Value);
            Device.StopBits = (StopBits)(Enum.Parse(typeof(StopBits), cboStopBits.Text.Trim()));
            Device.Parity = (Parity)(Enum.Parse(typeof(Parity), cboParity.Text.Trim()));
        }

       
    }
}
