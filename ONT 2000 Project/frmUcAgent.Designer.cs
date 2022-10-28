
namespace ONT_2000_Project
{
    partial class frmUcAgent
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
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.userMainReports1 = new ONT_2000_Project.UserMainReports();
            this.userRental1 = new ONT_2000_Project.UserRental();
            this.userProperty1 = new ONT_2000_Project.UserProperty();
            this.userAgent1 = new ONT_2000_Project.UserAgent();
            this.userWelcome1 = new ONT_2000_Project.UserWelcome();
            this.SuspendLayout();
            // 
            // btnAgent
            // 
            this.btnAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgent.Location = new System.Drawing.Point(3, 26);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(115, 43);
            this.btnAgent.TabIndex = 0;
            this.btnAgent.Text = "AGENT";
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperties.Location = new System.Drawing.Point(3, 91);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(115, 43);
            this.btnProperties.TabIndex = 1;
            this.btnProperties.Text = "PROPERTIES";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnRental
            // 
            this.btnRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRental.Location = new System.Drawing.Point(3, 153);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(115, 43);
            this.btnRental.TabIndex = 2;
            this.btnRental.Text = "RENTAL";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "SIGN OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(3, 202);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(115, 43);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // userMainReports1
            // 
            this.userMainReports1.Location = new System.Drawing.Point(124, 12);
            this.userMainReports1.Name = "userMainReports1";
            this.userMainReports1.Size = new System.Drawing.Size(890, 449);
            this.userMainReports1.TabIndex = 11;
            // 
            // userRental1
            // 
            this.userRental1.Location = new System.Drawing.Point(124, 12);
            this.userRental1.Name = "userRental1";
            this.userRental1.Size = new System.Drawing.Size(880, 449);
            this.userRental1.TabIndex = 12;
            // 
            // userProperty1
            // 
            this.userProperty1.Location = new System.Drawing.Point(124, 12);
            this.userProperty1.Name = "userProperty1";
            this.userProperty1.Size = new System.Drawing.Size(880, 453);
            this.userProperty1.TabIndex = 13;
            // 
            // userAgent1
            // 
            this.userAgent1.Location = new System.Drawing.Point(124, 12);
            this.userAgent1.Name = "userAgent1";
            this.userAgent1.Size = new System.Drawing.Size(880, 449);
            this.userAgent1.TabIndex = 14;
            // 
            // userWelcome1
            // 
            this.userWelcome1.Location = new System.Drawing.Point(124, 12);
            this.userWelcome1.Name = "userWelcome1";
            this.userWelcome1.Size = new System.Drawing.Size(880, 453);
            this.userWelcome1.TabIndex = 15;
            // 
            // frmUcAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1026, 470);
            this.Controls.Add(this.userWelcome1);
            this.Controls.Add(this.userAgent1);
            this.Controls.Add(this.userProperty1);
            this.Controls.Add(this.userRental1);
            this.Controls.Add(this.userMainReports1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.btnProperties);
            this.Controls.Add(this.btnAgent);
            this.Name = "frmUcAgent";
            this.Text = "frmUcAgent";
            this.Load += new System.EventHandler(this.frmUcAgent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReports;
        private UserMainReports userMainReports1;
        private UserRental userRental1;
        private UserProperty userProperty1;
        private UserAgent userAgent1;
        private UserWelcome userWelcome1;
    }
}