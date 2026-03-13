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
    public partial class FormAdminMenu : MetroFramework.Forms.MetroForm
    {
        private int selectedEmpId = 0;
        private bool isLoading = false;

        private void ClearFields()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbBoxGender.SelectedIndex = -1;
            cmbBoxRole.SelectedIndex = -1;
            CalenderDateofbirth.Value = DateTime.Today;
            selectedEmpId = 0;
        }
        private void LoadEmployees()
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "SELECT EmpId, EmpName, EmpDob, Gender, Phone, Address, Username, Role FROM Employee";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewEmp.DataSource = dt;
                conn.Close();

                dataGridViewEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewEmp.RowHeadersVisible = false;
                dataGridViewEmp.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridViewEmp.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridViewEmp.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridViewEmp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewEmp.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dataGridViewEmp.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridViewEmp.GridColor = Color.LightSteelBlue;
                dataGridViewEmp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridViewEmp.EnableHeadersVisualStyles = false;

                dataGridViewEmp.Columns["EmpId"].HeaderText = "ID";
                dataGridViewEmp.Columns["EmpName"].HeaderText = "Name";
                dataGridViewEmp.Columns["EmpDob"].HeaderText = "Date of Birth";
                dataGridViewEmp.Columns["Gender"].HeaderText = "Gender";
                dataGridViewEmp.Columns["Phone"].HeaderText = "Phone";
                dataGridViewEmp.Columns["Address"].HeaderText = "Address";
                dataGridViewEmp.Columns["Username"].HeaderText = "Username";
                dataGridViewEmp.Columns["Role"].HeaderText = "Role";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private string GetGreeting()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
                return "🌅 Good Morning";
            else if (hour < 17)
                return "☀️ Good Afternoon";
            else
                return "🌙 Good Evening";
        }

        public FormAdminMenu()
        {
            
            InitializeComponent();

            lblDate.Text = "📅 " + DateTime.Today.ToString("dddd, dd MMMM yyyy");
            //lblDate.Font = new Font("Segoe UI", 9);
            //lblDate.ForeColor = Color.FromArgb(100, 100, 100);

            lblGreeting.Text = GetGreeting() + "" + "!";
            lblGreeting.Font = new Font("Segoe UI", 11, FontStyle.Italic);
            lblGreeting.ForeColor = Color.FromArgb(80, 80, 80);

            lblsessioninfo.Text = "Logged in as : " + Session.EmpName;

            if (Session.Role != "Admin")
            {
                MessageBox.Show("Access Denied! Admins only.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
           
            // ── GENDER COMBOBOX ──
            cmbBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxGender.SelectedIndex = -1;

            // ── ROLE COMBOBOX ──
            cmbBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxRole.SelectedIndex = -1;

            // ── HIDE PASSWORD ──
            txtPassword.PasswordChar = '●';

            // ── AUTO CALCULATE AGE ──
            CalenderDateofbirth.ValueChanged += CalenderDateofbirth_ValueChanged;

            LoadEmployees();
            txtName.Select();

        }

        private void CalenderDateofbirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = CalenderDateofbirth.Value;
            int age = DateTime.Today.Year - dob.Year;
            if (dob.Date > DateTime.Today.AddYears(-age)) age--;
        }

        private void dataGridViewEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewEmp.Rows[e.RowIndex];

            selectedEmpId = Convert.ToInt32(row.Cells["EmpId"].Value);
            txtName.Text = row.Cells["EmpName"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value == DBNull.Value ? "" : row.Cells["Phone"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value == DBNull.Value ? "" : row.Cells["Address"].Value?.ToString();
            txtUsername.Text = row.Cells["Username"].Value == DBNull.Value ? "" : row.Cells["Username"].Value?.ToString();
            txtPassword.Text = ""; // never fill password for security

            cmbBoxGender.Text = row.Cells["Gender"].Value?.ToString();
            cmbBoxRole.Text = row.Cells["Role"].Value?.ToString();

            if (row.Cells["EmpDob"].Value != null && row.Cells["EmpDob"].Value != DBNull.Value)
                CalenderDateofbirth.Value = Convert.ToDateTime(row.Cells["EmpDob"].Value);
            else
                CalenderDateofbirth.Value = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter Employee Name.");
                return;
            }
            if (cmbBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter Phone Number.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter Username.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter Password.");
                return;
            }
            if (cmbBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Role.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"INSERT INTO Employee (EmpName, EmpDob, Gender, Phone, Address, Username, Password, Role)
                         VALUES (@EmpName, @EmpDob, @Gender, @Phone, @Address, @Username, @Password, @Role)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@EmpName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@EmpDob", CalenderDateofbirth.Value.Date);
                cmd.Parameters.AddWithValue("@Gender", cmbBoxGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbBoxRole.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Employee saved successfully!");
                LoadEmployees();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving employee: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEmpId == 0)
            {
                MessageBox.Show("Please select an employee from the table first.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter Employee Name.");
                return;
            }
            if (cmbBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender.");
                return;
            }
            if (cmbBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Role.");
                return;
            }

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query;
                SqlCommand cmd;

                // ── ONLY UPDATE PASSWORD IF USER TYPED A NEW ONE ──
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    query = @"UPDATE Employee SET
                        EmpName  = @EmpName,
                        EmpDob   = @EmpDob,
                        Gender   = @Gender,
                        Phone    = @Phone,
                        Address  = @Address,
                        Username = @Username,
                        Password = @Password,
                        Role     = @Role
                      WHERE EmpId = @EmpId";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                }
                else
                {
                    query = @"UPDATE Employee SET
                        EmpName  = @EmpName,
                        EmpDob   = @EmpDob,
                        Gender   = @Gender,
                        Phone    = @Phone,
                        Address  = @Address,
                        Username = @Username,
                        Role     = @Role
                      WHERE EmpId = @EmpId";
                    cmd = new SqlCommand(query, conn);
                }

                cmd.Parameters.AddWithValue("@EmpId", selectedEmpId);
                cmd.Parameters.AddWithValue("@EmpName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@EmpDob", CalenderDateofbirth.Value.Date);
                cmd.Parameters.AddWithValue("@Gender", cmbBoxGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbBoxRole.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Employee updated successfully!");
                selectedEmpId = 0;
                LoadEmployees();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmpId == 0)
            {
                MessageBox.Show("Please select an employee from the table first.");
                return;
            }

            // ── PREVENT ADMIN FROM DELETING THEMSELVES ──
            if (selectedEmpId == Session.EmpId)
            {
                MessageBox.Show("You cannot delete your own account!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete " + txtName.Text + "?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = "DELETE FROM Employee WHERE EmpId = @EmpId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpId", selectedEmpId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Employee deleted successfully!");
                selectedEmpId = 0;
                LoadEmployees();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee: " + ex.Message);
            }
        }

        private void btnempLogout_Click(object sender, EventArgs e)
        {
            FormLogin frmlog = new FormLogin();
            frmlog.Show();
            this.Hide();
        }
    }
}
