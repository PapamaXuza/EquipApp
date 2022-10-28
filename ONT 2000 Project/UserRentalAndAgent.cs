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
    public partial class UserRentalAndAgent : UserControl
    {
        public UserRentalAndAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnStatus_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetRentalsByTenantReport(txtStatus.Text);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetRentalsReport(dtpStart.Value, dtpEnd.Value);
        }
    }
}
