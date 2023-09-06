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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtboxUser.Text;
            string pass = txtboxPass.Text;

            Staff newstaff = null;
            newstaff = Staff.Login(user,pass);

            if (newstaff != null)
            {
                User.currentUser = newstaff;
                frmMenu form = new frmMenu();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Either Username or Password is incorrect, please try again");
                txtboxUser.Text = "";
                txtboxPass.Text = "";
                txtboxUser.Focus();
            }
        }

        private void picBanner_Click(object sender, EventArgs e)
        {

        }

        private void pictureShop_Click(object sender, EventArgs e)
        {

        }
    }
}
