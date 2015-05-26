namespace SmartReminder
{
    partial class frmPayment
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
            this.gvPayment = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblcmbModeName = new System.Windows.Forms.Label();
            this.cmbModeName = new System.Windows.Forms.ComboBox();
            this.tbModeName = new System.Windows.Forms.TextBox();
            this.tbModeID = new System.Windows.Forms.TextBox();
            this.lblModeName = new System.Windows.Forms.Label();
            this.lblModeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPayment
            // 
            this.gvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPayment.Location = new System.Drawing.Point(460, 110);
            this.gvPayment.Name = "gvPayment";
            this.gvPayment.Size = new System.Drawing.Size(240, 150);
            this.gvPayment.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(273, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Tag = "";
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(147, 188);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblcmbModeName
            // 
            this.lblcmbModeName.AutoSize = true;
            this.lblcmbModeName.Location = new System.Drawing.Point(476, 64);
            this.lblcmbModeName.Name = "lblcmbModeName";
            this.lblcmbModeName.Size = new System.Drawing.Size(111, 13);
            this.lblcmbModeName.TabIndex = 14;
            this.lblcmbModeName.Text = "Select Payment Mode";
            // 
            // cmbModeName
            // 
            this.cmbModeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbModeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModeName.FormattingEnabled = true;
            this.cmbModeName.Location = new System.Drawing.Point(592, 57);
            this.cmbModeName.Name = "cmbModeName";
            this.cmbModeName.Size = new System.Drawing.Size(121, 21);
            this.cmbModeName.TabIndex = 13;
            this.cmbModeName.SelectedValueChanged += new System.EventHandler(this.cmbModeName_SelectedValueChanged);
            // 
            // tbModeName
            // 
            this.tbModeName.Location = new System.Drawing.Point(248, 91);
            this.tbModeName.Name = "tbModeName";
            this.tbModeName.Size = new System.Drawing.Size(100, 20);
            this.tbModeName.TabIndex = 12;
            // 
            // tbModeID
            // 
            this.tbModeID.Location = new System.Drawing.Point(248, 58);
            this.tbModeID.Name = "tbModeID";
            this.tbModeID.Size = new System.Drawing.Size(100, 20);
            this.tbModeID.TabIndex = 11;
            // 
            // lblModeName
            // 
            this.lblModeName.AutoSize = true;
            this.lblModeName.Location = new System.Drawing.Point(82, 94);
            this.lblModeName.Name = "lblModeName";
            this.lblModeName.Size = new System.Drawing.Size(109, 13);
            this.lblModeName.TabIndex = 10;
            this.lblModeName.Text = "Payment Mode Name";
            // 
            // lblModeID
            // 
            this.lblModeID.AutoSize = true;
            this.lblModeID.Location = new System.Drawing.Point(82, 66);
            this.lblModeID.Name = "lblModeID";
            this.lblModeID.Size = new System.Drawing.Size(92, 13);
            this.lblModeID.TabIndex = 9;
            this.lblModeID.Text = "Payment Mode ID";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 316);
            this.Controls.Add(this.gvPayment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblcmbModeName);
            this.Controls.Add(this.cmbModeName);
            this.Controls.Add(this.tbModeName);
            this.Controls.Add(this.tbModeID);
            this.Controls.Add(this.lblModeName);
            this.Controls.Add(this.lblModeID);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPayment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblcmbModeName;
        private System.Windows.Forms.ComboBox cmbModeName;
        private System.Windows.Forms.TextBox tbModeName;
        private System.Windows.Forms.TextBox tbModeID;
        private System.Windows.Forms.Label lblModeName;
        private System.Windows.Forms.Label lblModeID;
    }
}