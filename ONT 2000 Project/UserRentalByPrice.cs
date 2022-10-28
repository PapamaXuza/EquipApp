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
    public partial class UserRentalByPrice : UserControl
    {
        public UserRentalByPrice()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnPrice_Click(object sender, EventArgs e)
        {
            dgvDisplay.DataSource = bll.GetRentalsByPriceReport(double.Parse(txtPrice.Text));
        }
    }
}
