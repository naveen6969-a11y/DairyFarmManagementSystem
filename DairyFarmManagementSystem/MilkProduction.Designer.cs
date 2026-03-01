namespace DairyFarmManagementSystem
{
    partial class FormMilkProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMilkProduction));
            this.lblManagecows = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCowlist = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.txtTotalMilk = new MetroFramework.Controls.MetroTextBox();
            this.txtPMmilk = new MetroFramework.Controls.MetroTextBox();
            this.txtNoonMilk = new MetroFramework.Controls.MetroTextBox();
            this.txtCowName2 = new MetroFramework.Controls.MetroTextBox();
            this.txtAMmilk = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.CalenderDate = new MetroFramework.Controls.MetroDateTime();
            this.lblTotalMilk = new System.Windows.Forms.Label();
            this.lblPMmilk = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNoonMilk = new System.Windows.Forms.Label();
            this.lblAmmilk = new System.Windows.Forms.Label();
            this.lblCowName2 = new System.Windows.Forms.Label();
            this.lblCowId = new System.Windows.Forms.Label();
            this.panelEmpMenuTOP = new System.Windows.Forms.Panel();
            this.lblSoftwareNameShort = new System.Windows.Forms.Label();
            this.panelLoginFrame = new System.Windows.Forms.Panel();
            this.btnempLogout = new MetroFramework.Controls.MetroButton();
            this.cmbboxCowid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelEmpMenuTOP.SuspendLayout();
            this.panelLoginFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManagecows
            // 
            this.lblManagecows.AutoSize = true;
            this.lblManagecows.BackColor = System.Drawing.Color.Transparent;
            this.lblManagecows.Location = new System.Drawing.Point(450, 44);
            this.lblManagecows.Name = "lblManagecows";
            this.lblManagecows.Size = new System.Drawing.Size(133, 19);
            this.lblManagecows.TabIndex = 58;
            this.lblManagecows.Text = "Daily Milk Production";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 57;
            // 
            // lblCowlist
            // 
            this.lblCowlist.AutoSize = true;
            this.lblCowlist.Location = new System.Drawing.Point(450, 271);
            this.lblCowlist.Name = "lblCowlist";
            this.lblCowlist.Size = new System.Drawing.Size(65, 19);
            this.lblCowlist.TabIndex = 56;
            this.lblCowlist.Text = "Daily Milk";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(645, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(543, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(446, 236);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            // 
            // txtTotalMilk
            // 
            // 
            // 
            // 
            this.txtTotalMilk.CustomButton.Image = null;
            this.txtTotalMilk.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtTotalMilk.CustomButton.Name = "";
            this.txtTotalMilk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalMilk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalMilk.CustomButton.TabIndex = 1;
            this.txtTotalMilk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalMilk.CustomButton.UseSelectable = true;
            this.txtTotalMilk.CustomButton.Visible = false;
            this.txtTotalMilk.Lines = new string[0];
            this.txtTotalMilk.Location = new System.Drawing.Point(370, 174);
            this.txtTotalMilk.MaxLength = 32767;
            this.txtTotalMilk.Name = "txtTotalMilk";
            this.txtTotalMilk.PasswordChar = '\0';
            this.txtTotalMilk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalMilk.SelectedText = "";
            this.txtTotalMilk.SelectionLength = 0;
            this.txtTotalMilk.SelectionStart = 0;
            this.txtTotalMilk.ShortcutsEnabled = true;
            this.txtTotalMilk.Size = new System.Drawing.Size(75, 23);
            this.txtTotalMilk.TabIndex = 51;
            this.txtTotalMilk.UseSelectable = true;
            this.txtTotalMilk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalMilk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPMmilk
            // 
            // 
            // 
            // 
            this.txtPMmilk.CustomButton.Image = null;
            this.txtPMmilk.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtPMmilk.CustomButton.Name = "";
            this.txtPMmilk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPMmilk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPMmilk.CustomButton.TabIndex = 1;
            this.txtPMmilk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPMmilk.CustomButton.UseSelectable = true;
            this.txtPMmilk.CustomButton.Visible = false;
            this.txtPMmilk.Lines = new string[0];
            this.txtPMmilk.Location = new System.Drawing.Point(260, 177);
            this.txtPMmilk.MaxLength = 32767;
            this.txtPMmilk.Name = "txtPMmilk";
            this.txtPMmilk.PasswordChar = '\0';
            this.txtPMmilk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPMmilk.SelectedText = "";
            this.txtPMmilk.SelectionLength = 0;
            this.txtPMmilk.SelectionStart = 0;
            this.txtPMmilk.ShortcutsEnabled = true;
            this.txtPMmilk.Size = new System.Drawing.Size(75, 23);
            this.txtPMmilk.TabIndex = 50;
            this.txtPMmilk.UseSelectable = true;
            this.txtPMmilk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPMmilk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNoonMilk
            // 
            // 
            // 
            // 
            this.txtNoonMilk.CustomButton.Image = null;
            this.txtNoonMilk.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtNoonMilk.CustomButton.Name = "";
            this.txtNoonMilk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoonMilk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoonMilk.CustomButton.TabIndex = 1;
            this.txtNoonMilk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoonMilk.CustomButton.UseSelectable = true;
            this.txtNoonMilk.CustomButton.Visible = false;
            this.txtNoonMilk.Lines = new string[0];
            this.txtNoonMilk.Location = new System.Drawing.Point(594, 96);
            this.txtNoonMilk.MaxLength = 32767;
            this.txtNoonMilk.Name = "txtNoonMilk";
            this.txtNoonMilk.PasswordChar = '\0';
            this.txtNoonMilk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoonMilk.SelectedText = "";
            this.txtNoonMilk.SelectionLength = 0;
            this.txtNoonMilk.SelectionStart = 0;
            this.txtNoonMilk.ShortcutsEnabled = true;
            this.txtNoonMilk.Size = new System.Drawing.Size(75, 23);
            this.txtNoonMilk.TabIndex = 49;
            this.txtNoonMilk.UseSelectable = true;
            this.txtNoonMilk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoonMilk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCowName2
            // 
            // 
            // 
            // 
            this.txtCowName2.CustomButton.Image = null;
            this.txtCowName2.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCowName2.CustomButton.Name = "";
            this.txtCowName2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCowName2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCowName2.CustomButton.TabIndex = 1;
            this.txtCowName2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCowName2.CustomButton.UseSelectable = true;
            this.txtCowName2.CustomButton.Visible = false;
            this.txtCowName2.Lines = new string[0];
            this.txtCowName2.Location = new System.Drawing.Point(370, 96);
            this.txtCowName2.MaxLength = 32767;
            this.txtCowName2.Name = "txtCowName2";
            this.txtCowName2.PasswordChar = '\0';
            this.txtCowName2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCowName2.SelectedText = "";
            this.txtCowName2.SelectionLength = 0;
            this.txtCowName2.SelectionStart = 0;
            this.txtCowName2.ShortcutsEnabled = true;
            this.txtCowName2.Size = new System.Drawing.Size(75, 23);
            this.txtCowName2.TabIndex = 48;
            this.txtCowName2.UseSelectable = true;
            this.txtCowName2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCowName2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAMmilk
            // 
            // 
            // 
            // 
            this.txtAMmilk.CustomButton.Image = null;
            this.txtAMmilk.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtAMmilk.CustomButton.Name = "";
            this.txtAMmilk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAMmilk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAMmilk.CustomButton.TabIndex = 1;
            this.txtAMmilk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAMmilk.CustomButton.UseSelectable = true;
            this.txtAMmilk.CustomButton.Visible = false;
            this.txtAMmilk.Lines = new string[0];
            this.txtAMmilk.Location = new System.Drawing.Point(467, 96);
            this.txtAMmilk.MaxLength = 32767;
            this.txtAMmilk.Name = "txtAMmilk";
            this.txtAMmilk.PasswordChar = '\0';
            this.txtAMmilk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAMmilk.SelectedText = "";
            this.txtAMmilk.SelectionLength = 0;
            this.txtAMmilk.SelectionStart = 0;
            this.txtAMmilk.ShortcutsEnabled = true;
            this.txtAMmilk.Size = new System.Drawing.Size(75, 23);
            this.txtAMmilk.TabIndex = 47;
            this.txtAMmilk.UseSelectable = true;
            this.txtAMmilk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAMmilk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(284, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            // 
            // CalenderDate
            // 
            this.CalenderDate.Location = new System.Drawing.Point(488, 168);
            this.CalenderDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.CalenderDate.Name = "CalenderDate";
            this.CalenderDate.Size = new System.Drawing.Size(200, 29);
            this.CalenderDate.TabIndex = 44;
            // 
            // lblTotalMilk
            // 
            this.lblTotalMilk.AutoSize = true;
            this.lblTotalMilk.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalMilk.Location = new System.Drawing.Point(367, 143);
            this.lblTotalMilk.Name = "lblTotalMilk";
            this.lblTotalMilk.Size = new System.Drawing.Size(57, 15);
            this.lblTotalMilk.TabIndex = 42;
            this.lblTotalMilk.Text = "Total Milk";
            // 
            // lblPMmilk
            // 
            this.lblPMmilk.AutoSize = true;
            this.lblPMmilk.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPMmilk.Location = new System.Drawing.Point(278, 143);
            this.lblPMmilk.Name = "lblPMmilk";
            this.lblPMmilk.Size = new System.Drawing.Size(49, 15);
            this.lblPMmilk.TabIndex = 41;
            this.lblPMmilk.Text = "PM Milk";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(551, 143);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(32, 15);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "Date";
            // 
            // lblNoonMilk
            // 
            this.lblNoonMilk.AutoSize = true;
            this.lblNoonMilk.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoonMilk.Location = new System.Drawing.Point(604, 69);
            this.lblNoonMilk.Name = "lblNoonMilk";
            this.lblNoonMilk.Size = new System.Drawing.Size(62, 15);
            this.lblNoonMilk.TabIndex = 39;
            this.lblNoonMilk.Text = "Noon Milk";
            // 
            // lblAmmilk
            // 
            this.lblAmmilk.AutoSize = true;
            this.lblAmmilk.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAmmilk.Location = new System.Drawing.Point(485, 69);
            this.lblAmmilk.Name = "lblAmmilk";
            this.lblAmmilk.Size = new System.Drawing.Size(50, 15);
            this.lblAmmilk.TabIndex = 38;
            this.lblAmmilk.Text = "AM Milk";
            // 
            // lblCowName2
            // 
            this.lblCowName2.AutoSize = true;
            this.lblCowName2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCowName2.Location = new System.Drawing.Point(382, 69);
            this.lblCowName2.Name = "lblCowName2";
            this.lblCowName2.Size = new System.Drawing.Size(66, 15);
            this.lblCowName2.TabIndex = 37;
            this.lblCowName2.Text = "Cow Name";
            // 
            // lblCowId
            // 
            this.lblCowId.AutoSize = true;
            this.lblCowId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCowId.Location = new System.Drawing.Point(272, 69);
            this.lblCowId.Name = "lblCowId";
            this.lblCowId.Size = new System.Drawing.Size(43, 15);
            this.lblCowId.TabIndex = 36;
            this.lblCowId.Text = "Cow Id";
            // 
            // panelEmpMenuTOP
            // 
            this.panelEmpMenuTOP.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelEmpMenuTOP.Controls.Add(this.lblSoftwareNameShort);
            this.panelEmpMenuTOP.ForeColor = System.Drawing.SystemColors.Control;
            this.panelEmpMenuTOP.Location = new System.Drawing.Point(228, 4);
            this.panelEmpMenuTOP.Name = "panelEmpMenuTOP";
            this.panelEmpMenuTOP.Size = new System.Drawing.Size(572, 32);
            this.panelEmpMenuTOP.TabIndex = 35;
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
            // panelLoginFrame
            // 
            this.panelLoginFrame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLoginFrame.Controls.Add(this.btnempLogout);
            this.panelLoginFrame.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginFrame.ForeColor = System.Drawing.Color.White;
            this.panelLoginFrame.Location = new System.Drawing.Point(20, 60);
            this.panelLoginFrame.Name = "panelLoginFrame";
            this.panelLoginFrame.Size = new System.Drawing.Size(194, 370);
            this.panelLoginFrame.TabIndex = 34;
            // 
            // btnempLogout
            // 
            this.btnempLogout.AutoSize = true;
            this.btnempLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnempLogout.BackgroundImage")));
            this.btnempLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnempLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnempLogout.Location = new System.Drawing.Point(72, 323);
            this.btnempLogout.Name = "btnempLogout";
            this.btnempLogout.Size = new System.Drawing.Size(36, 34);
            this.btnempLogout.TabIndex = 0;
            this.btnempLogout.UseSelectable = true;
            this.btnempLogout.Click += new System.EventHandler(this.btnempLogout_Click);
            // 
            // cmbboxCowid
            // 
            this.cmbboxCowid.FormattingEnabled = true;
            this.cmbboxCowid.Location = new System.Drawing.Point(249, 96);
            this.cmbboxCowid.Name = "cmbboxCowid";
            this.cmbboxCowid.Size = new System.Drawing.Size(104, 21);
            this.cmbboxCowid.TabIndex = 59;
            // 
            // FormMilkProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbboxCowid);
            this.Controls.Add(this.lblManagecows);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCowlist);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtTotalMilk);
            this.Controls.Add(this.txtPMmilk);
            this.Controls.Add(this.txtNoonMilk);
            this.Controls.Add(this.txtCowName2);
            this.Controls.Add(this.txtAMmilk);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CalenderDate);
            this.Controls.Add(this.lblTotalMilk);
            this.Controls.Add(this.lblPMmilk);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNoonMilk);
            this.Controls.Add(this.lblAmmilk);
            this.Controls.Add(this.lblCowName2);
            this.Controls.Add(this.lblCowId);
            this.Controls.Add(this.panelEmpMenuTOP);
            this.Controls.Add(this.panelLoginFrame);
            this.Name = "FormMilkProduction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelEmpMenuTOP.ResumeLayout(false);
            this.panelEmpMenuTOP.PerformLayout();
            this.panelLoginFrame.ResumeLayout(false);
            this.panelLoginFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblManagecows;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel lblCowlist;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroTextBox txtTotalMilk;
        private MetroFramework.Controls.MetroTextBox txtPMmilk;
        private MetroFramework.Controls.MetroTextBox txtNoonMilk;
        private MetroFramework.Controls.MetroTextBox txtCowName2;
        private MetroFramework.Controls.MetroTextBox txtAMmilk;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroDateTime CalenderDate;
        private System.Windows.Forms.Label lblTotalMilk;
        private System.Windows.Forms.Label lblPMmilk;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNoonMilk;
        private System.Windows.Forms.Label lblAmmilk;
        private System.Windows.Forms.Label lblCowName2;
        private System.Windows.Forms.Label lblCowId;
        private System.Windows.Forms.Panel panelEmpMenuTOP;
        private System.Windows.Forms.Label lblSoftwareNameShort;
        private System.Windows.Forms.Panel panelLoginFrame;
        private MetroFramework.Controls.MetroButton btnempLogout;
        private System.Windows.Forms.ComboBox cmbboxCowid;
    }
}