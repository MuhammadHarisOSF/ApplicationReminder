using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartReminder
{
    public partial class frmLogin : Form
    {
        cUser oUser = new cUser();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cUser.fDataRetrievePassWord(oUser, this.tbUsername.Text);

            oUser.pTempPassword = oUser.conversion(this.tbPassword.Text);

            if(oUser.pTempPassword == oUser.pPassword)
            {
                MessageBox.Show("login Successfull");
            }

            else
            {
                MessageBox.Show("login fail");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
