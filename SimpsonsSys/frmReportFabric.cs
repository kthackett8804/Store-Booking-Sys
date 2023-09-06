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
    public partial class frmReportFabric : Form
    {
        public frmReportFabric()
        {
            InitializeComponent();
        }

        private void frmReportFabric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetFabric.fabrics' table. You can move, or remove it, as needed.
            this.fabricsTableAdapter.FillBy(this.DataSetFabric.fabrics);

            this.reportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDressmaking frm = new frmDressmaking();
            frm.Show();
            this.Hide();
        }
    }
}
