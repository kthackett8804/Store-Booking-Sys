
namespace SimpsonsSys
{
    partial class frmDeleteDress
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
            this.lblDress = new System.Windows.Forms.Label();
            this.dgvAppoint3 = new System.Windows.Forms.DataGridView();
            this.lblname = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.txtboxMeasure = new System.Windows.Forms.TextBox();
            this.txtboxFabric = new System.Windows.Forms.TextBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.chckboxDeposit = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtboxCID = new System.Windows.Forms.TextBox();
            this.txtboxSID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoint3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDress
            // 
            this.lblDress.AutoSize = true;
            this.lblDress.BackColor = System.Drawing.Color.LightSalmon;
            this.lblDress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDress.Location = new System.Drawing.Point(32, 37);
            this.lblDress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDress.Name = "lblDress";
            this.lblDress.Size = new System.Drawing.Size(322, 33);
            this.lblDress.TabIndex = 2;
            this.lblDress.Text = "Dressmaking Deletion";
            // 
            // dgvAppoint3
            // 
            this.dgvAppoint3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoint3.Location = new System.Drawing.Point(18, 163);
            this.dgvAppoint3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAppoint3.Name = "dgvAppoint3";
            this.dgvAppoint3.ReadOnly = true;
            this.dgvAppoint3.RowHeadersWidth = 62;
            this.dgvAppoint3.Size = new System.Drawing.Size(478, 251);
            this.dgvAppoint3.TabIndex = 88;
            this.dgvAppoint3.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(24, 120);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(379, 26);
            this.lblname.TabIndex = 89;
            this.lblname.Text = "Please select a name from below: ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(38, 545);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(230, 78);
            this.btnDelete.TabIndex = 90;
            this.btnDelete.Text = "Delete Appointment";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(621, 106);
            this.txtboxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(148, 26);
            this.txtboxId.TabIndex = 128;
            // 
            // txtboxMeasure
            // 
            this.txtboxMeasure.Location = new System.Drawing.Point(621, 226);
            this.txtboxMeasure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxMeasure.Name = "txtboxMeasure";
            this.txtboxMeasure.Size = new System.Drawing.Size(148, 26);
            this.txtboxMeasure.TabIndex = 94;
            // 
            // txtboxFabric
            // 
            this.txtboxFabric.Location = new System.Drawing.Point(621, 266);
            this.txtboxFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFabric.Name = "txtboxFabric";
            this.txtboxFabric.Size = new System.Drawing.Size(148, 26);
            this.txtboxFabric.TabIndex = 95;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(621, 346);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(148, 26);
            this.txtboxDate.TabIndex = 126;
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(621, 306);
            this.txtboxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(148, 26);
            this.txtboxPrice.TabIndex = 125;
            // 
            // chckboxDeposit
            // 
            this.chckboxDeposit.AutoSize = true;
            this.chckboxDeposit.Location = new System.Drawing.Point(621, 388);
            this.chckboxDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckboxDeposit.Name = "chckboxDeposit";
            this.chckboxDeposit.Size = new System.Drawing.Size(87, 24);
            this.chckboxDeposit.TabIndex = 98;
            this.chckboxDeposit.Text = "Yes/No";
            this.chckboxDeposit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1080, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 31);
            this.btnBack.TabIndex = 124;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtboxCID
            // 
            this.txtboxCID.Location = new System.Drawing.Point(621, 37);
            this.txtboxCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCID.Name = "txtboxCID";
            this.txtboxCID.Size = new System.Drawing.Size(148, 26);
            this.txtboxCID.TabIndex = 136;
            this.txtboxCID.Visible = false;
            // 
            // txtboxSID
            // 
            this.txtboxSID.Location = new System.Drawing.Point(621, 72);
            this.txtboxSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSID.Name = "txtboxSID";
            this.txtboxSID.Size = new System.Drawing.Size(148, 26);
            this.txtboxSID.TabIndex = 137;
            this.txtboxSID.Visible = false;
            // 
            // frmDeleteDress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtboxSID);
            this.Controls.Add(this.txtboxCID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chckboxDeposit);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.txtboxFabric);
            this.Controls.Add(this.txtboxMeasure);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.dgvAppoint3);
            this.Controls.Add(this.lblDress);
            this.Name = "frmDeleteDress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteAppoint";
            this.Load += new System.EventHandler(this.frmDeleteAppoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoint3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDress;
        private System.Windows.Forms.DataGridView dgvAppoint3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.TextBox txtboxMeasure;
        private System.Windows.Forms.TextBox txtboxFabric;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.CheckBox chckboxDeposit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtboxCID;
        private System.Windows.Forms.TextBox txtboxSID;
    }
}