
namespace SimpsonsSys
{
    partial class frmAlteration
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvAlt = new System.Windows.Forms.DataGridView();
            this.txtboxAltid = new System.Windows.Forms.TextBox();
            this.txtboxCID = new System.Windows.Forms.TextBox();
            this.txtboxSID = new System.Windows.Forms.TextBox();
            this.txtboxReason = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.chckboxPaid = new System.Windows.Forms.CheckBox();
            this.lblAlterationID = new System.Windows.Forms.Label();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "View Alteration Bookings";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(27, 180);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Client ID: ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurname.Location = new System.Drawing.Point(18, 238);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(101, 29);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Staff ID: ";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReason.Location = new System.Drawing.Point(12, 294);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(249, 29);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Reason for Alteration: ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCost.Location = new System.Drawing.Point(27, 354);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(74, 29);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(12, 420);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(304, 29);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Expected completion date: ";
            // 
            // dgvAlt
            // 
            this.dgvAlt.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlt.Location = new System.Drawing.Point(638, 106);
            this.dgvAlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlt.Name = "dgvAlt";
            this.dgvAlt.ReadOnly = true;
            this.dgvAlt.RowHeadersWidth = 62;
            this.dgvAlt.Size = new System.Drawing.Size(501, 345);
            this.dgvAlt.TabIndex = 6;
            this.dgvAlt.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtboxAltid
            // 
            this.txtboxAltid.Location = new System.Drawing.Point(320, 129);
            this.txtboxAltid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxAltid.Name = "txtboxAltid";
            this.txtboxAltid.Size = new System.Drawing.Size(148, 26);
            this.txtboxAltid.TabIndex = 41;
            // 
            // txtboxCID
            // 
            this.txtboxCID.Location = new System.Drawing.Point(320, 183);
            this.txtboxCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCID.Name = "txtboxCID";
            this.txtboxCID.Size = new System.Drawing.Size(148, 26);
            this.txtboxCID.TabIndex = 42;
            this.txtboxCID.TextChanged += new System.EventHandler(this.txtboxName_TextChanged);
            // 
            // txtboxSID
            // 
            this.txtboxSID.Location = new System.Drawing.Point(320, 238);
            this.txtboxSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSID.Name = "txtboxSID";
            this.txtboxSID.Size = new System.Drawing.Size(148, 26);
            this.txtboxSID.TabIndex = 43;
            // 
            // txtboxReason
            // 
            this.txtboxReason.Location = new System.Drawing.Point(320, 294);
            this.txtboxReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxReason.Name = "txtboxReason";
            this.txtboxReason.Size = new System.Drawing.Size(148, 26);
            this.txtboxReason.TabIndex = 44;
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(320, 357);
            this.txtboxCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(148, 26);
            this.txtboxCost.TabIndex = 45;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaid.Location = new System.Drawing.Point(12, 482);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(74, 29);
            this.lblPaid.TabIndex = 46;
            this.lblPaid.Text = "Paid: ";
            // 
            // chckboxPaid
            // 
            this.chckboxPaid.AutoSize = true;
            this.chckboxPaid.Location = new System.Drawing.Point(320, 480);
            this.chckboxPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckboxPaid.Name = "chckboxPaid";
            this.chckboxPaid.Size = new System.Drawing.Size(87, 24);
            this.chckboxPaid.TabIndex = 47;
            this.chckboxPaid.Text = "Yes/No";
            this.chckboxPaid.UseVisualStyleBackColor = true;
            // 
            // lblAlterationID
            // 
            this.lblAlterationID.AutoSize = true;
            this.lblAlterationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAlterationID.Location = new System.Drawing.Point(18, 126);
            this.lblAlterationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlterationID.Name = "lblAlterationID";
            this.lblAlterationID.Size = new System.Drawing.Size(155, 29);
            this.lblAlterationID.TabIndex = 48;
            this.lblAlterationID.Text = "Alteration ID: ";
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(320, 423);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(148, 26);
            this.txtboxDate.TabIndex = 49;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(987, 28);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 31);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Location = new System.Drawing.Point(638, 502);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(501, 35);
            this.btnCreate.TabIndex = 87;
            this.btnCreate.Text = "Create a Booking";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete2.Location = new System.Drawing.Point(638, 592);
            this.btnDelete2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(501, 35);
            this.btnDelete2.TabIndex = 86;
            this.btnDelete2.Text = "Delete a Booking";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChange.Location = new System.Drawing.Point(638, 546);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(501, 35);
            this.btnChange.TabIndex = 85;
            this.btnChange.Text = "Change a Booking";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInvoice.Location = new System.Drawing.Point(638, 638);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(492, 35);
            this.btnInvoice.TabIndex = 84;
            this.btnInvoice.Text = "View alteration invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // frmAlteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.lblAlterationID);
            this.Controls.Add(this.chckboxPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxReason);
            this.Controls.Add(this.txtboxSID);
            this.Controls.Add(this.txtboxCID);
            this.Controls.Add(this.txtboxAltid);
            this.Controls.Add(this.dgvAlt);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAlteration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAlteration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvAlt;
        private System.Windows.Forms.TextBox txtboxAltid;
        private System.Windows.Forms.TextBox txtboxCID;
        private System.Windows.Forms.TextBox txtboxSID;
        private System.Windows.Forms.TextBox txtboxReason;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.CheckBox chckboxPaid;
        private System.Windows.Forms.Label lblAlterationID;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnInvoice;
    }
}