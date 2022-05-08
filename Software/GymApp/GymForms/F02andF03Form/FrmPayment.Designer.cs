namespace GymForms.F02andF03Form
{
    partial class FrmPayment
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblValidThru = new System.Windows.Forms.Label();
            this.lblCCV = new System.Windows.Forms.Label();
            this.txtCCVnumber = new System.Windows.Forms.TextBox();
            this.txtValidThru = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnReturnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(130, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(130, 160);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(130, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail adress:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(130, 280);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(105, 20);
            this.lblCardNumber.TabIndex = 3;
            this.lblCardNumber.Text = "Card number:";
            // 
            // lblValidThru
            // 
            this.lblValidThru.AutoSize = true;
            this.lblValidThru.Location = new System.Drawing.Point(130, 340);
            this.lblValidThru.Name = "lblValidThru";
            this.lblValidThru.Size = new System.Drawing.Size(80, 20);
            this.lblValidThru.TabIndex = 4;
            this.lblValidThru.Text = "Valid thru:";
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.Location = new System.Drawing.Point(130, 400);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(104, 20);
            this.lblCCV.TabIndex = 5;
            this.lblCCV.Text = "CCV number:";
            // 
            // txtCCVnumber
            // 
            this.txtCCVnumber.Location = new System.Drawing.Point(257, 400);
            this.txtCCVnumber.Name = "txtCCVnumber";
            this.txtCCVnumber.Size = new System.Drawing.Size(206, 26);
            this.txtCCVnumber.TabIndex = 6;
            // 
            // txtValidThru
            // 
            this.txtValidThru.Location = new System.Drawing.Point(257, 340);
            this.txtValidThru.Name = "txtValidThru";
            this.txtValidThru.Size = new System.Drawing.Size(206, 26);
            this.txtValidThru.TabIndex = 7;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(257, 280);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(206, 26);
            this.txtCardNumber.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(257, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 26);
            this.txtName.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(257, 160);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(206, 26);
            this.txtSurname.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(257, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(130, 500);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 40);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnReturnPay
            // 
            this.btnReturnPay.Location = new System.Drawing.Point(313, 500);
            this.btnReturnPay.Name = "btnReturnPay";
            this.btnReturnPay.Size = new System.Drawing.Size(150, 40);
            this.btnReturnPay.TabIndex = 13;
            this.btnReturnPay.Text = "Return";
            this.btnReturnPay.UseVisualStyleBackColor = true;
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 727);
            this.Controls.Add(this.btnReturnPay);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtValidThru);
            this.Controls.Add(this.txtCCVnumber);
            this.Controls.Add(this.lblCCV);
            this.Controls.Add(this.lblValidThru);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "FrmPayment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblValidThru;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.TextBox txtCCVnumber;
        private System.Windows.Forms.TextBox txtValidThru;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnReturnPay;
    }
}