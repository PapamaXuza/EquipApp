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
    public partial class frmUcAdmin : Form
    {
        public frmUcAdmin()
        {
            InitializeComponent();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            userAgent1.BringToFront();
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            userAgency1.BringToFront();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            userLocationOpt1.BringToFront();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            userPropertyType1.BringToFront();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            userProperty1.BringToFront();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            userAdmin1.BringToFront();
        }

        private void frmUcAdmin_Load(object sender, EventArgs e)
        {
            userWelcome1.BringToFront();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            frmAdminLogin form = new frmAdminLogin();
            form.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports form = new frmReports();
            form.Show();
            this.Hide();
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            userMainReports1.BringToFront();
        }
    }
}
