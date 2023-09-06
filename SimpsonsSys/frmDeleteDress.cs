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
    public partial class frmDeleteDress : Form
    { 
        int selectAppoint = -1;
        public frmDeleteDress()
        {
            InitializeComponent();


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppoint3.RowCount > 0)
            {
                try
                {
                    selectAppoint = Convert.ToInt32(dgvAppoint3.CurrentRow.Cells[0].Value);

                    Appointment edit = Appointment.RetrieveByID(selectAppoint);

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        txtboxCID.Text = edit.CId.ToString();
                        txtboxSID.Text = edit.SId.ToString();
                        txtboxId.Text = edit.Id.ToString();
                        txtboxMeasure.Text = edit.Measurements.ToString();
                        txtboxFabric.Text = edit.FabChosen.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnections2 = dbConnect.dbConnection();
            SqlCommand deleteRecord = new SqlCommand("DELETE FROM Appointment WHERE Id =" + txtboxId.Text, dbConnections2);

            DialogResult newDialog = MessageBox.Show("Do you want to delete this record?", "Warning!", MessageBoxButtons.YesNo);
            if (newDialog == DialogResult.Yes)
            {
                dbConnections2.Open();
                deleteRecord.ExecuteNonQuery();
                MessageBox.Show("Appointment deleted!");
                dgvAppoint3.DataSource = Appointment.GetAppointment();
            }
        }

        private void label1_Click(object sender, EventArgs e)

        {
        }  

        private void frmDeleteAppoint_Load(object sender, EventArgs e)
        {
            dgvAppoint3.DataSource = Appointment.GetAppointment();

            txtboxId.Visible = false;
            txtboxMeasure.Visible = false;
            txtboxFabric.Visible = false;
            txtboxDate.Visible = false;
            txtboxPrice.Visible = false;
            chckboxDeposit.Visible = false;

        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDressmaking frm = new frmDressmaking();
            frm.Show();
            this.Hide();
        }
    }
}

