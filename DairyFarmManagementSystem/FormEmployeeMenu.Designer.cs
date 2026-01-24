namespace DairyFarmManagementSystem
{
    partial class FormEmployeeMenu
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
            this.panelLoginFrame = new System.Windows.Forms.Panel();
            this.panelEmpMenuTOP = new System.Windows.Forms.Panel();
            this.lblSoftwareNameShort = new System.Windows.Forms.Label();
            this.panelEmpMenuTOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoginFrame
            // 
            this.panelLoginFrame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLoginFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginFrame.ForeColor = System.Drawing.Color.White;
            this.panelLoginFrame.Location = new System.Drawing.Point(0, 0);
            this.panelLoginFrame.Name = "panelLoginFrame";
            this.panelLoginFrame.Size = new System.Drawing.Size(228, 450);
            this.panelLoginFrame.TabIndex = 1;
            // 
            // panelEmpMenuTOP
            // 
            this.panelEmpMenuTOP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelEmpMenuTOP.Controls.Add(this.lblSoftwareNameShort);
            this.panelEmpMenuTOP.ForeColor = System.Drawing.SystemColors.Control;
            this.panelEmpMenuTOP.Location = new System.Drawing.Point(228, 0);
            this.panelEmpMenuTOP.Name = "panelEmpMenuTOP";
            this.panelEmpMenuTOP.Size = new System.Drawing.Size(572, 36);
            this.panelEmpMenuTOP.TabIndex = 2;
            // 
            // lblSoftwareNameShort
            // 
            this.lblSoftwareNameShort.AutoSize = true;
            this.lblSoftwareNameShort.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareNameShort.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoftwareNameShort.Location = new System.Drawing.Point(221, 0);
            this.lblSoftwareNameShort.Name = "lblSoftwareNameShort";
            this.lblSoftwareNameShort.Size = new System.Drawing.Size(108, 32);
            this.lblSoftwareNameShort.TabIndex = 3;
            this.lblSoftwareNameShort.Text = "D F M S";
            // 
            // FormEmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEmpMenuTOP);
            this.Controls.Add(this.panelLoginFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeMenu";
            this.panelEmpMenuTOP.ResumeLayout(false);
            this.panelEmpMenuTOP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginFrame;
        private System.Windows.Forms.Panel panelEmpMenuTOP;
        private System.Windows.Forms.Label lblSoftwareNameShort;
    }
}