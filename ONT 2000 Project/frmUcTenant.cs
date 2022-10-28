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
    public partial class frmUcTenant : Form
    {
        public frmUcTenant()
        {
            InitializeComponent();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            userLocationOpt1.BringToFront();
        }

        private void userProperty1_Load(object sender, EventArgs e)
        {

        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            userProperty1.BringToFront();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            userTenant1.BringToFront();
        }

        private void frmUcTenant_Load(object sender, EventArgs e)
        {
            userWelcome1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTenantLogin form = new frmTenantLogin();
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
