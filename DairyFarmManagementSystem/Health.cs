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
    public partial class FormHealth : MetroFramework.Forms.MetroForm
    {
        public FormHealth()
        {
            InitializeComponent();
        }

        private void lblcowsbtn_Click(object sender, EventArgs e)
        {
            FormEmployeeMenu frmem = new FormEmployeeMenu();
            frmem.Show();
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
            FormDashboard frmd = new FormDashboard();
            frmd.Show();
            this.Hide();

        }
    }
}
