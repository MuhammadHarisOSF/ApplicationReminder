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
    public partial class frmIssue : Form
    {
        cPayment oPayment = new cPayment();

        cBank oBank = new cBank();

        cIssue oIssue = new cIssue();

        cHBFCBranch oHBFCBranch = new cHBFCBranch();
        public frmIssue()
        {
            InitializeComponent();
        }

        public frmIssue(cConfiguration.pCRUD NameOfForm)
        {
            InitializeComponent();
            if (NameOfForm == cConfiguration.pCRUD.Create)
            {
                this.Text = cConfiguration.pCreate;
                btnOk.Text = cConfiguration.pCreate;

                SqlDataReader oDataReader = cIssue.fDataRetrieveOnlyColumnTblBank();
                while (oDataReader.Read())
                {

                    this.cmbBankName.Items.Add(oDataReader.GetString(0));

                }

                SqlDataReader oDataReader1 = cIssue.fDataRetrieveOnlyColumnTblHBFCBranch();
                while (oDataReader1.Read())
                {

                    this.cmbBranchName.Items.Add(oDataReader1.GetString(0));

                }

                SqlDataReader oDataReader2 = cIssue.fDataRetrieveOnlyColumnTblPayment();
                while (oDataReader2.Read())
                {

                    this.cmbBankName.Items.Add(oDataReader2.GetString(0));

                }
            }

            else if (NameOfForm == cConfiguration.pCRUD.Read)
            {
                btnOk.Visible = false;
                this.Text = cConfiguration.pRead;
                btnOk.Text = cConfiguration.pRead;

                this.dGTblIssue.Visible = true;

                DataSet oDataSet = cIssue.fGridViewIssue();
                dGTblIssue.DataMember = "tblIssue";
                dGTblIssue.DataSource = oDataSet;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Update)
            {
                this.Text = cConfiguration.pUpdate;
                btnOk.Text = cConfiguration.pUpdate;

                this.dGTblIssue.Visible = true;

                DataSet oDataSet = cIssue.fGridViewIssue();
                dGTblIssue.DataMember = "tblIssue";
                dGTblIssue.DataSource = oDataSet;

                SqlDataReader oDataReader = cIssue.fDataRetrieveOnlyColumnTblBank();
                while (oDataReader.Read())
                {

                    this.cmbBankName.Items.Add(oDataReader.GetString(0));

                }

                SqlDataReader oDataReader1 = cIssue.fDataRetrieveOnlyColumnTblHBFCBranch();
                while (oDataReader1.Read())
                {

                    this.cmbBranchName.Items.Add(oDataReader1.GetString(0));

                }

                SqlDataReader oDataReader2 = cIssue.fDataRetrieveOnlyColumnTblPayment();
                while (oDataReader2.Read())
                {

                    this.cmbBankName.Items.Add(oDataReader2.GetString(0));

                }
            }

            else if (NameOfForm == cConfiguration.pCRUD.Delete)
            {
                this.Text = cConfiguration.pDelete;
                btnOk.Text = cConfiguration.pDelete;

                this.dGTblIssue.Visible = true;

                DataSet oDataSet = cIssue.fGridViewIssue();
                dGTblIssue.DataMember = "tblIssue";
                dGTblIssue.DataSource = oDataSet;

                this.tbAccountNumber.ReadOnly = true;
                this.tbReportDate.ReadOnly = true;
                this.tbForwardDate.ReadOnly = true;
                this.tbResolveDate.ReadOnly = true;
                this.cmbBankName.Enabled = false;
                this.cmbBranchName.Enabled = false;
                this.tbDepositSlipNo.ReadOnly = true;
                this.tbCheckNo.ReadOnly = true;
                this.tbPayOrderNo.ReadOnly = true;
                this.tbReferance.ReadOnly = true;
                this.rTbRemarks.ReadOnly = true;

                this.lblPaymentMode.Visible = false;
                this.cmbPaymnetMode.Visible = false;
            }
        }



        private void frmIssue_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == cConfiguration.pCreate)
            {
                oIssue.pIssueReportDate = Convert.ToDateTime(this.tbReportDate.Text);
                oIssue.pIssueForwardDate = Convert.ToDateTime(this.tbForwardDate.Text);
                oIssue.pIssueResolvedDate = Convert.ToDateTime(this.tbResolveDate.Text);
                oBank.pBankName = this.cmbBankName.SelectedItem.ToString();
                oHBFCBranch.pHBFCBranchName = this.cmbBranchName.SelectedItem.ToString();
                oPayment.pModeName = this.cmbPaymnetMode.SelectedItem.ToString();
                oIssue.pRemarks = this.rTbRemarks.Text;
                oIssue.pReferance = this.tbReferance.Text;
                oIssue.pDepositSlipNo = Convert.ToInt16(this.tbDepositSlipNo.Text);
                oIssue.pChequeNo = Convert.ToInt16(this.tbCheckNo.Text);
                oIssue.pPayOrderNo = Convert.ToInt16(this.tbCheckNo.Text);
                oIssue.pAccountNo = Convert.ToInt16(this.tbAccountNumber.Text);

                cIssue.fCreateIssue(oIssue,oPayment,oHBFCBranch, oBank);

                this.tbAccountNumber.Clear();
                this.tbReportDate.Clear();
                this.tbForwardDate.Clear();
                this.tbResolveDate.Clear();
                this.cmbBankName.Items.Clear();
                this.cmbBranchName.Items.Clear();
                this.cmbPaymnetMode.Items.Clear();
                this.rTbRemarks.Clear();
                this.tbReferance.Clear();
                this.tbDepositSlipNo.Clear();
                this.tbCheckNo.Clear();
                this.tbPayOrderNo.Clear();

                
            }

            if(btnOk.Text == cConfiguration.pDelete)
            {
                cIssue.fDeleteTblIssue(oIssue);
            }

            if(btnOk.Text == cConfiguration.pUpdate)
            {
                oIssue.pIssueReportDate = Convert.ToDateTime(this.tbReportDate.Text);
                oIssue.pIssueForwardDate = Convert.ToDateTime(this.tbForwardDate.Text);
                oIssue.pIssueResolvedDate = Convert.ToDateTime(this.tbResolveDate.Text);
                oBank.pBankName = this.cmbBankName.SelectedItem.ToString();
                oHBFCBranch.pHBFCBranchName = this.cmbBranchName.SelectedItem.ToString();
                oPayment.pModeName = this.cmbPaymnetMode.SelectedItem.ToString();
                oIssue.pRemarks = this.rTbRemarks.Text;
                oIssue.pReferance = this.tbReferance.Text;
                oIssue.pDepositSlipNo = Convert.ToInt16(this.tbDepositSlipNo.Text);
                oIssue.pChequeNo = Convert.ToInt16(this.tbCheckNo.Text);
                oIssue.pPayOrderNo = Convert.ToInt16(this.tbCheckNo.Text);
                oIssue.pAccountNo = Convert.ToInt16(this.tbAccountNumber.Text);

                cIssue.fUpdateTblIssue(oIssue, oPayment, oBank, oHBFCBranch);

                this.tbAccountNumber.Clear();
                this.tbReportDate.Clear();
                this.tbForwardDate.Clear();
                this.tbResolveDate.Clear();
                this.cmbBankName.Items.Clear();
                this.cmbBranchName.Items.Clear();
                this.cmbPaymnetMode.Items.Clear();
                this.rTbRemarks.Clear();
                this.tbReferance.Clear();
                this.tbDepositSlipNo.Clear();
                this.tbCheckNo.Clear();
                this.tbPayOrderNo.Clear();
            }
        }
    }
}
