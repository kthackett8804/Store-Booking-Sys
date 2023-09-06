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
    public partial class frmCreateDress : Form
    {
        private int selectFabric = -1;

        List<Client> listClient = new List<Client>();
        List<Staff> listStaff = new List<Staff>();
        public frmCreateDress()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDressmaking frm = new frmDressmaking();
            frm.Show();
            this.Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtboxMeasure.Text) > 0 && Convert.ToInt32(txtboxMeasure.Text) < 100)
            {



                try
                {


                    Appointment newAppointment = new Appointment(0, Convert.ToInt32(comboClient.Text), Convert.ToInt32(comboStaff.Text), Convert.ToInt32(txtboxMeasure.Text), txtboxFabric.Text, Convert.ToDateTime(txtboxDate.Text), Convert.ToDecimal(txtboxPrice.Text), chckboxDeposit.Checked);
                    bool addResult = Appointment.AddAppoint(newAppointment);

                    //SQL will reduce the quantity and when the quantity is 0 then display out of stock
                    SqlConnection dbConnections = dbConnect.dbConnection();
                    SqlCommand saveChanges = new SqlCommand("UPDATE fabrics SET quantity= (quantity - 1)  WHERE quantity NOT LIKE 0 AND fabID=" + txtFabID.Text, dbConnections);
                    dbConnections.Open();
                    saveChanges.ExecuteNonQuery();

                    if (Convert.ToInt32(txtboxQuant.Text) == 0)
                    {
                        MessageBox.Show("Fabric is out of stock");
                    }

                    if (addResult == true && Convert.ToInt32(txtboxQuant.Text) != 0 && Convert.ToDateTime(txtboxDate) >= DateTime.Now)
                    {

                        MessageBox.Show("Appointment added successfully");
                        dgvFabric.DataSource = fabrics.GetFabrics();

                        
                        txtboxMeasure.Clear();
                        txtboxFabric.Clear();
                        txtboxDate.Clear();
                        txtboxPrice.Clear();

                    }

                    else
                    {
                        MessageBox.Show("Adding Appointment was unsuccessful");
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Textbox must contain correct values eg fabric must contain text and measure must contain numbers and time must be correct and not in the past");

                }
            }
            else
            {
                MessageBox.Show("Measurement must be between 0 and 100");
            }
           
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime newdate = Convert.ToDateTime(dateAppoint.Text);
            txtboxDate.Text = newdate.ToString();
        }

        private void frmCreateAppoint_Load(object sender, EventArgs e)
        {
            dgvFabric.DataSource = fabrics.GetFabrics();

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

        private void txtboxDate_TextChanged(object sender, EventArgs e)
        {

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
                        txtFabID.Text = edit.FabId.ToString();
                        txtboxQuant.Text = edit.Quantity.ToString();

                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show("Fabric couldnt be retrievd by their ID: " + errorMessage);
                }
            }
        }
    }
}
