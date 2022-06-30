using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KATMS.BL;

namespace KATMS.GUI
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void btCCMenu_Click(object sender, EventArgs e)
        {
            Customers_Cars customerandCar = new Customers_Cars();
            customerandCar.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {
            lblLoginName.Text = "Welcome " + UserInfo.userName;
        }

        private void btEmployeeMenu_Click(object sender, EventArgs e)
        {
            List_Employees list_Employees = new List_Employees();
            list_Employees.Show();
            this.Hide();
        }

        private void ManagerMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
