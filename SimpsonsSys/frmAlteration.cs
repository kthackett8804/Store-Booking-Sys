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
    public partial class frmAlteration : Form
    {
        private int selectAlteration = -1;

        public frmAlteration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDressmaking frm = new frmDressmaking();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlt.RowCount > 0)
            {
                try
                {
                    selectAlteration = Convert.ToInt32(dgvAlt.CurrentRow.Cells[0].Value);

                    Alteration edit = Alteration.RetrieveByAlterationID(selectAlteration);

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        txtboxAltid.Text = edit.AltId.ToString(); 
                        txtboxCID.Text = edit.CId.ToString();
                        txtboxSID.Text = edit.SId.ToString();
                        txtboxReason.Text = edit.Reason;
                        txtboxCost.Text = edit.Cost.ToString();
                        txtboxDate.Text = edit.DateComp.ToString();
                        chckboxPaid.Text = edit.IfPaid.ToString();


                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show("Alteration form couldnt be retrievd by their ID: " + errorMessage);
                }
            }
        }

        private void frmAlteration_Load(object sender, EventArgs e)
        {
            dgvAlt.DataSource = Alteration.GetAlteration();
        }

       

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnections2 = dbConnect.dbConnection();
            SqlCommand deleteRecord = new SqlCommand("DELETE FROM Alteration WHERE AlterationId =" + txtboxAltid.Text, dbConnections2);

            DialogResult newDialog = MessageBox.Show("Do you want to delete this record?", "Warning!", MessageBoxButtons.YesNo);
            if (newDialog == DialogResult.Yes)
            {
                dbConnections2.Open();
                deleteRecord.ExecuteNonQuery();
                MessageBox.Show("Alteration form deleted!");
                dgvAlt.DataSource = Alteration.GetAlteration();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime newdate = Convert.ToDateTime(dateTimePicker1.Text);
            //txtboxDate.Text = newdate.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateAlt frm = new frmCreateAlt();
            frm.Show();
            this.Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmChangeAlt frm = new frmChangeAlt();
            frm.Show();
            this.Hide();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            frmDeleteAlt frm = new frmDeleteAlt();
            frm.Show();
            this.Hide();
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmReportAlt frm = new frmReportAlt();
            frm.Show();
            this.Hide();
        }
    }
}
