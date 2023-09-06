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
    public partial class frmDressmaking : Form
    {
        private int selectAppoint = -1;
        public frmDressmaking()
        {
            
            InitializeComponent();
            
        }

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDress.RowCount > 0)
            {
                try
                {
                    selectAppoint = Convert.ToInt32(dgvDress.CurrentRow.Cells[0].Value);

                    Appointment edit = Appointment.RetrieveByID(selectAppoint);
                    

                    // Prohibits an error if the last record is deleted
                    if (edit != null)
                    {
                        txtboxId.Text = edit.Id.ToString();
                        txtboxCID.Text = edit.CId.ToString();
                        txtboxSID.Text = edit.SId.ToString();
                        txtboxMeasure.Text = edit.Measurements.ToString();
                        txtboxFabric.Text = edit.FabChosen;
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

        private void frmDress_Load(object sender, EventArgs e)
        {
            txtboxId.Enabled = false;
            dgvDress.DataSource = Appointment.GetAppointment();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu form = new frmMenu();
            this.Hide();
            form.Show();
        }

        

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    DateTime newdate = Convert.ToDateTime(dateTimePicker1.Text);
        //    txtboxDate.Text = newdate.ToString();
        //}

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmAlteration frm = new frmAlteration();
            frm.Show();
            this.Hide();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            frmDeleteDress frm = new frmDeleteDress();
            frm.Show();
            this.Hide();
        }

        
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            frmCreateDress frm = new frmCreateDress();
            frm.Show();
            this.Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmChangeDress frm = new frmChangeDress();
            frm.Show();
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmReportDress frm = new frmReportDress();
            frm.Show();
            this.Hide();
        }

        private void btnFabricRep_Click(object sender, EventArgs e)
        {
            frmReportFabric frm = new frmReportFabric();
            frm.Show();
            this.Hide();
        }
    }
}
