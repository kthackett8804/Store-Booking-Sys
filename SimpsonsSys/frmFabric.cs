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
    public partial class frmFabric : Form
    {
        private int selectedfabric = -1;

        public frmFabric()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void frmFabric_Load(object sender, EventArgs e)
        {
            dgvFabric.DataSource = fabrics.GetFabrics();
        }

        private void dgvFabric_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFabric.RowCount > 0)
            {
                try
                {
                    selectedfabric = Convert.ToInt32(dgvFabric.CurrentRow.Cells[0].Value);

                    fabrics edit = fabrics.RetrieveByfabID(selectedfabric);

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        txtboxfabID.Text = edit.FabId.ToString();
                        txtboxFabric.Text = edit.Fabric;
                        txtboxLength.Text = edit.Length.ToString();
                        txtboxQuant.Text = edit.Quantity.ToString();
                        
                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show("Fabric couldnt be retrievd by their ID: " + errorMessage);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnections = dbConnect.dbConnection();
            SqlCommand saveChanges = new SqlCommand("UPDATE fabrics SET fabric = @fabric, length = @length, quantity = @quantity WHERE fabID =" + txtboxfabID.Text, dbConnections);

            DialogResult newDialog = MessageBox.Show("Do you wish to overwrite previous data?", "Update data", MessageBoxButtons.YesNo);
            try
            {
                if (newDialog == DialogResult.Yes)
                {
                    if (Int32.TryParse(txtboxFabric.Text, out var parse1))
                    {
                        MessageBox.Show("fabric must contain letters only");

                    }
                    else
                    {
                        // fabID not set purposefully
                        saveChanges.Parameters.AddWithValue("@fabric", txtboxFabric.Text);

                    }
                    if (Int32.TryParse(txtboxLength.Text, out var parse3) || Int32.TryParse(txtboxQuant.Text, out var parse4))
                    {
                        saveChanges.Parameters.AddWithValue("@length", txtboxLength.Text);
                        saveChanges.Parameters.AddWithValue("@quantity", txtboxQuant.Text);
                    }
                    else
                    {
                        MessageBox.Show("Length and Quantity must be numbers");
                    }
                    
                    
                    

                    dbConnections.Open();
                    saveChanges.ExecuteNonQuery();
                    dgvFabric.DataSource = fabrics.GetFabrics();
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
            SqlCommand deleteRecord = new SqlCommand("DELETE FROM fabrics WHERE fabID =" + txtboxfabID.Text, dbConnections2);

            DialogResult newDialog = MessageBox.Show("Do you want to delete this record?", "Warning!", MessageBoxButtons.YesNo);
            if (newDialog == DialogResult.Yes)
            {
                dbConnections2.Open();
                deleteRecord.ExecuteNonQuery();
                MessageBox.Show("fabric record deleted!");
                dgvFabric.DataSource = fabrics.GetFabrics();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                fabrics newfabric = new fabrics(0, txtboxFabric.Text, Convert.ToInt32(txtboxLength.Text), Convert.ToInt32(txtboxQuant.Text));
                bool addResult = fabrics.AddFabric(newfabric);
                if (addResult == true)
                {

                    MessageBox.Show("New fabric added successfully");
                }
                else
                {
                    MessageBox.Show("new fabric unsuccessful");
                }
                dgvFabric.DataSource = fabrics.GetFabrics();
            }
            catch (Exception)
            {
                MessageBox.Show("Fabric must contain Text and length/quantity must contain numbers");

               
            }
                
           

        }
    }
}
