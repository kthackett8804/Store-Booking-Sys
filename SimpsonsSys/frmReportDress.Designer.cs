
namespace SimpsonsSys
{
    partial class frmReportDress
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAppoint = new SimpsonsSys.DataSetAppoint();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataSetAppointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new SimpsonsSys.DataSetAppointTableAdapters.DataTable1TableAdapter();
            this.comboApp = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAppoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAppointBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.dataSetAppoint;
            // 
            // dataSetAppoint
            // 
            this.dataSetAppoint.DataSetName = "DataSetAppoint";
            this.dataSetAppoint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SimpsonsSys.RptDress.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(697, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataSetAppointBindingSource
            // 
            this.dataSetAppointBindingSource.DataSource = this.dataSetAppoint;
            this.dataSetAppointBindingSource.Position = 0;
            this.dataSetAppointBindingSource.CurrentChanged += new System.EventHandler(this.dataSetAppointBindingSource_CurrentChanged);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // comboApp
            // 
            this.comboApp.FormattingEnabled = true;
            this.comboApp.Location = new System.Drawing.Point(234, 13);
            this.comboApp.Name = "comboApp";
            this.comboApp.Size = new System.Drawing.Size(121, 21);
            this.comboApp.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client ID";
            // 
            // frmReportDress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboApp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportDress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportDress";
            this.Load += new System.EventHandler(this.frmReportDress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAppoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAppointBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource dataSetAppointBindingSource;
        private DataSetAppoint dataSetAppoint;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetAppointTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.ComboBox comboApp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}