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
    public partial class FormHealth : MetroFramework.Forms.MetroForm
    {


        private int selectedRepId = 0;
        private bool isLoading = false;




        private void ClearFields()
        {
            cmbBoxCowid.SelectedIndex = -1;
            txtCowName.Text = "";
            txtEvent.Text = "";
            txtDiagnosis.Text = "";
            txtTreatment.Text = "";
            txtCostofTreatment.Text = "";
            txtVetName.Text = "";
        }

        private void LoadHealth()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"SELECT h.RepId, h.CowId, c.CowName, h.RepDate, h.Event, 
                                h.Diagnosis, h.Treatment, h.Cost, h.VetName
                         FROM Health h
                         JOIN Cow c ON h.CowId = c.CowId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewHealth.DataSource = dt;
                conn.Close();

                dataGridViewHealth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewHealth.RowHeadersVisible = false;
                dataGridViewHealth.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridViewHealth.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViewHealth.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewHealth.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewHealth.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dataGridViewHealth.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewHealth.GridColor = Color.LightSteelBlue;
                dataGridViewHealth.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridViewHealth.EnableHeadersVisualStyles = false;

                dataGridViewHealth.Columns["CowId"].Visible = false;
                dataGridViewHealth.Columns["RepId"].HeaderText = "ID";
                dataGridViewHealth.Columns["CowName"].HeaderText = "Cow Name";
                dataGridViewHealth.Columns["RepDate"].HeaderText = "Date";
                dataGridViewHealth.Columns["Event"].HeaderText = "Event";
                dataGridViewHealth.Columns["Diagnosis"].HeaderText = "Diagnosis";
                dataGridViewHealth.Columns["Treatment"].HeaderText = "Treatment";
                dataGridViewHealth.Columns["Cost"].HeaderText = "Cost";
                dataGridViewHealth.Columns["VetName"].HeaderText = "Vet Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading health records: " + ex.Message);
            }
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
        public FormHealth()
        {
            InitializeComponent();
            LoadCowCombobox();
            LoadHealth();
            cmbBoxCowid.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ActiveControl = cmbBoxCowid;
            txtCowName.ReadOnly = true;
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

        private void dataGridViewHealth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewHealth.Rows[e.RowIndex];

            isLoading = true;
            selectedRepId = Convert.ToInt32(row.Cells["RepId"].Value);
            cmbBoxCowid.SelectedValue = Convert.ToInt32(row.Cells["CowId"].Value);
            isLoading = false;

            txtCowName.Text = row.Cells["CowName"].Value?.ToString();
            txtEvent.Text = row.Cells["Event"].Value == DBNull.Value ? "" : row.Cells["Event"].Value?.ToString();
            txtDiagnosis.Text = row.Cells["Diagnosis"].Value == DBNull.Value ? "" : row.Cells["Diagnosis"].Value?.ToString();
            txtTreatment.Text = row.Cells["Treatment"].Value == DBNull.Value ? "" : row.Cells["Treatment"].Value?.ToString();
            txtCostofTreatment.Text = row.Cells["Cost"].Value == DBNull.Value ? "" : row.Cells["Cost"].Value?.ToString();
            txtVetName.Text = row.Cells["VetName"].Value == DBNull.Value ? "" : row.Cells["VetName"].Value?.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbBoxCowid.SelectedValue == null)
            {
                MessageBox.Show("Please select a Cow.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEvent.Text))
            {
                MessageBox.Show("Please enter Event.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCostofTreatment.Text) || !int.TryParse(txtCostofTreatment.Text, out int cost))
            {
                MessageBox.Show("Please enter a valid Cost.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                // ── INSERT AND GET LAST ID IN ONE QUERY ──
                string query = @"INSERT INTO Health (CowId, RepDate, Event, Diagnosis, Treatment, Cost, VetName)
                 VALUES (@CowId, @RepDate, @Event, @Diagnosis, @Treatment, @Cost, @VetName);
                 SELECT SCOPE_IDENTITY();";


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CowId", cmbBoxCowid.SelectedValue);
                cmd.Parameters.AddWithValue("@RepDate", DateTime.Today);  // system date auto
                cmd.Parameters.AddWithValue("@Event", txtEvent.Text.Trim());
                cmd.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text.Trim());
                cmd.Parameters.AddWithValue("@Treatment", txtTreatment.Text.Trim());
                cmd.Parameters.AddWithValue("@Cost", cost);
                cmd.Parameters.AddWithValue("@VetName", txtVetName.Text.Trim());

                int lastHealthId = Convert.ToInt32(cmd.ExecuteScalar());


                MessageBox.Show("Health record saved successfully!");
                LoadHealth();
                ClearFields();

                

                // ── AUTO ADD TO EXPENDITURE TABLE ──
                if (cost > 0)
                {
                    string expQuery = @"INSERT INTO Expenditure (ExpDate, ExpPurpose, ExpAmount, EmpId, HealthId)
                        VALUES (@ExpDate, @ExpPurpose, @ExpAmount, @EmpId, @HealthId)";

                    SqlCommand expCmd = new SqlCommand(expQuery, conn);
                    expCmd.Parameters.AddWithValue("@ExpDate", DateTime.Today);
                    expCmd.Parameters.AddWithValue("@ExpPurpose", "Veterinary - " + txtCowName.Text);
                    expCmd.Parameters.AddWithValue("@ExpAmount", cost);
                    expCmd.Parameters.AddWithValue("@EmpId", Session.EmpId);
                    expCmd.Parameters.AddWithValue("@HealthId", lastHealthId);
                    expCmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving health record: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRepId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }
            if (cmbBoxCowid.SelectedValue == null)
            {
                MessageBox.Show("Please select a Cow.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCostofTreatment.Text) || !int.TryParse(txtCostofTreatment.Text, out int cost))
            {
                MessageBox.Show("Please enter a valid Cost.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"UPDATE Health SET
                        CowId     = @CowId,
                        Event     = @Event,
                        Diagnosis = @Diagnosis,
                        Treatment = @Treatment,
                        Cost      = @Cost,
                        VetName   = @VetName
                     WHERE RepId = @RepId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RepId", selectedRepId);
                cmd.Parameters.AddWithValue("@CowId", cmbBoxCowid.SelectedValue);
                cmd.Parameters.AddWithValue("@Event", txtEvent.Text.Trim());
                cmd.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text.Trim());
                cmd.Parameters.AddWithValue("@Treatment", txtTreatment.Text.Trim());
                cmd.Parameters.AddWithValue("@Cost", cost);
                cmd.Parameters.AddWithValue("@VetName", txtVetName.Text.Trim());
                cmd.ExecuteNonQuery();

                // ── UPDATE EXPENDITURE TABLE TOO ──
                // ── UPDATE OR INSERT EXPENDITURE ──
                if (cost > 0)
                {
                    // check if expenditure record exists for this health record
                    string checkQuery = "SELECT COUNT(*) FROM Expenditure WHERE HealthId = @HealthId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@HealthId", selectedRepId);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        // update existing
                        string expQuery = @"UPDATE Expenditure SET
                                ExpDate   = @ExpDate,
                                ExpAmount = @ExpAmount
                            WHERE HealthId = @HealthId";
                        SqlCommand expCmd = new SqlCommand(expQuery, conn);
                        expCmd.Parameters.AddWithValue("@ExpDate", DateTime.Today);
                        expCmd.Parameters.AddWithValue("@ExpAmount", cost);
                        expCmd.Parameters.AddWithValue("@HealthId", selectedRepId);
                        expCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // insert new one
                        string expQuery = @"INSERT INTO Expenditure (ExpDate, ExpPurpose, ExpAmount, EmpId, HealthId)
                            VALUES (@ExpDate, @ExpPurpose, @ExpAmount, @EmpId, @HealthId)";
                        SqlCommand expCmd = new SqlCommand(expQuery, conn);
                        expCmd.Parameters.AddWithValue("@ExpDate", DateTime.Today);
                        expCmd.Parameters.AddWithValue("@ExpPurpose", "Veterinary - " + txtCowName.Text);
                        expCmd.Parameters.AddWithValue("@ExpAmount", cost);
                        expCmd.Parameters.AddWithValue("@EmpId", Session.EmpId);
                        expCmd.Parameters.AddWithValue("@HealthId", selectedRepId);
                        expCmd.ExecuteNonQuery();
                    }
                }

                conn.Close();

                // ── THESE GO LAST ──
                MessageBox.Show("Health record updated successfully!");
                selectedRepId = 0; // ← reset AFTER everything is done
                LoadHealth();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating health record: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRepId == 0)
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this health record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                // ── DELETE FROM EXPENDITURE TABLE TOO ──
                string expQuery = "DELETE FROM Expenditure WHERE HealthId = @HealthId";
                SqlCommand expCmd = new SqlCommand(expQuery, conn);
                expCmd.Parameters.AddWithValue("@HealthId", selectedRepId);
                expCmd.ExecuteNonQuery();

                string query = "DELETE FROM Health WHERE RepId = @RepId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RepId", selectedRepId);

                cmd.ExecuteNonQuery();
                

                MessageBox.Show("Health record deleted successfully!");
                selectedRepId = 0;
                LoadHealth();
                ClearFields();
                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting health record: " + ex.Message);
            }
        }
    }
}
