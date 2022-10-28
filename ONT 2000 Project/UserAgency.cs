using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using BLL;

namespace ONT_2000_Project
{
    public partial class UserAgency : UserControl
    {
        public UserAgency()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtAgencyID.Enabled = false;
            cmbSuburbID.DataSource = bll.LoadSuburb();
            cmbSuburbID.DisplayMember = "SuburbDescription";
            cmbSuburbID.ValueMember = "SuburbID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = true;
            if (string.IsNullOrEmpty(txtAgencyName.Text) || (!Regex.IsMatch(txtAgencyName.Text, @"^[A-Z][a-z']+$")))
            {
                errorProv.SetError(txtAgencyName, "Name must start with Uppercase");
                validate = false;
            }

            if (validate)
            {
                Agency agency = new Agency();
                agency.AgencyName = txtAgencyName.Text;
                agency.SuburbID = int.Parse(cmbSuburbID.SelectedValue.ToString());
                int x = bll.InsertAgency(agency);
                if (x > 0)
                {
                    MessageBox.Show("Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgency.DataSource = bll.DisplayAgency();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency();
            agency.AgencyID = int.Parse(txtAgencyID.Text);
            agency.SuburbID = int.Parse(cmbSuburbID.SelectedValue.ToString());
            int x = bll.DeleteAgency(agency);
            if (x > 0)
            {
                MessageBox.Show("Deleted");
            }
        }

        private void dgvAgency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgency.SelectedRows.Count > 0)
            {
                txtAgencyID.Text = dgvAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txtAgencyName.Text = dgvAgency.SelectedRows[0].Cells["AgencyName"].Value.ToString();
                cmbSuburbID.Text = dgvAgency.SelectedRows[0].Cells["SuburbDescription"].Value.ToString();
            }
        }
    }
}
