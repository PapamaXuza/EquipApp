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
    public partial class UserCity : UserControl
    {
        public UserCity()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            
        }

        private void UserCity_Load(object sender, EventArgs e)
        {
            txtCityID.Enabled = false;
            cmbProvinceID.DataSource = bll.LoadProvince();
            cmbProvinceID.DisplayMember = "ProvinceDescription";
            cmbProvinceID.ValueMember = "ProvinceID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = true;
            if (string.IsNullOrEmpty(txtCityDesc.Text) || (!Regex.IsMatch(txtCityDesc.Text, @"")))
            {
                errorProv.SetError(txtCityDesc, "Name must start with Uppercase");
                validate = false;
            }

            if (validate)
            {
                City city = new City();
                city.CityDescription = txtCityDesc.Text;
                city.ProvinceID = int.Parse(cmbProvinceID.SelectedValue.ToString());
                int x = bll.InsertCity(city);
                if (x > 0)
                {
                    MessageBox.Show("Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvCity.DataSource = bll.DisplayCity();
        }
    }
}
