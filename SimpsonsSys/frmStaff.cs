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
    public partial class frmStaff : Form
    {
        private int selectedStaff = -1;
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            dgvStaff.DataSource = Staff.GetStaff();
        }

        private void dgvClient_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.RowCount > 0)
            {
                try
                {
                    selectedStaff = Convert.ToInt32(dgvStaff.CurrentRow.Cells[0].Value);

                    Staff edit = Staff.RetrieveBySID(selectedStaff);

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        txtboxSID.Text = edit.SID.ToString();
                        txtboxSFname.Text = edit.SFname;
                        txtboxSSurname.Text = edit.SSurname;
                        chckBoxAdmin.Text = edit.isAdmin.ToString();
                        txtboxUser.Text = edit.Username;
                        txtboxPass.Text = edit.Pass;
                        
                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show("Staff couldnt be retrievd by their ID: " + errorMessage);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            SqlConnection dbConnections = dbConnect.dbConnection();
            SqlCommand saveChanges = new SqlCommand("UPDATE Staff SET SFname = @SFname, SSurname = @SSurname, IsAdmin = @IsAdmin, Username = @Username, Pass=@Pass WHERE SID =" + txtboxSID.Text, dbConnections);

            DialogResult newDialog = MessageBox.Show("Do you wish to overwrite previous data?", "Update data", MessageBoxButtons.YesNo);
            try
            {
                if (newDialog == DialogResult.Yes)
                {
                    // SID not set purposefully
                    if (Int32.TryParse(txtboxSFname.Text, out var parse1) || Int32.TryParse(txtboxSSurname.Text, out var parse2) || txtboxSFname.Text == "" || txtboxSSurname.Text == "")
                    {
                        MessageBox.Show("Name and surname must contain letters only");

                    }
                    else
                    {
                        saveChanges.Parameters.AddWithValue("@SFname", txtboxSFname.Text);
                        saveChanges.Parameters.AddWithValue("@SSurname", txtboxSSurname.Text);
                        saveChanges.Parameters.AddWithValue("@IsAdmin", chckBoxAdmin.Checked);
                    }
                    if (Int32.TryParse(txtboxUser.Text, out var parse3) || Int32.TryParse(txtboxPass.Text, out var parse4) || txtboxUser.Text == "" || txtboxPass.Text == "")
                    {
                        MessageBox.Show("Username must contain letters and password must contain a  mixture of letters and numbers");
                    }
                    else
                    {
                        saveChanges.Parameters.AddWithValue("@Username", txtboxUser.Text);
                        saveChanges.Parameters.AddWithValue("@Pass", txtboxPass.Text);
                    }
                    
                    dbConnections.Open();
                    saveChanges.ExecuteNonQuery();
                    dgvStaff.DataSource = Staff.GetStaff();
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
            SqlCommand deleteRecord = new SqlCommand("DELETE FROM Staff WHERE SID =" + txtboxSID.Text, dbConnections2);

            DialogResult newDialog = MessageBox.Show("Do you want to delete this record?", "Warning!", MessageBoxButtons.YesNo);
            if (newDialog == DialogResult.Yes)
            {
                dbConnections2.Open();
                deleteRecord.ExecuteNonQuery();
                MessageBox.Show("Staff record deleted!");
                dgvStaff.DataSource = Staff.GetStaff();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Staff newStaff = new Staff(0, txtboxSFname.Text, txtboxSSurname.Text, chckBoxAdmin.Checked,
             txtboxUser.Text, txtboxPass.Text);
                bool addResult = Staff.AddStaff(newStaff);
                if (addResult == true)
                {

                    MessageBox.Show("Staff added successfully");
                }
                else
                {
                    MessageBox.Show("Adding staff was unsuccessful");
                }
                dgvStaff.DataSource = Staff.GetStaff();
            }
            catch (Exception)
            {

                MessageBox.Show("Each textbox must contain the correct type eg name and surname must be letters not numbers");
            }
            
        }

        private void chckBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            this.Hide();
            form.Show();
        }

      

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            this.Hide();
            form.Show();
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {
            frmDressmaking form = new frmDressmaking();
            this.Hide();
            form.Show();
        }
        
    }
}

