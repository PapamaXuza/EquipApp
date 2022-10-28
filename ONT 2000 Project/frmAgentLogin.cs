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
    public partial class frmAgentLogin : Form
    {
        public frmAgentLogin()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.AgentLogin(txtUsername.Text, txtPassword.Text);
            if(dt.Rows.Count>0)
            {
                frmUcAgent form = new frmUcAgent();
                form.Show();
                this.Hide();
            }
            else
            {
                txtPassword.Clear();
                txtUsername.Clear();
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
