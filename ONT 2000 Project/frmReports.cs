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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void userGetPropertyByNameReport1_Load(object sender, EventArgs e)
        {

        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            userWelcome1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userReports1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userReportsByName1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userGetPropertyByNameReport1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userLocationReport1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userRentalAndAgent1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userRentalByPrice1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmStart form = new frmStart();
            form.Show();
            this.Hide();
        }

        private void userAgenciesWithMostProperties1_Load(object sender, EventArgs e)
        {

        }
    }
}
