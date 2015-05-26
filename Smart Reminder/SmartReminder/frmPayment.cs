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
    public partial class frmPayment : Form
    {
        cPayment oPayment = new cPayment();
        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(cConfiguration.pCRUD NameOfForm)
        {
            InitializeComponent();
            if (NameOfForm == cConfiguration.pCRUD.Create)
            {
                this.Text = cConfiguration.pCreate;
                btnOk.Text = cConfiguration.pCreate;

                cmbModeName.Visible = false;
                lblcmbModeName.Visible = false;
                gvPayment.Visible = false;
                lblModeID.Visible = true;
                lblModeName.Visible = true;

                tbModeID.Visible = true;
                tbModeName.Visible = true;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Read)
            {
                btnOk.Visible = false;
                this.Text = cConfiguration.pRead;
                btnOk.Text = cConfiguration.pRead;
                gvPayment.Visible = true;
                cmbModeName.Visible = false;
                lblcmbModeName.Visible = false;

                lblModeID.Visible = false;
                lblModeName.Visible = false;
                tbModeID.ReadOnly = false;
                tbModeName.ReadOnly = false;
                tbModeID.Visible = false;
                tbModeName.Visible = false;
                btnOk.Visible = false;
                DataSet oDataSet = cPayment.fGridView_Payment();
                gvPayment.DataMember = "tblPayment";
                gvPayment.DataSource = oDataSet;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Update)
            {
                this.Text = cConfiguration.pUpdate;
                btnOk.Text = cConfiguration.pUpdate;

                cmbModeName.Visible = true;
                lblcmbModeName.Visible = true;
                gvPayment.Visible = false;
                lblModeID.Visible = true;
                lblModeName.Visible = true;
                tbModeID.ReadOnly = false;
                tbModeName.ReadOnly = false;
                tbModeID.Visible = true;
                tbModeName.Visible = true;

                SqlDataReader oDataReader = cPayment.fDataRetrieveOnlyColumnPayment();
                while (oDataReader.Read())
                {
                    this.cmbModeName.Items.Add(oDataReader.GetString(0));
                }
            }

            else if (NameOfForm == cConfiguration.pCRUD.Delete)
            {
                this.Text = cConfiguration.pDelete;
                btnOk.Text = cConfiguration.pDelete;
                gvPayment.Visible = false;
                cmbModeName.Visible = true;
                lblcmbModeName.Visible = true;

                lblModeID.Visible = true;
                lblModeName.Visible = true;
                tbModeID.ReadOnly = true;
                tbModeName.ReadOnly = true;
                tbModeID.Visible = true;
                tbModeName.Visible = true;

                SqlDataReader oDataReader = cPayment.fDataRetrieveOnlyColumnPayment();
                while (oDataReader.Read())
                {
                    this.cmbModeName.Items.Add(oDataReader.GetString(0));
                }
            }
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == cConfiguration.pCreate)
            {
                oPayment.pModeName = tbModeName.Text;
                cPayment.fCreatePaymentMode(oPayment);
            }
            else if (btnOk.Text == cConfiguration.pRead)
            {

            }
            else if (btnOk.Text == cConfiguration.pUpdate)
            {
                oPayment.pModeName = tbModeName.Text;
                cPayment.fCRUD_U_Payment(oPayment, cmbModeName.Text.ToString());
            }
            else if (btnOk.Text == cConfiguration.pDelete)
            {
                oPayment.pModeName = tbModeName.Text;
                cPayment.fCRUD_D_Payment(oPayment);
            }
        }

        private void cmbModeName_SelectedValueChanged(object sender, EventArgs e)
        {
            cPayment.fDataRetrieveWholeRecordPayment(oPayment, this.cmbModeName.SelectedItem.ToString());
            this.tbModeID.Text = Convert.ToString(oPayment.pModeID);
            this.tbModeName.Text = oPayment.pModeName;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
