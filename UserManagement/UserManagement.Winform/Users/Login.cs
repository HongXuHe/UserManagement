using Microsoft.Extensions.DependencyInjection;
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
using UserManagement.IRepository;
using UserManagement.UnitOfWok;
using UserManagement.Utility;
using UserManagement.Utility.Winform;

namespace UserManagement.Winform.Users
{
    public partial class Login : Form
    {
        #region ctor and props
        private readonly IUserRepo _userRepo;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUnitOfWork _unitOfWork;

        public Login(IUserRepo userRepo, IServiceProvider serviceProvider,IUnitOfWork unitOfWork)
        {
            _userRepo = userRepo;
            _serviceProvider = serviceProvider;
            _unitOfWork = unitOfWork;
            InitializeComponent();
        } 
        #endregion

        #region Events

        /// <summary>
        /// login button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userEmail = txtUserEmail.TrimString();
            var userPassword = txtPassword.TrimString();
            if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(userPassword))
            {
                // user exists
                if (_userRepo.Exists(u => u.Email == userEmail))
                {
                    var userFromDb = _unitOfWork.UserRepo.FindSingle(u => u.Email == userEmail);
                    var hashInputPwd = Md5Encrypt.GetMD5Hash(string.Concat(userFromDb.PasswordSalt, userPassword));
                    if (userFromDb.Password.Equals(hashInputPwd))
                    {
                        Log.Logger.Information("user {0},{1} logged in", userFromDb.UserName, userFromDb.Email);
                        var mainForm = _serviceProvider.GetRequiredService<MainForm>();
                        mainForm.UserEmail = userEmail;
                        mainForm.Show();
                        this.Hide();
                        return;
                    }
                }
                //user password entered not match
                ShowMessage message = new ShowMessage();
                message.Text = "Login Failed";
                message.Message = "Authentication Failed";
                var bmp = new Bitmap(UserManagement.Winform.Properties.Resources.close_24x24);
                message.Icon = Icon.FromHandle(bmp.GetHicon());
                message.ShowDialog();
                return;
            }
            ShowMessage emptyMsg = new ShowMessage();
            var bmpEmp = new Bitmap(UserManagement.Winform.Properties.Resources.close_24x24);
            emptyMsg.Icon = Icon.FromHandle(bmpEmp.GetHicon());
            emptyMsg.Text = "Empty Fileds";
            emptyMsg.Message = "Please fill in email/password";
            emptyMsg.ShowDialog();
            return;
        }

        /// <summary>
        /// cancel button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     
        #endregion
    }
}
