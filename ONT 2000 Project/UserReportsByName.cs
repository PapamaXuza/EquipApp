using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ONT_2000_Project
{
    public partial class UserReportsByName : UserControl
    {
        public UserReportsByName()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAgent_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetAgentByName(txtAgent.Text);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetAAdminByName(txtAdmin.Text);
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetTenantByName(txtTenant.Text);
        }

        private void UserReportsByName_Load(object sender, EventArgs e)
        {

        }
    }
}
