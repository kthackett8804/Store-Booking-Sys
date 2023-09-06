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
    public partial class frmDeleteAlt : Form
    {
        int selectAlt = -1;
        public frmDeleteAlt()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAlteration frm = new frmAlteration();
            frm.Show();
            this.Hide();
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

        private void frmDeleteAlt_Load(object sender, EventArgs e)
        {
            dgvAlt.DataSource = Alteration.GetAlteration();
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
                        txtboxAltid.Text = edit.AltId.ToString();
                        txtboxCID.Text = edit.CId.ToString();
                        txtboxSID.Text = edit.SId.ToString();
                        txtboxReason.Text = edit.Reason.ToString();
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
    }
}
