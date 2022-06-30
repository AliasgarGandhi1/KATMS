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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btCCMenu_Click(object sender, EventArgs e)
        {
            Customers_Cars ocustomerandCar = new Customers_Cars();
            ocustomerandCar.Show();
            this.Hide();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            List_Employees olist_Employees = new List_Employees();
            olist_Employees.Show();
            this.Show();
        }

        private void btInventory_Click(object sender, EventArgs e)
        {
            Inventory oinventory = new Inventory();
            oinventory.Show();
            this.Hide();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            lblLoginName.Text = "Welcome " + UserInfo.userName;
        }

        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
