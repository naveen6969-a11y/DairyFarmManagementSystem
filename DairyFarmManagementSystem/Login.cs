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

            this.BackColor = Color.FromArgb(245, 245, 245);

            // ── PASSWORD HIDDEN ──
            txtPassword.PasswordChar = '●';

            // ── USERNAME TEXTBOX ──
            txtUsername.Font = new Font("Segoe UI", 10);
            //txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.FromArgb(50, 50, 50);
            txtUsername.Height = 30;

            // ── PASSWORD TEXTBOX ──
            txtPassword.Font = new Font("Segoe UI", 10);
            //txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.FromArgb(50, 50, 50);
            txtPassword.Height = 30;

            // ── COMBOBOX ──
            cmbBoxRole.Font = new Font("Segoe UI", 10);
            cmbBoxRole.BackColor = Color.White;
            cmbBoxRole.ForeColor = Color.FromArgb(50, 50, 50);
            cmbBoxRole.FlatStyle = FlatStyle.Flat;
            
           

            // ── LOGIN BUTTON ──
            btnLogin.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Height = 40;
            btnLogin.Cursor = Cursors.Hand;

            // ── HOVER EFFECT ON BUTTON ──
            btnLogin.MouseEnter += (s, ev) => btnLogin.BackColor = Color.FromArgb(30, 100, 180);
            btnLogin.MouseLeave += (s, ev) => btnLogin.BackColor = Color.SteelBlue;
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

                    // ── OPEN FORM BASED ON ROLE ──
                    if (Session.Role == "Admin")
                    {
                        FormAdminMenu adminForm = new FormAdminMenu();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormEmployeeMenu empForm = new FormEmployeeMenu();
                        empForm.Show();
                        this.Hide();
                    }
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
