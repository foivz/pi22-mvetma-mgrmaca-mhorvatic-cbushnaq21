namespace GymForms
{
    partial class FrmUserHome
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
            this.buttonMembershipFee = new System.Windows.Forms.Button();
            this.buttonOdabirPlana = new System.Windows.Forms.Button();
            this.buttonOdabirTermina = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMembershipFee
            // 
            this.buttonMembershipFee.Location = new System.Drawing.Point(188, 54);
            this.buttonMembershipFee.Name = "buttonMembershipFee";
            this.buttonMembershipFee.Size = new System.Drawing.Size(200, 34);
            this.buttonMembershipFee.TabIndex = 0;
            this.buttonMembershipFee.Text = "Membership fee";
            this.buttonMembershipFee.UseVisualStyleBackColor = true;
            this.buttonMembershipFee.Click += new System.EventHandler(this.buttonMembershipFee_Click);
            // 
            // buttonOdabirPlana
            // 
            this.buttonOdabirPlana.Location = new System.Drawing.Point(188, 141);
            this.buttonOdabirPlana.Name = "buttonOdabirPlana";
            this.buttonOdabirPlana.Size = new System.Drawing.Size(200, 33);
            this.buttonOdabirPlana.TabIndex = 1;
            this.buttonOdabirPlana.Text = "Majin feature";
            this.buttonOdabirPlana.UseVisualStyleBackColor = true;
            // 
            // buttonOdabirTermina
            // 
            this.buttonOdabirTermina.Location = new System.Drawing.Point(188, 208);
            this.buttonOdabirTermina.Name = "buttonOdabirTermina";
            this.buttonOdabirTermina.Size = new System.Drawing.Size(200, 33);
            this.buttonOdabirTermina.TabIndex = 2;
            this.buttonOdabirTermina.Text = "Majin feature 2";
            this.buttonOdabirTermina.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(340, 386);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 31);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FrmUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonOdabirTermina);
            this.Controls.Add(this.buttonOdabirPlana);
            this.Controls.Add(this.buttonMembershipFee);
            this.Name = "FrmUserHome";
            this.Text = "FrmUserHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMembershipFee;
        private System.Windows.Forms.Button buttonOdabirPlana;
        private System.Windows.Forms.Button buttonOdabirTermina;
        private System.Windows.Forms.Button buttonLogout;
    }
}