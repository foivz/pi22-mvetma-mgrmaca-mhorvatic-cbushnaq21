namespace GymForms
{
    partial class FrmTrainingManagment
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
            this.lblTrainingTypes = new System.Windows.Forms.Label();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.btnGroupTraining = new System.Windows.Forms.Button();
            this.btnTrainingMamagmentReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrainingTypes
            // 
            this.lblTrainingTypes.AutoSize = true;
            this.lblTrainingTypes.Location = new System.Drawing.Point(107, 48);
            this.lblTrainingTypes.Name = "lblTrainingTypes";
            this.lblTrainingTypes.Size = new System.Drawing.Size(76, 13);
            this.lblTrainingTypes.TabIndex = 0;
            this.lblTrainingTypes.Text = "Training types:";
            // 
            // btnIndividual
            // 
            this.btnIndividual.Location = new System.Drawing.Point(110, 82);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.Size = new System.Drawing.Size(144, 46);
            this.btnIndividual.TabIndex = 1;
            this.btnIndividual.Text = "Individual";
            this.btnIndividual.UseVisualStyleBackColor = true;
            // 
            // btnGroupTraining
            // 
            this.btnGroupTraining.Location = new System.Drawing.Point(282, 82);
            this.btnGroupTraining.Name = "btnGroupTraining";
            this.btnGroupTraining.Size = new System.Drawing.Size(144, 46);
            this.btnGroupTraining.TabIndex = 2;
            this.btnGroupTraining.Text = "Group training";
            this.btnGroupTraining.UseVisualStyleBackColor = true;
            // 
            // btnTrainingMamagmentReturn
            // 
            this.btnTrainingMamagmentReturn.Location = new System.Drawing.Point(166, 162);
            this.btnTrainingMamagmentReturn.Name = "btnTrainingMamagmentReturn";
            this.btnTrainingMamagmentReturn.Size = new System.Drawing.Size(206, 27);
            this.btnTrainingMamagmentReturn.TabIndex = 3;
            this.btnTrainingMamagmentReturn.Text = "Return";
            this.btnTrainingMamagmentReturn.UseVisualStyleBackColor = true;
            // 
            // FrmTrainingManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 262);
            this.Controls.Add(this.btnTrainingMamagmentReturn);
            this.Controls.Add(this.btnGroupTraining);
            this.Controls.Add(this.btnIndividual);
            this.Controls.Add(this.lblTrainingTypes);
            this.Name = "FrmTrainingManagment";
            this.Text = "FrmTrainingManagment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrainingTypes;
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Button btnGroupTraining;
        private System.Windows.Forms.Button btnTrainingMamagmentReturn;
    }
}