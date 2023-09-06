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
    public partial class frmCreateAlt : Form
    {
        List<Client> listClient = new List<Client>();
        List<Staff> listStaff = new List<Staff>();
        public frmCreateAlt()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAlteration frm = new frmAlteration();
            frm.Show();
            this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            
            try
            {
                Alteration newAlteration = new Alteration(0, Convert.ToInt32(comboClient.Text), Convert.ToInt32(comboStaff.Text), txtboxReason.Text, Convert.ToDecimal(txtboxCost.Text), Convert.ToDateTime(txtboxDate.Text), chckboxPaid.Checked);
                bool addResult = Alteration.AddAlteration(newAlteration);
                if (addResult == true && Convert.ToDateTime(txtboxDate.Text) >= DateTime.Now)
                {

                    MessageBox.Show("Alteration added successfully");
                    txtboxCost.Clear();
                    txtboxDate.Clear();
                    txtboxReason.Clear();
                }
                else
                {
                    MessageBox.Show("Adding Alteration was unsuccessful");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Each textbox must contain correct values eg cost must be a decimal/money and date must contain date and time must be correct and not in the past");
            }
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime newdate = Convert.ToDateTime(dateTimeAlt.Text);
            txtboxDate.Text = newdate.ToString();
        }

        private void frmCreateAlt_Load(object sender, EventArgs e)
        {
            listClient = Client.GetClients();
            listStaff = Staff.GetStaff();

            comboClient.Items.Clear();
            comboStaff.Items.Clear();

            foreach (Client thing in listClient)
            {
                comboClient.Items.Add(thing.CID.ToString());
            }

            foreach (Staff thing in listStaff)
            {
                comboStaff.Items.Add(thing.SID.ToString());
            }
        }

        private void frmCreateAlt_Click(object sender, EventArgs e)
        {
            if (rdbtnReason1.Checked)
            {
                txtboxReason.Text = rdbtnReason1.Text;
            }
            else if (rdbtnReason2.Checked)
            {
                txtboxReason.Text = rdbtnReason2.Text;
            }
            else if (rdbtnReason3.Checked)
            {
                txtboxReason.Text = rdbtnReason3.Text;
            }
            else if (rdbtnReason4.Checked)
            {
                txtboxReason.Text = rdbtnReason4.Text;
            }
            else
            {

            }
        }
    }
}
