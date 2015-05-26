namespace SmartReminder
{
    partial class frmHBFCBranch
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
            this.gvHBFCBranchList = new System.Windows.Forms.DataGridView();
            this.lblcmbHBFCBranchName = new System.Windows.Forms.Label();
            this.cmbHBFCBranchName = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbHBFCBranchName = new System.Windows.Forms.TextBox();
            this.tbHBFCBranchID = new System.Windows.Forms.TextBox();
            this.lblHBFCBranchName = new System.Windows.Forms.Label();
            this.lblHBFCBranchID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvHBFCBranchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(111, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvHBFCBranchList
            // 
            this.gvHBFCBranchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHBFCBranchList.Location = new System.Drawing.Point(329, 89);
            this.gvHBFCBranchList.Name = "gvHBFCBranchList";
            this.gvHBFCBranchList.Size = new System.Drawing.Size(294, 150);
            this.gvHBFCBranchList.TabIndex = 25;
            // 
            // lblcmbHBFCBranchName
            // 
            this.lblcmbHBFCBranchName.AutoSize = true;
            this.lblcmbHBFCBranchName.Location = new System.Drawing.Point(306, 65);
            this.lblcmbHBFCBranchName.Name = "lblcmbHBFCBranchName";
            this.lblcmbHBFCBranchName.Size = new System.Drawing.Size(190, 13);
            this.lblcmbHBFCBranchName.TabIndex = 24;
            this.lblcmbHBFCBranchName.Text = "Select HBFC Branch Name To Update";
            // 
            // cmbHBFCBranchName
            // 
            this.cmbHBFCBranchName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHBFCBranchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHBFCBranchName.FormattingEnabled = true;
            this.cmbHBFCBranchName.Location = new System.Drawing.Point(502, 62);
            this.cmbHBFCBranchName.Name = "cmbHBFCBranchName";
            this.cmbHBFCBranchName.Size = new System.Drawing.Size(121, 21);
            this.cmbHBFCBranchName.TabIndex = 23;
            this.cmbHBFCBranchName.SelectedValueChanged += new System.EventHandler(this.cmbHBFCBranchName_SelectedValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(231, 248);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbHBFCBranchName
            // 
            this.tbHBFCBranchName.Location = new System.Drawing.Point(191, 68);
            this.tbHBFCBranchName.Name = "tbHBFCBranchName";
            this.tbHBFCBranchName.Size = new System.Drawing.Size(100, 20);
            this.tbHBFCBranchName.TabIndex = 21;
            // 
            // tbHBFCBranchID
            // 
            this.tbHBFCBranchID.Location = new System.Drawing.Point(191, 42);
            this.tbHBFCBranchID.Name = "tbHBFCBranchID";
            this.tbHBFCBranchID.Size = new System.Drawing.Size(100, 20);
            this.tbHBFCBranchID.TabIndex = 20;
            // 
            // lblHBFCBranchName
            // 
            this.lblHBFCBranchName.AutoSize = true;
            this.lblHBFCBranchName.Location = new System.Drawing.Point(82, 75);
            this.lblHBFCBranchName.Name = "lblHBFCBranchName";
            this.lblHBFCBranchName.Size = new System.Drawing.Size(103, 13);
            this.lblHBFCBranchName.TabIndex = 19;
            this.lblHBFCBranchName.Text = "HBFC Branch Name";
            // 
            // lblHBFCBranchID
            // 
            this.lblHBFCBranchID.AutoSize = true;
            this.lblHBFCBranchID.Location = new System.Drawing.Point(83, 50);
            this.lblHBFCBranchID.Name = "lblHBFCBranchID";
            this.lblHBFCBranchID.Size = new System.Drawing.Size(100, 13);
            this.lblHBFCBranchID.TabIndex = 18;
            this.lblHBFCBranchID.Text = "HBFC Branch Code";
            // 
            // frmHBFCBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 312);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gvHBFCBranchList);
            this.Controls.Add(this.lblcmbHBFCBranchName);
            this.Controls.Add(this.cmbHBFCBranchName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbHBFCBranchName);
            this.Controls.Add(this.tbHBFCBranchID);
            this.Controls.Add(this.lblHBFCBranchName);
            this.Controls.Add(this.lblHBFCBranchID);
            this.Name = "frmHBFCBranch";
            this.Text = "frmHBFCBranch";
            this.Load += new System.EventHandler(this.frmHBFCBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHBFCBranchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gvHBFCBranchList;
        private System.Windows.Forms.Label lblcmbHBFCBranchName;
        private System.Windows.Forms.ComboBox cmbHBFCBranchName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbHBFCBranchName;
        private System.Windows.Forms.TextBox tbHBFCBranchID;
        private System.Windows.Forms.Label lblHBFCBranchName;
        private System.Windows.Forms.Label lblHBFCBranchID;
    }
}