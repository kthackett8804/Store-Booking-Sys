
namespace SimpsonsSys
{
    partial class frmCreateAlt
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
            this.btnBook = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.dateTimeAlt = new System.Windows.Forms.DateTimePicker();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtboxReason = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.chckboxPaid = new System.Windows.Forms.CheckBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.rdbtnReason1 = new System.Windows.Forms.RadioButton();
            this.rdbtnReason2 = new System.Windows.Forms.RadioButton();
            this.rdbtnReason4 = new System.Windows.Forms.RadioButton();
            this.rdbtnReason3 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.comboStaff = new System.Windows.Forms.ComboBox();
            this.comboClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(574, 359);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(184, 58);
            this.btnBook.TabIndex = 123;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.BackColor = System.Drawing.Color.AliceBlue;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(22, 103);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(291, 18);
            this.lblSelect.TabIndex = 145;
            this.lblSelect.Text = "Please select a reason for alteration: ";
            // 
            // dateTimeAlt
            // 
            this.dateTimeAlt.CustomFormat = " dd/MM/yyyy hh:mm:ss";
            this.dateTimeAlt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAlt.Location = new System.Drawing.Point(25, 311);
            this.dateTimeAlt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeAlt.Name = "dateTimeAlt";
            this.dateTimeAlt.Size = new System.Drawing.Size(300, 20);
            this.dateTimeAlt.TabIndex = 129;
            this.dateTimeAlt.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt.Location = new System.Drawing.Point(21, 33);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(186, 24);
            this.lblAlt.TabIndex = 128;
            this.lblAlt.Text = "Alteration Booking ";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReason.Location = new System.Drawing.Point(438, 195);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(168, 20);
            this.lblReason.TabIndex = 148;
            this.lblReason.Text = "Reason for Alteration: ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCost.Location = new System.Drawing.Point(448, 234);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(50, 20);
            this.lblCost.TabIndex = 149;
            this.lblCost.Text = "Cost: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(438, 277);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(201, 20);
            this.lblDate.TabIndex = 150;
            this.lblDate.Text = "Expected completion date: ";
            // 
            // txtboxReason
            // 
            this.txtboxReason.Location = new System.Drawing.Point(643, 195);
            this.txtboxReason.Name = "txtboxReason";
            this.txtboxReason.Size = new System.Drawing.Size(100, 20);
            this.txtboxReason.TabIndex = 154;
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(643, 236);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(100, 20);
            this.txtboxCost.TabIndex = 155;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaid.Location = new System.Drawing.Point(438, 317);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(48, 20);
            this.lblPaid.TabIndex = 156;
            this.lblPaid.Text = "Paid: ";
            // 
            // chckboxPaid
            // 
            this.chckboxPaid.AutoSize = true;
            this.chckboxPaid.Location = new System.Drawing.Point(643, 316);
            this.chckboxPaid.Name = "chckboxPaid";
            this.chckboxPaid.Size = new System.Drawing.Size(63, 17);
            this.chckboxPaid.TabIndex = 157;
            this.chckboxPaid.Text = "Yes/No";
            this.chckboxPaid.UseVisualStyleBackColor = true;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(643, 279);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(100, 20);
            this.txtboxDate.TabIndex = 159;
            // 
            // rdbtnReason1
            // 
            this.rdbtnReason1.AutoSize = true;
            this.rdbtnReason1.BackColor = System.Drawing.Color.AliceBlue;
            this.rdbtnReason1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbtnReason1.Location = new System.Drawing.Point(25, 138);
            this.rdbtnReason1.Name = "rdbtnReason1";
            this.rdbtnReason1.Size = new System.Drawing.Size(90, 24);
            this.rdbtnReason1.TabIndex = 160;
            this.rdbtnReason1.TabStop = true;
            this.rdbtnReason1.Text = "too small";
            this.rdbtnReason1.UseVisualStyleBackColor = false;
            this.rdbtnReason1.Click += new System.EventHandler(this.frmCreateAlt_Click);
            // 
            // rdbtnReason2
            // 
            this.rdbtnReason2.AutoSize = true;
            this.rdbtnReason2.BackColor = System.Drawing.Color.AliceBlue;
            this.rdbtnReason2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbtnReason2.Location = new System.Drawing.Point(25, 175);
            this.rdbtnReason2.Name = "rdbtnReason2";
            this.rdbtnReason2.Size = new System.Drawing.Size(70, 24);
            this.rdbtnReason2.TabIndex = 161;
            this.rdbtnReason2.TabStop = true;
            this.rdbtnReason2.Text = "Faulty";
            this.rdbtnReason2.UseVisualStyleBackColor = false;
            this.rdbtnReason2.Click += new System.EventHandler(this.frmCreateAlt_Click);
            // 
            // rdbtnReason4
            // 
            this.rdbtnReason4.AutoSize = true;
            this.rdbtnReason4.BackColor = System.Drawing.Color.AliceBlue;
            this.rdbtnReason4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbtnReason4.Location = new System.Drawing.Point(25, 239);
            this.rdbtnReason4.Name = "rdbtnReason4";
            this.rdbtnReason4.Size = new System.Drawing.Size(55, 24);
            this.rdbtnReason4.TabIndex = 162;
            this.rdbtnReason4.TabStop = true;
            this.rdbtnReason4.Text = "ugly";
            this.rdbtnReason4.UseVisualStyleBackColor = false;
            this.rdbtnReason4.Click += new System.EventHandler(this.frmCreateAlt_Click);
            // 
            // rdbtnReason3
            // 
            this.rdbtnReason3.AutoSize = true;
            this.rdbtnReason3.BackColor = System.Drawing.Color.AliceBlue;
            this.rdbtnReason3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbtnReason3.Location = new System.Drawing.Point(25, 207);
            this.rdbtnReason3.Name = "rdbtnReason3";
            this.rdbtnReason3.Size = new System.Drawing.Size(75, 24);
            this.rdbtnReason3.TabIndex = 163;
            this.rdbtnReason3.TabStop = true;
            this.rdbtnReason3.Text = "too big";
            this.rdbtnReason3.UseVisualStyleBackColor = false;
            this.rdbtnReason3.Click += new System.EventHandler(this.frmCreateAlt_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(720, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 20);
            this.btnBack.TabIndex = 164;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 210);
            this.pictureBox1.TabIndex = 165;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(501, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 20);
            this.lblName.TabIndex = 166;
            this.lblName.Text = "Client ID: ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurname.Location = new System.Drawing.Point(511, 151);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(73, 20);
            this.lblSurname.TabIndex = 167;
            this.lblSurname.Text = "Staff ID: ";
            // 
            // comboStaff
            // 
            this.comboStaff.FormattingEnabled = true;
            this.comboStaff.Location = new System.Drawing.Point(643, 150);
            this.comboStaff.Name = "comboStaff";
            this.comboStaff.Size = new System.Drawing.Size(100, 21);
            this.comboStaff.TabIndex = 192;
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(643, 104);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(100, 21);
            this.comboClient.TabIndex = 193;
            // 
            // frmCreateAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.comboStaff);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rdbtnReason3);
            this.Controls.Add(this.rdbtnReason4);
            this.Controls.Add(this.rdbtnReason2);
            this.Controls.Add(this.rdbtnReason1);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.chckboxPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxReason);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.dateTimeAlt);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCreateAlt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateAlt";
            this.Load += new System.EventHandler(this.frmCreateAlt_Load);
            this.Click += new System.EventHandler(this.frmCreateAlt_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.DateTimePicker dateTimeAlt;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtboxReason;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.CheckBox chckboxPaid;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.RadioButton rdbtnReason1;
        private System.Windows.Forms.RadioButton rdbtnReason2;
        private System.Windows.Forms.RadioButton rdbtnReason4;
        private System.Windows.Forms.RadioButton rdbtnReason3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.ComboBox comboStaff;
        private System.Windows.Forms.ComboBox comboClient;
    }
}