using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement.Winform.CommonControls
{
    public partial class SearchControl : UserControl
    {
        public event Action SearchClickHandler;
        public SearchControl()
        {
            InitializeComponent();
        }

        private void GRID_Click(object sender, EventArgs e)
        {

        }

        private void GRID_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(SearchClickHandler != null)
            {
                SearchClickHandler();
            }
        }
    }
}
