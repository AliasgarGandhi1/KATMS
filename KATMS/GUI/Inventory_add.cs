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
using KATMS.Validation;
using KATMS.BL;
using System.Data.SqlClient;

namespace KATMS.GUI
{
    public partial class Inventory_add : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private string str;

        public Inventory_add()
        {
            InitializeComponent();
        }

        private void connection()
        {
            con = new SqlConnection("Data Source=ALIASGAR-GANDHI;Initial Catalog=KATMSdb;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
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

        private void roundedBtAdd_Click(object sender, EventArgs e)
        {
            if( !Validator.IsPresent(txtPartID)|| !Validator.IsPresent(txtPartName)|| !Validator.IsPresent(txtQuantity)|| !Validator.IsPresent(txtPrice))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection();
                str = "INSERT INTO Parttb(partID, partName, quantity ,unitPrice) VALUES (@pID, @pName, @quantity, @price)";
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@pID", txtPartID.Text);
                cmd.Parameters.AddWithValue("@pName", txtPartName.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPartID.Clear();
                txtPartName.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
                txtPartID.Focus();
            }

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

        private void Inventory_add_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Inventory_add_Load(object sender, EventArgs e)
        {

        }
    }
}
