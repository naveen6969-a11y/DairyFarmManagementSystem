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
    public partial class FormMilkSales : MetroFramework.Forms.MetroForm
    {
        private int selectedSaleId = 0;
        private bool isLoading = false;

        private void ClearFields()
        {
            txtPrice.Text = "";
            txtClientName.Text = "";
            txtClientPhone.Text = "";
            txtQuantity.Text = "";
            txtTotal.Text = "";
            CalenderDateSales.Value = DateTime.Today;
        }

        private void LoadSales()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"SELECT ms.SId, ms.SaleDate, ms.UPrice, ms.ClientName, 
                                ms.ClientPhone, e.EmpName, ms.Quantity, ms.Amount
                         FROM MilkSales ms
                         JOIN Employee e ON ms.EmpId = e.EmpId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewSales.DataSource = dt;
                conn.Close();

                dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSales.RowHeadersVisible = false;
                dataGridViewSales.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridViewSales.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViewSales.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewSales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dataGridViewSales.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewSales.GridColor = Color.LightSteelBlue;
                dataGridViewSales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridViewSales.EnableHeadersVisualStyles = false;

                dataGridViewSales.Columns["SId"].HeaderText = "ID";
                dataGridViewSales.Columns["SaleDate"].HeaderText = "Date";
                dataGridViewSales.Columns["UPrice"].HeaderText = "Unit Price";
                dataGridViewSales.Columns["ClientName"].HeaderText = "Client Name";
                dataGridViewSales.Columns["ClientPhone"].HeaderText = "Phone";
                dataGridViewSales.Columns["EmpName"].HeaderText = "Sold By";
                dataGridViewSales.Columns["Quantity"].HeaderText = "Quantity (L)";
                dataGridViewSales.Columns["Amount"].HeaderText = "Total Amount";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message);
            }
        }

        public FormMilkSales()
        {
            InitializeComponent();
            LoadSales();
            txtQuantity.TextChanged += txtPrice_TextChanged;
            txtTotal.ReadOnly = true;
            this.ActiveControl = CalenderDateSales;
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

        private void btnempLogout_Click(object sender, EventArgs e)
        {
            FormLogin frmlog = new FormLogin();
            frmlog.Show();
            this.Hide();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int price = int.TryParse(txtPrice.Text, out int p) ? p : 0;
            int quantity = int.TryParse(txtQuantity.Text, out int q) ? q : 0;
            txtTotal.Text = (price * quantity).ToString();
        }

        private void dataGridViewSales_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewSales.Rows[e.RowIndex];

            selectedSaleId = Convert.ToInt32(row.Cells["SId"].Value);
            txtPrice.Text = row.Cells["UPrice"].Value == DBNull.Value ? "" : row.Cells["UPrice"].Value?.ToString();
            txtClientName.Text = row.Cells["ClientName"].Value == DBNull.Value ? "" : row.Cells["ClientName"].Value?.ToString();
            txtClientPhone.Text = row.Cells["ClientPhone"].Value == DBNull.Value ? "" : row.Cells["ClientPhone"].Value?.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value == DBNull.Value ? "" : row.Cells["Quantity"].Value?.ToString();
            txtTotal.Text = row.Cells["Amount"].Value == DBNull.Value ? "" : row.Cells["Amount"].Value?.ToString();

            if (row.Cells["SaleDate"].Value != null && row.Cells["SaleDate"].Value != DBNull.Value)
                CalenderDateSales.Value = Convert.ToDateTime(row.Cells["SaleDate"].Value);
            else
                CalenderDateSales.Value = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Please enter Client Name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtClientPhone.Text))
            {
                MessageBox.Show("Please enter Client Phone.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text) || !int.TryParse(txtPrice.Text, out int price))
            {
                MessageBox.Show("Please enter a valid Unit Price.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid Quantity.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"INSERT INTO MilkSales (SaleDate, UPrice, ClientName, ClientPhone, EmpId, Quantity)
                         VALUES (@SaleDate, @UPrice, @ClientName, @ClientPhone, @EmpId, @Quantity)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@SaleDate", CalenderDateSales.Value.Date);
                cmd.Parameters.AddWithValue("@UPrice", price);
                cmd.Parameters.AddWithValue("@ClientName", txtClientName.Text.Trim());
                cmd.Parameters.AddWithValue("@ClientPhone", txtClientPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@EmpId", Session.EmpId); // ← auto from session!
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Sale saved successfully!");
                LoadSales();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sale: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSaleId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text) || !int.TryParse(txtPrice.Text, out int price))
            {
                MessageBox.Show("Please enter a valid Unit Price.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid Quantity.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"UPDATE MilkSales SET
                            SaleDate    = @SaleDate,
                            UPrice      = @UPrice,
                            ClientName  = @ClientName,
                            ClientPhone = @ClientPhone,
                            Quantity    = @Quantity
                         WHERE SId = @SId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@SId", selectedSaleId);
                cmd.Parameters.AddWithValue("@SaleDate", CalenderDateSales.Value.Date);
                cmd.Parameters.AddWithValue("@UPrice", price);
                cmd.Parameters.AddWithValue("@ClientName", txtClientName.Text.Trim());
                cmd.Parameters.AddWithValue("@ClientPhone", txtClientPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Sale updated successfully!");
                selectedSaleId = 0;
                LoadSales();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating sale: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSaleId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this sale record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "DELETE FROM MilkSales WHERE SId = @SId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SId", selectedSaleId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Sale deleted successfully!");
                selectedSaleId = 0;
                LoadSales();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting sale: " + ex.Message);
            }
        }
    }
}
