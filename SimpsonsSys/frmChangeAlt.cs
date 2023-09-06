using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsSys
{
    public partial class frmChangeAlt : Form
    {

        int selectAlt = -1;
        List<Client> listClient = new List<Client>();
        List<Staff> listStaff = new List<Staff>();
        public frmChangeAlt()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime newdate = Convert.ToDateTime(dateTimeAlt.Text);
            txtboxDate.Text = newdate.ToString();
        }

       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlt.RowCount > 0)
            {
                try
                {
                    selectAlt = Convert.ToInt32(dgvAlt.CurrentRow.Cells[0].Value);

                    Alteration edit = Alteration.RetrieveByAlterationID(selectAlt);

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        txtboxid.Text = edit.AltId.ToString();
                        comboClient.Text = edit.CId.ToString();
                        comboStaff.Text = edit.SId.ToString();
                        txtboxReason.Text = edit.Reason;
                        txtboxCost.Text = edit.Cost.ToString();
                        txtboxDate.Text = edit.DateComp.ToString();
                        chckboxPaid.Text = edit.IfPaid.ToString();
                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show("Appointment couldnt be retrievd by their ID: " + errorMessage);
                }
            }
        }

        private void frmChangeAlt_Load(object sender, EventArgs e)
        {
            dgvAlt.DataSource = Alteration.GetAlteration();
            listClient = Client.GetClients();
            listStaff = Staff.GetStaff();

            comboClient.Items.Clear();
            comboStaff.Items.Clear();

            //populates comboBox with all Client IDS
            foreach (Client thing in listClient)
            {
                comboClient.Items.Add(thing.CID.ToString());
            }

            //populates comboBox with all Staff IDS
            foreach (Staff thing in listStaff)
            {
                comboStaff.Items.Add(thing.SID.ToString());
            }

            
            txtboxid.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAlteration frm = new frmAlteration();
            frm.Show();
            this.Hide();
        }

        private void createAlt(object sender, EventArgs e)
        {
            //if a radio button is clicked then the text will go to the textbox
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

        private void btnChangeAlt_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnections = dbConnect.dbConnection();
            SqlCommand saveChanges = new SqlCommand("UPDATE Alteration SET ClientID=@ClientID, StaffID=@StaffID, Reason=@Reason, Cost=@Cost, DateComp=@DateComp, ifPaid=@ifPaid WHERE AlterationId=" + txtboxid.Text, dbConnections);

            DialogResult newDialog = MessageBox.Show("Do you wish to overwrite previous data?", "Update data", MessageBoxButtons.YesNo);
            try
            {
                if (newDialog == DialogResult.Yes)
                {
                    

                        // ID not set purposefully
                        saveChanges.Parameters.AddWithValue("@ClientID", comboClient.Text);
                        saveChanges.Parameters.AddWithValue("@StaffID", comboStaff.Text);
                    
                   
                    if (Int32.TryParse(txtboxReason.Text, out var parse4) || txtboxReason.Text == "")
                    {
                        MessageBox.Show("Reason must contain letters only");
                    }
                    else
                    {
                        saveChanges.Parameters.AddWithValue("@Reason", txtboxReason.Text);
                    }
                    if (decimal.TryParse(txtboxCost.Text, out var parse5))
                    {
                        saveChanges.Parameters.AddWithValue("@Cost", Convert.ToDecimal(txtboxCost.Text));
                    }
                    else
                    {
                        MessageBox.Show("Cost must contain decimal ");
                    }
                    if (DateTime.TryParse(txtboxDate.Text, out var parse7) && Convert.ToDateTime(txtboxDate.Text) >= DateTime.Now)
                    {
                        saveChanges.Parameters.AddWithValue("@DateComp", Convert.ToDateTime(txtboxDate.Text));
                        saveChanges.Parameters.AddWithValue("@ifPaid", chckboxPaid.Checked);
                    }
                    else
                    {
                        MessageBox.Show("Date textbox must contain a date only");
                    }
                    
                    




                    dbConnections.Open();
                    saveChanges.ExecuteNonQuery();
                    dgvAlt.DataSource = Alteration.GetAlteration();
                    MessageBox.Show("update successful");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A problem has occured updating database");
            }
        }
    }
}
