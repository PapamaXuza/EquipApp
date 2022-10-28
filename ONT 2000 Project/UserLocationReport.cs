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
    public partial class UserLocationReport : UserControl
    {
        public UserLocationReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnCity_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetCityReport(txtCity.Text);
        }

        private void btnSuburb_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetSuburbReport(txtSuburb.Text);
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetProvinceReport(txtProvince.Text);
        }
    }
}
