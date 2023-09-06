using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsSys
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnDressmaking_Click(object sender, EventArgs e)
        {
            frmDressmaking form = new frmDressmaking();
            form.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUserr.Text = User.currentUser.Username + "\t ---" + User.currentUser.SFname + " " + User.currentUser.SSurname;
        }

       

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (rdbtnStaff.Checked)
            {
                if (User.currentUser.isAdmin == true)
                {
                    frmStaff form = new frmStaff();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Only admin can access staff");
                }
                
                
            }
            else if (rdbtnFabric.Checked)
            {
                if (User.currentUser.isAdmin == true)
                {
                    frmFabric frm = new frmFabric();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Only admin can access fabrics");
                }
            }
            else if (rdbtnClient.Checked)
            {
                frmClient form = new frmClient();
                form.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("please select either client,staff or fabric button");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            rdbtnClient.Checked = false;
            rdbtnStaff.Checked = false;
            rdbtnFabric.Checked = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pending");
        }

        private void btnWedding_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pending");
        }

        private void btnBeauty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pending");
        }

        private void S_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pending");
        }

        #region ignore
        private void rdbtnStaff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnClient_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblRecord_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
