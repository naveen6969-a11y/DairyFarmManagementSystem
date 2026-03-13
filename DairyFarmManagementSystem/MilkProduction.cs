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
    public partial class FormMilkProduction : MetroFramework.Forms.MetroForm
    {
        private bool isLoading = false;  // add this at the top of your form class
        private int selectedMilkId = 0; // add this at the top of your form class
        private void LoadCowCombobox()
        {
            try
            {
                isLoading = true;  // ← stop the event from firing

                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "SELECT CowId, CowName, (CAST(CowId AS VARCHAR) + ' - ' + CowName) AS DisplayText FROM Cow";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbboxCowid.DataSource = dt;
                cmbboxCowid.DisplayMember = "DisplayText";
                cmbboxCowid.ValueMember = "CowId";
                cmbboxCowid.SelectedIndex = -1;

                isLoading = false;  // ← allow the event again
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cows: " + ex.Message);
            }
        }

        private void LoadMilkProduction()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"SELECT m.MilkId, m.CowId, c.CowName, m.AmMilk, m.NoonMilk, 
                        m.PmMilk, m.TotalMilk, m.DateProd 
                 FROM Milk m 
                 JOIN Cow c ON m.CowId = c.CowId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewMilk.DataSource = dt;
                conn.Close();

                dataGridViewMilk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewMilk.RowHeadersVisible = false;
                dataGridViewMilk.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridViewMilk.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViewMilk.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewMilk.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewMilk.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dataGridViewMilk.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewMilk.GridColor = Color.LightSteelBlue;
                dataGridViewMilk.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridViewMilk.EnableHeadersVisualStyles = false;

                dataGridViewMilk.Columns["MilkId"].HeaderText = "ID";
                dataGridViewMilk.Columns["CowName"].HeaderText = "Cow Name";
                dataGridViewMilk.Columns["AmMilk"].HeaderText = "Morning (L)";
                dataGridViewMilk.Columns["NoonMilk"].HeaderText = "Noon (L)";
                dataGridViewMilk.Columns["PmMilk"].HeaderText = "Evening (L)";
                dataGridViewMilk.Columns["TotalMilk"].HeaderText = "Total (L)";
                dataGridViewMilk.Columns["DateProd"].HeaderText = "Date";
                dataGridViewMilk.Columns["CowId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading milk production: " + ex.Message);
            }
        }

        public FormMilkProduction()
        {
            InitializeComponent();
            LoadMilkProduction();
            LoadCowCombobox();
            cmbboxCowid.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ActiveControl = cmbboxCowid;
            txtCowName2.ReadOnly = true;
            lblsessioninfo.Text = "Logged in as : " + Session.EmpName;
        }

        private void btnempLogout_Click(object sender, EventArgs e)
        {
            FormLogin frmlog = new FormLogin();
            frmlog.Show();
            this.Hide();
        }

        private void lblcowsbtn_Click(object sender, EventArgs e)
        {
            FormEmployeeMenu frmem = new FormEmployeeMenu();
            frmem.Show();
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

        private void btnempLogout_Click_1(object sender, EventArgs e)
        {
            FormLogin frmlog = new FormLogin();
            frmlog.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check if a row is selected
            if (selectedMilkId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }

            // ── VALIDATION ──
            if (cmbboxCowid.SelectedValue == null)
            {
                MessageBox.Show("Please select a Cow.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAMmilk.Text) || !int.TryParse(txtAMmilk.Text, out int amMilk))
            {
                MessageBox.Show("Please enter a valid Morning Milk amount.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNoonMilk.Text) || !int.TryParse(txtNoonMilk.Text, out int noonMilk))
            {
                MessageBox.Show("Please enter a valid Noon Milk amount.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPMmilk.Text) || !int.TryParse(txtPMmilk.Text, out int pmMilk))
            {
                MessageBox.Show("Please enter a valid Evening Milk amount.");
                return;
            }

            // ── UPDATE ──
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"UPDATE Milk SET 
                            CowId    = @CowId,
                            AmMilk   = @AmMilk,
                            NoonMilk = @NoonMilk,
                            PmMilk   = @PmMilk,
                            DateProd = @DateProd
                         WHERE MilkId = @MilkId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MilkId", selectedMilkId);
                cmd.Parameters.AddWithValue("@CowId", cmbboxCowid.SelectedValue);
                cmd.Parameters.AddWithValue("@AmMilk", amMilk);
                cmd.Parameters.AddWithValue("@NoonMilk", noonMilk);
                cmd.Parameters.AddWithValue("@PmMilk", pmMilk);
                cmd.Parameters.AddWithValue("@DateProd", CalenderDate.Value.Date);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Milk record updated successfully!");
                selectedMilkId = 0;
                LoadMilkProduction();

                // ── CLEAR FIELDS ──
                cmbboxCowid.SelectedIndex = -1;
                txtAMmilk.Text = "";
                txtNoonMilk.Text = "";
                txtPMmilk.Text = "";
                txtTotalMilk.Text = "";
                CalenderDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating milk record: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ── VALIDATION ──
            if (cmbboxCowid.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Cow.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAMmilk.Text) || !int.TryParse(txtAMmilk.Text, out int amMilk))
            {
                MessageBox.Show("Please enter a valid Morning Milk amount.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNoonMilk.Text) || !int.TryParse(txtNoonMilk.Text, out int noonMilk))
            {
                MessageBox.Show("Please enter a valid Noon Milk amount.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPMmilk.Text) || !int.TryParse(txtPMmilk.Text, out int pmMilk))
            {
                MessageBox.Show("Please enter a valid Evening Milk amount.");
                return;
            }

            // ── SAVE ──
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"INSERT INTO Milk (CowId, AmMilk, NoonMilk, PmMilk, DateProd)
                         VALUES (@CowId, @AmMilk, @NoonMilk, @PmMilk, @DateProd)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CowId", cmbboxCowid.SelectedValue);
                cmd.Parameters.AddWithValue("@AmMilk", amMilk);
                cmd.Parameters.AddWithValue("@NoonMilk", noonMilk);
                cmd.Parameters.AddWithValue("@PmMilk", pmMilk);
                cmd.Parameters.AddWithValue("@DateProd", CalenderDate.Value.Date);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Milk production saved successfully!");
                LoadMilkProduction();

                // ── CLEAR FIELDS ──
                cmbboxCowid.SelectedIndex = -1;
                txtCowName2.Text = "";
                txtAMmilk.Text = "";
                txtNoonMilk.Text = "";
                txtPMmilk.Text = "";
                txtTotalMilk.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving milk production: " + ex.Message);
            }
        }

        private void cmbboxCowid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;  // ← ignore if still loading
            if (cmbboxCowid.SelectedIndex == -1) return;

            DataRowView row = (DataRowView)cmbboxCowid.SelectedItem;
            txtCowName2.Text = row["CowName"].ToString();
        }

        private void txtAMmilk_TextChanged(object sender, EventArgs e)
        {
            int am = int.TryParse(txtAMmilk.Text, out int a) ? a : 0;
            int noon = int.TryParse(txtNoonMilk.Text, out int n) ? n : 0;
            int pm = int.TryParse(txtPMmilk.Text, out int p) ? p : 0;
            txtTotalMilk.Text = (am + noon + pm).ToString();
        }

        private void txtNoonMilk_TextChanged(object sender, EventArgs e)
        {
            int am = int.TryParse(txtAMmilk.Text, out int a) ? a : 0;
            int noon = int.TryParse(txtNoonMilk.Text, out int n) ? n : 0;
            int pm = int.TryParse(txtPMmilk.Text, out int p) ? p : 0;
            txtTotalMilk.Text = (am + noon + pm).ToString();
        }

        private void txtPMmilk_TextChanged(object sender, EventArgs e)
        {
            int am = int.TryParse(txtAMmilk.Text, out int a) ? a : 0;
            int noon = int.TryParse(txtNoonMilk.Text, out int n) ? n : 0;
            int pm = int.TryParse(txtPMmilk.Text, out int p) ? p : 0;
            txtTotalMilk.Text = (am + noon + pm).ToString();
        }

        private void dataGridViewMilk_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return; // ← move this to the top FIRST

            DataGridViewRow row = dataGridViewMilk.Rows[e.RowIndex];

            isLoading = true;
            selectedMilkId = Convert.ToInt32(row.Cells["MilkId"].Value);
            cmbboxCowid.SelectedValue = Convert.ToInt32(row.Cells["CowId"].Value);
            isLoading = false;

            txtAMmilk.Text = row.Cells["AmMilk"].Value == DBNull.Value ? "" : row.Cells["AmMilk"].Value?.ToString();
            txtNoonMilk.Text = row.Cells["NoonMilk"].Value == DBNull.Value ? "" : row.Cells["NoonMilk"].Value?.ToString();
            txtPMmilk.Text = row.Cells["PmMilk"].Value == DBNull.Value ? "" : row.Cells["PmMilk"].Value?.ToString();
            txtTotalMilk.Text = row.Cells["TotalMilk"].Value == DBNull.Value ? "" : row.Cells["TotalMilk"].Value?.ToString();
            txtCowName2.Text = row.Cells["CowName"].Value?.ToString();

            if (row.Cells["DateProd"].Value != null && row.Cells["DateProd"].Value != DBNull.Value)
                CalenderDate.Value = Convert.ToDateTime(row.Cells["DateProd"].Value);
            else
                CalenderDate.Value = DateTime.Today;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMilkId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this milk record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "DELETE FROM Milk WHERE MilkId = @MilkId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MilkId", selectedMilkId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Record deleted successfully!");
                selectedMilkId = 0;
                LoadMilkProduction();

                // ── CLEAR FIELDS ──
                cmbboxCowid.SelectedIndex = -1;
                txtAMmilk.Text = "";
                txtNoonMilk.Text = "";
                txtPMmilk.Text = "";
                txtTotalMilk.Text = "";
                CalenderDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }
    }
}
