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
    public partial class UserTenant : UserControl
    {
        public UserTenant()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void UserTenant_Load(object sender, EventArgs e)
        {
            txtTenantID.Enabled = false;
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

            if (string.IsNullOrEmpty(txtPhone.Text) || (!Regex.IsMatch(txtPhone.Text, @"^$|^[0-9X]{10}$")))
            {
                errorProv.SetError(txtPhone, "Please enter a correct phone number with 10 digits");
                validate = false;
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errorProv.SetError(cmbStatus, "Please select status");
                validate = false;
            }
               

            if (validate)
            {
                Tenant tenant = new Tenant();
                tenant.Name = txtName.Text;
                tenant.Surname = txtSurname.Text;
                tenant.Email = txtEmail.Text;
                tenant.Phone = int.Parse(txtPhone.Text);
                tenant.Password = txtPassword.Text;
                tenant.Status = cmbStatus.Text;



                int x = bll.InsertTenant(tenant);
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
            dgvTenant.DataSource = bll.DisplayTenant();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();
            tenant.TenantID = int.Parse(txtTenantID.Text);
            tenant.Email = txtEmail.Text;
            tenant.Phone = int.Parse(txtPhone.Text);
            tenant.Status = cmbStatus.SelectedText.ToString();
            int x = bll.UpdateTenant(tenant);
            if (x > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tenant tenant = new Tenant();
            tenant.TenantID = int.Parse(txtTenantID.Text);
            int x = bll.DeleteTenant(tenant);
            if (x > 0)
            {
                MessageBox.Show("Deleted");
            }
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            {
                txtTenantID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvTenant.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }
    }
}
