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
    public partial class frmChangeDress : Form
    {
        private int selectAppoint = -1;
        private int selectFabric = -1;

        List<Client> listClient = new List<Client>();
        List<Staff> listStaff = new List<Staff>();
        public frmChangeDress()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime newdate = Convert.ToDateTime(dateAppoint2.Text);
            txtboxDate.Text = newdate.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnections = dbConnect.dbConnection();
            SqlCommand saveChanges = new SqlCommand("UPDATE Appointment SET ClientID=@ClientID, StaffID=@StaffID,  Measurements = @Measurements, fabChosen = @fabChosen, furtDate = @furtDate, estPrice = @estPrice, depositPaid = @depositPaid WHERE Id=" + txtboxid.Text, dbConnections);

            DialogResult newDialog = MessageBox.Show("Do you wish to overwrite previous data?", "Update data", MessageBoxButtons.YesNo);
            try
            {
                if (newDialog == DialogResult.Yes)
                {
                    if ( Int32.TryParse(txtboxMeasure.Text, out var parse3) ||  txtboxMeasure.Text == "")
                    {
                        if(Convert.ToInt32(txtboxMeasure.Text) > 0 && Convert.ToInt32(txtboxMeasure.Text) < 100)
                        {
                            // ID not set purposefully
                            saveChanges.Parameters.AddWithValue("@ClientID", comboClient.Text);
                            saveChanges.Parameters.AddWithValue("@StaffID", comboStaff.Text);
                            saveChanges.Parameters.AddWithValue("@Measurements", txtboxMeasure.Text);
                        }
                        else
                        {
                            MessageBox.Show("Measurement must be between 0 and 100");
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("ID and measurements must contain numbers only");
                    }
                    if (Int32.TryParse(txtboxFabric.Text, out var parse4) || txtboxFabric.Text == "")
                    {
                        MessageBox.Show("fabric must contain letters only");
                    }
                    else
                    {
                        saveChanges.Parameters.AddWithValue("@fabChosen", txtboxFabric.Text);
                    }
                    if (DateTime.TryParse(txtboxDate.Text, out var parse5) || txtboxDate.Text == "" && Convert.ToDateTime(txtboxDate.Text) >= DateTime.Now)
                    {
                        saveChanges.Parameters.AddWithValue("@furtDate", Convert.ToDateTime(txtboxDate.Text));
                    }
                    else
                    {
                        MessageBox.Show("Date must contain a date only");
                    }
                    if (decimal.TryParse(txtboxPrice.Text, out var parse6))
                    {
                        saveChanges.Parameters.AddWithValue("@estPrice", Convert.ToDecimal(txtboxPrice.Text));
                        saveChanges.Parameters.AddWithValue("@depositPaid", chckboxDeposit.Checked);
                    }
                    else
                    {
                        MessageBox.Show("Price must contain money/decimal only");
                    }
                    
                    


                    dbConnections.Open();
                    saveChanges.ExecuteNonQuery();
                    dgvAppoint.DataSource = Appointment.GetAppointment();
                    MessageBox.Show("update successful");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A problem has occured updating database");
            }
        }

        private void frmBookAppoint_Load(object sender, EventArgs e)
        {
            dgvAppoint.DataSource = Appointment.GetAppointment();
            dgvFabric.DataSource = fabrics.GetFabrics();
            txtboxid.Enabled = false;

            listClient = Client.GetClients();
            listStaff = Staff.GetStaff();

            comboClient.Items.Clear();
            comboStaff.Items.Clear();

            //populates combobox with all Client IDS
            foreach (Client thing in listClient)
            {
                comboClient.Items.Add(thing.CID.ToString());
            }

            //populates combobox with all Staff IDS
            foreach (Staff thing in listStaff)
            {
                comboStaff.Items.Add(thing.SID.ToString());
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvAppoint.RowCount > 0)
            {
                try
                {
                    selectAppoint = Convert.ToInt32(dgvAppoint.CurrentRow.Cells[0].Value);

                    Appointment edit = Appointment.RetrieveByID(selectAppoint);

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        
                        txtboxid.Text = edit.Id.ToString();
                        comboClient.Text = edit.CId.ToString();
                        comboStaff.Text = edit.SId.ToString();
                        txtboxMeasure.Text = edit.Measurements.ToString();
                        //txtboxFabric.Text = edit.FabChosen;
                        txtboxDate.Text = edit.Furtdate.ToString();
                        txtboxPrice.Text = edit.EstPrice.ToString();
                        chckboxDeposit.Text = edit.DepositPaid.ToString();

                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show("Appointment couldnt be retrievd by their ID: " + errorMessage);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDressmaking frm = new frmDressmaking();
            frm.Show();
            this.Hide();
        }

        private void dgvFabric_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFabric.RowCount > 0)
            {
                try
                {
                    selectFabric = Convert.ToInt32(dgvFabric.CurrentRow.Cells[0].Value);

                    fabrics edit = fabrics.RetrieveByfabID(selectFabric);

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        
                        txtboxFabric.Text = edit.Fabric;
                        

                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show("Appointment couldnt be retrievd by their ID: " + errorMessage);
                }
            }
        }
    }
}
