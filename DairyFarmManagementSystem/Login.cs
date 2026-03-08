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
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Resizable = false;
            this.Movable = false;
           
            cmbBoxRole.SelectedIndex = -1;
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (cmbBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Role.");
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

            // ── LOGIN ──
            try
            {
                DBconnection db = new DBconnection();
                SqlConnection conn = db.GetConnection();

                string query = @"SELECT EmpId, EmpName, Role FROM Employee 
                         WHERE Username = @Username 
                         AND Password  = @Password 
                         AND Role      = @Role";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbBoxRole.SelectedItem.ToString());

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // ── SET SESSION ──
                    Session.EmpId = Convert.ToInt32(reader["EmpId"]);
                    Session.EmpName = reader["EmpName"].ToString();
                    Session.Role = reader["Role"].ToString();

                    reader.Close();
                    conn.Close();

                    MessageBox.Show("Welcome, " + Session.EmpName + "!");

                    // ── OPEN MAIN FORM ──
                    FormEmployeeMenu mainForm = new FormEmployeeMenu();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    MessageBox.Show("Invalid Username, Password or Role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
