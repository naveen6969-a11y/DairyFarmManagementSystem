using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyFarmManagementSystem
{
    public partial class FormDashboard : MetroFramework.Forms.MetroForm
    {
        private void LoadDashboard()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                // ── TOTAL INCOME ──
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(IncAmount), 0) FROM Income", conn);
                lblincomeAmount.Text = "Rs. " + cmd.ExecuteScalar().ToString();

                // ── TOTAL EXPENDITURE ──
                cmd = new SqlCommand("SELECT ISNULL(SUM(ExpAmount), 0) FROM Expenditure", conn);
                lblExAmount.Text = "Rs. " + cmd.ExecuteScalar().ToString();

                // ── BALANCE ──
                cmd = new SqlCommand("SELECT ISNULL(SUM(IncAmount), 0) FROM Income", conn);
                int totalIncome = Convert.ToInt32(cmd.ExecuteScalar());

                cmd = new SqlCommand("SELECT ISNULL(SUM(ExpAmount), 0) FROM Expenditure", conn);
                int totalExp = Convert.ToInt32(cmd.ExecuteScalar());

                int balance = totalIncome - totalExp;
                lblBalanceAmount.Text = "Rs. " + balance.ToString();

                // change color based on balance
                lblBalanceAmount.ForeColor = balance >= 0 ? Color.Green : Color.Red;

                // ── TOTAL COWS ──
                cmd = new SqlCommand("SELECT COUNT(*) FROM Cow", conn);
                lblCowsCount.Text = cmd.ExecuteScalar().ToString();

                // ── TOTAL MILK STOCK ──
                cmd = new SqlCommand("SELECT ISNULL(SUM(TotalMilk), 0) FROM Milk", conn);
                lblMilkStockCount.Text = cmd.ExecuteScalar().ToString() + " L";

                // ── TOTAL EMPLOYEES ──
                cmd = new SqlCommand("SELECT COUNT(*) FROM Employee", conn);
                lblEmpCount.Text = cmd.ExecuteScalar().ToString();

                // ── HIGHEST SALE AMOUNT ──
                cmd = new SqlCommand("SELECT ISNULL(MAX(Amount), 0) FROM MilkSales", conn);
                lblhighestsaleAmount.Text = "Rs. " + cmd.ExecuteScalar().ToString();

                // ── HIGHEST EXPENDITURE ──
                cmd = new SqlCommand("SELECT ISNULL(MAX(ExpAmount), 0) FROM Expenditure", conn);
                lblHighestExpenditureAmount.Text = "Rs. " + cmd.ExecuteScalar().ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }
        public FormDashboard()
        {
            InitializeComponent();
            LoadDashboard();
            lblsessioninfo.Text = "Logged in as : " + Session.EmpName;
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

        private void btnempLogout_Click(object sender, EventArgs e)
        {
            FormLogin frmlog = new FormLogin();
            frmlog.Show();
            this.Hide();
        }
    }
}
