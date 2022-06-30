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
using KATMS.GUI;

namespace KATMS.GUI
{
    public partial class List_Employees : Form
    {
        public List_Employees()
        {
            InitializeComponent();
        }

        private void List_Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kATMSdbDataSet1.Employeetb' table. You can move, or remove it, as needed.
            this.employeetbTableAdapter1.Fill(this.kATMSdbDataSet1.Employeetb);

        }

        private void btNewEmployee_Click(object sender, EventArgs e)
        {
            New_Employee onew_Employee = new New_Employee();
            onew_Employee.Show();
            this.Hide();
        }

        private void btList_Click(object sender, EventArgs e)
        {

        }

        private void btExistingEmployee_Click(object sender, EventArgs e)
        {
            Search_Employee osearch_Employee = new Search_Employee();
            osearch_Employee.Show();
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

        private void List_Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
