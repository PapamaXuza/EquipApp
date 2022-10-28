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
using BLL;
using DAL;

namespace ONT_2000_Project
{
    public partial class UserAgent : UserControl
    {
        public UserAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtAgentID.Enabled = false;

            cmbStatus.Items.Add("Single");
            cmbStatus.Items.Add("Married");

            cmbAgencyID.DataSource = bll.LoadAgency();
            cmbAgencyID.DisplayMember = "AgencyName";
            cmbAgencyID.ValueMember = "AgencyID";
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
                errorProv.SetError(txtPassword, "Your password must be a minimum of 5 characters, with alteast one uppercase one, lowercase and one special character");
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
            }
            if (string.IsNullOrEmpty(cmbAgencyID.Text))
            {
                errorProv.SetError(cmbAgencyID, "Please select Agency");
            }

            if (validate)
            {
                Agent agent = new Agent();
                agent.Name = txtName.Text;
                agent.Surname = txtSurname.Text;
                agent.Email = txtEmail.Text;
                agent.Phone = int.Parse(txtPhone.Text);
                agent.Password = txtPassword.Text;
                agent.Status = cmbStatus.Text;
                agent.AgencyID = int.Parse(cmbAgencyID.SelectedValue.ToString());
                int x = bll.InsertAgent(agent);
                if (x > 0)
                {
                    MessageBox.Show("Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgent.DataSource = bll.DisplayAgent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.AgentID = int.Parse(txtAgentID.Text);
            agent.Email = txtEmail.Text;
            agent.Phone = int.Parse(txtPhone.Text);
            agent.Status = cmbStatus.Text;
            int x = bll.UpdateAgent(agent);
            if (x > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();
            agent.AgentID = int.Parse(txtAgentID.Text);
            int x = bll.DeleteAgent(agent);
            if (x > 0)
            {
                MessageBox.Show("Deleted");
            }
        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgent.SelectedRows.Count > 0)
            {
                txtAgentID.Text = dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                txtName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbAgencyID.Text = dgvAgent.SelectedRows[0].Cells["AgencyName"].Value.ToString();
            }
        }
    }
}
