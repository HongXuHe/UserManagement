using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement.Winform
{
    public partial class ShowMessage : Form
    {
        public string Message { get; set; }
        public DialogResult ReturnDialogResult { get; set; }
        public ShowMessage()
        {
            InitializeComponent();
        }

        private void ShowMessage_Load(object sender, EventArgs e)
        {
            lblMessage.Text = Message;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ReturnDialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnDialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
