using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.IRepository;

namespace UserManagement.Winform.Data
{
    public partial class NewRFID : Form
    {

        private readonly IUnitOfWork.IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserRepo _userRepo;
        private readonly IRoleRepo _roleRepo;
        private readonly IPermissionRepo _permissionRepo;
        private readonly IDeviceRepo _deviceRepo;
        private SerialPort _serialPort { get; set; }
        public NewRFID(IUnitOfWork.IUnitOfWork unitOfWork, IServiceProvider serviceProvider, IUserRepo userRepo, IRoleRepo roleRepo, IPermissionRepo permissionRepo, IDeviceRepo deviceRepo)
        {
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
            _userRepo = userRepo;
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            _deviceRepo = deviceRepo;           
            InitializeComponent();
        }

        private void NewRFID_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            LoadDeviceIntoCbo();
        }

        private void LoadDeviceIntoCbo()
        {
            cboDevice.Items.Clear();
            foreach (var item in _deviceRepo.GetList(x => true).Select(x => x.DeviceName).ToList())
            {
                cboDevice.Items.Add(item);
            }
        }

        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var deviceInfo = _deviceRepo.FindSingle(x => x.DeviceName == cboDevice.Text);
            
            try
            {
                _serialPort.BaudRate = deviceInfo.BaudRate;
                _serialPort.Parity = deviceInfo.Parity;
                _serialPort.DataBits = deviceInfo.DataBits;
                _serialPort.PortName = deviceInfo.COM;
                _serialPort.StopBits = deviceInfo.StopBits;
                _serialPort.DtrEnable = true;
                _serialPort.RtsEnable = true;
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }

            }
            catch (Exception ex)
            {

                Log.Logger.Error(ex, "oper serialPort error");
                MessageBox.Show("Open Port {0} error, please check connection", deviceInfo.COM);
            }


            _serialPort.DataReceived += _serialPort_DataReceived;
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string output = string.Empty;
                while (_serialPort.BytesToRead > 0)
                {
                    output += _serialPort.ReadExisting();
                    Thread.Sleep(100);
                    Trace.WriteLine("bytes to read: " + _serialPort.BytesToRead);
                }
                output = output.Replace("\r", "");
                Trace.WriteLine("Barcode: " + output);
                _serialPort.DiscardInBuffer();
                txtDeviceNo.Invoke(new Action(() =>
                {
                    txtDeviceNo.Text = output;
                }));
            }
            catch (Exception ex)
            {

            }

        }
        private void DoUpdate(object s, EventArgs e)
        {
            txtDeviceNo.Text = _serialPort.ReadLine();
        }
    }
}
