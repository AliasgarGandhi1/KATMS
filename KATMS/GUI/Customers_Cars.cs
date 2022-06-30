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
    public partial class Customers_Cars : Form
    {
        public Customers_Cars()
        {
            InitializeComponent();
        }

        private void btNewCust_Click(object sender, EventArgs e)
        {
            NewCustomer customer_Car = new NewCustomer();
            customer_Car.Show();
            this.Hide();
        }

        private void btExixtingCust_Click(object sender, EventArgs e)
        {
            ExistingCustomer existingCustomer = new ExistingCustomer();
            existingCustomer.Show();
            this.Hide();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            if (UserInfo.role == "Admin")
            {
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
                this.Hide();
            }
            else
            {
                ManagerMenu managerMenu = new ManagerMenu();
                managerMenu.Show();
                this.Hide();
            }
        }

        private void Customers_Cars_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Customers_Cars_Load(object sender, EventArgs e)
        {

        }
    }
}
