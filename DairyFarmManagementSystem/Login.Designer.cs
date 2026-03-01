namespace DairyFarmManagementSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLoginFrame = new System.Windows.Forms.Panel();
            this.lblSoftwareNameShort = new System.Windows.Forms.Label();
            this.picBoxFarmerCow = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picBoxLoginback = new System.Windows.Forms.PictureBox();
            this.cmbBoxRole = new System.Windows.Forms.ComboBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFarmerCow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoginback)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginFrame
            // 
            this.panelLoginFrame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLoginFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginFrame.ForeColor = System.Drawing.Color.White;
            this.panelLoginFrame.Location = new System.Drawing.Point(20, 60);
            this.panelLoginFrame.Name = "panelLoginFrame";
            this.panelLoginFrame.Size = new System.Drawing.Size(228, 370);
            this.panelLoginFrame.TabIndex = 0;
            // 
            // lblSoftwareNameShort
            // 
            this.lblSoftwareNameShort.AutoSize = true;
            this.lblSoftwareNameShort.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareNameShort.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoftwareNameShort.Location = new System.Drawing.Point(434, 9);
            this.lblSoftwareNameShort.Name = "lblSoftwareNameShort";
            this.lblSoftwareNameShort.Size = new System.Drawing.Size(127, 38);
            this.lblSoftwareNameShort.TabIndex = 2;
            this.lblSoftwareNameShort.Text = "D F M S";
            // 
            // picBoxFarmerCow
            // 
            this.picBoxFarmerCow.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFarmerCow.Image")));
            this.picBoxFarmerCow.Location = new System.Drawing.Point(451, 50);
            this.picBoxFarmerCow.Name = "picBoxFarmerCow";
            this.picBoxFarmerCow.Size = new System.Drawing.Size(92, 83);
            this.picBoxFarmerCow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFarmerCow.TabIndex = 3;
            this.picBoxFarmerCow.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(297, 251);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(303, 300);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 19);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(432, 253);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(432, 302);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // picBoxLoginback
            // 
            this.picBoxLoginback.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLoginback.Image")));
            this.picBoxLoginback.Location = new System.Drawing.Point(393, 139);
            this.picBoxLoginback.Name = "picBoxLoginback";
            this.picBoxLoginback.Size = new System.Drawing.Size(218, 221);
            this.picBoxLoginback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLoginback.TabIndex = 9;
            this.picBoxLoginback.TabStop = false;
            // 
            // cmbBoxRole
            // 
            this.cmbBoxRole.FormattingEnabled = true;
            this.cmbBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmbBoxRole.Location = new System.Drawing.Point(440, 226);
            this.cmbBoxRole.Name = "cmbBoxRole";
            this.cmbBoxRole.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxRole.TabIndex = 10;
            this.cmbBoxRole.Text = "Select Role";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(440, 366);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 46);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbBoxRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picBoxFarmerCow);
            this.Controls.Add(this.lblSoftwareNameShort);
            this.Controls.Add(this.panelLoginFrame);
            this.Controls.Add(this.picBoxLoginback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFarmerCow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoginback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginFrame;
        private System.Windows.Forms.Label lblSoftwareNameShort;
        private System.Windows.Forms.PictureBox picBoxFarmerCow;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picBoxLoginback;
        private System.Windows.Forms.ComboBox cmbBoxRole;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}