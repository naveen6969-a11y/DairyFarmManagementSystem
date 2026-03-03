using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyFarmManagementSystem
{
    public partial class FormEmployeeMenu : MetroFramework.Forms.MetroForm
    {
        public FormEmployeeMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Resizable = false;
            this.Movable = false;
           

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            FormLogin frmlog = new FormLogin();
            frmlog.Show();
            this.Hide();
        }

        private void lblMilkProductionbtn_Click(object sender, EventArgs e)
        {
            FormMilkProduction frmmilk = new FormMilkProduction();
            frmmilk.Show();
            this.Hide();
        }

        private void lblHealthbtn_Click(object sender, EventArgs e)
        {
            FormHealth frmh = new FormHealth();
            frmh.Show();
            this.Hide();
        }

        private void lblBreedingbtn_Click(object sender, EventArgs e)
        {
            FormBreeding frmb = new FormBreeding();
            frmb.Show();
            this.Hide();
        }

        private void lblMilkSalesbtn_Click(object sender, EventArgs e)
        {
            FormMilkSales frms = new FormMilkSales();
            frms.Show();
            this.Hide();
        }

        private void lblFinancebtn_Click(object sender, EventArgs e)
        {
            FormFinance frmf = new FormFinance();
            frmf.Show();
            this.Hide();
        }

        private void lblDashboardbtn_Click(object sender, EventArgs e)
        {
            FormDashboard frmf = new FormDashboard();
            frmf.Show();
            this.Hide();
        }
    }
}
