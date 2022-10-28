
namespace ONT_2000_Project
{
    partial class UserGetPropertyByNameReport
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDisplayReport = new System.Windows.Forms.DataGridView();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPropType = new System.Windows.Forms.TextBox();
            this.btnPropTSearch = new System.Windows.Forms.Button();
            this.ptbProperty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(248, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select Property Name";
            // 
            // dgvDisplayReport
            // 
            this.dgvDisplayReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayReport.Location = new System.Drawing.Point(3, 235);
            this.dgvDisplayReport.Name = "dgvDisplayReport";
            this.dgvDisplayReport.Size = new System.Drawing.Size(726, 169);
            this.dgvDisplayReport.TabIndex = 3;
            this.dgvDisplayReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayReport_CellClick);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(21, 66);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(208, 22);
            this.txtDesc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please select Property Type  Name";
            // 
            // txtPropType
            // 
            this.txtPropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropType.Location = new System.Drawing.Point(21, 133);
            this.txtPropType.Name = "txtPropType";
            this.txtPropType.Size = new System.Drawing.Size(208, 22);
            this.txtPropType.TabIndex = 6;
            // 
            // btnPropTSearch
            // 
            this.btnPropTSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropTSearch.Location = new System.Drawing.Point(248, 132);
            this.btnPropTSearch.Name = "btnPropTSearch";
            this.btnPropTSearch.Size = new System.Drawing.Size(93, 23);
            this.btnPropTSearch.TabIndex = 7;
            this.btnPropTSearch.Text = "SEARCH";
            this.btnPropTSearch.UseVisualStyleBackColor = true;
            this.btnPropTSearch.Click += new System.EventHandler(this.btnPropTSearch_Click);
            // 
            // ptbProperty
            // 
            this.ptbProperty.Location = new System.Drawing.Point(505, 8);
            this.ptbProperty.Name = "ptbProperty";
            this.ptbProperty.Size = new System.Drawing.Size(194, 147);
            this.ptbProperty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProperty.TabIndex = 8;
            this.ptbProperty.TabStop = false;
            // 
            // UserGetPropertyByNameReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbProperty);
            this.Controls.Add(this.btnPropTSearch);
            this.Controls.Add(this.txtPropType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.dgvDisplayReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "UserGetPropertyByNameReport";
            this.Size = new System.Drawing.Size(850, 427);
            this.Load += new System.EventHandler(this.UserGetPropertyByNameReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProperty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDisplayReport;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPropType;
        private System.Windows.Forms.Button btnPropTSearch;
        private System.Windows.Forms.PictureBox ptbProperty;
    }
}
