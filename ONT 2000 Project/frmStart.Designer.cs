
namespace ONT_2000_Project
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnTenant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME, PLEASE SELECT A CATAGORY THAT FIT YOUR DESCRIPTION";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(52, 200);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(153, 130);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "ADMINISTRATOR";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgent.Location = new System.Drawing.Point(239, 200);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(153, 130);
            this.btnAgent.TabIndex = 2;
            this.btnAgent.Text = "AGENT";
            this.btnAgent.UseVisualStyleBackColor = false;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnTenant
            // 
            this.btnTenant.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenant.Location = new System.Drawing.Point(433, 200);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(153, 130);
            this.btnTenant.TabIndex = 3;
            this.btnTenant.Text = "TENANT";
            this.btnTenant.UseVisualStyleBackColor = false;
            this.btnTenant.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(885, 492);
            this.Controls.Add(this.btnTenant);
            this.Controls.Add(this.btnAgent);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label1);
            this.Name = "frmStart";
            this.Text = "frmStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnTenant;
    }
}