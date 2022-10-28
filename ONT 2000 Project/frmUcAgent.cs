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
    public partial class frmUcAgent : Form
    {
        public frmUcAgent()
        {
            InitializeComponent();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            userRental1.BringToFront();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            userProperty1.BringToFront();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            userAgent1.BringToFront();
        }

        private void frmUcAgent_Load(object sender, EventArgs e)
        {
            userWelcome1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgentLogin form = new frmAgentLogin();
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
