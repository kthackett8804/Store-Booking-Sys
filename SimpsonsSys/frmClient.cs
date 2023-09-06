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
    public partial class frmClient : Form
    {
        private int selectedClient = -1;
        public frmClient()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = Client.GetClients();

        }

        private void dgvClient_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClient.RowCount > 0)
            {
                try
                {
                    selectedClient = Convert.ToInt32(dgvClient.CurrentRow.Cells[0].Value);

                    Client edit = Client.RetrieveByClientID(selectedClient);

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        
                         txtboxCID.Text = edit.CID.ToString();
                         txtboxFname.Text = edit.CFname;
                        txtboxSurname.Text = edit.CSurname;
                        txtboxHouse.Text = edit.CHouseNo;
                        txtboxStreet.Text = edit.Cstreet;
                        txtboxTown.Text = edit.Ctown;
                        txtboxPostcode.Text = edit.Cpostcode;
                        txtboxPhone.Text = edit.phoneNum;
                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show("Error Message: " + errorMessage);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnections = dbConnect.dbConnection();
            SqlCommand saveChanges = new SqlCommand("UPDATE Client SET CFname = @CFname, CSurname = @CSurname, ChouseNo = @ChouseNo, Cstreet = @Cstreet, Ctown=@Ctown, Cpostcode = @Cpostcode, phoneNum = @phoneNum WHERE CID =" + txtboxCID.Text, dbConnections);

            DialogResult newDialog = MessageBox.Show("Do you wish to overwrite previous data?", "Update data", MessageBoxButtons.YesNo);
            try
            {
                if (newDialog == DialogResult.Yes)
                {
                    // CID not set purposefully
                    if (Int32.TryParse(txtboxFname.Text, out var parse1) || Int32.TryParse(txtboxSurname.Text, out var parse2))
                    {
                        MessageBox.Show("Name and surname must contain letters only");
                        
                    }
                    else
                    {
                        saveChanges.Parameters.AddWithValue("@CFname", txtboxFname.Text);
                        saveChanges.Parameters.AddWithValue("@CSurname", txtboxSurname.Text);
                    }
                    if (Int32.TryParse(txtboxHouse.Text, out var parse3))
                    {
                        saveChanges.Parameters.AddWithValue("@ChouseNo", txtboxHouse.Text);
                    }
                    else
                    {
                        MessageBox.Show("house number must contain numbers only");
                    }
                    if (Int32.TryParse(txtboxStreet.Text, out var parse4) || Int32.TryParse(txtboxTown.Text, out var parse5) || Int32.TryParse(txtboxPostcode.Text, out var parse6))
                    {
                        MessageBox.Show("Street,town and postcode must contain letters only");
                    }
                    else
                    {
                        saveChanges.Parameters.AddWithValue("@Cstreet", txtboxStreet.Text);
                        saveChanges.Parameters.AddWithValue("@Ctown", txtboxTown.Text);
                        saveChanges.Parameters.AddWithValue("@Cpostcode", txtboxPostcode.Text);
                    }
                    if (Int64.TryParse(txtboxPhone.Text, out var parse8))
                    {
                        saveChanges.Parameters.AddWithValue("@phoneNum", txtboxPhone.Text);
                    }
                    else
                    {
                        MessageBox.Show("phone number must contain numbers only");
                    }
                    
                    dbConnections.Open();
                    saveChanges.ExecuteNonQuery();
                    dgvClient.DataSource = Client.GetClients();
                    MessageBox.Show("update successful");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A problem has occured updating database");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnections2 = dbConnect.dbConnection();
            SqlCommand deleteRecord = new SqlCommand("DELETE FROM Client WHERE CID =" + txtboxCID.Text, dbConnections2);

            DialogResult newDialog = MessageBox.Show("Do you want to delete this record?", "Warning!", MessageBoxButtons.YesNo);
            if (newDialog == DialogResult.Yes)
            {
                dbConnections2.Open();
                deleteRecord.ExecuteNonQuery();
                MessageBox.Show("Customer record deleted!");
                dgvClient.DataSource = Client.GetClients();
            }
        }

        private void lblTown_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client newClient = new Client(0, txtboxFname.Text, txtboxSurname.Text, txtboxHouse.Text,
             txtboxStreet.Text, txtboxTown.Text, txtboxPostcode.Text, txtboxPhone.Text);

            bool addResult = Client.AddClient(newClient);
            if (addResult == true)
            {

                MessageBox.Show("Client added successfully");
            }
            else
            {
                MessageBox.Show("Adding client was unsuccessful");
            }
            dgvClient.DataSource = Client.GetClients();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmStaff form = new frmStaff();
            form.Show();
            this.Hide();
            
        }

        private void txtboxCID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }
    }
}


