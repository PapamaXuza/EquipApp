
namespace ONT_2000_Project
{
    partial class UserReportsByName
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTenant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgent
            // 
            this.btnAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgent.Location = new System.Drawing.Point(559, 36);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(86, 23);
            this.btnAgent.TabIndex = 0;
            this.btnAgent.Text = "SEARCH";
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEARCH AGENT BY NAME";
            // 
            // txtAgent
            // 
            this.txtAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgent.Location = new System.Drawing.Point(251, 36);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(273, 22);
            this.txtAgent.TabIndex = 2;
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(3, 170);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(656, 216);
            this.dgvDisplay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEARCH ADMIN BY NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEARCH TENANT BY NAME";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.Location = new System.Drawing.Point(251, 76);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(273, 22);
            this.txtAdmin.TabIndex = 6;
            // 
            // txtTenant
            // 
            this.txtTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenant.Location = new System.Drawing.Point(251, 125);
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.Size = new System.Drawing.Size(273, 22);
            this.txtTenant.TabIndex = 7;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(559, 77);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(86, 23);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "SEARCH";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTenant
            // 
            this.btnTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenant.Location = new System.Drawing.Point(559, 126);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(86, 23);
            this.btnTenant.TabIndex = 9;
            this.btnTenant.Text = "SEARCH";
            this.btnTenant.UseVisualStyleBackColor = true;
            this.btnTenant.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // UserReportsByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTenant);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtTenant);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.txtAgent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgent);
            this.Name = "UserReportsByName";
            this.Size = new System.Drawing.Size(785, 417);
            this.Load += new System.EventHandler(this.UserReportsByName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.TextBox txtTenant;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnTenant;
    }
}
