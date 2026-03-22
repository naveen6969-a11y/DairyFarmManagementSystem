using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DairyFarmManagementSystem
{   
    public partial class FormLoading : MetroFramework.Forms.MetroForm
    {
       

        public FormLoading()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Resizable = false;
            this.Movable = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
           
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (progressBarLoading.Value < 100)
            {
                progressBarLoading.Value += 1;
            }
            else
            {
                timerLoading.Stop();
                this.Refresh();
                FormLogin frmlog=new FormLogin();
                frmlog.Show();
                this.Hide();
                
            }
        }
    }
}
