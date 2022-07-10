namespace GymForms.F08CoachProfilesForms
{
    partial class FrmCoachProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.txtCoachSurname = new System.Windows.Forms.TextBox();
            this.txtCoachEducation = new System.Windows.Forms.TextBox();
            this.txtCoachNumber = new System.Windows.Forms.TextBox();
            this.txtCoachEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Education:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "e-mail adress:";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(130, 420);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(150, 40);
            this.btnEditProfile.TabIndex = 5;
            this.btnEditProfile.Text = "Edit profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(310, 420);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 40);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(257, 100);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(207, 26);
            this.txtCoachName.TabIndex = 7;
            // 
            // txtCoachSurname
            // 
            this.txtCoachSurname.Location = new System.Drawing.Point(257, 160);
            this.txtCoachSurname.Name = "txtCoachSurname";
            this.txtCoachSurname.Size = new System.Drawing.Size(207, 26);
            this.txtCoachSurname.TabIndex = 8;
            // 
            // txtCoachEducation
            // 
            this.txtCoachEducation.Location = new System.Drawing.Point(257, 220);
            this.txtCoachEducation.Name = "txtCoachEducation";
            this.txtCoachEducation.Size = new System.Drawing.Size(207, 26);
            this.txtCoachEducation.TabIndex = 9;
            // 
            // txtCoachNumber
            // 
            this.txtCoachNumber.Location = new System.Drawing.Point(257, 280);
            this.txtCoachNumber.Name = "txtCoachNumber";
            this.txtCoachNumber.Size = new System.Drawing.Size(207, 26);
            this.txtCoachNumber.TabIndex = 10;
            // 
            // txtCoachEmail
            // 
            this.txtCoachEmail.Location = new System.Drawing.Point(257, 340);
            this.txtCoachEmail.Name = "txtCoachEmail";
            this.txtCoachEmail.Size = new System.Drawing.Size(207, 26);
            this.txtCoachEmail.TabIndex = 11;
            // 
            // FrmCoachProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 643);
            this.Controls.Add(this.txtCoachEmail);
            this.Controls.Add(this.txtCoachNumber);
            this.Controls.Add(this.txtCoachEducation);
            this.Controls.Add(this.txtCoachSurname);
            this.Controls.Add(this.txtCoachName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCoachProfile";
            this.Text = "Coach profile";
            this.Load += new System.EventHandler(this.FrmCoachProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.TextBox txtCoachSurname;
        private System.Windows.Forms.TextBox txtCoachEducation;
        private System.Windows.Forms.TextBox txtCoachNumber;
        private System.Windows.Forms.TextBox txtCoachEmail;
    }
}