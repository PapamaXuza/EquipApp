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
    public partial class UserProvince : UserControl
    {
        public UserProvince()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtProvinceID.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = true;
            if (string.IsNullOrEmpty(txtDescription.Text) || (!Regex.IsMatch(txtDescription.Text, @"^[A-Z][a-z]+\s[A-Z][a-z]||[A-Z][a-z]+$")))
            {
                errorProv.SetError(txtDescription, "Name must start with Uppercase");
                validate = false;
            }
            if (validate)
            {
                Province prov = new Province();
                prov.ProvinceDescription = txtDescription.Text;
                int x = bll.InsertProvince(prov);
                if (x > 0)
                {
                    MessageBox.Show("Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvProvinve.DataSource = bll.DisplayProvince();
        }

        private void dgvProvinve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProvinve_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
