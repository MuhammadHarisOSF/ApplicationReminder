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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser oFrmUser = new frmUser(cConfiguration.pCRUD.Update);
            oFrmUser.MdiParent = this;
            oFrmUser.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser oFrmUser = new frmUser(cConfiguration.pCRUD.Read);
            oFrmUser.MdiParent = this;
            oFrmUser.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser oFrmUser = new frmUser(cConfiguration.pCRUD.Create);
            oFrmUser.MdiParent = this;
            oFrmUser.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser oFrmUser = new frmUser(cConfiguration.pCRUD.Delete);
            oFrmUser.MdiParent = this;
            oFrmUser.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBank oFrmBank = new frmBank(cConfiguration.pCRUD.Create);
            oFrmBank.MdiParent = this;
            oFrmBank.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBank oFrmBank = new frmBank(cConfiguration.pCRUD.Read);
            oFrmBank.MdiParent = this;
            oFrmBank.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBank oFrmBank = new frmBank(cConfiguration.pCRUD.Update);
            oFrmBank.MdiParent = this;
            oFrmBank.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBank oFrmBank = new frmBank(cConfiguration.pCRUD.Delete);
            oFrmBank.MdiParent = this;
            oFrmBank.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHBFCBranch oFrmHBFCBranch = new frmHBFCBranch(cConfiguration.pCRUD.Create);
            oFrmHBFCBranch.MdiParent = this;
            oFrmHBFCBranch.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHBFCBranch oFrmHBFCBranch = new frmHBFCBranch(cConfiguration.pCRUD.Read);
            oFrmHBFCBranch.MdiParent = this;
            oFrmHBFCBranch.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHBFCBranch oFrmHBFCBranch = new frmHBFCBranch(cConfiguration.pCRUD.Update);
            oFrmHBFCBranch.MdiParent = this;
            oFrmHBFCBranch.Show();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHBFCBranch oFrmHBFCBranch = new frmHBFCBranch(cConfiguration.pCRUD.Delete);
            oFrmHBFCBranch.MdiParent = this;
            oFrmHBFCBranch.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPayment oFrmPayment = new frmPayment(cConfiguration.pCRUD.Create);
            oFrmPayment.MdiParent = this;
            oFrmPayment.Show();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPayment oFrmPayment = new frmPayment(cConfiguration.pCRUD.Read);
            oFrmPayment.MdiParent = this;
            oFrmPayment.Show();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPayment oFrmPayment = new frmPayment(cConfiguration.pCRUD.Update);
            oFrmPayment.MdiParent = this;
            oFrmPayment.Show();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPayment oFrmPayment = new frmPayment(cConfiguration.pCRUD.Delete);
            oFrmPayment.MdiParent = this;
            oFrmPayment.Show();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmIssue oFrmIssue = new frmIssue(cConfiguration.pCRUD.Create);
            oFrmIssue.MdiParent = this;
            oFrmIssue.Show();
        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmIssue oFrmIssue = new frmIssue(cConfiguration.pCRUD.Read);
            oFrmIssue.MdiParent = this;
            oFrmIssue.Show();
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmIssue oFrmIssue = new frmIssue(cConfiguration.pCRUD.Update);
            oFrmIssue.MdiParent = this;
            oFrmIssue.Show();
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmIssue oFrmIssue = new frmIssue(cConfiguration.pCRUD.Delete);
            oFrmIssue.MdiParent = this;
            oFrmIssue.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin oFrmLogin = new frmLogin();
            oFrmLogin.MdiParent = this;
            oFrmLogin.Show();
        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmDepartment oFrmDepartment = new frmDepartment(cConfiguration.pCRUD.Create);
            oFrmDepartment.MdiParent = this;
            oFrmDepartment.Show();
        }

        private void viewToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmDepartment oFrmDepartment = new frmDepartment(cConfiguration.pCRUD.Read);
            oFrmDepartment.MdiParent = this;
            oFrmDepartment.Show();
        }

        private void updateToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmDepartment oFrmDepartment = new frmDepartment(cConfiguration.pCRUD.Update);
            oFrmDepartment.MdiParent = this;
            oFrmDepartment.Show();
        }

        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmDepartment oFrmDepartment = new frmDepartment(cConfiguration.pCRUD.Delete);
            oFrmDepartment.MdiParent = this;
            oFrmDepartment.Show();
        }
    }
}
