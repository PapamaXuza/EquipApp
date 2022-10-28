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
    public partial class UserAdmin : UserControl
    {
        public UserAdmin()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void UserAdmin_Load(object sender, EventArgs e)
        {
            txtAdminID.Enabled = false;
            cmbStatus.Items.Add("Single");
            cmbStatus.Items.Add("Married");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = true;
            if (string.IsNullOrEmpty(txtName.Text) || (!Regex.IsMatch(txtName.Text, @"^[A-Z][a-z']+$")))
            {
                errorProv.SetError(txtName, "Please enter Name");
                validate = false;
            }

            if (string.IsNullOrEmpty(txtSurname.Text) || (!Regex.IsMatch(txtSurname.Text, @"^[A-Z][a-z']+$")))
            {
                errorProv.SetError(txtSurname, "Please enter Surname");
                validate = false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                errorProv.SetError(txtEmail, "Please enter Email");
                validate = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) || (!Regex.IsMatch(txtPassword.Text, @"^(?=.{5,})(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+*!=]).*$")))
            {
                errorProv.SetError(txtPassword, "Please enter a password with one uppercase one lowercase and one special character");
                validate = false;
            }


            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errorProv.SetError(cmbStatus, "Please select status");
                validate = false;
            }


            if (validate)
            {
                Admin admin = new Admin();
                admin.Name = txtName.Text;
                admin.Surname = txtSurname.Text;
                admin.Email = txtEmail.Text;
                admin.Password = txtPassword.Text;
                admin.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.InsertAdmin(admin);
                if (x > 0)
                {
                    MessageBox.Show("Added");
                }

            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = bll.displayAdmin();
        }
    }
}
