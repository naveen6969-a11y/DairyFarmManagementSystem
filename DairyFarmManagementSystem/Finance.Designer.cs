namespace DairyFarmManagementSystem
{
    partial class FormFinance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinance));
            this.lblFarmFinances = new MetroFramework.Controls.MetroLabel();
            this.TableEx = new System.Windows.Forms.DataGridView();
            this.panelEmpMenuTOP = new System.Windows.Forms.Panel();
            this.lblSoftwareNameShort = new System.Windows.Forms.Label();
            this.panelLoginFrame = new System.Windows.Forms.Panel();
            this.btnempLogout = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExSave = new MetroFramework.Controls.MetroButton();
            this.cmbBoxPurpose = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblExDate = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.txtExAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblExAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInSave = new MetroFramework.Controls.MetroButton();
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblInDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtInAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblInAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TableIn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableEx)).BeginInit();
            this.panelEmpMenuTOP.SuspendLayout();
            this.panelLoginFrame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFarmFinances
            // 
            this.lblFarmFinances.AutoSize = true;
            this.lblFarmFinances.BackColor = System.Drawing.Color.Transparent;
            this.lblFarmFinances.Location = new System.Drawing.Point(445, 44);
            this.lblFarmFinances.Name = "lblFarmFinances";
            this.lblFarmFinances.Size = new System.Drawing.Size(92, 19);
            this.lblFarmFinances.TabIndex = 91;
            this.lblFarmFinances.Text = "Farm Finances";
            // 
            // TableEx
            // 
            this.TableEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableEx.Location = new System.Drawing.Point(307, 19);
            this.TableEx.Name = "TableEx";
            this.TableEx.Size = new System.Drawing.Size(244, 135);
            this.TableEx.TabIndex = 90;
            // 
            // panelEmpMenuTOP
            // 
            this.panelEmpMenuTOP.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelEmpMenuTOP.Controls.Add(this.lblSoftwareNameShort);
            this.panelEmpMenuTOP.ForeColor = System.Drawing.SystemColors.Control;
            this.panelEmpMenuTOP.Location = new System.Drawing.Point(213, 7);
            this.panelEmpMenuTOP.Name = "panelEmpMenuTOP";
            this.panelEmpMenuTOP.Size = new System.Drawing.Size(572, 32);
            this.panelEmpMenuTOP.TabIndex = 74;
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
            this.panelLoginFrame.TabIndex = 73;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnExSave);
            this.panel1.Controls.Add(this.cmbBoxPurpose);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblExDate);
            this.panel1.Controls.Add(this.lblPurpose);
            this.panel1.Controls.Add(this.txtExAmount);
            this.panel1.Controls.Add(this.lblExAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TableEx);
            this.panel1.Location = new System.Drawing.Point(231, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 164);
            this.panel1.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Expenditure List";
            // 
            // btnExSave
            // 
            this.btnExSave.Location = new System.Drawing.Point(48, 132);
            this.btnExSave.Name = "btnExSave";
            this.btnExSave.Size = new System.Drawing.Size(136, 23);
            this.btnExSave.TabIndex = 98;
            this.btnExSave.Text = "Save";
            this.btnExSave.UseSelectable = true;
            // 
            // cmbBoxPurpose
            // 
            this.cmbBoxPurpose.FormattingEnabled = true;
            this.cmbBoxPurpose.Location = new System.Drawing.Point(90, 73);
            this.cmbBoxPurpose.Name = "cmbBoxPurpose";
            this.cmbBoxPurpose.Size = new System.Drawing.Size(75, 21);
            this.cmbBoxPurpose.TabIndex = 97;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker1.TabIndex = 96;
            // 
            // lblExDate
            // 
            this.lblExDate.AutoSize = true;
            this.lblExDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExDate.Location = new System.Drawing.Point(28, 35);
            this.lblExDate.Name = "lblExDate";
            this.lblExDate.Size = new System.Drawing.Size(32, 15);
            this.lblExDate.TabIndex = 95;
            this.lblExDate.Text = "Date";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPurpose.Location = new System.Drawing.Point(12, 75);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(51, 15);
            this.lblPurpose.TabIndex = 94;
            this.lblPurpose.Text = "Purpose";
            // 
            // txtExAmount
            // 
            // 
            // 
            // 
            this.txtExAmount.CustomButton.Image = null;
            this.txtExAmount.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtExAmount.CustomButton.Name = "";
            this.txtExAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExAmount.CustomButton.TabIndex = 1;
            this.txtExAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExAmount.CustomButton.UseSelectable = true;
            this.txtExAmount.CustomButton.Visible = false;
            this.txtExAmount.Lines = new string[0];
            this.txtExAmount.Location = new System.Drawing.Point(90, 103);
            this.txtExAmount.MaxLength = 32767;
            this.txtExAmount.Name = "txtExAmount";
            this.txtExAmount.PasswordChar = '\0';
            this.txtExAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExAmount.SelectedText = "";
            this.txtExAmount.SelectionLength = 0;
            this.txtExAmount.SelectionStart = 0;
            this.txtExAmount.ShortcutsEnabled = true;
            this.txtExAmount.Size = new System.Drawing.Size(75, 23);
            this.txtExAmount.TabIndex = 93;
            this.txtExAmount.UseSelectable = true;
            this.txtExAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblExAmount
            // 
            this.lblExAmount.AutoSize = true;
            this.lblExAmount.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExAmount.Location = new System.Drawing.Point(20, 103);
            this.lblExAmount.Name = "lblExAmount";
            this.lblExAmount.Size = new System.Drawing.Size(48, 15);
            this.lblExAmount.TabIndex = 92;
            this.lblExAmount.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Expenditures";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnInSave);
            this.panel2.Controls.Add(this.cmbBoxType);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.lblInDate);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.txtInAmount);
            this.panel2.Controls.Add(this.lblInAmount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.TableIn);
            this.panel2.Location = new System.Drawing.Point(231, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 164);
            this.panel2.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Income List";
            // 
            // btnInSave
            // 
            this.btnInSave.Location = new System.Drawing.Point(48, 132);
            this.btnInSave.Name = "btnInSave";
            this.btnInSave.Size = new System.Drawing.Size(136, 23);
            this.btnInSave.TabIndex = 98;
            this.btnInSave.Text = "Save";
            this.btnInSave.UseSelectable = true;
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Location = new System.Drawing.Point(92, 69);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(75, 21);
            this.cmbBoxType.TabIndex = 97;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(92, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker2.TabIndex = 96;
            // 
            // lblInDate
            // 
            this.lblInDate.AutoSize = true;
            this.lblInDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInDate.Location = new System.Drawing.Point(12, 28);
            this.lblInDate.Name = "lblInDate";
            this.lblInDate.Size = new System.Drawing.Size(74, 15);
            this.lblInDate.TabIndex = 95;
            this.lblInDate.Text = "Income Date";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(28, 71);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(32, 15);
            this.lblType.TabIndex = 94;
            this.lblType.Text = "Type";
            // 
            // txtInAmount
            // 
            // 
            // 
            // 
            this.txtInAmount.CustomButton.Image = null;
            this.txtInAmount.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtInAmount.CustomButton.Name = "";
            this.txtInAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInAmount.CustomButton.TabIndex = 1;
            this.txtInAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInAmount.CustomButton.UseSelectable = true;
            this.txtInAmount.CustomButton.Visible = false;
            this.txtInAmount.Lines = new string[0];
            this.txtInAmount.Location = new System.Drawing.Point(90, 103);
            this.txtInAmount.MaxLength = 32767;
            this.txtInAmount.Name = "txtInAmount";
            this.txtInAmount.PasswordChar = '\0';
            this.txtInAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInAmount.SelectedText = "";
            this.txtInAmount.SelectionLength = 0;
            this.txtInAmount.SelectionStart = 0;
            this.txtInAmount.ShortcutsEnabled = true;
            this.txtInAmount.Size = new System.Drawing.Size(75, 23);
            this.txtInAmount.TabIndex = 93;
            this.txtInAmount.UseSelectable = true;
            this.txtInAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblInAmount
            // 
            this.lblInAmount.AutoSize = true;
            this.lblInAmount.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInAmount.Location = new System.Drawing.Point(12, 103);
            this.lblInAmount.Name = "lblInAmount";
            this.lblInAmount.Size = new System.Drawing.Size(48, 15);
            this.lblInAmount.TabIndex = 92;
            this.lblInAmount.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 91;
            this.label8.Text = "Incomes";
            // 
            // TableIn
            // 
            this.TableIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableIn.Location = new System.Drawing.Point(307, 19);
            this.TableIn.Name = "TableIn";
            this.TableIn.Size = new System.Drawing.Size(244, 135);
            this.TableIn.TabIndex = 90;
            // 
            // FormFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFarmFinances);
            this.Controls.Add(this.panelEmpMenuTOP);
            this.Controls.Add(this.panelLoginFrame);
            this.Name = "FormFinance";
            ((System.ComponentModel.ISupportInitialize)(this.TableEx)).EndInit();
            this.panelEmpMenuTOP.ResumeLayout(false);
            this.panelEmpMenuTOP.PerformLayout();
            this.panelLoginFrame.ResumeLayout(false);
            this.panelLoginFrame.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblFarmFinances;
        private System.Windows.Forms.DataGridView TableEx;
        private System.Windows.Forms.Panel panelEmpMenuTOP;
        private System.Windows.Forms.Label lblSoftwareNameShort;
        private System.Windows.Forms.Panel panelLoginFrame;
        private MetroFramework.Controls.MetroButton btnempLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPurpose;
        private MetroFramework.Controls.MetroTextBox txtExAmount;
        private System.Windows.Forms.Label lblExAmount;
        private System.Windows.Forms.Label lblExDate;
        private System.Windows.Forms.ComboBox cmbBoxPurpose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnExSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btnInSave;
        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblInDate;
        private System.Windows.Forms.Label lblType;
        private MetroFramework.Controls.MetroTextBox txtInAmount;
        private System.Windows.Forms.Label lblInAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView TableIn;
    }
}