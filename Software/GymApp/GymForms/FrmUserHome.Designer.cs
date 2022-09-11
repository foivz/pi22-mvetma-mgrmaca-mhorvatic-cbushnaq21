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
            this.btnSelectTrainPLan = new System.Windows.Forms.Button();
            this.btnUserSchedule = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMembershipFee
            // 
            this.buttonMembershipFee.Location = new System.Drawing.Point(291, 56);
            this.buttonMembershipFee.Name = "buttonMembershipFee";
            this.buttonMembershipFee.Size = new System.Drawing.Size(150, 40);
            this.buttonMembershipFee.TabIndex = 0;
            this.buttonMembershipFee.Text = "Membership fee";
            this.buttonMembershipFee.UseVisualStyleBackColor = true;
            this.buttonMembershipFee.Click += new System.EventHandler(this.buttonMembershipFee_Click);
            // 
            // btnSelectTrainPLan
            // 
            this.btnSelectTrainPLan.Location = new System.Drawing.Point(291, 141);
            this.btnSelectTrainPLan.Name = "btnSelectTrainPLan";
            this.btnSelectTrainPLan.Size = new System.Drawing.Size(150, 40);
            this.btnSelectTrainPLan.TabIndex = 1;
            this.btnSelectTrainPLan.Text = "Training plan";
            this.btnSelectTrainPLan.UseVisualStyleBackColor = true;
            // 
            // btnUserSchedule
            // 
            this.btnUserSchedule.Location = new System.Drawing.Point(291, 228);
            this.btnUserSchedule.Name = "btnUserSchedule";
            this.btnUserSchedule.Size = new System.Drawing.Size(150, 40);
            this.btnUserSchedule.TabIndex = 2;
            this.btnUserSchedule.Text = "Schedule";
            this.btnUserSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(326, 340);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(85, 40);
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
            this.Controls.Add(this.btnUserSchedule);
            this.Controls.Add(this.btnSelectTrainPLan);
            this.Controls.Add(this.buttonMembershipFee);
            this.Name = "FrmUserHome";
            this.Text = "FrmUserHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMembershipFee;
        private System.Windows.Forms.Button btnSelectTrainPLan;
        private System.Windows.Forms.Button btnUserSchedule;
        private System.Windows.Forms.Button buttonLogout;
    }
}