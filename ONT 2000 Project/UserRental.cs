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
    public partial class UserRental : UserControl
    {
        public UserRental()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void UserRental_Load(object sender, EventArgs e)
        {
            txtRentalID.Enabled = false;
            cmbPropertyAgentID.DataSource = bll.LoadPropertyAgent();
            cmbPropertyAgentID.DisplayMember = "PropertyAgentDate";
            cmbPropertyAgentID.ValueMember = "PropertyAgentID";
            cmbTenant.DataSource = bll.LoadTenant();
            cmbTenant.DisplayMember = "TenantInformation";
            cmbTenant.ValueMember = "TenantID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental();
            rental.PropertyAgentID = int.Parse(cmbPropertyAgentID.SelectedValue.ToString());
            rental.TenantID = int.Parse(cmbTenant.SelectedValue.ToString());
            rental.StartDate = dtaStartDate.Value;
            rental.EndDate = dtaEndDate.Value;
            int x = bll.InsertRental(rental);
            if (x > 0)
            {
                MessageBox.Show("Added");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.DisplayRental();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental();
            rental.RentalID = int.Parse(txtRentalID.Text);
            rental.StartDate = dtaStartDate.Value;
            rental.EndDate = dtaEndDate.Value;
            int x = bll.UpdateRental(rental);
            if (x > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                txtRentalID.Text = dgvRental.SelectedRows[0].Cells["RentalID"].Value.ToString();
                cmbPropertyAgentID.Text = dgvRental.SelectedRows[0].Cells["PropertyAgentDate"].Value.ToString();
                cmbTenant.Text = dgvRental.SelectedRows[0].Cells["TenantFullName"].Value.ToString();
                dtaStartDate.Text = dgvRental.SelectedRows[0].Cells["StartDate"].Value.ToString();
                dtaEndDate.Text = dgvRental.SelectedRows[0].Cells["EndDate"].Value.ToString();
            }
        }
    }
}
