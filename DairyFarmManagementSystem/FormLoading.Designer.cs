namespace DairyFarmManagementSystem
{
    partial class FormLoading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
            this.picBoxCow = new System.Windows.Forms.PictureBox();
            this.lblSoftwareName = new System.Windows.Forms.Label();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.picBoxYogurt = new System.Windows.Forms.PictureBox();
            this.picBoxMilk = new System.Windows.Forms.PictureBox();
            this.picBoxMilk2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYogurt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMilk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMilk2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCow
            // 
            this.picBoxCow.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCow.Image")));
            this.picBoxCow.Location = new System.Drawing.Point(243, 107);
            this.picBoxCow.Name = "picBoxCow";
            this.picBoxCow.Size = new System.Drawing.Size(262, 171);
            this.picBoxCow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCow.TabIndex = 0;
            this.picBoxCow.TabStop = false;
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.AutoSize = true;
            this.lblSoftwareName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareName.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoftwareName.Location = new System.Drawing.Point(140, 53);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(520, 38);
            this.lblSoftwareName.TabIndex = 1;
            this.lblSoftwareName.Text = "Dairy Farm Management System";
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(147, 324);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarLoading.Size = new System.Drawing.Size(499, 21);
            this.progressBarLoading.Step = 1;
            this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarLoading.TabIndex = 2;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 20;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // picBoxYogurt
            // 
            this.picBoxYogurt.Image = ((System.Drawing.Image)(resources.GetObject("picBoxYogurt.Image")));
            this.picBoxYogurt.Location = new System.Drawing.Point(692, 295);
            this.picBoxYogurt.Name = "picBoxYogurt";
            this.picBoxYogurt.Size = new System.Drawing.Size(51, 50);
            this.picBoxYogurt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxYogurt.TabIndex = 3;
            this.picBoxYogurt.TabStop = false;
            // 
            // picBoxMilk
            // 
            this.picBoxMilk.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMilk.Image")));
            this.picBoxMilk.Location = new System.Drawing.Point(643, 295);
            this.picBoxMilk.Name = "picBoxMilk";
            this.picBoxMilk.Size = new System.Drawing.Size(53, 50);
            this.picBoxMilk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMilk.TabIndex = 4;
            this.picBoxMilk.TabStop = false;
            // 
            // picBoxMilk2
            // 
            this.picBoxMilk2.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMilk2.Image")));
            this.picBoxMilk2.Location = new System.Drawing.Point(97, 295);
            this.picBoxMilk2.Name = "picBoxMilk2";
            this.picBoxMilk2.Size = new System.Drawing.Size(54, 50);
            this.picBoxMilk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMilk2.TabIndex = 5;
            this.picBoxMilk2.TabStop = false;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxMilk2);
            this.Controls.Add(this.picBoxMilk);
            this.Controls.Add(this.picBoxYogurt);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.lblSoftwareName);
            this.Controls.Add(this.picBoxCow);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "FormLoading";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYogurt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMilk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMilk2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCow;
        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.PictureBox picBoxYogurt;
        private System.Windows.Forms.PictureBox picBoxMilk;
        private System.Windows.Forms.PictureBox picBoxMilk2;
    }
}

