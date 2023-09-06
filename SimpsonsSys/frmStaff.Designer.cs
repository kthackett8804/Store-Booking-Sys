
namespace SimpsonsSys
{
    partial class frmStaff
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.txtboxUser = new System.Windows.Forms.TextBox();
            this.txtboxSSurname = new System.Windows.Forms.TextBox();
            this.txtboxSFname = new System.Windows.Forms.TextBox();
            this.txtboxSID = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblsSurname = new System.Windows.Forms.Label();
            this.lblSFname = new System.Windows.Forms.Label();
            this.lblSD = new System.Windows.Forms.Label();
            this.chckBoxAdmin = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(784, 563);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 82);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(645, 563);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 82);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.BackColor = System.Drawing.Color.PowderBlue;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.Black;
            this.lblStaff.Location = new System.Drawing.Point(42, 35);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(204, 33);
            this.lblStaff.TabIndex = 56;
            this.lblStaff.Text = "Staff Records";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(488, 563);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 82);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(458, 131);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersWidth = 62;
            this.dgvStaff.Size = new System.Drawing.Size(687, 403);
            this.dgvStaff.TabIndex = 50;
            this.dgvStaff.SelectionChanged += new System.EventHandler(this.dgvClient_SelectionChanged);
            // 
            // txtboxPass
            // 
            this.txtboxPass.Location = new System.Drawing.Point(210, 395);
            this.txtboxPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(148, 26);
            this.txtboxPass.TabIndex = 49;
            // 
            // txtboxUser
            // 
            this.txtboxUser.Location = new System.Drawing.Point(210, 337);
            this.txtboxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxUser.Name = "txtboxUser";
            this.txtboxUser.Size = new System.Drawing.Size(148, 26);
            this.txtboxUser.TabIndex = 48;
            // 
            // txtboxSSurname
            // 
            this.txtboxSSurname.Location = new System.Drawing.Point(210, 225);
            this.txtboxSSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSSurname.Name = "txtboxSSurname";
            this.txtboxSSurname.Size = new System.Drawing.Size(148, 26);
            this.txtboxSSurname.TabIndex = 46;
            // 
            // txtboxSFname
            // 
            this.txtboxSFname.Location = new System.Drawing.Point(210, 162);
            this.txtboxSFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSFname.Name = "txtboxSFname";
            this.txtboxSFname.Size = new System.Drawing.Size(148, 26);
            this.txtboxSFname.TabIndex = 45;
            // 
            // txtboxSID
            // 
            this.txtboxSID.Enabled = false;
            this.txtboxSID.Location = new System.Drawing.Point(210, 105);
            this.txtboxSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSID.Name = "txtboxSID";
            this.txtboxSID.Size = new System.Drawing.Size(148, 26);
            this.txtboxSID.TabIndex = 44;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPass.Location = new System.Drawing.Point(40, 392);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 29);
            this.lblPass.TabIndex = 43;
            this.lblPass.Text = "Pass: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUser.Location = new System.Drawing.Point(42, 334);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 29);
            this.lblUser.TabIndex = 42;
            this.lblUser.Text = "User: ";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdmin.Location = new System.Drawing.Point(44, 283);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(93, 29);
            this.lblAdmin.TabIndex = 41;
            this.lblAdmin.Text = "Admin: ";
            // 
            // lblsSurname
            // 
            this.lblsSurname.AutoSize = true;
            this.lblsSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblsSurname.Location = new System.Drawing.Point(42, 222);
            this.lblsSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsSurname.Name = "lblsSurname";
            this.lblsSurname.Size = new System.Drawing.Size(116, 29);
            this.lblsSurname.TabIndex = 40;
            this.lblsSurname.Text = "Surname:";
            // 
            // lblSFname
            // 
            this.lblSFname.AutoSize = true;
            this.lblSFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSFname.Location = new System.Drawing.Point(42, 158);
            this.lblSFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSFname.Name = "lblSFname";
            this.lblSFname.Size = new System.Drawing.Size(143, 29);
            this.lblSFname.TabIndex = 39;
            this.lblSFname.Text = "First Name: ";
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSD.Location = new System.Drawing.Point(44, 102);
            this.lblSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(101, 29);
            this.lblSD.TabIndex = 38;
            this.lblSD.Text = "Staff ID: ";
            // 
            // chckBoxAdmin
            // 
            this.chckBoxAdmin.AutoSize = true;
            this.chckBoxAdmin.Location = new System.Drawing.Point(254, 292);
            this.chckBoxAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chckBoxAdmin.Name = "chckBoxAdmin";
            this.chckBoxAdmin.Size = new System.Drawing.Size(22, 21);
            this.chckBoxAdmin.TabIndex = 59;
            this.chckBoxAdmin.UseVisualStyleBackColor = true;
            this.chckBoxAdmin.CheckedChanged += new System.EventHandler(this.chckBoxAdmin_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1011, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 31);
            this.btnBack.TabIndex = 79;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chckBoxAdmin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.txtboxUser);
            this.Controls.Add(this.txtboxSSurname);
            this.Controls.Add(this.txtboxSFname);
            this.Controls.Add(this.txtboxSID);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblsSurname);
            this.Controls.Add(this.lblSFname);
            this.Controls.Add(this.lblSD);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.TextBox txtboxUser;
        private System.Windows.Forms.TextBox txtboxSSurname;
        private System.Windows.Forms.TextBox txtboxSFname;
        private System.Windows.Forms.TextBox txtboxSID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblsSurname;
        private System.Windows.Forms.Label lblSFname;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.CheckBox chckBoxAdmin;
        private System.Windows.Forms.Button btnBack;
    }
}

