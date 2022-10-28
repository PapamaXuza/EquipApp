
namespace ONT_2000_Project
{
    partial class UserPropertyType
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPropertyType = new System.Windows.Forms.DataGridView();
            this.txtPropertyTypeID = new System.Windows.Forms.TextBox();
            this.txtPropertyTypeDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPropertyType);
            this.groupBox1.Controls.Add(this.txtPropertyTypeID);
            this.groupBox1.Controls.Add(this.txtPropertyTypeDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 330);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Type Details";
            // 
            // dgvPropertyType
            // 
            this.dgvPropertyType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyType.Location = new System.Drawing.Point(2, 168);
            this.dgvPropertyType.Name = "dgvPropertyType";
            this.dgvPropertyType.Size = new System.Drawing.Size(585, 150);
            this.dgvPropertyType.TabIndex = 13;
            // 
            // txtPropertyTypeID
            // 
            this.txtPropertyTypeID.Location = new System.Drawing.Point(322, 37);
            this.txtPropertyTypeID.Name = "txtPropertyTypeID";
            this.txtPropertyTypeID.Size = new System.Drawing.Size(265, 22);
            this.txtPropertyTypeID.TabIndex = 12;
            // 
            // txtPropertyTypeDesc
            // 
            this.txtPropertyTypeDesc.Location = new System.Drawing.Point(322, 75);
            this.txtPropertyTypeDesc.Name = "txtPropertyTypeDesc";
            this.txtPropertyTypeDesc.Size = new System.Drawing.Size(265, 22);
            this.txtPropertyTypeDesc.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Property Type Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Property TypeID:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(272, 117);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(2, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // UserPropertyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserPropertyType";
            this.Size = new System.Drawing.Size(669, 355);
            this.Load += new System.EventHandler(this.UserPropertyType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPropertyType;
        private System.Windows.Forms.TextBox txtPropertyTypeID;
        private System.Windows.Forms.TextBox txtPropertyTypeDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}
