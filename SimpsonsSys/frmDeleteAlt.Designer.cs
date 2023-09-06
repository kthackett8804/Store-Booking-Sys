
namespace SimpsonsSys
{
    partial class frmDeleteAlt
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
            this.dgvAlt = new System.Windows.Forms.DataGridView();
            this.lblname = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtboxAltid = new System.Windows.Forms.TextBox();
            this.txtboxCID = new System.Windows.Forms.TextBox();
            this.txtboxSID = new System.Windows.Forms.TextBox();
            this.txtboxReason = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.txtboxDate = new System.Windows.Forms.TextBox();
            this.chckboxPaid = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlt
            // 
            this.dgvAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlt.Location = new System.Drawing.Point(34, 165);
            this.dgvAlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlt.Name = "dgvAlt";
            this.dgvAlt.ReadOnly = true;
            this.dgvAlt.RowHeadersWidth = 62;
            this.dgvAlt.Size = new System.Drawing.Size(478, 251);
            this.dgvAlt.TabIndex = 89;
            this.dgvAlt.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(45, 114);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(379, 26);
            this.lblname.TabIndex = 90;
            this.lblname.Text = "Please select a name from below: ";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt.Location = new System.Drawing.Point(44, 31);
            this.lblAlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(272, 33);
            this.lblAlt.TabIndex = 91;
            this.lblAlt.Text = "Alteration Deletion";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1080, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 31);
            this.btnBack.TabIndex = 125;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtboxAltid
            // 
            this.txtboxAltid.Location = new System.Drawing.Point(700, 116);
            this.txtboxAltid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxAltid.Name = "txtboxAltid";
            this.txtboxAltid.Size = new System.Drawing.Size(148, 26);
            this.txtboxAltid.TabIndex = 126;
            this.txtboxAltid.Visible = false;
            // 
            // txtboxCID
            // 
            this.txtboxCID.Location = new System.Drawing.Point(700, 152);
            this.txtboxCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCID.Name = "txtboxCID";
            this.txtboxCID.Size = new System.Drawing.Size(148, 26);
            this.txtboxCID.TabIndex = 127;
            this.txtboxCID.Visible = false;
            // 
            // txtboxSID
            // 
            this.txtboxSID.Location = new System.Drawing.Point(700, 197);
            this.txtboxSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSID.Name = "txtboxSID";
            this.txtboxSID.Size = new System.Drawing.Size(148, 26);
            this.txtboxSID.TabIndex = 128;
            this.txtboxSID.Visible = false;
            // 
            // txtboxReason
            // 
            this.txtboxReason.Location = new System.Drawing.Point(700, 249);
            this.txtboxReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxReason.Name = "txtboxReason";
            this.txtboxReason.Size = new System.Drawing.Size(148, 26);
            this.txtboxReason.TabIndex = 129;
            this.txtboxReason.Visible = false;
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(700, 285);
            this.txtboxCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(148, 26);
            this.txtboxCost.TabIndex = 130;
            this.txtboxCost.Visible = false;
            // 
            // txtboxDate
            // 
            this.txtboxDate.Location = new System.Drawing.Point(700, 341);
            this.txtboxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxDate.Name = "txtboxDate";
            this.txtboxDate.Size = new System.Drawing.Size(148, 26);
            this.txtboxDate.TabIndex = 131;
            this.txtboxDate.Visible = false;
            // 
            // chckboxPaid
            // 
            this.chckboxPaid.AutoSize = true;
            this.chckboxPaid.Location = new System.Drawing.Point(700, 404);
            this.chckboxPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckboxPaid.Name = "chckboxPaid";
            this.chckboxPaid.Size = new System.Drawing.Size(87, 24);
            this.chckboxPaid.TabIndex = 132;
            this.chckboxPaid.Text = "Yes/No";
            this.chckboxPaid.UseVisualStyleBackColor = true;
            this.chckboxPaid.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(34, 543);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(230, 78);
            this.btnDelete.TabIndex = 133;
            this.btnDelete.Text = "Delete Form";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chckboxPaid);
            this.Controls.Add(this.txtboxDate);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.txtboxReason);
            this.Controls.Add(this.txtboxSID);
            this.Controls.Add(this.txtboxCID);
            this.Controls.Add(this.txtboxAltid);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.dgvAlt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDeleteAlt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteAlt";
            this.Load += new System.EventHandler(this.frmDeleteAlt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlt;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtboxAltid;
        private System.Windows.Forms.TextBox txtboxCID;
        private System.Windows.Forms.TextBox txtboxSID;
        private System.Windows.Forms.TextBox txtboxReason;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.TextBox txtboxDate;
        private System.Windows.Forms.CheckBox chckboxPaid;
        private System.Windows.Forms.Button btnDelete;
    }
}