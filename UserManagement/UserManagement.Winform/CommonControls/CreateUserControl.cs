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

namespace UserManagement.Winform.CommonControls
{
    public partial class CreateUserControl : UserControl
    {
        private readonly IUserRepo _userRepo;
        private readonly IServiceProvider _serviceProvider;

        public CreateUserControl(IUserRepo userRepo, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userRepo = userRepo;
            _serviceProvider = serviceProvider;
        }

        private void CreateUserControl_Load(object sender, EventArgs e)
        {
          var list =  _userRepo.GetList(x=>true).ToList();
        }
    }
}
