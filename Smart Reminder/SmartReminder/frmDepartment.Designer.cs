namespace SmartReminder
{
    partial class frmDepartment
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
            this.btnExit = new System.Windows.Forms.Button();
            this.gvDepartmentList = new System.Windows.Forms.DataGridView();
            this.lblcmbDepartmentName = new System.Windows.Forms.Label();
            this.cmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.tbDepartmentID = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(55, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvDepartmentList
            // 
            this.gvDepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDepartmentList.Location = new System.Drawing.Point(273, 86);
            this.gvDepartmentList.Name = "gvDepartmentList";
            this.gvDepartmentList.Size = new System.Drawing.Size(240, 150);
            this.gvDepartmentList.TabIndex = 25;
            // 
            // lblcmbDepartmentName
            // 
            this.lblcmbDepartmentName.AutoSize = true;
            this.lblcmbDepartmentName.Location = new System.Drawing.Point(249, 68);
            this.lblcmbDepartmentName.Name = "lblcmbDepartmentName";
            this.lblcmbDepartmentName.Size = new System.Drawing.Size(180, 13);
            this.lblcmbDepartmentName.TabIndex = 24;
            this.lblcmbDepartmentName.Text = "Select Department Name To Update";
            // 
            // cmbDepartmentName
            // 
            this.cmbDepartmentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDepartmentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartmentName.FormattingEnabled = true;
            this.cmbDepartmentName.Location = new System.Drawing.Point(447, 60);
            this.cmbDepartmentName.Name = "cmbDepartmentName";
            this.cmbDepartmentName.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartmentName.TabIndex = 23;
            this.cmbDepartmentName.SelectedValueChanged += new System.EventHandler(this.cmbDepartmentName_SelectedValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(175, 245);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(135, 65);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(100, 20);
            this.tbDepartmentName.TabIndex = 21;
            // 
            // tbDepartmentID
            // 
            this.tbDepartmentID.Location = new System.Drawing.Point(135, 39);
            this.tbDepartmentID.Name = "tbDepartmentID";
            this.tbDepartmentID.Size = new System.Drawing.Size(100, 20);
            this.tbDepartmentID.TabIndex = 20;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(26, 72);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(93, 13);
            this.lblDepartmentName.TabIndex = 19;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Location = new System.Drawing.Point(27, 47);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(76, 13);
            this.lblDepartmentID.TabIndex = 18;
            this.lblDepartmentID.Text = "Department ID";
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 306);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gvDepartmentList);
            this.Controls.Add(this.lblcmbDepartmentName);
            this.Controls.Add(this.cmbDepartmentName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbDepartmentName);
            this.Controls.Add(this.tbDepartmentID);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lblDepartmentID);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gvDepartmentList;
        private System.Windows.Forms.Label lblcmbDepartmentName;
        private System.Windows.Forms.ComboBox cmbDepartmentName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.TextBox tbDepartmentID;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentID;
    }
}