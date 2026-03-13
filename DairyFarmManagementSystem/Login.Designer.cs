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
            this.lblSoftwareNameShort = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picBoxLoginback = new System.Windows.Forms.PictureBox();
            this.cmbBoxRole = new System.Windows.Forms.ComboBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lblRole = new System.Windows.Forms.Label();
            this.picBoxFarmerCow = new System.Windows.Forms.PictureBox();
            this.lblMilkSalesbtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLoginFrame = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoginback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFarmerCow)).BeginInit();
            this.panelLoginFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoftwareNameShort
            // 
            this.lblSoftwareNameShort.AutoSize = true;
            this.lblSoftwareNameShort.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareNameShort.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoftwareNameShort.Location = new System.Drawing.Point(457, 27);
            this.lblSoftwareNameShort.Name = "lblSoftwareNameShort";
            this.lblSoftwareNameShort.Size = new System.Drawing.Size(127, 38);
            this.lblSoftwareNameShort.TabIndex = 2;
            this.lblSoftwareNameShort.Text = "D F M S";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(332, 290);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(338, 333);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 19);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Gray;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(454, 289);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(454, 332);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // picBoxLoginback
            // 
            this.picBoxLoginback.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLoginback.Image")));
            this.picBoxLoginback.Location = new System.Drawing.Point(268, 10);
            this.picBoxLoginback.Name = "picBoxLoginback";
            this.picBoxLoginback.Size = new System.Drawing.Size(534, 420);
            this.picBoxLoginback.TabIndex = 9;
            this.picBoxLoginback.TabStop = false;
            // 
            // cmbBoxRole
            // 
            this.cmbBoxRole.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cmbBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxRole.ForeColor = System.Drawing.Color.Navy;
            this.cmbBoxRole.FormattingEnabled = true;
            this.cmbBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmbBoxRole.Location = new System.Drawing.Point(454, 248);
            this.cmbBoxRole.Name = "cmbBoxRole";
            this.cmbBoxRole.Size = new System.Drawing.Size(142, 21);
            this.cmbBoxRole.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(464, 368);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 30);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(379, 250);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 19);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Role";
            // 
            // picBoxFarmerCow
            // 
            this.picBoxFarmerCow.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFarmerCow.Image")));
            this.picBoxFarmerCow.Location = new System.Drawing.Point(39, 3);
            this.picBoxFarmerCow.Name = "picBoxFarmerCow";
            this.picBoxFarmerCow.Size = new System.Drawing.Size(126, 106);
            this.picBoxFarmerCow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFarmerCow.TabIndex = 3;
            this.picBoxFarmerCow.TabStop = false;
            // 
            // lblMilkSalesbtn
            // 
            this.lblMilkSalesbtn.AutoSize = true;
            this.lblMilkSalesbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMilkSalesbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilkSalesbtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMilkSalesbtn.Location = new System.Drawing.Point(18, 128);
            this.lblMilkSalesbtn.Name = "lblMilkSalesbtn";
            this.lblMilkSalesbtn.Size = new System.Drawing.Size(197, 24);
            this.lblMilkSalesbtn.TabIndex = 8;
            this.lblMilkSalesbtn.Text = "Kasun Dairy Farm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pansala Godalla, \r\n   Angulugaha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "📞 074 179 0421";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(41, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "🌿 Smart Dairy Farm \r\nManagement System";
            // 
            // panelLoginFrame
            // 
            this.panelLoginFrame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLoginFrame.Controls.Add(this.label3);
            this.panelLoginFrame.Controls.Add(this.label2);
            this.panelLoginFrame.Controls.Add(this.label1);
            this.panelLoginFrame.Controls.Add(this.lblMilkSalesbtn);
            this.panelLoginFrame.Controls.Add(this.picBoxFarmerCow);
            this.panelLoginFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginFrame.ForeColor = System.Drawing.Color.White;
            this.panelLoginFrame.Location = new System.Drawing.Point(20, 60);
            this.panelLoginFrame.Name = "panelLoginFrame";
            this.panelLoginFrame.Size = new System.Drawing.Size(228, 370);
            this.panelLoginFrame.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbBoxRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSoftwareNameShort);
            this.Controls.Add(this.panelLoginFrame);
            this.Controls.Add(this.picBoxLoginback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "FormLogin";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoginback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFarmerCow)).EndInit();
            this.panelLoginFrame.ResumeLayout(false);
            this.panelLoginFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSoftwareNameShort;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picBoxLoginback;
        private System.Windows.Forms.ComboBox cmbBoxRole;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox picBoxFarmerCow;
        private System.Windows.Forms.Label lblMilkSalesbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLoginFrame;
    }
}