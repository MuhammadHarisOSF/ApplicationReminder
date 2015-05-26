using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SmartReminder
{
    public partial class frmHBFCBranch : Form
    {
        cHBFCBranch oHBFCBranch = new cHBFCBranch();
        public frmHBFCBranch()
        {
            InitializeComponent();
        }

        public frmHBFCBranch(cConfiguration.pCRUD NameOfForm)
        {
            InitializeComponent();
            if (NameOfForm == cConfiguration.pCRUD.Create)
            {
                this.Text = cConfiguration.pCreate;
                btnOk.Text = cConfiguration.pCreate;

                cmbHBFCBranchName.Visible = false;
                lblcmbHBFCBranchName.Visible = false;
                gvHBFCBranchList.Visible = false;
                lblHBFCBranchID.Visible = true;
                lblHBFCBranchName.Visible = true;

                tbHBFCBranchID.Visible = true;
                tbHBFCBranchName.Visible = true;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Read)
            {
                btnOk.Visible = false;
                this.Text = cConfiguration.pRead;
                btnOk.Text = cConfiguration.pRead;
                gvHBFCBranchList.Visible = true;
                cmbHBFCBranchName.Visible = false;
                lblcmbHBFCBranchName.Visible = false;

                lblHBFCBranchID.Visible = false;
                lblHBFCBranchName.Visible = false;
                tbHBFCBranchID.ReadOnly = false;
                tbHBFCBranchName.ReadOnly = false;
                tbHBFCBranchID.Visible = false;
                tbHBFCBranchName.Visible = false;
                btnOk.Visible = false;
                DataSet oDataSet = cBank.fGridView_Bank();
                gvHBFCBranchList.DataMember = "tblHBFCBranch";
                gvHBFCBranchList.DataSource = oDataSet;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Update)
            {
                this.Text = cConfiguration.pUpdate;
                btnOk.Text = cConfiguration.pUpdate;

                cmbHBFCBranchName.Visible = true;
                lblcmbHBFCBranchName.Visible = true;
                gvHBFCBranchList.Visible = false;
                lblHBFCBranchID.Visible = true;
                lblHBFCBranchName.Visible = true;
                tbHBFCBranchID.ReadOnly = false;
                tbHBFCBranchName.ReadOnly = false;
                tbHBFCBranchID.Visible = true;
                tbHBFCBranchName.Visible = true;

                SqlDataReader oDataReader = cBank.fDataRetrieveOnlyColumnBank();
                while (oDataReader.Read())
                {
                    this.cmbHBFCBranchName.Items.Add(oDataReader.GetString(0));
                }
            }

            else if (NameOfForm == cConfiguration.pCRUD.Delete)
            {
                this.Text = cConfiguration.pDelete;
                btnOk.Text = cConfiguration.pDelete;
                gvHBFCBranchList.Visible = false;
                cmbHBFCBranchName.Visible = true;
                lblcmbHBFCBranchName.Visible = true;

                lblHBFCBranchID.Visible = true;
                lblHBFCBranchName.Visible = true;
                tbHBFCBranchID.ReadOnly = true;
                tbHBFCBranchName.ReadOnly = true;
                tbHBFCBranchID.Visible = true;
                tbHBFCBranchName.Visible = true;

                SqlDataReader oDataReader = cBank.fDataRetrieveOnlyColumnBank();
                while (oDataReader.Read())
                {
                    this.cmbHBFCBranchName.Items.Add(oDataReader.GetString(0));
                }
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == cConfiguration.pCreate)
            {
                oHBFCBranch.pHBFCBranchName = tbHBFCBranchName.Text;
                oHBFCBranch.pHBFCBranchID = Convert.ToInt16(tbHBFCBranchID.Text);
                cHBFCBranch.fCreateHBFCBranch(oHBFCBranch);
            }
            else if (btnOk.Text == cConfiguration.pRead)
            {

            }
            else if (btnOk.Text == cConfiguration.pUpdate)
            {
                oHBFCBranch.pHBFCBranchID = Convert.ToInt16(tbHBFCBranchID.Text);
                oHBFCBranch.pHBFCBranchName = tbHBFCBranchName.Text;
                cHBFCBranch.fCRUD_U_HBFCBranch(oHBFCBranch, cmbHBFCBranchName.Text.ToString());
            }
            else if (btnOk.Text == cConfiguration.pDelete)
            {
                oHBFCBranch.pHBFCBranchName = tbHBFCBranchName.Text;
                cHBFCBranch.fCRUD_D_HBFCBranch(oHBFCBranch);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbHBFCBranchName_SelectedValueChanged(object sender, EventArgs e)
        {
            cHBFCBranch.fDataRetrieveWholeRecordHBFCBranch(oHBFCBranch, this.cmbHBFCBranchName.SelectedItem.ToString());
            this.tbHBFCBranchID.Text = Convert.ToString(oHBFCBranch.pHBFCBranchID);
            this.tbHBFCBranchName.Text = oHBFCBranch.pHBFCBranchName;
        }

        private void frmHBFCBranch_Load(object sender, EventArgs e)
        {

        }
    }
}
