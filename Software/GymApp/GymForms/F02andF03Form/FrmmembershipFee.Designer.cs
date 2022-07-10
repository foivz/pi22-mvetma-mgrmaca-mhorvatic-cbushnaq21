namespace GymForms.F02andF03Form
{
    partial class FrmMembershipFee
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
            this.dgvUnpaidBills = new System.Windows.Forms.DataGridView();
            this.dgvPaidBills = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPaySelectedBill = new System.Windows.Forms.Button();
            this.btnReturnMembershipFee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaidBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnpaidBills
            // 
            this.dgvUnpaidBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnpaidBills.Location = new System.Drawing.Point(57, 52);
            this.dgvUnpaidBills.Name = "dgvUnpaidBills";
            this.dgvUnpaidBills.RowHeadersWidth = 62;
            this.dgvUnpaidBills.RowTemplate.Height = 28;
            this.dgvUnpaidBills.Size = new System.Drawing.Size(904, 235);
            this.dgvUnpaidBills.TabIndex = 0;
            // 
            // dgvPaidBills
            // 
            this.dgvPaidBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaidBills.Location = new System.Drawing.Point(61, 430);
            this.dgvPaidBills.Name = "dgvPaidBills";
            this.dgvPaidBills.RowHeadersWidth = 62;
            this.dgvPaidBills.RowTemplate.Height = 28;
            this.dgvPaidBills.Size = new System.Drawing.Size(904, 235);
            this.dgvPaidBills.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unpaid bills:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paid bills:";
            // 
            // btnPaySelectedBill
            // 
            this.btnPaySelectedBill.Location = new System.Drawing.Point(619, 340);
            this.btnPaySelectedBill.Name = "btnPaySelectedBill";
            this.btnPaySelectedBill.Size = new System.Drawing.Size(150, 40);
            this.btnPaySelectedBill.TabIndex = 4;
            this.btnPaySelectedBill.Text = "Pay selected bill";
            this.btnPaySelectedBill.UseVisualStyleBackColor = true;
            this.btnPaySelectedBill.Click += new System.EventHandler(this.btnPaySelectedBill_Click);
            // 
            // btnReturnMembershipFee
            // 
            this.btnReturnMembershipFee.Location = new System.Drawing.Point(811, 340);
            this.btnReturnMembershipFee.Name = "btnReturnMembershipFee";
            this.btnReturnMembershipFee.Size = new System.Drawing.Size(150, 40);
            this.btnReturnMembershipFee.TabIndex = 5;
            this.btnReturnMembershipFee.Text = "Return";
            this.btnReturnMembershipFee.UseVisualStyleBackColor = true;
            this.btnReturnMembershipFee.Click += new System.EventHandler(this.btnReturnMembershipFee_Click);
            // 
            // FrmmembershipFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 732);
            this.Controls.Add(this.btnReturnMembershipFee);
            this.Controls.Add(this.btnPaySelectedBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPaidBills);
            this.Controls.Add(this.dgvUnpaidBills);
            this.Name = "FrmmembershipFee";
            this.Text = "FrmmembershipFee";
            this.Load += new System.EventHandler(this.FrmmembershipFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaidBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnpaidBills;
        private System.Windows.Forms.DataGridView dgvPaidBills;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaySelectedBill;
        private System.Windows.Forms.Button btnReturnMembershipFee;
    }
}