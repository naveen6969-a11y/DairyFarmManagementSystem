using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            FormEmployeeMenu frmEmployeeMenu = new FormEmployeeMenu();
            frmEmployeeMenu.Show();
            this.Hide();
        }
    }
}
