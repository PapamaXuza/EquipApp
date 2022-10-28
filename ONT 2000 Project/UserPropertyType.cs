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
    public partial class UserPropertyType : UserControl
    {
        public UserPropertyType()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool validate = true;
            if (string.IsNullOrEmpty(txtPropertyTypeDesc.Text) || (!Regex.IsMatch(txtPropertyTypeDesc.Text, @"^[A-Z][a-z]+\s[A-Z][a-z]||[A-Z][a-z]+$")))
            {
                errorProv.SetError(txtPropertyTypeDesc, "Name must start with Uppercase");
                validate = false;
            }
            if (validate)
            {
                PropertyType pt = new PropertyType();
                pt.PropertyTypeDescription = txtPropertyTypeDesc.Text;
                int x = bll.InsertPropertyType(pt);
                if (x > 0)
                {
                    MessageBox.Show("Added");

                }
                else
                {
                    MessageBox.Show("Something is wrong");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyType.DataSource = bll.DisplayPropertyType();
        }

        private void UserPropertyType_Load(object sender, EventArgs e)
        {
            txtPropertyTypeID.Enabled = false;
        }
    }
}
