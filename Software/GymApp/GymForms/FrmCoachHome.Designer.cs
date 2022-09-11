namespace GymForms
{
    partial class FrmCoachHome
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
            this.buttonCoachProfile = new System.Windows.Forms.Button();
            this.btnCoachRequests = new System.Windows.Forms.Button();
            this.btnCoachSchedule = new System.Windows.Forms.Button();
            this.btnCoachLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCoachProfile
            // 
            this.buttonCoachProfile.Location = new System.Drawing.Point(320, 100);
            this.buttonCoachProfile.Name = "buttonCoachProfile";
            this.buttonCoachProfile.Size = new System.Drawing.Size(140, 40);
            this.buttonCoachProfile.TabIndex = 0;
            this.buttonCoachProfile.Text = "Coach profile";
            this.buttonCoachProfile.UseVisualStyleBackColor = true;
            this.buttonCoachProfile.Click += new System.EventHandler(this.buttonCoachProfile_Click);
            // 
            // btnCoachRequests
            // 
            this.btnCoachRequests.Location = new System.Drawing.Point(320, 182);
            this.btnCoachRequests.Name = "btnCoachRequests";
            this.btnCoachRequests.Size = new System.Drawing.Size(140, 40);
            this.btnCoachRequests.TabIndex = 1;
            this.btnCoachRequests.Text = "Requests";
            this.btnCoachRequests.UseVisualStyleBackColor = true;
            // 
            // btnCoachSchedule
            // 
            this.btnCoachSchedule.Location = new System.Drawing.Point(320, 263);
            this.btnCoachSchedule.Name = "btnCoachSchedule";
            this.btnCoachSchedule.Size = new System.Drawing.Size(140, 40);
            this.btnCoachSchedule.TabIndex = 2;
            this.btnCoachSchedule.Text = "Schedule";
            this.btnCoachSchedule.UseVisualStyleBackColor = true;
            // 
            // btnCoachLogout
            // 
            this.btnCoachLogout.Location = new System.Drawing.Point(348, 361);
            this.btnCoachLogout.Name = "btnCoachLogout";
            this.btnCoachLogout.Size = new System.Drawing.Size(85, 40);
            this.btnCoachLogout.TabIndex = 3;
            this.btnCoachLogout.Text = "Logout";
            this.btnCoachLogout.UseVisualStyleBackColor = true;
            this.btnCoachLogout.Click += new System.EventHandler(this.btnCoachLogout_Click);
            // 
            // FrmCoachHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCoachLogout);
            this.Controls.Add(this.btnCoachSchedule);
            this.Controls.Add(this.btnCoachRequests);
            this.Controls.Add(this.buttonCoachProfile);
            this.Name = "FrmCoachHome";
            this.Text = "FrmCoachHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCoachProfile;
        private System.Windows.Forms.Button btnCoachRequests;
        private System.Windows.Forms.Button btnCoachSchedule;
        private System.Windows.Forms.Button btnCoachLogout;
    }
}