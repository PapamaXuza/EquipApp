
namespace ONT_2000_Project
{
    partial class frmUcAdmin
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
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnAgency = new System.Windows.Forms.Button();
            this.btnPropertyType = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.userMainReports1 = new ONT_2000_Project.UserMainReports();
            this.userAgent1 = new ONT_2000_Project.UserAgent();
            this.userAgency1 = new ONT_2000_Project.UserAgency();
            this.userLocationOpt1 = new ONT_2000_Project.UserLocationOpt();
            this.userPropertyType1 = new ONT_2000_Project.UserPropertyType();
            this.userProperty1 = new ONT_2000_Project.UserProperty();
            this.userAdmin1 = new ONT_2000_Project.UserAdmin();
            this.userWelcome1 = new ONT_2000_Project.UserWelcome();
            this.SuspendLayout();
            // 
            // btnLocation
            // 
            this.btnLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.Location = new System.Drawing.Point(12, 159);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(113, 43);
            this.btnLocation.TabIndex = 8;
            this.btnLocation.Text = "LOCATION";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperties.Location = new System.Drawing.Point(12, 61);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(113, 43);
            this.btnProperties.TabIndex = 7;
            this.btnProperties.Text = "PROPERTIES";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnTenant
            // 
            this.btnTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenant.Location = new System.Drawing.Point(12, 12);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(113, 43);
            this.btnTenant.TabIndex = 6;
            this.btnTenant.Text = "ADMIN";
            this.btnTenant.UseVisualStyleBackColor = true;
            this.btnTenant.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgent.Location = new System.Drawing.Point(12, 257);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(113, 43);
            this.btnAgent.TabIndex = 11;
            this.btnAgent.Text = "AGENT";
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnAgency
            // 
            this.btnAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgency.Location = new System.Drawing.Point(12, 208);
            this.btnAgency.Name = "btnAgency";
            this.btnAgency.Size = new System.Drawing.Size(113, 43);
            this.btnAgency.TabIndex = 10;
            this.btnAgency.Text = "AGENCY";
            this.btnAgency.UseVisualStyleBackColor = true;
            this.btnAgency.Click += new System.EventHandler(this.btnAgency_Click);
            // 
            // btnPropertyType
            // 
            this.btnPropertyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertyType.Location = new System.Drawing.Point(12, 110);
            this.btnPropertyType.Name = "btnPropertyType";
            this.btnPropertyType.Size = new System.Drawing.Size(113, 43);
            this.btnPropertyType.TabIndex = 9;
            this.btnPropertyType.Text = "PROPERTY TYPE";
            this.btnPropertyType.UseVisualStyleBackColor = true;
            this.btnPropertyType.Click += new System.EventHandler(this.btnPropertyType_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.Location = new System.Drawing.Point(12, 355);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(113, 43);
            this.btnSignout.TabIndex = 19;
            this.btnSignout.Text = "SIGN OUT";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(12, 306);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(113, 43);
            this.btnReports.TabIndex = 20;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // userMainReports1
            // 
            this.userMainReports1.Location = new System.Drawing.Point(126, 12);
            this.userMainReports1.Name = "userMainReports1";
            this.userMainReports1.Size = new System.Drawing.Size(881, 461);
            this.userMainReports1.TabIndex = 21;
            // 
            // userAgent1
            // 
            this.userAgent1.Location = new System.Drawing.Point(126, 12);
            this.userAgent1.Name = "userAgent1";
            this.userAgent1.Size = new System.Drawing.Size(881, 461);
            this.userAgent1.TabIndex = 22;
            // 
            // userAgency1
            // 
            this.userAgency1.Location = new System.Drawing.Point(126, 12);
            this.userAgency1.Name = "userAgency1";
            this.userAgency1.Size = new System.Drawing.Size(881, 461);
            this.userAgency1.TabIndex = 23;
            // 
            // userLocationOpt1
            // 
            this.userLocationOpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLocationOpt1.Location = new System.Drawing.Point(131, 12);
            this.userLocationOpt1.Name = "userLocationOpt1";
            this.userLocationOpt1.Size = new System.Drawing.Size(876, 461);
            this.userLocationOpt1.TabIndex = 24;
            // 
            // userPropertyType1
            // 
            this.userPropertyType1.Location = new System.Drawing.Point(131, 12);
            this.userPropertyType1.Name = "userPropertyType1";
            this.userPropertyType1.Size = new System.Drawing.Size(876, 461);
            this.userPropertyType1.TabIndex = 25;
            // 
            // userProperty1
            // 
            this.userProperty1.Location = new System.Drawing.Point(131, 12);
            this.userProperty1.Name = "userProperty1";
            this.userProperty1.Size = new System.Drawing.Size(876, 461);
            this.userProperty1.TabIndex = 26;
            // 
            // userAdmin1
            // 
            this.userAdmin1.Location = new System.Drawing.Point(126, 12);
            this.userAdmin1.Name = "userAdmin1";
            this.userAdmin1.Size = new System.Drawing.Size(881, 461);
            this.userAdmin1.TabIndex = 27;
            // 
            // userWelcome1
            // 
            this.userWelcome1.Location = new System.Drawing.Point(126, 12);
            this.userWelcome1.Name = "userWelcome1";
            this.userWelcome1.Size = new System.Drawing.Size(881, 461);
            this.userWelcome1.TabIndex = 28;
            // 
            // frmUcAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1019, 510);
            this.Controls.Add(this.userWelcome1);
            this.Controls.Add(this.userAdmin1);
            this.Controls.Add(this.userProperty1);
            this.Controls.Add(this.userPropertyType1);
            this.Controls.Add(this.userLocationOpt1);
            this.Controls.Add(this.userAgency1);
            this.Controls.Add(this.userAgent1);
            this.Controls.Add(this.userMainReports1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnAgent);
            this.Controls.Add(this.btnAgency);
            this.Controls.Add(this.btnPropertyType);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.btnTenant);
            this.Name = "frmUcAdmin";
            this.Text = "frmUcAdmin";
            this.Load += new System.EventHandler(this.frmUcAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnAgency;
        private System.Windows.Forms.Button btnPropertyType;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnReports;
        private UserMainReports userMainReports1;
        private UserAgent userAgent1;
        private UserAgency userAgency1;
        private UserLocationOpt userLocationOpt1;
        private UserPropertyType userPropertyType1;
        private UserProperty userProperty1;
        private UserAdmin userAdmin1;
        private UserWelcome userWelcome1;
    }
}