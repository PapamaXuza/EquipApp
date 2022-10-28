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
using System.IO;

namespace ONT_2000_Project
{
    public partial class UserProperty : UserControl
    {
        public UserProperty()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void UserProperty_Load(object sender, EventArgs e)
        {
            txtPropertyID.Enabled = false;
            cmbSuburbID.DataSource = bll.LoadSuburb();
            cmbSuburbID.DisplayMember = "SuburbDescription";
            cmbSuburbID.ValueMember = "SuburbID";
            cmbPropertyTypeID.DataSource = bll.LoadPropertyType();
            cmbPropertyTypeID.DisplayMember = "PropertyTypeDescription";
            cmbPropertyTypeID.ValueMember = "PropertyTypeID";
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Title = "Open Image";
            ofdlg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";

            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                ptbProperty.Image = Image.FromFile(ofdlg.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = true;
            if (string.IsNullOrEmpty(txtDiscription.Text))
            {
                errorProv.SetError(txtDiscription, "Please enter Property Name");
                validate = false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProv.SetError(txtPrice, "Please enter Price");
                validate = false;
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errorProv.SetError(cmbStatus, "Please select status");
                validate = false;
            }

            if (validate)
            {
                Image img = ptbProperty.Image;
                byte[] arr;
                ImageConverter Converter = new ImageConverter();

                arr = (byte[])Converter.ConvertTo(img, typeof(byte[]));

                Propertly propertly = new Propertly();
                propertly.Description = txtDiscription.Text;
                propertly.Price = double.Parse(txtPrice.Text);
                propertly.Image = arr;
                propertly.PropertyTypeID = int.Parse(cmbPropertyTypeID.SelectedValue.ToString());
                propertly.Status = cmbStatus.SelectedItem.ToString();
                propertly.SuburbID = int.Parse(cmbSuburbID.SelectedValue.ToString());
                int x = bll.InsertProperty(propertly);
                if (x > 0)
                {
                    MessageBox.Show("Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvProperty.DataSource = bll.DisplayProperty();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Propertly propertly = new Propertly();
            propertly.PropertyID = int.Parse(txtPropertyID.Text);
            propertly.Price = double.Parse(txtPrice.Text);
            propertly.PropertyTypeID = int.Parse(cmbPropertyTypeID.SelectedValue.ToString());
            propertly.Status = cmbStatus.SelectedItem.ToString();

            int x = bll.UpdateProperty(propertly);
            if (x > 0)
            {
                MessageBox.Show("Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Propertly propertly = new Propertly();
            propertly.PropertyID = int.Parse(txtPropertyID.Text);
            int x = bll.DeleteProperty(propertly);
            if (x > 0)
            {
                MessageBox.Show("Deleted");
            }
        }

        private void dgvProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProperty.SelectedRows.Count > 0)
            {
                txtPropertyID.Text = dgvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txtDiscription.Text = dgvProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txtPrice.Text = dgvProperty.SelectedRows[0].Cells["Price"].Value.ToString();
                cmbPropertyTypeID.Text = dgvProperty.SelectedRows[0].Cells["PropertyTypeDescription"].Value.ToString();
                cmbStatus.Text = dgvProperty.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbSuburbID.Text = dgvProperty.SelectedRows[0].Cells["SuburbDescription"].Value.ToString();
                byte[] imgData = (byte[])dgvProperty.CurrentRow.Cells[3].Value;
                MemoryStream ms = new MemoryStream(imgData);
                ptbProperty.Image = Image.FromStream(ms);
            }
        }
    }
}
