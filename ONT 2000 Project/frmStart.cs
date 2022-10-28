using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT_2000_Project
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdminLogin login = new frmAdminLogin();
            login.Show();
            this.Hide();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            frmAgentLogin login = new frmAgentLogin();
            login.Show();
            this.Hide();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            frmTenantLogin login = new frmTenantLogin();
            login.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
          
        }
    }
}
