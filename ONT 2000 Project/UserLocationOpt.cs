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
    public partial class UserLocationOpt : UserControl
    {
        public UserLocationOpt()
        {
            InitializeComponent();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            userCity1.BringToFront();
        }

        private void btnSuburb_Click(object sender, EventArgs e)
        {
            userSuburb1.BringToFront();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            userProvince1.BringToFront();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
        }

        private void userSuburb2_Load(object sender, EventArgs e)
        {

        }

        private void userSuburb1_Load(object sender, EventArgs e)
        {
            userCity1.BringToFront();
        }

        private void userCity1_Load(object sender, EventArgs e)
        {
            userSuburb1.BringToFront();
        }
    }
}
