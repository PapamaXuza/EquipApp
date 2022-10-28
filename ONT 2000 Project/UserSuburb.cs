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
    public partial class UserSuburb : UserControl
    {
        public UserSuburb()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnNext_Click(object sender, EventArgs e)
        {
            UserProvince province = new UserProvince();
            province.BringToFront();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtSuburbID.Enabled = false;
            cmbCityID.DataSource = bll.LoadCity();
            cmbCityID.DisplayMember = "CityDescription";
            cmbCityID.ValueMember = "CityID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool validate = true;
            if (string.IsNullOrEmpty(txtSuburbDesc.Text) || (!Regex.IsMatch(txtSuburbDesc.Text, @"^[A-Z][a-z]+\s[A-Z][a-z]||[A-Z][a-z]+$")))
            {
                errorProv.SetError(txtSuburbDesc, "Please enter Suburb name");
                validate = false;
            }

            if (string.IsNullOrEmpty(txtPostalCode.Text) || (!Regex.IsMatch(txtPostalCode.Text, @"^$|^[0-9X]{4}$")))
            {
                errorProv.SetError(txtPostalCode, "Please enter Suburb code");
                validate = false;
            }
            if (string.IsNullOrEmpty(cmbCityID.Text))
            {
                errorProv.SetError(cmbCityID, "Please select City");
                validate = false;
            }
  
            if (validate)
            {
                Suburb suburb = new Suburb();
                suburb.SuburbDescription = txtSuburbDesc.Text;
                suburb.PostalCode = int.Parse(txtPostalCode.Text);
                suburb.CityID = int.Parse(cmbCityID.SelectedValue.ToString());
                int x = bll.InsertSuburb(suburb);
                if (x > 0)
                {
                    MessageBox.Show(x+"Added");
                }
            }
           
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvSuburb.DataSource = bll.DisplaySuburb();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            UserCity city = new UserCity();
            city.BringToFront();
            this.Hide();
        }
    }
}
