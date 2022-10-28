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
    public partial class UserPropertyAgent : UserControl
    {
        public UserPropertyAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtPropertyAgentID.Enabled = false;
            cmbPropertyID.DataSource = bll.LoadProperty();
            cmbPropertyID.DisplayMember = "Description";
            cmbPropertyID.ValueMember = "PropertyID";
            cmbAgentID.DataSource = bll.LoadAgent();
            cmbAgentID.DisplayMember = "AgentFullName";
            cmbAgentID.ValueMember = "AgentID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyAgent propertyagent = new PropertyAgent();
            propertyagent.PropertyID = int.Parse(cmbPropertyID.SelectedValue.ToString());
            propertyagent.AgentID = int.Parse(cmbAgentID.SelectedValue.ToString());
            propertyagent.Date = dtaDate.Value;
            int x = bll.InsertPropertyAgent(propertyagent);
            if (x > 0)
            {
                MessageBox.Show("Added");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyAgent.DataSource = bll.DisplayPropertyAgent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertyAgent propertyagent = new PropertyAgent();
            propertyagent.PropertyAgentID = int.Parse(txtPropertyAgentID.Text);
            propertyagent.PropertyID = int.Parse(cmbPropertyID.SelectedValue.ToString());
            propertyagent.AgentID = int.Parse(cmbAgentID.SelectedValue.ToString());
            propertyagent.Date = dtaDate.Value;
            int x = bll.UpdateProprtyAgent(propertyagent);
            if (x > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void dgvPropertyAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropertyAgent.SelectedRows.Count > 0)
            {
                txtPropertyAgentID.Text = dgvPropertyAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbPropertyID.Text = dgvPropertyAgent.SelectedRows[0].Cells["Description"].Value.ToString();
                cmbAgentID.Text = dgvPropertyAgent.SelectedRows[0].Cells["AgentDetails"].Value.ToString();
                dtaDate.Text = dgvPropertyAgent.SelectedRows[0].Cells["Date"].Value.ToString();

            }
        }
    }
}
