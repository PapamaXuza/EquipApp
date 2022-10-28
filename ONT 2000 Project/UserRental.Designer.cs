
namespace ONT_2000_Project
{
    partial class UserRental
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtaEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtaStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTenant = new System.Windows.Forms.ComboBox();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbPropertyAgentID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtaEndDate);
            this.groupBox1.Controls.Add(this.dtaStartDate);
            this.groupBox1.Controls.Add(this.cmbTenant);
            this.groupBox1.Controls.Add(this.dgvRental);
            this.groupBox1.Controls.Add(this.txtRentalID);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbPropertyAgentID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental Details";
            // 
            // dtaEndDate
            // 
            this.dtaEndDate.Location = new System.Drawing.Point(322, 182);
            this.dtaEndDate.Name = "dtaEndDate";
            this.dtaEndDate.Size = new System.Drawing.Size(220, 22);
            this.dtaEndDate.TabIndex = 23;
            // 
            // dtaStartDate
            // 
            this.dtaStartDate.Location = new System.Drawing.Point(322, 142);
            this.dtaStartDate.Name = "dtaStartDate";
            this.dtaStartDate.Size = new System.Drawing.Size(220, 22);
            this.dtaStartDate.TabIndex = 22;
            // 
            // cmbTenant
            // 
            this.cmbTenant.FormattingEnabled = true;
            this.cmbTenant.Location = new System.Drawing.Point(322, 112);
            this.cmbTenant.Name = "cmbTenant";
            this.cmbTenant.Size = new System.Drawing.Size(220, 24);
            this.cmbTenant.TabIndex = 21;
            // 
            // dgvRental
            // 
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Location = new System.Drawing.Point(9, 272);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.Size = new System.Drawing.Size(742, 130);
            this.dgvRental.TabIndex = 20;
            this.dgvRental.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRental_CellClick);
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(322, 34);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(218, 22);
            this.txtRentalID.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(274, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(144, 233);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbPropertyAgentID
            // 
            this.cmbPropertyAgentID.FormattingEnabled = true;
            this.cmbPropertyAgentID.Location = new System.Drawing.Point(322, 68);
            this.cmbPropertyAgentID.Name = "cmbPropertyAgentID";
            this.cmbPropertyAgentID.Size = new System.Drawing.Size(220, 24);
            this.cmbPropertyAgentID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TenantID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PropertyAgentID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RentalID:";
            // 
            // UserRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserRental";
            this.Size = new System.Drawing.Size(923, 525);
            this.Load += new System.EventHandler(this.UserRental_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtaEndDate;
        private System.Windows.Forms.DateTimePicker dtaStartDate;
        private System.Windows.Forms.ComboBox cmbTenant;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbPropertyAgentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
