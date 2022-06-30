using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KATMS.GUI;
using KATMS.BL;


namespace KATMS.GUI
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void btList_Click(object sender, EventArgs e)
        {
            Inventory_list inv_List = new Inventory_list();
            inv_List.Show();
            this.Hide();


        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Inventory_add inv_Add = new Inventory_add();
            inv_Add.Show();
            this.Hide();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Inventory_search inv_Search = new Inventory_search();
            inv_Search.Show();
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

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
