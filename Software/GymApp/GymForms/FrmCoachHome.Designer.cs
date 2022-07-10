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
            this.SuspendLayout();
            // 
            // buttonCoachProfile
            // 
            this.buttonCoachProfile.Location = new System.Drawing.Point(321, 100);
            this.buttonCoachProfile.Name = "buttonCoachProfile";
            this.buttonCoachProfile.Size = new System.Drawing.Size(105, 37);
            this.buttonCoachProfile.TabIndex = 0;
            this.buttonCoachProfile.Text = "Coach profile";
            this.buttonCoachProfile.UseVisualStyleBackColor = true;
            this.buttonCoachProfile.Click += new System.EventHandler(this.buttonCoachProfile_Click);
            // 
            // FrmCoachHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCoachProfile);
            this.Name = "FrmCoachHome";
            this.Text = "FrmCoachHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCoachProfile;
    }
}