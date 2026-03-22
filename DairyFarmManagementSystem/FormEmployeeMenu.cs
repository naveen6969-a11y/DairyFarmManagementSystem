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
    public partial class FormEmployeeMenu : MetroFramework.Forms.MetroForm
    {
        private int selectedCowId = 0;

        private void LoadCows()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "SELECT * FROM Cow";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewCows.DataSource = dt;
                conn.Close();
                dataGridViewCows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewCows.RowHeadersVisible = false;
                dataGridViewCows.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridViewCows.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViewCows.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewCows.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewCows.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dataGridViewCows.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewCows.GridColor = Color.LightSteelBlue;
                
                dataGridViewCows.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridViewCows.EnableHeadersVisualStyles = false;

                dataGridViewCows.Columns["CowId"].HeaderText = "ID";
                dataGridViewCows.Columns["CowName"].HeaderText = "Cow Name";
                dataGridViewCows.Columns["EarTag"].HeaderText = "Ear Tag";
                dataGridViewCows.Columns["WeightAtBirth"].HeaderText = "Weight at Birth";
                dataGridViewCows.Columns["DateOfBirth"].HeaderText = "Date of Birth";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cows: " + ex.Message);
            }
        }
        public FormEmployeeMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Resizable = false;
            this.Movable = false;
            LoadCows();
            txtCowname.Select();
            txtAge.ReadOnly = true;
            lblsessioninfo.Text = "Logged in as : " + Session.EmpName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCowname.Text))
            {
                MessageBox.Show("Please enter Cow Name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEartag.Text))
            {
                MessageBox.Show("Please enter Ear Tag.");
                return;

            }
            if (CalenderDateofbirth.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be a future date!");
                return;
            }
            if (int.Parse(txtAge.Text) < 0)
            {
                MessageBox.Show("Date of Birth cannot be a future date!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text) || !int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid Age.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtWeightatbirth.Text) || !int.TryParse(txtWeightatbirth.Text, out int weight))
            {
                MessageBox.Show("Please enter a valid Weight at Birth.");
                return;
            }

            
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"INSERT INTO Cow (CowName, EarTag, Color, Breed, Age, WeightAtBirth, Pasture, DateOfBirth)
                                VALUES (@CowName, @EarTag, @Color, @Breed, @Age, @WeightAtBirth, @Pasture, @DateOfBirth)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CowName", txtCowname.Text.Trim());
                cmd.Parameters.AddWithValue("@EarTag", txtEartag.Text.Trim());
                cmd.Parameters.AddWithValue("@Color", txtColor.Text.Trim());
                cmd.Parameters.AddWithValue("@Breed", txtBreed.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@WeightAtBirth", weight);
                cmd.Parameters.AddWithValue("@Pasture", txtPasture.Text.Trim());
                
                cmd.Parameters.AddWithValue("@DateOfBirth", CalenderDateofbirth.Value.Date);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cow saved successfully!");
                LoadCows();
                
                txtCowname.Text = "";
                txtEartag.Text = "";
                txtColor.Text = "";
                txtBreed.Text = "";
                txtAge.Text = "";
                txtWeightatbirth.Text = "";
                txtPasture.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving cow: " + ex.Message);
            }
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

        private void CalenderDateofbirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = CalenderDateofbirth.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - dob.Year;

            
            if (dob.Date > today.AddYears(-age))
                age--;

            txtAge.Text = age.ToString();
        }

        private void dataGridViewCows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewCows.Rows[e.RowIndex];

            txtCowname.Text = row.Cells["CowName"].Value == DBNull.Value ? "" : row.Cells["CowName"].Value?.ToString();
            txtEartag.Text = row.Cells["EarTag"].Value == DBNull.Value ? "" : row.Cells["EarTag"].Value?.ToString();
            txtColor.Text = row.Cells["Color"].Value == DBNull.Value ? "" : row.Cells["Color"].Value?.ToString();
            txtBreed.Text = row.Cells["Breed"].Value == DBNull.Value ? "" : row.Cells["Breed"].Value?.ToString();
            txtAge.Text = row.Cells["Age"].Value == DBNull.Value ? "" : row.Cells["Age"].Value?.ToString();
            txtWeightatbirth.Text = row.Cells["WeightAtBirth"].Value == DBNull.Value ? "" : row.Cells["WeightAtBirth"].Value?.ToString();
            txtPasture.Text = row.Cells["Pasture"].Value == DBNull.Value ? "" : row.Cells["Pasture"].Value?.ToString();


            
            if (row.Cells["DateOfBirth"].Value != null && row.Cells["DateOfBirth"].Value != DBNull.Value)
                CalenderDateofbirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
            else
                CalenderDateofbirth.Value = DateTime.Today;

            selectedCowId = Convert.ToInt32(row.Cells["CowId"].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (selectedCowId == 0)
            {
                MessageBox.Show("Please select a cow from the table first.");
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtCowname.Text))
            {
                MessageBox.Show("Please enter Cow Name.");
                return;
            }
            if (CalenderDateofbirth.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Date of Birth cannot be a future date!");
                return;
            }
            if (int.Parse(txtAge.Text) < 0)
            {
                MessageBox.Show("Date of Birth cannot be a future date!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEartag.Text))
            {
                MessageBox.Show("Please enter Ear Tag.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAge.Text) || !int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid Age.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtWeightatbirth.Text) || !int.TryParse(txtWeightatbirth.Text, out int weight))
            {
                MessageBox.Show("Please enter a valid Weight at Birth.");
                return;
            }

            
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"UPDATE Cow SET 
                            CowName = @CowName,
                            EarTag = @EarTag,
                            Color = @Color,
                            Breed = @Breed,
                            Age = @Age,
                            WeightAtBirth = @WeightAtBirth,
                            Pasture = @Pasture,
                            DateOfBirth = @DateOfBirth
                         WHERE CowId = @CowId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CowId", selectedCowId);
                cmd.Parameters.AddWithValue("@CowName", txtCowname.Text.Trim());
                cmd.Parameters.AddWithValue("@EarTag", txtEartag.Text.Trim());
                cmd.Parameters.AddWithValue("@Color", txtColor.Text.Trim());
                cmd.Parameters.AddWithValue("@Breed", txtBreed.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@WeightAtBirth", weight);
                cmd.Parameters.AddWithValue("@Pasture", txtPasture.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", CalenderDateofbirth.Value.Date);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cow updated successfully!");
                selectedCowId = 0;
                LoadCows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating cow: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (selectedCowId == 0)
            {
                MessageBox.Show("Please select a cow from the table first.");
                return;
            }

            
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete " + txtCowname.Text + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

           
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "DELETE FROM Cow WHERE CowId = @CowId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CowId", selectedCowId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cow deleted successfully!");
                selectedCowId = 0;
                LoadCows();

                
                txtCowname.Text = "";
                txtEartag.Text = "";
                txtColor.Text = "";
                txtBreed.Text = "";
                txtAge.Text = "";
                txtWeightatbirth.Text = "";
                txtPasture.Text = "";
                CalenderDateofbirth.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting cow: " + ex.Message);
            }
        }
    }
}
