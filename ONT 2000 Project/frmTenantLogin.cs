﻿using System;
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
    public partial class frmTenantLogin : Form
    {
        public frmTenantLogin()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.TenantLogin(txtUsername.Text, txtPassword.Text);
            if(dt.Rows.Count==1)
            {
                frmUcTenant form = new frmUcTenant();
                form.Show();
                this.Hide();
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                lblError.Visible = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmStart form = new frmStart();
            form.Show();
            this.Hide();
        }
    }
}
