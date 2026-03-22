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
    public partial class FormFinance : MetroFramework.Forms.MetroForm
    {
        private int selectedExpId = 0;
        private int selectedIncId = 0;

        private void ClearExFields()
        {
            cmbBoxPurpose.SelectedIndex = -1;
            txtExAmount.Text = "";
            dateTimePickerEX.Value = DateTime.Today;
            selectedExpId = 0;
        }

        private void ClearInFields()
        {
            cmbBoxType.SelectedIndex = -1;
            txtInAmount.Text = "";
            dateTimePickerIN.Value = DateTime.Today;
            selectedIncId = 0;
        }
        private void LoadIncomes()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"SELECT i.IncId, i.IncDate, i.IncType, i.IncAmount, e.EmpName
                         FROM Income i
                         JOIN Employee e ON i.EmpId = e.EmpId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewIn.DataSource = dt;
                conn.Close();

                dataGridViewIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewIn.RowHeadersVisible = false;
                dataGridViewIn.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridViewIn.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViewIn.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewIn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewIn.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dataGridViewIn.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewIn.GridColor = Color.LightSteelBlue;
                dataGridViewIn.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridViewIn.EnableHeadersVisualStyles = false;

                dataGridViewIn.Columns["IncId"].HeaderText = "ID";
                dataGridViewIn.Columns["IncDate"].HeaderText = "Date";
                dataGridViewIn.Columns["IncType"].HeaderText = "Income Type";
                dataGridViewIn.Columns["IncAmount"].HeaderText = "Amount";
                dataGridViewIn.Columns["EmpName"].HeaderText = "Recorded By";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading incomes: " + ex.Message);
            }
        }
        private void LoadExpenditures()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"SELECT ex.ExpId, ex.ExpDate, ex.ExpPurpose, ex.ExpAmount, e.EmpName
                         FROM Expenditure ex
                         JOIN Employee e ON ex.EmpId = e.EmpId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewEx.DataSource = dt;
                conn.Close();

                dataGridViewEx.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewEx.RowHeadersVisible = false;
                dataGridViewEx.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridViewEx.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViewEx.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewEx.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewEx.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dataGridViewEx.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewEx.GridColor = Color.LightSteelBlue;
                dataGridViewEx.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridViewEx.EnableHeadersVisualStyles = false;

                dataGridViewEx.Columns["ExpId"].HeaderText = "ID";
                dataGridViewEx.Columns["ExpDate"].HeaderText = "Date";
                dataGridViewEx.Columns["ExpPurpose"].HeaderText = "Purpose";
                dataGridViewEx.Columns["ExpAmount"].HeaderText = "Amount";
                dataGridViewEx.Columns["EmpName"].HeaderText = "Recorded By";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expenditures: " + ex.Message);
            }
        }
        
        public FormFinance()
        {
            InitializeComponent();

            cmbBoxPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxType.DropDownStyle = ComboBoxStyle.DropDownList;

            lblsessioninfo.Text = "Logged in as : " + Session.EmpName;
            
            cmbBoxPurpose.Items.Add("Animal Feed");
            cmbBoxPurpose.Items.Add("Veterinary Services");
            cmbBoxPurpose.Items.Add("Medicine & Vaccines");
            cmbBoxPurpose.Items.Add("Equipment Maintenance");
            cmbBoxPurpose.Items.Add("Farm Supplies");
            cmbBoxPurpose.Items.Add("Electricity & Utilities");
            cmbBoxPurpose.Items.Add("Labour Wages");
            cmbBoxPurpose.Items.Add("Transport");
            cmbBoxPurpose.Items.Add("Fertilizer & Pasture");
            cmbBoxPurpose.Items.Add("Other");
            cmbBoxPurpose.SelectedIndex = -1;

            
            cmbBoxType.Items.Add("Cow Sales");
            cmbBoxType.Items.Add("Manure Sales");
            cmbBoxType.Items.Add("Calf Sales");
            cmbBoxType.Items.Add("Government Subsidy");
            cmbBoxType.Items.Add("Insurance Claim");
            cmbBoxType.Items.Add("Other");
            cmbBoxType.SelectedIndex = -1;

            LoadExpenditures();
            LoadIncomes();
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

        private void dataGridViewEx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewEx.Rows[e.RowIndex];

            selectedExpId = Convert.ToInt32(row.Cells["ExpId"].Value);
            cmbBoxPurpose.Text = row.Cells["ExpPurpose"].Value?.ToString();
            txtExAmount.Text = row.Cells["ExpAmount"].Value == DBNull.Value ? "" : row.Cells["ExpAmount"].Value?.ToString();

            if (row.Cells["ExpDate"].Value != null && row.Cells["ExpDate"].Value != DBNull.Value)
                dateTimePickerEX.Value = Convert.ToDateTime(row.Cells["ExpDate"].Value);
            else
                dateTimePickerEX.Value = DateTime.Today;
        }

        private void dataGridViewIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewIn.Rows[e.RowIndex];

            selectedIncId = Convert.ToInt32(row.Cells["IncId"].Value);
            cmbBoxType.Text = row.Cells["IncType"].Value?.ToString();
            txtInAmount.Text = row.Cells["IncAmount"].Value == DBNull.Value ? "" : row.Cells["IncAmount"].Value?.ToString();

            if (row.Cells["IncDate"].Value != null && row.Cells["IncDate"].Value != DBNull.Value)
                dateTimePickerIN.Value = Convert.ToDateTime(row.Cells["IncDate"].Value);
            else
                dateTimePickerIN.Value = DateTime.Today;
        }

        private void btnExSave_Click(object sender, EventArgs e)
        {
            if (cmbBoxPurpose.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Purpose.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtExAmount.Text) || !int.TryParse(txtExAmount.Text, out int expAmount))
            {
                MessageBox.Show("Please enter a valid Amount.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"INSERT INTO Expenditure (ExpDate, ExpPurpose, ExpAmount, EmpId)
                         VALUES (@ExpDate, @ExpPurpose, @ExpAmount, @EmpId)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ExpDate", dateTimePickerEX.Value.Date);
                cmd.Parameters.AddWithValue("@ExpPurpose", cmbBoxPurpose.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ExpAmount", expAmount);
                cmd.Parameters.AddWithValue("@EmpId", Session.EmpId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Expenditure saved successfully!");
                LoadExpenditures();
                ClearExFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving expenditure: " + ex.Message);
            }
        }

        private void btnInSave_Click(object sender, EventArgs e)
        {
            if (cmbBoxType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Income Type.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtInAmount.Text) || !int.TryParse(txtInAmount.Text, out int incAmount))
            {
                MessageBox.Show("Please enter a valid Amount.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"INSERT INTO Income (IncDate, IncType, IncAmount, EmpId)
                         VALUES (@IncDate, @IncType, @IncAmount, @EmpId)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IncDate", dateTimePickerIN.Value.Date);
                cmd.Parameters.AddWithValue("@IncType", cmbBoxType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@IncAmount", incAmount);
                cmd.Parameters.AddWithValue("@EmpId", Session.EmpId); 

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Income saved successfully!");
                LoadIncomes();
                ClearInFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving income: " + ex.Message);
            }
        }

        private void btnDeleteEx_Click(object sender, EventArgs e)
        {
            if (selectedExpId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this expenditure?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "DELETE FROM Expenditure WHERE ExpId = @ExpId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ExpId", selectedExpId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Expenditure deleted successfully!");
                selectedExpId = 0;
                LoadExpenditures();
                ClearExFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting expenditure: " + ex.Message);
            }
        }

        private void btnDeletein_Click(object sender, EventArgs e)
        {
            if (selectedIncId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this income record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "DELETE FROM Income WHERE IncId = @IncId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IncId", selectedIncId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Income deleted successfully!");
                selectedIncId = 0;
                LoadIncomes();
                ClearInFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting income: " + ex.Message);
            }
        }
    }
}
