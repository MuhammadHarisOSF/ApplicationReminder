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
    public partial class frmBank : Form
    {
        cBank oBank = new cBank();
        public frmBank()
        {
            InitializeComponent();
        }

        public frmBank(cConfiguration.pCRUD NameOfForm)
        {
            InitializeComponent();
            // String NameForm = "Create";
            if (NameOfForm == cConfiguration.pCRUD.Create)
            {
                this.Text = cConfiguration.pCreate;
                btnOk.Text = cConfiguration.pCreate;

                cmbBankName.Visible = false;
                lblcmbBankName.Visible = false;
                gvBankList.Visible = false;
                lblBankID.Visible = true;
                lblBankName.Visible = true;

                tbBankID.Visible = true;
                tbBankName.Visible = true;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Read)
            {
                btnOk.Visible = false;
                this.Text = cConfiguration.pRead;
                btnOk.Text = cConfiguration.pRead;
                gvBankList.Visible = true;
                cmbBankName.Visible = false;
                lblcmbBankName.Visible = false;

                lblBankID.Visible = false;
                lblBankName.Visible = false;
                tbBankID.ReadOnly = false;
                tbBankName.ReadOnly = false;
                tbBankID.Visible = false;
                tbBankName.Visible = false;
                btnOk.Visible = false;
                DataSet oDataSet = cBank.fGridView_Bank();
                gvBankList.DataMember = "tblBank";
                gvBankList.DataSource = oDataSet;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Update)
            {
                this.Text = cConfiguration.pUpdate;
                btnOk.Text = cConfiguration.pUpdate;

                cmbBankName.Visible = true;
                lblcmbBankName.Visible = true;
                gvBankList.Visible = false;
                lblBankID.Visible = true;
                lblBankName.Visible = true;
                tbBankID.ReadOnly = false;
                tbBankName.ReadOnly = false;
                tbBankID.Visible = true;
                tbBankName.Visible = true;

                SqlDataReader oDataReader = cBank.fDataRetrieveOnlyColumnBank();
                while (oDataReader.Read())
                {
                    this.cmbBankName.Items.Add(oDataReader.GetString(0));
                }
            }

            else if (NameOfForm == cConfiguration.pCRUD.Delete)
            {
                this.Text = cConfiguration.pDelete;
                btnOk.Text = cConfiguration.pDelete;
                gvBankList.Visible = false;
                cmbBankName.Visible = true;
                lblcmbBankName.Visible = true;

                lblBankID.Visible = true;
                lblBankName.Visible = true;
                tbBankID.ReadOnly = true;
                tbBankName.ReadOnly = true;
                tbBankID.Visible = true;
                tbBankName.Visible = true;

                SqlDataReader oDataReader = cBank.fDataRetrieveOnlyColumnBank();
                while (oDataReader.Read())
                {
                    this.cmbBankName.Items.Add(oDataReader.GetString(0));
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == cConfiguration.pCreate)
            {
                oBank.pBankName = tbBankName.Text;
                cBank.fCreateBank(oBank);
            }
            else if (btnOk.Text == cConfiguration.pRead)
            {

            }
            else if (btnOk.Text == cConfiguration.pUpdate)
            {
                oBank.pBankName = tbBankName.Text;
                cBank.fCRUD_U_Bank(oBank, cmbBankName.Text.ToString());
            }
            else if (btnOk.Text == cConfiguration.pDelete)
            {
                oBank.pBankName = tbBankName.Text;
                cBank.fCRUD_D_Bank(oBank);
            }
        }

        private void cmbBankName_SelectedValueChanged(object sender, EventArgs e)
        {
            cBank.fDataRetrieveWholeRecordBank(oBank, this.cmbBankName.SelectedItem.ToString());
            this.tbBankID.Text = Convert.ToString(oBank.pBankID);
            this.tbBankName.Text = oBank.pBankName;
        }
    }
}
