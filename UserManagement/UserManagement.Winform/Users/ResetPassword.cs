using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement.Winform.Users
{
    public partial class ResetPassword : Form
    {
        #region ctor and props
        public Action<string> PasswordFunc;
        public ResetPassword()
        {
            InitializeComponent();
            this.txtPwd.Text = string.Empty;
            this.txtConfirmPwd.Text = string.Empty;

        } 
        #endregion

        #region Events
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPwd.Text.Trim()) || string.IsNullOrEmpty(txtConfirmPwd.Text.Trim()))
            {
                MessageBox.Show("All Fields must filled in");
                this.DialogResult = DialogResult.Cancel;
            }
            if (string.Equals(txtPwd.Text.Trim(), txtConfirmPwd.Text.Trim()))
            {
                if (PasswordFunc != null)
                {
                    PasswordFunc(txtPwd.Text);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Password and Confirm Password not the same");
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        } 
        #endregion
    }
}
