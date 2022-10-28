
namespace ONT_2000_Project
{
    partial class frmUcTenant
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
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnTenant = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.userMainReports1 = new ONT_2000_Project.UserMainReports();
            this.userLocationOpt1 = new ONT_2000_Project.UserLocationOpt();
            this.userProperty1 = new ONT_2000_Project.UserProperty();
            this.userTenant1 = new ONT_2000_Project.UserTenant();
            this.userWelcome1 = new ONT_2000_Project.UserWelcome();
            this.SuspendLayout();
            // 
            // btnLocation
            // 
            this.btnLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.Location = new System.Drawing.Point(12, 139);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(104, 43);
            this.btnLocation.TabIndex = 5;
            this.btnLocation.Text = "LOCATION";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperties.Location = new System.Drawing.Point(12, 77);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(104, 43);
            this.btnProperties.TabIndex = 4;
            this.btnProperties.Text = "PROPERTIES";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnTenant
            // 
            this.btnTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenant.Location = new System.Drawing.Point(12, 12);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(104, 43);
            this.btnTenant.TabIndex = 3;
            this.btnTenant.Text = "TENANT";
            this.btnTenant.UseVisualStyleBackColor = true;
            this.btnTenant.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.Location = new System.Drawing.Point(12, 251);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(104, 43);
            this.btnSignout.TabIndex = 10;
            this.btnSignout.Text = "SIGN OUT";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(12, 188);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(104, 43);
            this.btnReports.TabIndex = 13;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // userMainReports1
            // 
            this.userMainReports1.Location = new System.Drawing.Point(122, 12);
            this.userMainReports1.Name = "userMainReports1";
            this.userMainReports1.Size = new System.Drawing.Size(879, 481);
            this.userMainReports1.TabIndex = 14;
            // 
            // userLocationOpt1
            // 
            this.userLocationOpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLocationOpt1.Location = new System.Drawing.Point(122, 12);
            this.userLocationOpt1.Name = "userLocationOpt1";
            this.userLocationOpt1.Size = new System.Drawing.Size(879, 481);
            this.userLocationOpt1.TabIndex = 15;
            // 
            // userProperty1
            // 
            this.userProperty1.Location = new System.Drawing.Point(122, 12);
            this.userProperty1.Name = "userProperty1";
            this.userProperty1.Size = new System.Drawing.Size(879, 481);
            this.userProperty1.TabIndex = 16;
            // 
            // userTenant1
            // 
            this.userTenant1.Location = new System.Drawing.Point(122, 12);
            this.userTenant1.Name = "userTenant1";
            this.userTenant1.Size = new System.Drawing.Size(879, 481);
            this.userTenant1.TabIndex = 17;
            // 
            // userWelcome1
            // 
            this.userWelcome1.Location = new System.Drawing.Point(122, 12);
            this.userWelcome1.Name = "userWelcome1";
            this.userWelcome1.Size = new System.Drawing.Size(879, 481);
            this.userWelcome1.TabIndex = 18;
            // 
            // frmUcTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1015, 519);
            this.Controls.Add(this.userWelcome1);
            this.Controls.Add(this.userTenant1);
            this.Controls.Add(this.userProperty1);
            this.Controls.Add(this.userLocationOpt1);
            this.Controls.Add(this.userMainReports1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.btnTenant);
            this.Name = "frmUcTenant";
            this.Text = "frmUcTenant";
            this.Load += new System.EventHandler(this.frmUcTenant_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnReports;
        private UserMainReports userMainReports1;
        private UserLocationOpt userLocationOpt1;
        private UserProperty userProperty1;
        private UserTenant userTenant1;
        private UserWelcome userWelcome1;
    }
}