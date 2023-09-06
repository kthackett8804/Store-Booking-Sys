
namespace SimpsonsSys
{
    partial class frmChangeDress
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
            this.dateAppoint2 = new System.Windows.Forms.DateTimePicker();
            this.dgvAppoint = new System.Windows.Forms.DataGridView();
            this.lblname = new System.Windows.Forms.Label();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.lblMeasurements = new System.Windows.Forms.Label();
            this.chckboxDeposit = new System.Windows.Forms.CheckBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.txtboxFabric = new System.Windows.Forms.TextBox();
            this.txtboxMeasure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFabric = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFabric = new System.Windows.Forms.DataGridView();
            this.lblSelect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboStaff = new System.Windows.Forms.ComboBox();
            this.comboClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabric)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDress
            // 
            this.lblDress.AutoSize = true;
            this.lblDress.BackColor = System.Drawing.Color.LightSalmon;
            this.lblDress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDress.Location = new System.Drawing.Point(32, 32);
            this.lblDress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDress.Name = "lblDress";
            this.lblDress.Size = new System.Drawing.Size(444, 33);
            this.lblDress.TabIndex = 1;
            this.lblDress.Text = "Change Dressmaking Booking ";
            // 
            // dateAppoint2
            // 
            this.dateAppoint2.CustomFormat = " dd/MM/yyyy hh:mm:ss";
            this.dateAppoint2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAppoint2.Location = new System.Drawing.Point(28, 403);
            this.dateAppoint2.Name = "dateAppoint2";
            this.dateAppoint2.Size = new System.Drawing.Size(446, 26);
            this.dateAppoint2.TabIndex = 79;
            this.dateAppoint2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvAppoint
            // 
            this.dgvAppoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoint.Location = new System.Drawing.Point(28, 145);
            this.dgvAppoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAppoint.Name = "dgvAppoint";
            this.dgvAppoint.ReadOnly = true;
            this.dgvAppoint.RowHeadersWidth = 62;
            this.dgvAppoint.Size = new System.Drawing.Size(448, 251);
            this.dgvAppoint.TabIndex = 80;
            this.dgvAppoint.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(33, 112);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(379, 26);
            this.lblname.TabIndex = 83;
            this.lblname.Text = "Please select a name from below: ";
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(922, 328);
            this.txtboxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(186, 26);
            this.txtboxPrice.TabIndex = 97;
            // 
            // lblMeasurements
            // 
            this.lblMeasurements.AutoSize = true;
            this.lblMeasurements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasurements.Location = new System.Drawing.Point(633, 182);
            this.lblMeasurements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeasurements.Name = "lblMeasurements";
            this.lblMeasurements.Size = new System.Drawing.Size(238, 29);
            this.lblMeasurements.TabIndex = 96;
            this.lblMeasurements.Text = "Measurements (cm): ";
            // 
            // chckboxDeposit
            // 
            this.chckboxDeposit.AutoSize = true;
            this.chckboxDeposit.Location = new System.Drawing.Point(922, 389);
            this.chckboxDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckboxDeposit.Name = "chckboxDeposit";
            this.chckboxDeposit.Size = new System.Drawing.Size(87, 24);
            this.chckboxDeposit.TabIndex = 95;
            this.chckboxDeposit.Text = "Yes/No";
            this.chckboxDeposit.UseVisualStyleBackColor = true;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(922, 282);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(186, 26);
            this.txtboxDate.TabIndex = 94;
            // 
            // txtboxFabric
            // 
            this.txtboxFabric.Location = new System.Drawing.Point(922, 229);
            this.txtboxFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFabric.Name = "txtboxFabric";
            this.txtboxFabric.Size = new System.Drawing.Size(186, 26);
            this.txtboxFabric.TabIndex = 93;
            // 
            // txtboxMeasure
            // 
            this.txtboxMeasure.Location = new System.Drawing.Point(922, 182);
            this.txtboxMeasure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxMeasure.Name = "txtboxMeasure";
            this.txtboxMeasure.Size = new System.Drawing.Size(186, 26);
            this.txtboxMeasure.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(664, 389);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 29);
            this.label6.TabIndex = 89;
            this.label6.Text = "£50 Deposit paid: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.Location = new System.Drawing.Point(693, 325);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(178, 29);
            this.lblPrice.TabIndex = 88;
            this.lblPrice.Text = "Estimate price: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(584, 278);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(294, 29);
            this.lblDate.TabIndex = 87;
            this.lblDate.Text = " Further appointment date:";
            // 
            // lblFabric
            // 
            this.lblFabric.AutoSize = true;
            this.lblFabric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFabric.Location = new System.Drawing.Point(700, 229);
            this.lblFabric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabric.Name = "lblFabric";
            this.lblFabric.Size = new System.Drawing.Size(177, 29);
            this.lblFabric.TabIndex = 86;
            this.lblFabric.Text = "Fabric chosen: ";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(856, 585);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(276, 89);
            this.btnChange.TabIndex = 98;
            this.btnChange.Text = "Change Appointment";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1080, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 31);
            this.btnBack.TabIndex = 99;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(922, 58);
            this.txtboxid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(186, 26);
            this.txtboxid.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(704, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 101;
            this.label1.Text = "Appointment ID: ";
            // 
            // dgvFabric
            // 
            this.dgvFabric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabric.Location = new System.Drawing.Point(28, 562);
            this.dgvFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFabric.Name = "dgvFabric";
            this.dgvFabric.ReadOnly = true;
            this.dgvFabric.RowHeadersWidth = 62;
            this.dgvFabric.Size = new System.Drawing.Size(448, 112);
            this.dgvFabric.TabIndex = 102;
            this.dgvFabric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dgvFabric.SelectionChanged += new System.EventHandler(this.dgvFabric_SelectionChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(33, 514);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(427, 26);
            this.lblSelect.TabIndex = 103;
            this.lblSelect.Text = "Please select from a variety of fabrics: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(762, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 137;
            this.label3.Text = "Client ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(770, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 138;
            this.label4.Text = "Staff ID: ";
            // 
            // comboStaff
            // 
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(922, 134);
            this.comboStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(186, 28);
            this.comboStaff.TabIndex = 191;
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(922, 92);
            this.comboClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(186, 28);
            this.comboClient.TabIndex = 192;
            // 
            // frmChangeDress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.comboStaff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.dgvFabric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.lblMeasurements);
            this.Controls.Add(this.chckboxDeposit);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.txtboxFabric);
            this.Controls.Add(this.txtboxMeasure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFabric);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.dgvAppoint);
            this.Controls.Add(this.dateAppoint2);
            this.Controls.Add(this.lblDress);
            this.Name = "frmChangeDress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookAppoint";
            this.Load += new System.EventHandler(this.frmBookAppoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDress;
        private System.Windows.Forms.DateTimePicker dateAppoint2;
        private System.Windows.Forms.DataGridView dgvAppoint;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.Label lblMeasurements;
        private System.Windows.Forms.CheckBox chckboxDeposit;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.TextBox txtboxFabric;
        private System.Windows.Forms.TextBox txtboxMeasure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFabric;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFabric;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboStaff;
        private System.Windows.Forms.ComboBox comboClient;
    }
}