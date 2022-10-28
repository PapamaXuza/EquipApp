using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;
using BLL;

namespace ONT_2000_Project
{
    public partial class UserGetPropertyByNameReport : UserControl
    {
        public UserGetPropertyByNameReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void UserGetPropertyByNameReport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDisplayReport.DataSource = bll.GetPropertyByName(txtDesc.Text);
           
        }

        private void btnPropTSearch_Click(object sender, EventArgs e)
        {
            dgvDisplayReport.DataSource = bll.GetPropertyTypeByName(txtPropType.Text);
           
        }

        private void dgvDisplayReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(dgvDisplayReport.SelectedRows.Count > 0)
            {
                byte[] imgData = (byte[])dgvDisplayReport.CurrentRow.Cells[8].Value;
                MemoryStream ms = new MemoryStream(imgData);
                ptbProperty.Image = Image.FromStream(ms);
            }
               
        }
    }
}
