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
    public partial class frmReportAlt : Form
    {
        public frmReportAlt()
        {
            InitializeComponent();
        }

        int searchClient = 1;
        List<Client> listClient = new List<Client>();

        private void frmReportAlt_Load(object sender, EventArgs e)
        {
            listClient = Client.GetClients();
            comboAlt.Items.Clear();

            foreach (Client app in listClient)
            {
                comboAlt.Items.Add(app.CID.ToString());
            }
            // TODO: This line of code loads data into the 'DataSetAlt.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.FillBy(this.DataSetAlt.DataTable1, searchClient);

            this.reportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAlteration frm = new frmAlteration();
            frm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchClient = Convert.ToInt16(comboAlt.Text);
            frmReportAlt_Load(null, null);
        }
    }
}
