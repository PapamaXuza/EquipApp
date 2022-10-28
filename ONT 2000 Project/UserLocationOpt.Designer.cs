
namespace ONT_2000_Project
{
    partial class UserLocationOpt
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
            this.btnCity = new System.Windows.Forms.Button();
            this.btnSuburb = new System.Windows.Forms.Button();
            this.btnProvince = new System.Windows.Forms.Button();
            this.userCity1 = new ONT_2000_Project.UserCity();
            this.userSuburb1 = new ONT_2000_Project.UserSuburb();
            this.userProvince1 = new ONT_2000_Project.UserProvince();
            this.SuspendLayout();
            // 
            // btnCity
            // 
            this.btnCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCity.Location = new System.Drawing.Point(26, 33);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(124, 23);
            this.btnCity.TabIndex = 0;
            this.btnCity.Text = "CITY";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // btnSuburb
            // 
            this.btnSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuburb.Location = new System.Drawing.Point(26, 87);
            this.btnSuburb.Name = "btnSuburb";
            this.btnSuburb.Size = new System.Drawing.Size(124, 23);
            this.btnSuburb.TabIndex = 1;
            this.btnSuburb.Text = "SUBURB";
            this.btnSuburb.UseVisualStyleBackColor = true;
            this.btnSuburb.Click += new System.EventHandler(this.btnSuburb_Click);
            // 
            // btnProvince
            // 
            this.btnProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvince.Location = new System.Drawing.Point(26, 136);
            this.btnProvince.Name = "btnProvince";
            this.btnProvince.Size = new System.Drawing.Size(124, 23);
            this.btnProvince.TabIndex = 2;
            this.btnProvince.Text = "PROVINCE";
            this.btnProvince.UseVisualStyleBackColor = true;
            this.btnProvince.Click += new System.EventHandler(this.btnProvince_Click);
            // 
            // userCity1
            // 
            this.userCity1.Location = new System.Drawing.Point(156, 15);
            this.userCity1.Name = "userCity1";
            this.userCity1.Size = new System.Drawing.Size(854, 516);
            this.userCity1.TabIndex = 5;
            // 
            // userSuburb1
            // 
            this.userSuburb1.Location = new System.Drawing.Point(156, 12);
            this.userSuburb1.Name = "userSuburb1";
            this.userSuburb1.Size = new System.Drawing.Size(753, 495);
            this.userSuburb1.TabIndex = 4;
            // 
            // userProvince1
            // 
            this.userProvince1.Location = new System.Drawing.Point(156, 12);
            this.userProvince1.Name = "userProvince1";
            this.userProvince1.Size = new System.Drawing.Size(751, 519);
            this.userProvince1.TabIndex = 3;
            // 
            // UserLocationOpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userCity1);
            this.Controls.Add(this.userSuburb1);
            this.Controls.Add(this.userProvince1);
            this.Controls.Add(this.btnProvince);
            this.Controls.Add(this.btnSuburb);
            this.Controls.Add(this.btnCity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserLocationOpt";
            this.Size = new System.Drawing.Size(1010, 531);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Button btnSuburb;
        private System.Windows.Forms.Button btnProvince;
        private UserProvince userProvince1;
        private UserSuburb userSuburb1;
        private UserCity userCity1;
    }
}
