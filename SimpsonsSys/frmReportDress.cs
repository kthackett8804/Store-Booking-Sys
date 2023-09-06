using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsSys
{
    public partial class frmReportDress : Form
    {
        public frmReportDress()
        {
            InitializeComponent();
        }

        int searchClient = 1;
        List<Client> listClient = new List<Client>();
        private void frmReportDress_Load(object sender, EventArgs e)
        {
            listClient = Client.GetClients();
            comboApp.Items.Clear();

            foreach (Client app in listClient)
            {
                comboApp.Items.Add(app.CID.ToString());
            }
            // TODO: This line of code loads data into the 'dataSetAppoint.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.FillBy(this.dataSetAppoint.DataTable1, searchClient);

            this.reportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDressmaking frm = new frmDressmaking();
            frm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchClient = Convert.ToInt16(comboApp.Text);
            frmReportDress_Load(null, null);
        }

        private void dataSetAppointBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
