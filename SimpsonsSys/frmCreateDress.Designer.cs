
namespace SimpsonsSys
{
    partial class frmCreateDress
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.dgvFabric = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.chckboxDeposit = new System.Windows.Forms.CheckBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.txtboxFabric = new System.Windows.Forms.TextBox();
            this.txtboxMeasure = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFabChosen = new System.Windows.Forms.Label();
            this.dateAppoint = new System.Windows.Forms.DateTimePicker();
            this.lblDress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFabID = new System.Windows.Forms.TextBox();
            this.txtboxQuant = new System.Windows.Forms.TextBox();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.comboStaff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabric)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(14, 172);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(427, 26);
            this.lblSelect.TabIndex = 127;
            this.lblSelect.Text = "Please select from a variety of fabrics: ";
            // 
            // dgvFabric
            // 
            this.dgvFabric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabric.Location = new System.Drawing.Point(18, 217);
            this.dgvFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFabric.Name = "dgvFabric";
            this.dgvFabric.ReadOnly = true;
            this.dgvFabric.RowHeadersWidth = 62;
            this.dgvFabric.Size = new System.Drawing.Size(448, 217);
            this.dgvFabric.TabIndex = 126;
            this.dgvFabric.SelectionChanged += new System.EventHandler(this.dgvFabric_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1077, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 31);
            this.btnBack.TabIndex = 123;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(872, 585);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(276, 89);
            this.btnBook.TabIndex = 122;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(934, 317);
            this.txtboxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(186, 26);
            this.txtboxPrice.TabIndex = 121;
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasure.Location = new System.Drawing.Point(688, 168);
            this.lblMeasure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(238, 29);
            this.lblMeasure.TabIndex = 120;
            this.lblMeasure.Text = "Measurements (cm): ";
            // 
            // chckboxDeposit
            // 
            this.chckboxDeposit.AutoSize = true;
            this.chckboxDeposit.Location = new System.Drawing.Point(934, 378);
            this.chckboxDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckboxDeposit.Name = "chckboxDeposit";
            this.chckboxDeposit.Size = new System.Drawing.Size(87, 24);
            this.chckboxDeposit.TabIndex = 119;
            this.chckboxDeposit.Text = "Yes/No";
            this.chckboxDeposit.UseVisualStyleBackColor = true;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(934, 266);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(186, 26);
            this.txtboxDate.TabIndex = 118;
            this.txtboxDate.TextChanged += new System.EventHandler(this.txtboxDate_TextChanged);
            // 
            // txtboxFabric
            // 
            this.txtboxFabric.Location = new System.Drawing.Point(934, 217);
            this.txtboxFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFabric.Name = "txtboxFabric";
            this.txtboxFabric.Size = new System.Drawing.Size(186, 26);
            this.txtboxFabric.TabIndex = 117;
            // 
            // txtboxMeasure
            // 
            this.txtboxMeasure.Location = new System.Drawing.Point(934, 172);
            this.txtboxMeasure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxMeasure.Name = "txtboxMeasure";
            this.txtboxMeasure.Size = new System.Drawing.Size(186, 26);
            this.txtboxMeasure.TabIndex = 116;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDeposit.Location = new System.Drawing.Point(672, 372);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(206, 29);
            this.lblDeposit.TabIndex = 113;
            this.lblDeposit.Text = "£50 Deposit paid: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.Location = new System.Drawing.Point(700, 312);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(178, 29);
            this.lblPrice.TabIndex = 112;
            this.lblPrice.Text = "Estimate price: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(584, 266);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(294, 29);
            this.lblDate.TabIndex = 111;
            this.lblDate.Text = " Further appointment date:";
            // 
            // lblFabChosen
            // 
            this.lblFabChosen.AutoSize = true;
            this.lblFabChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFabChosen.Location = new System.Drawing.Point(700, 217);
            this.lblFabChosen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabChosen.Name = "lblFabChosen";
            this.lblFabChosen.Size = new System.Drawing.Size(177, 29);
            this.lblFabChosen.TabIndex = 110;
            this.lblFabChosen.Text = "Fabric chosen: ";
            // 
            // dateAppoint
            // 
            this.dateAppoint.CustomFormat = " dd/MM/yyyy hh:mm:ss";
            this.dateAppoint.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAppoint.Location = new System.Drawing.Point(16, 460);
            this.dateAppoint.Name = "dateAppoint";
            this.dateAppoint.Size = new System.Drawing.Size(446, 26);
            this.dateAppoint.TabIndex = 105;
            this.dateAppoint.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDress
            // 
            this.lblDress.AutoSize = true;
            this.lblDress.BackColor = System.Drawing.Color.LightSalmon;
            this.lblDress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDress.Location = new System.Drawing.Point(24, 40);
            this.lblDress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDress.Name = "lblDress";
            this.lblDress.Size = new System.Drawing.Size(328, 33);
            this.lblDress.TabIndex = 104;
            this.lblDress.Text = "Dressmaking Booking ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 135;
            this.label2.Text = "Staff ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 136;
            this.label1.Text = "Client ID: ";
            // 
            // txtFabID
            // 
            this.txtFabID.Location = new System.Drawing.Point(596, 602);
            this.txtFabID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFabID.Name = "txtFabID";
            this.txtFabID.Size = new System.Drawing.Size(186, 26);
            this.txtFabID.TabIndex = 137;
            this.txtFabID.Visible = false;
            // 
            // txtboxQuant
            // 
            this.txtboxQuant.Location = new System.Drawing.Point(590, 557);
            this.txtboxQuant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxQuant.Name = "txtboxQuant";
            this.txtboxQuant.Size = new System.Drawing.Size(186, 26);
            this.txtboxQuant.TabIndex = 138;
            this.txtboxQuant.Visible = false;
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(934, 66);
            this.comboClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(186, 28);
            this.comboClient.TabIndex = 194;
            // 
            // comboStaff
            // 
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(934, 117);
            this.comboStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(186, 28);
            this.comboStaff.TabIndex = 195;
            // 
            // frmCreateDress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.comboStaff);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.txtboxQuant);
            this.Controls.Add(this.txtFabID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.dgvFabric);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.lblMeasure);
            this.Controls.Add(this.chckboxDeposit);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.txtboxFabric);
            this.Controls.Add(this.txtboxMeasure);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFabChosen);
            this.Controls.Add(this.dateAppoint);
            this.Controls.Add(this.lblDress);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCreateDress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateAppoint";
            this.Load += new System.EventHandler(this.frmCreateAppoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.DataGridView dgvFabric;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.CheckBox chckboxDeposit;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.TextBox txtboxFabric;
        private System.Windows.Forms.TextBox txtboxMeasure;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFabChosen;
        private System.Windows.Forms.DateTimePicker dateAppoint;
        private System.Windows.Forms.Label lblDress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFabID;
        private System.Windows.Forms.TextBox txtboxQuant;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.ComboBox comboStaff;
    }
}