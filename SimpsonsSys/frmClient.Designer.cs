
namespace SimpsonsSys
{
    partial class frmClient
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
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxPostcode = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.txtboxTown = new System.Windows.Forms.TextBox();
            this.txtboxStreet = new System.Windows.Forms.TextBox();
            this.txtboxHouse = new System.Windows.Forms.TextBox();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.txtboxFname = new System.Windows.Forms.TextBox();
            this.txtboxCID = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblHousenum = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Location = new System.Drawing.Point(228, 545);
            this.txtboxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(148, 26);
            this.txtboxPhone.TabIndex = 33;
            // 
            // txtboxPostcode
            // 
            this.txtboxPostcode.Location = new System.Drawing.Point(228, 477);
            this.txtboxPostcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPostcode.Name = "txtboxPostcode";
            this.txtboxPostcode.Size = new System.Drawing.Size(148, 26);
            this.txtboxPostcode.TabIndex = 32;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhoneNum.Location = new System.Drawing.Point(30, 542);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(188, 29);
            this.lblPhoneNum.TabIndex = 31;
            this.lblPhoneNum.Text = "Phone Number: ";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPostcode.Location = new System.Drawing.Point(34, 474);
            this.lblPostcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(127, 29);
            this.lblPostcode.TabIndex = 30;
            this.lblPostcode.Text = "Postcode: ";
            // 
            // dgvClient
            // 
            this.dgvClient.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClient.Location = new System.Drawing.Point(432, 111);
            this.dgvClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersWidth = 62;
            this.dgvClient.Size = new System.Drawing.Size(687, 403);
            this.dgvClient.TabIndex = 29;
            this.dgvClient.SelectionChanged += new System.EventHandler(this.dgvClient_SelectionChanged);
            // 
            // txtboxTown
            // 
            this.txtboxTown.Location = new System.Drawing.Point(228, 418);
            this.txtboxTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxTown.Name = "txtboxTown";
            this.txtboxTown.Size = new System.Drawing.Size(148, 26);
            this.txtboxTown.TabIndex = 28;
            // 
            // txtboxStreet
            // 
            this.txtboxStreet.Location = new System.Drawing.Point(228, 358);
            this.txtboxStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxStreet.Name = "txtboxStreet";
            this.txtboxStreet.Size = new System.Drawing.Size(148, 26);
            this.txtboxStreet.TabIndex = 27;
            // 
            // txtboxHouse
            // 
            this.txtboxHouse.Location = new System.Drawing.Point(228, 292);
            this.txtboxHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxHouse.Name = "txtboxHouse";
            this.txtboxHouse.Size = new System.Drawing.Size(148, 26);
            this.txtboxHouse.TabIndex = 26;
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(228, 231);
            this.txtboxSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(148, 26);
            this.txtboxSurname.TabIndex = 25;
            // 
            // txtboxFname
            // 
            this.txtboxFname.Location = new System.Drawing.Point(228, 168);
            this.txtboxFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFname.Name = "txtboxFname";
            this.txtboxFname.Size = new System.Drawing.Size(148, 26);
            this.txtboxFname.TabIndex = 24;
            // 
            // txtboxCID
            // 
            this.txtboxCID.Enabled = false;
            this.txtboxCID.Location = new System.Drawing.Point(228, 111);
            this.txtboxCID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxCID.Name = "txtboxCID";
            this.txtboxCID.Size = new System.Drawing.Size(148, 26);
            this.txtboxCID.TabIndex = 23;
            this.txtboxCID.TextChanged += new System.EventHandler(this.txtboxCID_TextChanged);
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTown.Location = new System.Drawing.Point(30, 415);
            this.lblTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(86, 29);
            this.lblTown.TabIndex = 22;
            this.lblTown.Text = "Town: ";
            this.lblTown.Click += new System.EventHandler(this.lblTown_Click);
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStreetName.Location = new System.Drawing.Point(34, 355);
            this.lblStreetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(155, 29);
            this.lblStreetName.TabIndex = 21;
            this.lblStreetName.Text = "Street name: ";
            // 
            // lblHousenum
            // 
            this.lblHousenum.AutoSize = true;
            this.lblHousenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHousenum.Location = new System.Drawing.Point(34, 289);
            this.lblHousenum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHousenum.Name = "lblHousenum";
            this.lblHousenum.Size = new System.Drawing.Size(183, 29);
            this.lblHousenum.TabIndex = 20;
            this.lblHousenum.Text = "House number: ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurname.Location = new System.Drawing.Point(39, 228);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(116, 29);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFname.Location = new System.Drawing.Point(39, 165);
            this.lblFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(143, 29);
            this.lblFname.TabIndex = 18;
            this.lblFname.Text = "First Name: ";
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCID.Location = new System.Drawing.Point(39, 108);
            this.lblCID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(116, 29);
            this.lblCID.TabIndex = 17;
            this.lblCID.Text = "Client ID: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(462, 545);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 82);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.PowderBlue;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.Black;
            this.lblClient.Location = new System.Drawing.Point(44, 31);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(221, 33);
            this.lblClient.TabIndex = 35;
            this.lblClient.Text = "Client Records";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(620, 545);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 82);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(759, 545);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 82);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1017, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 31);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.txtboxPostcode);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.txtboxTown);
            this.Controls.Add(this.txtboxStreet);
            this.Controls.Add(this.txtboxHouse);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.txtboxFname);
            this.Controls.Add(this.txtboxCID);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.lblHousenum);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblCID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtboxPostcode;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.TextBox txtboxTown;
        private System.Windows.Forms.TextBox txtboxStreet;
        private System.Windows.Forms.TextBox txtboxHouse;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.TextBox txtboxFname;
        private System.Windows.Forms.TextBox txtboxCID;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblHousenum;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}