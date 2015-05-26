using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SmartReminder
{
    public partial class frmUser : Form
    {
        cUser oUser = new cUser();

        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(cConfiguration.pCRUD formType)
        {
            InitializeComponent();

            if (formType == cConfiguration.pCRUD.Create)
            {
                this.cmdBoxUserName.Visible = false;
                this.btnOK.Text = cConfiguration.pCreate;
                SqlDataReader oDataReader = cDepartment.fDataRetrieveOnlyColumnDepartment();
                while (oDataReader.Read())
                {

                    this.cmbDepartment.Items.Add(oDataReader.GetString(0));

                }
            }

            else if (formType == cConfiguration.pCRUD.Read)
            {
                this.btnOK.Visible = false;

                this.lblUserName.Visible = false;
                this.lblPassword.Visible = false;
                this.lblReEnterPassword.Visible = false;

                this.tbPassword.Visible = false;
                this.tbUsername.Visible = false;
                this.tbReEnterPassword.Visible = false;

                this.cmdBoxUserName.Visible = false;

                this.dataGridUsers.Visible = true;

                DataSet oDataSet = cUser.fGridViewUser();
                dataGridUsers.DataMember = "tblUser";
                dataGridUsers.DataSource = oDataSet;


            }

            else if (formType == cConfiguration.pCRUD.Update)
            {
                this.btnOK.Text = cConfiguration.pUpdate;

                SqlDataReader oDataReader = cUser.fDataRetrieveOnlyColumnTblUser();
                while (oDataReader.Read())
                {

                    this.cmdBoxUserName.Items.Add(oDataReader.GetString(0));

                }
                SqlDataReader oDataReader1 = cDepartment.fDataRetrieveOnlyColumnDepartment();
                while (oDataReader1.Read())
                {

                    this.cmbDepartment.Items.Add(oDataReader1.GetString(0));

                }
            }

            else if (formType == cConfiguration.pCRUD.Delete)
            {
                this.btnOK.Text = cConfiguration.pDelete;

                SqlDataReader oDataReader = cUser.fDataRetrieveOnlyColumnTblUser();
                while (oDataReader.Read())
                {

                    this.cmdBoxUserName.Items.Add(oDataReader.GetString(0));

                }
                
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == cConfiguration.pCreate)
            {
                if (this.tbPassword.Text == this.tbReEnterPassword.Text)
                {
                    oUser.pUsername = this.tbUsername.Text;
                    oUser.pPassword = oUser.conversion(this.tbPassword.Text);
                    cUser.fCreateUser(oUser);

                    MessageBox.Show("User Created");

                    this.tbUsername.Clear();
                    this.tbPassword.Clear();
                    this.tbReEnterPassword.Clear();

                }

                else
                {
                    this.tbPassword.Clear();
                    this.tbReEnterPassword.Clear();
                    MessageBox.Show("Password and Re-Enter Password\n  does not Match");
                }
            }

            else if(btnOK.Text == cConfiguration.pDelete)
            {
                cUser.fDeleteTblUser(oUser);
            }

            else if (btnOK.Text == cConfiguration.pDelete)
            {
                cUser.fDeleteTblUser(oUser);
            }

            else if (btnOK.Text == cConfiguration.pUpdate)
            {
                cUser.fUpdateTblUser(oUser);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void cmdBoxUserName_SelectedValueChanged(object sender, EventArgs e)
        {
            cUser.fDataRetrieveWholeRecordTblUser(oUser, this.cmdBoxUserName.SelectedItem.ToString());

            this.tbUsername.Text = oUser.pUsername;
            this.tbPassword.Text = oUser.pPassword;
        }

        private void cmbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
