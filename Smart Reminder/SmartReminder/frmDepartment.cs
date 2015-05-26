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
    public partial class frmDepartment : Form
    {
        cDepartment oDepartment = new cDepartment();
        public frmDepartment()
        {
            InitializeComponent();
        }
        public frmDepartment(cConfiguration.pCRUD NameOfForm)
        {
            InitializeComponent();
            if (NameOfForm == cConfiguration.pCRUD.Create)
            {
                this.Text = cConfiguration.pCreate;
                btnOk.Text = cConfiguration.pCreate;

                cmbDepartmentName.Visible = false;
                lblcmbDepartmentName.Visible = false;
                gvDepartmentList.Visible = false;
                lblDepartmentID.Visible = true;
                lblDepartmentName.Visible = true;

                tbDepartmentID.Visible = true;
                tbDepartmentName.Visible = true;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Read)
            {
                btnOk.Visible = false;
                this.Text = cConfiguration.pRead;
                btnOk.Text = cConfiguration.pRead;
                gvDepartmentList.Visible = true;
                cmbDepartmentName.Visible = false;
                lblcmbDepartmentName.Visible = false;

                lblDepartmentID.Visible = false;
                lblDepartmentName.Visible = false;
                tbDepartmentID.ReadOnly = false;
                tbDepartmentName.ReadOnly = false;
                tbDepartmentID.Visible = false;
                tbDepartmentName.Visible = false;
                btnOk.Visible = false;
                DataSet oDataSet = cDepartment.fGridView_Department();
                gvDepartmentList.DataMember = "tblDepartment";
                gvDepartmentList.DataSource = oDataSet;
            }

            else if (NameOfForm == cConfiguration.pCRUD.Update)
            {
                this.Text = cConfiguration.pUpdate;
                btnOk.Text = cConfiguration.pUpdate;

                cmbDepartmentName.Visible = true;
                lblcmbDepartmentName.Visible = true;
                gvDepartmentList.Visible = false;
                lblDepartmentID.Visible = true;
                lblDepartmentName.Visible = true;
                tbDepartmentID.ReadOnly = false;
                tbDepartmentName.ReadOnly = false;
                tbDepartmentID.Visible = true;
                tbDepartmentName.Visible = true;

                SqlDataReader oDataReader = cDepartment.fDataRetrieveOnlyColumnDepartment();
                while (oDataReader.Read())
                {
                    this.cmbDepartmentName.Items.Add(oDataReader.GetString(0));
                }
            }

            else if (NameOfForm == cConfiguration.pCRUD.Delete)
            {
                this.Text = cConfiguration.pDelete;
                btnOk.Text = cConfiguration.pDelete;
                gvDepartmentList.Visible = false;
                cmbDepartmentName.Visible = true;
                lblcmbDepartmentName.Visible = true;

                lblDepartmentID.Visible = true;
                lblDepartmentName.Visible = true;
                tbDepartmentID.ReadOnly = true;
                tbDepartmentName.ReadOnly = true;
                tbDepartmentID.Visible = true;
                tbDepartmentName.Visible = true;

                SqlDataReader oDataReader = cDepartment.fDataRetrieveOnlyColumnDepartment();
                while (oDataReader.Read())
                {
                    this.cmbDepartmentName.Items.Add(oDataReader.GetString(0));
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == cConfiguration.pCreate)
            {
                oDepartment.pDepartmentName = tbDepartmentName.Text;
                cDepartment.fCreateDepartment(oDepartment);
            }
            else if (btnOk.Text == cConfiguration.pRead)
            {

            }
            else if (btnOk.Text == cConfiguration.pUpdate)
            {
                oDepartment.pDepartmentName = tbDepartmentName.Text;
                cDepartment.fCRUD_U_Department(oDepartment, cmbDepartmentName.Text.ToString());
            }
            else if (btnOk.Text == cConfiguration.pDelete)
            {
                oDepartment.pDepartmentName = tbDepartmentName.Text;
                cDepartment.fCRUD_D_Department(oDepartment);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDepartmentName_SelectedValueChanged(object sender, EventArgs e)
        {
            cDepartment.fDataRetrieveWholeRecordDepartment(oDepartment, this.cmbDepartmentName.SelectedItem.ToString());
            this.tbDepartmentID.Text = Convert.ToString(oDepartment.pDepartmentID);
            this.tbDepartmentName.Text = oDepartment.pDepartmentName;
        }
    }
}
