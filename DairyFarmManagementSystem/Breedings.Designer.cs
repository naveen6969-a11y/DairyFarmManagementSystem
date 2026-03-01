namespace DairyFarmManagementSystem
{
    partial class FormBreeding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBreeding));
            this.lblManagecows = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCowlist = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.txtCowAge = new MetroFramework.Controls.MetroTextBox();
            this.txtCowName = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.lblCowAge = new System.Windows.Forms.Label();
            this.lblDateCalved = new System.Windows.Forms.Label();
            this.lblExpectedCalve = new System.Windows.Forms.Label();
            this.lblPregnancyDate = new System.Windows.Forms.Label();
            this.lblCowName = new System.Windows.Forms.Label();
            this.lblCowid = new System.Windows.Forms.Label();
            this.lblBreeddate = new System.Windows.Forms.Label();
            this.lblHeatDate = new System.Windows.Forms.Label();
            this.panelEmpMenuTOP = new System.Windows.Forms.Panel();
            this.lblSoftwareNameShort = new System.Windows.Forms.Label();
            this.panelLoginFrame = new System.Windows.Forms.Panel();
            this.btnempLogout = new MetroFramework.Controls.MetroButton();
            this.cmbBoxCowid = new System.Windows.Forms.ComboBox();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime4 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime5 = new MetroFramework.Controls.MetroDateTime();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new MetroFramework.Controls.MetroTextBox();
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
            this.lblManagecows.Size = new System.Drawing.Size(92, 19);
            this.lblManagecows.TabIndex = 58;
            this.lblManagecows.Text = "Cow Breeding";
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
            this.lblCowlist.Size = new System.Drawing.Size(62, 19);
            this.lblCowlist.TabIndex = 56;
            this.lblCowlist.Text = "Cows List";
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
            // txtCowAge
            // 
            // 
            // 
            // 
            this.txtCowAge.CustomButton.Image = null;
            this.txtCowAge.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCowAge.CustomButton.Name = "";
            this.txtCowAge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCowAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCowAge.CustomButton.TabIndex = 1;
            this.txtCowAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCowAge.CustomButton.UseSelectable = true;
            this.txtCowAge.CustomButton.Visible = false;
            this.txtCowAge.Lines = new string[0];
            this.txtCowAge.Location = new System.Drawing.Point(494, 171);
            this.txtCowAge.MaxLength = 32767;
            this.txtCowAge.Name = "txtCowAge";
            this.txtCowAge.PasswordChar = '\0';
            this.txtCowAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCowAge.SelectedText = "";
            this.txtCowAge.SelectionLength = 0;
            this.txtCowAge.SelectionStart = 0;
            this.txtCowAge.ShortcutsEnabled = true;
            this.txtCowAge.Size = new System.Drawing.Size(75, 23);
            this.txtCowAge.TabIndex = 52;
            this.txtCowAge.UseSelectable = true;
            this.txtCowAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCowAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCowName
            // 
            // 
            // 
            // 
            this.txtCowName.CustomButton.Image = null;
            this.txtCowName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCowName.CustomButton.Name = "";
            this.txtCowName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCowName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCowName.CustomButton.TabIndex = 1;
            this.txtCowName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCowName.CustomButton.UseSelectable = true;
            this.txtCowName.CustomButton.Visible = false;
            this.txtCowName.Lines = new string[0];
            this.txtCowName.Location = new System.Drawing.Point(571, 94);
            this.txtCowName.MaxLength = 32767;
            this.txtCowName.Name = "txtCowName";
            this.txtCowName.PasswordChar = '\0';
            this.txtCowName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCowName.SelectedText = "";
            this.txtCowName.SelectionLength = 0;
            this.txtCowName.SelectionStart = 0;
            this.txtCowName.ShortcutsEnabled = true;
            this.txtCowName.Size = new System.Drawing.Size(75, 23);
            this.txtCowName.TabIndex = 49;
            this.txtCowName.UseSelectable = true;
            this.txtCowName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCowName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // lblCowAge
            // 
            this.lblCowAge.AutoSize = true;
            this.lblCowAge.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCowAge.Location = new System.Drawing.Point(501, 140);
            this.lblCowAge.Name = "lblCowAge";
            this.lblCowAge.Size = new System.Drawing.Size(56, 15);
            this.lblCowAge.TabIndex = 43;
            this.lblCowAge.Text = "Cow Age";
            // 
            // lblDateCalved
            // 
            this.lblDateCalved.AutoSize = true;
            this.lblDateCalved.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDateCalved.Location = new System.Drawing.Point(379, 140);
            this.lblDateCalved.Name = "lblDateCalved";
            this.lblDateCalved.Size = new System.Drawing.Size(73, 15);
            this.lblDateCalved.TabIndex = 42;
            this.lblDateCalved.Text = "Date Calved";
            // 
            // lblExpectedCalve
            // 
            this.lblExpectedCalve.AutoSize = true;
            this.lblExpectedCalve.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExpectedCalve.Location = new System.Drawing.Point(224, 140);
            this.lblExpectedCalve.Name = "lblExpectedCalve";
            this.lblExpectedCalve.Size = new System.Drawing.Size(132, 15);
            this.lblExpectedCalve.TabIndex = 41;
            this.lblExpectedCalve.Text = "Expected Date to Calve";
            // 
            // lblPregnancyDate
            // 
            this.lblPregnancyDate.AutoSize = true;
            this.lblPregnancyDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPregnancyDate.Location = new System.Drawing.Point(683, 69);
            this.lblPregnancyDate.Name = "lblPregnancyDate";
            this.lblPregnancyDate.Size = new System.Drawing.Size(94, 15);
            this.lblPregnancyDate.TabIndex = 40;
            this.lblPregnancyDate.Text = "Pregnancy Date";
            // 
            // lblCowName
            // 
            this.lblCowName.AutoSize = true;
            this.lblCowName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCowName.Location = new System.Drawing.Point(580, 69);
            this.lblCowName.Name = "lblCowName";
            this.lblCowName.Size = new System.Drawing.Size(66, 15);
            this.lblCowName.TabIndex = 39;
            this.lblCowName.Text = "Cow Name";
            // 
            // lblCowid
            // 
            this.lblCowid.AutoSize = true;
            this.lblCowid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCowid.Location = new System.Drawing.Point(478, 69);
            this.lblCowid.Name = "lblCowid";
            this.lblCowid.Size = new System.Drawing.Size(43, 15);
            this.lblCowid.TabIndex = 38;
            this.lblCowid.Text = "Cow Id";
            // 
            // lblBreeddate
            // 
            this.lblBreeddate.AutoSize = true;
            this.lblBreeddate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBreeddate.Location = new System.Drawing.Point(369, 69);
            this.lblBreeddate.Name = "lblBreeddate";
            this.lblBreeddate.Size = new System.Drawing.Size(67, 15);
            this.lblBreeddate.TabIndex = 37;
            this.lblBreeddate.Text = "Breed Date";
            // 
            // lblHeatDate
            // 
            this.lblHeatDate.AutoSize = true;
            this.lblHeatDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHeatDate.Location = new System.Drawing.Point(248, 69);
            this.lblHeatDate.Name = "lblHeatDate";
            this.lblHeatDate.Size = new System.Drawing.Size(60, 15);
            this.lblHeatDate.TabIndex = 36;
            this.lblHeatDate.Text = "Heat Date";
            // 
            // panelEmpMenuTOP
            // 
            this.panelEmpMenuTOP.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelEmpMenuTOP.Controls.Add(this.lblSoftwareNameShort);
            this.panelEmpMenuTOP.ForeColor = System.Drawing.SystemColors.Control;
            this.panelEmpMenuTOP.Location = new System.Drawing.Point(218, 7);
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
            this.panelLoginFrame.Size = new System.Drawing.Size(198, 370);
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
            // 
            // cmbBoxCowid
            // 
            this.cmbBoxCowid.FormattingEnabled = true;
            this.cmbBoxCowid.Location = new System.Drawing.Point(468, 94);
            this.cmbBoxCowid.Name = "cmbBoxCowid";
            this.cmbBoxCowid.Size = new System.Drawing.Size(79, 21);
            this.cmbBoxCowid.TabIndex = 62;
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.CalendarFont = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime3.Location = new System.Drawing.Point(671, 86);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(106, 29);
            this.metroDateTime3.TabIndex = 64;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CalendarFont = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(224, 87);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(106, 29);
            this.metroDateTime1.TabIndex = 65;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.CalendarFont = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime2.Location = new System.Drawing.Point(346, 87);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(106, 29);
            this.metroDateTime2.TabIndex = 66;
            // 
            // metroDateTime4
            // 
            this.metroDateTime4.CalendarFont = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime4.Location = new System.Drawing.Point(224, 165);
            this.metroDateTime4.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime4.Name = "metroDateTime4";
            this.metroDateTime4.Size = new System.Drawing.Size(106, 29);
            this.metroDateTime4.TabIndex = 67;
            // 
            // metroDateTime5
            // 
            this.metroDateTime5.CalendarFont = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime5.Location = new System.Drawing.Point(356, 165);
            this.metroDateTime5.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime5.Name = "metroDateTime5";
            this.metroDateTime5.Size = new System.Drawing.Size(106, 29);
            this.metroDateTime5.TabIndex = 68;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.Location = new System.Drawing.Point(575, 174);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(52, 15);
            this.lblRemarks.TabIndex = 71;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.CustomButton.Image = null;
            this.txtRemarks.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtRemarks.CustomButton.Name = "";
            this.txtRemarks.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemarks.CustomButton.TabIndex = 1;
            this.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemarks.CustomButton.UseSelectable = true;
            this.txtRemarks.CustomButton.Visible = false;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(625, 171);
            this.txtRemarks.MaxLength = 32767;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(152, 23);
            this.txtRemarks.TabIndex = 72;
            this.txtRemarks.UseSelectable = true;
            this.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormBreeding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.metroDateTime5);
            this.Controls.Add(this.metroDateTime4);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroDateTime3);
            this.Controls.Add(this.cmbBoxCowid);
            this.Controls.Add(this.lblManagecows);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCowlist);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtCowAge);
            this.Controls.Add(this.txtCowName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCowAge);
            this.Controls.Add(this.lblDateCalved);
            this.Controls.Add(this.lblExpectedCalve);
            this.Controls.Add(this.lblPregnancyDate);
            this.Controls.Add(this.lblCowName);
            this.Controls.Add(this.lblCowid);
            this.Controls.Add(this.lblBreeddate);
            this.Controls.Add(this.lblHeatDate);
            this.Controls.Add(this.panelEmpMenuTOP);
            this.Controls.Add(this.panelLoginFrame);
            this.Name = "FormBreeding";
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
        private MetroFramework.Controls.MetroTextBox txtCowAge;
        private MetroFramework.Controls.MetroTextBox txtCowName;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label lblCowAge;
        private System.Windows.Forms.Label lblDateCalved;
        private System.Windows.Forms.Label lblExpectedCalve;
        private System.Windows.Forms.Label lblPregnancyDate;
        private System.Windows.Forms.Label lblCowName;
        private System.Windows.Forms.Label lblCowid;
        private System.Windows.Forms.Label lblBreeddate;
        private System.Windows.Forms.Label lblHeatDate;
        private System.Windows.Forms.Panel panelEmpMenuTOP;
        private System.Windows.Forms.Label lblSoftwareNameShort;
        private System.Windows.Forms.Panel panelLoginFrame;
        private MetroFramework.Controls.MetroButton btnempLogout;
        private System.Windows.Forms.ComboBox cmbBoxCowid;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime4;
        private MetroFramework.Controls.MetroDateTime metroDateTime5;
        private System.Windows.Forms.Label lblRemarks;
        private MetroFramework.Controls.MetroTextBox txtRemarks;
    }
}