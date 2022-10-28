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
    public partial class UserMainReports : UserControl
    {
        public UserMainReports()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userReportsByName1.BringToFront();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            userGetPropertyByNameReport1.BringToFront();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            userLocationReport1.BringToFront();
        }

        private void btnUserReport_Click(object sender, EventArgs e)
        {
            userReports1.BringToFront();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            userRentalAndAgent1.BringToFront();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            userRentalByPrice1.BringToFront();
        }
    }
}
