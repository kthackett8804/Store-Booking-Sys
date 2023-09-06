
namespace SimpsonsSys
{
    partial class frmReportFabric
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.fabricsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFabric = new SimpsonsSys.DataSetFabric();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fabricsTableAdapter = new SimpsonsSys.DataSetFabricTableAdapters.fabricsTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fabricsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFabric)).BeginInit();
            this.SuspendLayout();
            // 
            // fabricsBindingSource
            // 
            this.fabricsBindingSource.DataMember = "fabrics";
            this.fabricsBindingSource.DataSource = this.DataSetFabric;
            // 
            // DataSetFabric
            // 
            this.DataSetFabric.DataSetName = "DataSetFabric";
            this.DataSetFabric.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.fabricsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SimpsonsSys.ReportFabric.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // fabricsTableAdapter
            // 
            this.fabricsTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmReportFabric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportFabric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportFabric";
            this.Load += new System.EventHandler(this.frmReportFabric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fabricsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFabric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fabricsBindingSource;
        private DataSetFabric DataSetFabric;
        private DataSetFabricTableAdapters.fabricsTableAdapter fabricsTableAdapter;
        private System.Windows.Forms.Button btnBack;
    }
}