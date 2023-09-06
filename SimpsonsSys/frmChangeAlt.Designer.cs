
namespace SimpsonsSys
{
    partial class frmChangeAlt
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
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.chckboxPaid = new System.Windows.Forms.CheckBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.txtboxReason = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.dgvAlt = new System.Windows.Forms.DataGridView();
            this.dateTimeAlt = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.lblAltid = new System.Windows.Forms.Label();
            this.rdbtnReason3 = new System.Windows.Forms.RadioButton();
            this.rdbtnReason4 = new System.Windows.Forms.RadioButton();
            this.rdbtnReason2 = new System.Windows.Forms.RadioButton();
            this.rdbtnReason1 = new System.Windows.Forms.RadioButton();
            this.lblSelect = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChangeAlt = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.comboStaff = new System.Windows.Forms.ComboBox();
            this.comboClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(1000, 398);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(148, 26);
            this.txtboxDate.TabIndex = 171;
            // 
            // chckboxPaid
            // 
            this.chckboxPaid.AutoSize = true;
            this.chckboxPaid.Location = new System.Drawing.Point(996, 446);
            this.chckboxPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckboxPaid.Name = "chckboxPaid";
            this.chckboxPaid.Size = new System.Drawing.Size(87, 24);
            this.chckboxPaid.TabIndex = 170;
            this.chckboxPaid.Text = "Yes/No";
            this.chckboxPaid.UseVisualStyleBackColor = true;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaid.Location = new System.Drawing.Point(688, 448);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(74, 29);
            this.lblPaid.TabIndex = 169;
            this.lblPaid.Text = "Paid: ";
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(996, 323);
            this.txtboxCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(148, 26);
            this.txtboxCost.TabIndex = 168;
            // 
            // txtboxReason
            // 
            this.txtboxReason.Location = new System.Drawing.Point(996, 260);
            this.txtboxReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxReason.Name = "txtboxReason";
            this.txtboxReason.Size = new System.Drawing.Size(148, 26);
            this.txtboxReason.TabIndex = 167;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(688, 386);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(304, 29);
            this.lblDate.TabIndex = 164;
            this.lblDate.Text = "Expected completion date: ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCost.Location = new System.Drawing.Point(704, 320);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(74, 29);
            this.lblCost.TabIndex = 163;
            this.lblCost.Text = "Cost: ";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReason.Location = new System.Drawing.Point(688, 260);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(249, 29);
            this.lblReason.TabIndex = 162;
            this.lblReason.Text = "Reason for Alteration: ";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(16, 22);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(379, 26);
            this.lblName2.TabIndex = 174;
            this.lblName2.Text = "Please select a name from below: ";
            // 
            // dgvAlt
            // 
            this.dgvAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlt.Location = new System.Drawing.Point(16, 54);
            this.dgvAlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlt.Name = "dgvAlt";
            this.dgvAlt.ReadOnly = true;
            this.dgvAlt.RowHeadersWidth = 62;
            this.dgvAlt.Size = new System.Drawing.Size(448, 251);
            this.dgvAlt.TabIndex = 173;
            this.dgvAlt.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dateTimeAlt
            // 
            this.dateTimeAlt.CustomFormat = " dd/MM/yyyy hh:mm:ss";
            this.dateTimeAlt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAlt.Location = new System.Drawing.Point(16, 323);
            this.dateTimeAlt.Name = "dateTimeAlt";
            this.dateTimeAlt.Size = new System.Drawing.Size(446, 26);
            this.dateTimeAlt.TabIndex = 172;
            this.dateTimeAlt.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1030, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 31);
            this.btnBack.TabIndex = 176;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(996, 91);
            this.txtboxid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(148, 26);
            this.txtboxid.TabIndex = 177;
            // 
            // lblAltid
            // 
            this.lblAltid.AutoSize = true;
            this.lblAltid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAltid.Location = new System.Drawing.Point(704, 88);
            this.lblAltid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltid.Name = "lblAltid";
            this.lblAltid.Size = new System.Drawing.Size(149, 29);
            this.lblAltid.TabIndex = 178;
            this.lblAltid.Text = "Alteration ID:";
            // 
            // rdbtnReason3
            // 
            this.rdbtnReason3.AutoSize = true;
            this.rdbtnReason3.BackColor = System.Drawing.Color.AliceBlue;
            this.rdbtnReason3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbtnReason3.Location = new System.Drawing.Point(58, 543);
            this.rdbtnReason3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbtnReason3.Name = "rdbtnReason3";
            this.rdbtnReason3.Size = new System.Drawing.Size(112, 33);
            this.rdbtnReason3.TabIndex = 183;
            this.rdbtnReason3.TabStop = true;
            this.rdbtnReason3.Text = "too big";
            this.rdbtnReason3.UseVisualStyleBackColor = false;
            this.rdbtnReason3.Click += new System.EventHandler(this.createAlt);
            // 
            // rdbtnReason4
            // 
            this.rdbtnReason4.AutoSize = true;
            this.rdbtnReason4.BackColor = System.Drawing.Color.AliceBlue;
            this.rdbtnReason4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbtnReason4.Location = new System.Drawing.Point(58, 595);
            this.rdbtnReason4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbtnReason4.Name = "rdbtnReason4";
            this.rdbtnReason4.Size = new System.Drawing.Size(82, 33);
            this.rdbtnReason4.TabIndex = 182;
            this.rdbtnReason4.TabStop = true;
            this.rdbtnReason4.Text = "ugly";
            this.rdbtnReason4.UseVisualStyleBackColor = false;
            this.rdbtnReason4.Click += new System.EventHandler(this.createAlt);
            // 
            // rdbtnReason2
            // 
            this.rdbtnReason2.AutoSize = true;
            this.rdbtnReason2.BackColor = System.Drawing.Color.AliceBlue;
            this.rdbtnReason2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbtnReason2.Location = new System.Drawing.Point(58, 494);
            this.rdbtnReason2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbtnReason2.Name = "rdbtnReason2";
            this.rdbtnReason2.Size = new System.Drawing.Size(102, 33);
            this.rdbtnReason2.TabIndex = 181;
            this.rdbtnReason2.TabStop = true;
            this.rdbtnReason2.Text = "Faulty";
            this.rdbtnReason2.UseVisualStyleBackColor = false;
            this.rdbtnReason2.Click += new System.EventHandler(this.createAlt);
            // 
            // rdbtnReason1
            // 
            this.rdbtnReason1.AutoSize = true;
            this.rdbtnReason1.BackColor = System.Drawing.Color.AliceBlue;
            this.rdbtnReason1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbtnReason1.Location = new System.Drawing.Point(58, 448);
            this.rdbtnReason1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbtnReason1.Name = "rdbtnReason1";
            this.rdbtnReason1.Size = new System.Drawing.Size(135, 33);
            this.rdbtnReason1.TabIndex = 180;
            this.rdbtnReason1.TabStop = true;
            this.rdbtnReason1.Text = "too small";
            this.rdbtnReason1.UseVisualStyleBackColor = false;
            this.rdbtnReason1.Click += new System.EventHandler(this.createAlt);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(16, 398);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(409, 26);
            this.lblSelect.TabIndex = 179;
            this.lblSelect.Text = "Please select a reason for alteration: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(16, 389);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 285);
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // btnChangeAlt
            // 
            this.btnChangeAlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAlt.Location = new System.Drawing.Point(868, 538);
            this.btnChangeAlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangeAlt.Name = "btnChangeAlt";
            this.btnChangeAlt.Size = new System.Drawing.Size(276, 89);
            this.btnChangeAlt.TabIndex = 186;
            this.btnChangeAlt.Text = "Change Alteration";
            this.btnChangeAlt.UseVisualStyleBackColor = false;
            this.btnChangeAlt.Click += new System.EventHandler(this.btnChangeAlt_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurname.Location = new System.Drawing.Point(800, 203);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(101, 29);
            this.lblSurname.TabIndex = 188;
            this.lblSurname.Text = "Staff ID: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(784, 148);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 29);
            this.lblName.TabIndex = 187;
            this.lblName.Text = "Client ID: ";
            // 
            // comboStaff
            // 
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(996, 202);
            this.comboStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(152, 28);
            this.comboStaff.TabIndex = 190;
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(996, 146);
            this.comboClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(152, 28);
            this.comboClient.TabIndex = 189;
            // 
            // frmChangeAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.comboStaff);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnChangeAlt);
            this.Controls.Add(this.rdbtnReason3);
            this.Controls.Add(this.rdbtnReason4);
            this.Controls.Add(this.rdbtnReason2);
            this.Controls.Add(this.rdbtnReason1);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAltid);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.dgvAlt);
            this.Controls.Add(this.dateTimeAlt);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.chckboxPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxReason);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblReason);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChangeAlt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeAlt";
            this.Load += new System.EventHandler(this.frmChangeAlt_Load);
            this.Click += new System.EventHandler(this.createAlt);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.CheckBox chckboxPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.TextBox txtboxReason;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.DataGridView dgvAlt;
        private System.Windows.Forms.DateTimePicker dateTimeAlt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.Label lblAltid;
        private System.Windows.Forms.RadioButton rdbtnReason3;
        private System.Windows.Forms.RadioButton rdbtnReason4;
        private System.Windows.Forms.RadioButton rdbtnReason2;
        private System.Windows.Forms.RadioButton rdbtnReason1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangeAlt;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox comboStaff;
        private System.Windows.Forms.ComboBox comboClient;
    }
}