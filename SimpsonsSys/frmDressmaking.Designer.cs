
namespace SimpsonsSys
{
    partial class frmDressmaking
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFabric = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMeasurements = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.dgvDress = new System.Windows.Forms.DataGridView();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtboxMeasure = new System.Windows.Forms.TextBox();
            this.txtboxFabric = new System.Windows.Forms.TextBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.chckboxDeposit = new System.Windows.Forms.CheckBox();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.lblFabChosen = new System.Windows.Forms.Label();
            this.lblFurtDate = new System.Windows.Forms.Label();
            this.lblEstPrice = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxCID = new System.Windows.Forms.TextBox();
            this.txtboxSID = new System.Windows.Forms.TextBox();
            this.btnFabricRep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDress)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDress
            // 
            this.lblDress.AutoSize = true;
            this.lblDress.BackColor = System.Drawing.Color.LightSalmon;
            this.lblDress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDress.Location = new System.Drawing.Point(10, 9);
            this.lblDress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDress.Name = "lblDress";
            this.lblDress.Size = new System.Drawing.Size(473, 33);
            this.lblDress.TabIndex = 0;
            this.lblDress.Text = "View Dressmaking Appointments";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(18, 348);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 35);
            this.lblName.TabIndex = 97;
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(45, 465);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(150, 35);
            this.lblSurname.TabIndex = 96;
            // 
            // lblFabric
            // 
            this.lblFabric.Location = new System.Drawing.Point(250, 420);
            this.lblFabric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabric.Name = "lblFabric";
            this.lblFabric.Size = new System.Drawing.Size(150, 35);
            this.lblFabric.TabIndex = 95;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(18, 312);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 35);
            this.lblDate.TabIndex = 94;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(111, 588);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(150, 35);
            this.lblPrice.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(172, 429);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 35);
            this.label6.TabIndex = 92;
            // 
            // lblMeasurements
            // 
            this.lblMeasurements.Location = new System.Drawing.Point(250, 378);
            this.lblMeasurements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeasurements.Name = "lblMeasurements";
            this.lblMeasurements.Size = new System.Drawing.Size(150, 35);
            this.lblMeasurements.TabIndex = 85;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.LightSalmon;
            this.btnInvoice.Location = new System.Drawing.Point(646, 632);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(492, 35);
            this.btnInvoice.TabIndex = 66;
            this.btnInvoice.Text = "View appointment invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // dgvDress
            // 
            this.dgvDress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDress.Location = new System.Drawing.Point(638, 55);
            this.dgvDress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDress.Name = "dgvDress";
            this.dgvDress.ReadOnly = true;
            this.dgvDress.RowHeadersWidth = 62;
            this.dgvDress.Size = new System.Drawing.Size(501, 409);
            this.dgvDress.TabIndex = 73;
            this.dgvDress.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.LightSalmon;
            this.btnChange.Location = new System.Drawing.Point(646, 542);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(501, 35);
            this.btnChange.TabIndex = 76;
            this.btnChange.Text = "Change an Appointment";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(838, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 31);
            this.btnBack.TabIndex = 77;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Snow;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(1030, 15);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(152, 31);
            this.btnNext.TabIndex = 79;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDelete2.Location = new System.Drawing.Point(646, 588);
            this.btnDelete2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(501, 35);
            this.btnDelete2.TabIndex = 80;
            this.btnDelete2.Text = "Delete an Appointment";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCreate.Location = new System.Drawing.Point(646, 497);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(501, 35);
            this.btnCreate.TabIndex = 81;
            this.btnCreate.Text = "Create an Appointment";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // txtboxMeasure
            // 
            this.txtboxMeasure.Location = new System.Drawing.Point(354, 232);
            this.txtboxMeasure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxMeasure.Name = "txtboxMeasure";
            this.txtboxMeasure.Size = new System.Drawing.Size(186, 26);
            this.txtboxMeasure.TabIndex = 117;
            // 
            // txtboxFabric
            // 
            this.txtboxFabric.Location = new System.Drawing.Point(354, 283);
            this.txtboxFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFabric.Name = "txtboxFabric";
            this.txtboxFabric.Size = new System.Drawing.Size(186, 26);
            this.txtboxFabric.TabIndex = 118;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(354, 342);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(186, 26);
            this.txtboxDate.TabIndex = 119;
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(354, 400);
            this.txtboxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(186, 26);
            this.txtboxPrice.TabIndex = 122;
            // 
            // chckboxDeposit
            // 
            this.chckboxDeposit.AutoSize = true;
            this.chckboxDeposit.Location = new System.Drawing.Point(354, 460);
            this.chckboxDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckboxDeposit.Name = "chckboxDeposit";
            this.chckboxDeposit.Size = new System.Drawing.Size(87, 24);
            this.chckboxDeposit.TabIndex = 123;
            this.chckboxDeposit.Text = "Yes/No";
            this.chckboxDeposit.UseVisualStyleBackColor = true;
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasure.Location = new System.Drawing.Point(38, 229);
            this.lblMeasure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(238, 29);
            this.lblMeasure.TabIndex = 126;
            this.lblMeasure.Text = "Measurements (cm): ";
            // 
            // lblFabChosen
            // 
            this.lblFabChosen.AutoSize = true;
            this.lblFabChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFabChosen.Location = new System.Drawing.Point(38, 283);
            this.lblFabChosen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabChosen.Name = "lblFabChosen";
            this.lblFabChosen.Size = new System.Drawing.Size(177, 29);
            this.lblFabChosen.TabIndex = 127;
            this.lblFabChosen.Text = "Fabric chosen: ";
            // 
            // lblFurtDate
            // 
            this.lblFurtDate.AutoSize = true;
            this.lblFurtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFurtDate.Location = new System.Drawing.Point(10, 342);
            this.lblFurtDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFurtDate.Name = "lblFurtDate";
            this.lblFurtDate.Size = new System.Drawing.Size(294, 29);
            this.lblFurtDate.TabIndex = 128;
            this.lblFurtDate.Text = " Further appointment date:";
            // 
            // lblEstPrice
            // 
            this.lblEstPrice.AutoSize = true;
            this.lblEstPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEstPrice.Location = new System.Drawing.Point(16, 400);
            this.lblEstPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstPrice.Name = "lblEstPrice";
            this.lblEstPrice.Size = new System.Drawing.Size(178, 29);
            this.lblEstPrice.TabIndex = 129;
            this.lblEstPrice.Text = "Estimate price: ";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDeposit.Location = new System.Drawing.Point(9, 465);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(206, 29);
            this.lblDeposit.TabIndex = 130;
            this.lblDeposit.Text = "£50 Deposit paid: ";
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(354, 103);
            this.txtboxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(186, 26);
            this.txtboxId.TabIndex = 131;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(46, 100);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(189, 29);
            this.lblId.TabIndex = 132;
            this.lblId.Text = "Appointment ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 133;
            this.label1.Text = "Client ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 134;
            this.label2.Text = "Staff ID: ";
            // 
            // txtboxCID
            // 
            this.txtboxCID.Location = new System.Drawing.Point(354, 148);
            this.txtboxCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCID.Name = "txtboxCID";
            this.txtboxCID.Size = new System.Drawing.Size(186, 26);
            this.txtboxCID.TabIndex = 135;
            // 
            // txtboxSID
            // 
            this.txtboxSID.Location = new System.Drawing.Point(354, 188);
            this.txtboxSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSID.Name = "txtboxSID";
            this.txtboxSID.Size = new System.Drawing.Size(186, 26);
            this.txtboxSID.TabIndex = 136;
            // 
            // btnFabricRep
            // 
            this.btnFabricRep.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFabricRep.Location = new System.Drawing.Point(93, 628);
            this.btnFabricRep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFabricRep.Name = "btnFabricRep";
            this.btnFabricRep.Size = new System.Drawing.Size(492, 35);
            this.btnFabricRep.TabIndex = 137;
            this.btnFabricRep.Text = "View Fabric Stock";
            this.btnFabricRep.UseVisualStyleBackColor = false;
            this.btnFabricRep.Click += new System.EventHandler(this.btnFabricRep_Click);
            // 
            // frmDressmaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnFabricRep);
            this.Controls.Add(this.txtboxSID);
            this.Controls.Add(this.txtboxCID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblEstPrice);
            this.Controls.Add(this.lblFurtDate);
            this.Controls.Add(this.lblFabChosen);
            this.Controls.Add(this.lblMeasure);
            this.Controls.Add(this.chckboxDeposit);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.txtboxFabric);
            this.Controls.Add(this.txtboxMeasure);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.dgvDress);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.lblMeasurements);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFabric);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDress);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDressmaking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmDress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFabric;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMeasurements;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.DataGridView dgvDress;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtboxMeasure;
        private System.Windows.Forms.TextBox txtboxFabric;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.CheckBox chckboxDeposit;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.Label lblFabChosen;
        private System.Windows.Forms.Label lblFurtDate;
        private System.Windows.Forms.Label lblEstPrice;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxCID;
        private System.Windows.Forms.TextBox txtboxSID;
        private System.Windows.Forms.Button btnFabricRep;
    }
}