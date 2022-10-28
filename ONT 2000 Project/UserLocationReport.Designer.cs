
namespace ONT_2000_Project
{
    partial class UserLocationReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.btnSuburb = new System.Windows.Forms.Button();
            this.btnProvince = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCity
            // 
            this.btnCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCity.Location = new System.Drawing.Point(356, 57);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(84, 23);
            this.btnCity.TabIndex = 0;
            this.btnCity.Text = "SEARCH";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEARCH USING CITY";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(3, 241);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(730, 150);
            this.dgvDisplay.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(21, 60);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(289, 22);
            this.txtCity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEARCH USING SUBURB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEARCH USING PROVINCE";
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(21, 185);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(289, 22);
            this.txtProvince.TabIndex = 6;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuburb.Location = new System.Drawing.Point(21, 126);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(289, 22);
            this.txtSuburb.TabIndex = 7;
            // 
            // btnSuburb
            // 
            this.btnSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuburb.Location = new System.Drawing.Point(356, 123);
            this.btnSuburb.Name = "btnSuburb";
            this.btnSuburb.Size = new System.Drawing.Size(84, 23);
            this.btnSuburb.TabIndex = 8;
            this.btnSuburb.Text = "SEARCH";
            this.btnSuburb.UseVisualStyleBackColor = true;
            this.btnSuburb.Click += new System.EventHandler(this.btnSuburb_Click);
            // 
            // btnProvince
            // 
            this.btnProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvince.Location = new System.Drawing.Point(356, 182);
            this.btnProvince.Name = "btnProvince";
            this.btnProvince.Size = new System.Drawing.Size(84, 23);
            this.btnProvince.TabIndex = 9;
            this.btnProvince.Text = "SEARCH";
            this.btnProvince.UseVisualStyleBackColor = true;
            this.btnProvince.Click += new System.EventHandler(this.btnProvince_Click);
            // 
            // UserLocationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProvince);
            this.Controls.Add(this.btnSuburb);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCity);
            this.Name = "UserLocationReport";
            this.Size = new System.Drawing.Size(882, 406);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Button btnSuburb;
        private System.Windows.Forms.Button btnProvince;
    }
}
