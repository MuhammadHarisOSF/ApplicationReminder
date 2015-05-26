namespace SmartReminder
{
    partial class frmBank
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
            this.gvBankList = new System.Windows.Forms.DataGridView();
            this.lblcmbBankName = new System.Windows.Forms.Label();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbBankName = new System.Windows.Forms.TextBox();
            this.tbBankID = new System.Windows.Forms.TextBox();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblBankID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvBankList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(29, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvBankList
            // 
            this.gvBankList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBankList.Location = new System.Drawing.Point(247, 93);
            this.gvBankList.Name = "gvBankList";
            this.gvBankList.Size = new System.Drawing.Size(240, 150);
            this.gvBankList.TabIndex = 16;
            // 
            // lblcmbBankName
            // 
            this.lblcmbBankName.AutoSize = true;
            this.lblcmbBankName.Location = new System.Drawing.Point(223, 75);
            this.lblcmbBankName.Name = "lblcmbBankName";
            this.lblcmbBankName.Size = new System.Drawing.Size(150, 13);
            this.lblcmbBankName.TabIndex = 15;
            this.lblcmbBankName.Text = "Select Bank Name To Update";
            // 
            // cmbBankName
            // 
            this.cmbBankName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBankName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(380, 66);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(121, 21);
            this.cmbBankName.TabIndex = 14;
            this.cmbBankName.SelectedValueChanged += new System.EventHandler(this.cmbBankName_SelectedValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(149, 252);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbBankName
            // 
            this.tbBankName.Location = new System.Drawing.Point(109, 72);
            this.tbBankName.Name = "tbBankName";
            this.tbBankName.Size = new System.Drawing.Size(100, 20);
            this.tbBankName.TabIndex = 12;
            // 
            // tbBankID
            // 
            this.tbBankID.Location = new System.Drawing.Point(109, 46);
            this.tbBankID.Name = "tbBankID";
            this.tbBankID.Size = new System.Drawing.Size(100, 20);
            this.tbBankID.TabIndex = 11;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Location = new System.Drawing.Point(0, 79);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(63, 13);
            this.lblBankName.TabIndex = 10;
            this.lblBankName.Text = "Bank Name";
            // 
            // lblBankID
            // 
            this.lblBankID.AutoSize = true;
            this.lblBankID.Location = new System.Drawing.Point(1, 54);
            this.lblBankID.Name = "lblBankID";
            this.lblBankID.Size = new System.Drawing.Size(46, 13);
            this.lblBankID.TabIndex = 9;
            this.lblBankID.Text = "Bank ID";
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gvBankList);
            this.Controls.Add(this.lblcmbBankName);
            this.Controls.Add(this.cmbBankName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbBankName);
            this.Controls.Add(this.tbBankID);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.lblBankID);
            this.Name = "frmBank";
            this.Text = "frmBank";
            ((System.ComponentModel.ISupportInitialize)(this.gvBankList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gvBankList;
        private System.Windows.Forms.Label lblcmbBankName;
        private System.Windows.Forms.ComboBox cmbBankName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbBankName;
        private System.Windows.Forms.TextBox tbBankID;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblBankID;
    }
}