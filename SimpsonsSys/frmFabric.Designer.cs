
namespace SimpsonsSys
{
    partial class frmFabric
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblfabrics = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvFabric = new System.Windows.Forms.DataGridView();
            this.txtboxQuant = new System.Windows.Forms.TextBox();
            this.txtboxLength = new System.Windows.Forms.TextBox();
            this.txtboxFabric = new System.Windows.Forms.TextBox();
            this.txtboxfabID = new System.Windows.Forms.TextBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblFabric = new System.Windows.Forms.Label();
            this.lblfabID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Snow;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(1018, 42);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 31);
            this.btnBack.TabIndex = 100;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(760, 569);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 82);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(621, 569);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 82);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblfabrics
            // 
            this.lblfabrics.AutoSize = true;
            this.lblfabrics.BackColor = System.Drawing.Color.PowderBlue;
            this.lblfabrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfabrics.ForeColor = System.Drawing.Color.Black;
            this.lblfabrics.Location = new System.Drawing.Point(45, 55);
            this.lblfabrics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfabrics.Name = "lblfabrics";
            this.lblfabrics.Size = new System.Drawing.Size(228, 33);
            this.lblfabrics.TabIndex = 97;
            this.lblfabrics.Text = "Fabric Records";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(463, 569);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 82);
            this.btnUpdate.TabIndex = 96;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvFabric
            // 
            this.dgvFabric.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFabric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabric.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFabric.Location = new System.Drawing.Point(433, 135);
            this.dgvFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFabric.Name = "dgvFabric";
            this.dgvFabric.ReadOnly = true;
            this.dgvFabric.RowHeadersWidth = 62;
            this.dgvFabric.Size = new System.Drawing.Size(687, 403);
            this.dgvFabric.TabIndex = 91;
            this.dgvFabric.SelectionChanged += new System.EventHandler(this.dgvFabric_SelectionChanged);
            // 
            // txtboxQuant
            // 
            this.txtboxQuant.Location = new System.Drawing.Point(229, 316);
            this.txtboxQuant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxQuant.Name = "txtboxQuant";
            this.txtboxQuant.Size = new System.Drawing.Size(148, 26);
            this.txtboxQuant.TabIndex = 88;
            // 
            // txtboxLength
            // 
            this.txtboxLength.Location = new System.Drawing.Point(229, 255);
            this.txtboxLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxLength.Name = "txtboxLength";
            this.txtboxLength.Size = new System.Drawing.Size(148, 26);
            this.txtboxLength.TabIndex = 87;
            // 
            // txtboxFabric
            // 
            this.txtboxFabric.Location = new System.Drawing.Point(229, 192);
            this.txtboxFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFabric.Name = "txtboxFabric";
            this.txtboxFabric.Size = new System.Drawing.Size(148, 26);
            this.txtboxFabric.TabIndex = 86;
            // 
            // txtboxfabID
            // 
            this.txtboxfabID.Enabled = false;
            this.txtboxfabID.Location = new System.Drawing.Point(229, 135);
            this.txtboxfabID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxfabID.Name = "txtboxfabID";
            this.txtboxfabID.Size = new System.Drawing.Size(148, 26);
            this.txtboxfabID.TabIndex = 85;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuant.Location = new System.Drawing.Point(35, 313);
            this.lblQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(112, 29);
            this.lblQuant.TabIndex = 82;
            this.lblQuant.Text = "Quantity: ";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLength.Location = new System.Drawing.Point(40, 252);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(92, 29);
            this.lblLength.TabIndex = 81;
            this.lblLength.Text = "Length:";
            // 
            // lblFabric
            // 
            this.lblFabric.AutoSize = true;
            this.lblFabric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFabric.Location = new System.Drawing.Point(40, 189);
            this.lblFabric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabric.Name = "lblFabric";
            this.lblFabric.Size = new System.Drawing.Size(84, 29);
            this.lblFabric.TabIndex = 80;
            this.lblFabric.Text = "fabric: ";
            // 
            // lblfabID
            // 
            this.lblfabID.AutoSize = true;
            this.lblfabID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfabID.Location = new System.Drawing.Point(40, 132);
            this.lblfabID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfabID.Name = "lblfabID";
            this.lblfabID.Size = new System.Drawing.Size(113, 29);
            this.lblfabID.TabIndex = 79;
            this.lblfabID.Text = "fabric ID: ";
            // 
            // frmFabric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblfabrics);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvFabric);
            this.Controls.Add(this.txtboxQuant);
            this.Controls.Add(this.txtboxLength);
            this.Controls.Add(this.txtboxFabric);
            this.Controls.Add(this.txtboxfabID);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblFabric);
            this.Controls.Add(this.lblfabID);
            this.Name = "frmFabric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFabric";
            this.Load += new System.EventHandler(this.frmFabric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblfabrics;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvFabric;
        private System.Windows.Forms.TextBox txtboxQuant;
        private System.Windows.Forms.TextBox txtboxLength;
        private System.Windows.Forms.TextBox txtboxFabric;
        private System.Windows.Forms.TextBox txtboxfabID;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblFabric;
        private System.Windows.Forms.Label lblfabID;
    }
}