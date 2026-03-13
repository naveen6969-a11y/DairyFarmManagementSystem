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
    public partial class FormBreeding : MetroFramework.Forms.MetroForm
    {
        private int selectedBreedId = 0;
        private bool isLoading = false;


        private void ClearFields()
        {
            cmbBoxCowid.SelectedIndex = -1;
            txtCowName.Text = "";
            txtCowAge.Text = "";
            txtRemarks.Text = "";
            metroDateTimeHeat.Value = DateTime.Today;
            metroDateTimeBreed.Value = DateTime.Today;
            metroDateTimePregnancy.Value = DateTime.Today;
            metroDateTimeExcalve.Value = DateTime.Today;
            metroDateTimeCalve.Value = DateTime.Today;
        }
        private void LoadCowCombobox()
        {
            try
            {
                isLoading = true;

                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "SELECT CowId, CowName, (CAST(CowId AS VARCHAR) + ' - ' + CowName) AS DisplayText FROM Cow";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                cmbBoxCowid.DataSource = dt;
                cmbBoxCowid.DisplayMember = "DisplayText";
                cmbBoxCowid.ValueMember = "CowId";
                cmbBoxCowid.SelectedIndex = -1;

                isLoading = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cows: " + ex.Message);
            }
        }
        private void LoadBreedings()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"SELECT b.BreedId, b.CowId, c.CowName, b.HeatDate, b.BreedDate,
                                b.PregDate, b.ExpDateCalve, b.DateCalved, b.CowAge, b.Remarks
                         FROM Breed b
                         JOIN Cow c ON b.CowId = c.CowId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewBreedings.DataSource = dt;
                conn.Close();

                dataGridViewBreedings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewBreedings.RowHeadersVisible = false;
                dataGridViewBreedings.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridViewBreedings.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViewBreedings.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewBreedings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewBreedings.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dataGridViewBreedings.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewBreedings.GridColor = Color.LightSteelBlue;
                dataGridViewBreedings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridViewBreedings.EnableHeadersVisualStyles = false;

                dataGridViewBreedings.Columns["CowId"].Visible = false;
                dataGridViewBreedings.Columns["BreedId"].HeaderText = "ID";
                dataGridViewBreedings.Columns["CowName"].HeaderText = "Cow Name";
                dataGridViewBreedings.Columns["HeatDate"].HeaderText = "Heat Date";
                dataGridViewBreedings.Columns["BreedDate"].HeaderText = "Breed Date";
                dataGridViewBreedings.Columns["PregDate"].HeaderText = "Pregnancy Date";
                dataGridViewBreedings.Columns["ExpDateCalve"].HeaderText = "Expected Calve Date";
                dataGridViewBreedings.Columns["DateCalved"].HeaderText = "Date Calved";
                dataGridViewBreedings.Columns["CowAge"].HeaderText = "Cow Age";
                dataGridViewBreedings.Columns["Remarks"].HeaderText = "Remarks";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading breeding records: " + ex.Message);
            }
        }


        public FormBreeding()
        {
            InitializeComponent();
            LoadCowCombobox();
            LoadBreedings();
            lblsessioninfo.Text = "Logged in as : " + Session.EmpName;
            this.ActiveControl = cmbBoxCowid;
            cmbBoxCowid.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCowName.ReadOnly = true;
            txtCowAge.ReadOnly = true;
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

        private void btnempLogout_Click(object sender, EventArgs e)
        {
            FormLogin frmlog = new FormLogin();
            frmlog.Show();
            this.Hide();
        }

        private void cmbBoxCowid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            if (cmbBoxCowid.SelectedIndex == -1) return;

            DataRowView row = (DataRowView)cmbBoxCowid.SelectedItem;
            txtCowName.Text = row["CowName"].ToString();

            
        }

        private void dataGridViewBreedings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewBreedings.Rows[e.RowIndex];

            isLoading = true;
            selectedBreedId = Convert.ToInt32(row.Cells["BreedId"].Value);
            cmbBoxCowid.SelectedValue = Convert.ToInt32(row.Cells["CowId"].Value);
            isLoading = false;

            txtCowName.Text = row.Cells["CowName"].Value?.ToString();
            txtCowAge.Text = row.Cells["CowAge"].Value == DBNull.Value ? "" : row.Cells["CowAge"].Value?.ToString();
            txtRemarks.Text = row.Cells["Remarks"].Value == DBNull.Value ? "" : row.Cells["Remarks"].Value?.ToString();

            if (row.Cells["HeatDate"].Value != null && row.Cells["HeatDate"].Value != DBNull.Value)
                metroDateTimeHeat.Value = Convert.ToDateTime(row.Cells["HeatDate"].Value);

            if (row.Cells["BreedDate"].Value != null && row.Cells["BreedDate"].Value != DBNull.Value)
                metroDateTimeBreed.Value = Convert.ToDateTime(row.Cells["BreedDate"].Value);

            if (row.Cells["PregDate"].Value != null && row.Cells["PregDate"].Value != DBNull.Value)
                metroDateTimePregnancy.Value = Convert.ToDateTime(row.Cells["PregDate"].Value);

            if (row.Cells["ExpDateCalve"].Value != null && row.Cells["ExpDateCalve"].Value != DBNull.Value)
                metroDateTimeExcalve.Value = Convert.ToDateTime(row.Cells["ExpDateCalve"].Value);

            if (row.Cells["DateCalved"].Value != null && row.Cells["DateCalved"].Value != DBNull.Value)
                metroDateTimeCalve.Value = Convert.ToDateTime(row.Cells["DateCalved"].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbBoxCowid.SelectedValue == null)
            {
                MessageBox.Show("Please select a Cow.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"INSERT INTO Breed (CowId, HeatDate, BreedDate, PregDate, ExpDateCalve, DateCalved, CowAge, Remarks)
                         VALUES (@CowId, @HeatDate, @BreedDate, @PregDate, @ExpDateCalve, @DateCalved, @CowAge, @Remarks)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CowId", cmbBoxCowid.SelectedValue);
                cmd.Parameters.AddWithValue("@HeatDate", metroDateTimeHeat.Value.Date);
                cmd.Parameters.AddWithValue("@BreedDate", metroDateTimeBreed.Value.Date);
                cmd.Parameters.AddWithValue("@PregDate", metroDateTimePregnancy.Value.Date);
                cmd.Parameters.AddWithValue("@ExpDateCalve", metroDateTimeExcalve.Value.Date);
                int cowAge = string.IsNullOrWhiteSpace(txtCowAge.Text) ? 0 : int.Parse(txtCowAge.Text);
                cmd.Parameters.AddWithValue("@CowAge", cowAge);
                cmd.Parameters.AddWithValue("@DateCalved", cowAge == 0 ? (object)DBNull.Value : metroDateTimeCalve.Value.Date);
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Breeding record saved successfully!");
                LoadBreedings();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving breeding record: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBreedId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }
            if (cmbBoxCowid.SelectedValue == null)
            {
                MessageBox.Show("Please select a Cow.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"UPDATE Breed SET
                            CowId        = @CowId,
                            HeatDate     = @HeatDate,
                            BreedDate    = @BreedDate,
                            PregDate     = @PregDate,
                            ExpDateCalve = @ExpDateCalve,
                            DateCalved   = @DateCalved,
                            CowAge       = @CowAge,
                            Remarks      = @Remarks
                         WHERE BreedId = @BreedId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@BreedId", selectedBreedId);
                cmd.Parameters.AddWithValue("@CowId", cmbBoxCowid.SelectedValue);
                cmd.Parameters.AddWithValue("@HeatDate", metroDateTimeHeat.Value.Date);
                cmd.Parameters.AddWithValue("@BreedDate", metroDateTimeBreed.Value.Date);
                cmd.Parameters.AddWithValue("@PregDate", metroDateTimePregnancy.Value.Date);
                cmd.Parameters.AddWithValue("@ExpDateCalve", metroDateTimeExcalve.Value.Date);
                int cowAge = string.IsNullOrWhiteSpace(txtCowAge.Text) ? 0 : int.Parse(txtCowAge.Text);
                cmd.Parameters.AddWithValue("@CowAge", cowAge);
                cmd.Parameters.AddWithValue("@DateCalved", cowAge == 0 ? (object)DBNull.Value : metroDateTimeCalve.Value.Date);
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Breeding record updated successfully!");
                selectedBreedId = 0;
                LoadBreedings();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating breeding record: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBreedId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this breeding record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "DELETE FROM Breed WHERE BreedId = @BreedId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BreedId", selectedBreedId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Breeding record deleted successfully!");
                selectedBreedId = 0;
                LoadBreedings();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting breeding record: " + ex.Message);
            }
        }

        private void metroDateTimeBreed_ValueChanged(object sender, EventArgs e)
        {
            metroDateTimeExcalve.Value = metroDateTimeBreed.Value.AddDays(283);
        }

        private void metroDateTimeCalve_ValueChanged(object sender, EventArgs e)
        {
            DateTime calvedDate = metroDateTimeCalve.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - calvedDate.Year;
            if (calvedDate.Date > today.AddYears(-age)) age--;

            txtCowAge.Text = age.ToString();
        }
    }
}
