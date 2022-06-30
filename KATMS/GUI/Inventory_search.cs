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
using System.Data.SqlClient;
using KATMS.BL;

namespace KATMS.GUI
{
    public partial class Inventory_search : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private string str;

        public Inventory_search()
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

        private void roundedBtDelete_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtPartID) || !Validator.IsPresent(txtPartName) || !Validator.IsPresent(txtQuantity) || !Validator.IsPresent(txtPrice))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection();
                str = "DELETE FROM Parttb WHERE partID = @pID";
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@pID", txtPartID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void roundedBtSearch_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtPartID))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection();
                str = "select * from Parttb where partID=@pID ";

                cmd= new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@pID", txtPartID.Text);
                adapter= new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dataTable= ds.Tables[0];

                if(dataTable.Rows.Count > 0)
                {
                    txtPartName.Text = dataTable.Rows[0]["partName"].ToString();
                    txtQuantity.Text = dataTable.Rows[0]["quantity"].ToString();
                    txtPrice.Text = dataTable.Rows[0]["unitPrice"].ToString();
                }
                else
                {
                    MessageBox.Show("Inventory Data Does not exist!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPartID.Text = "";
                    txtPartID.Focus();
                }
            }

        }

        private void roundedBtUpdate_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtPartID) || !Validator.IsPresent(txtPartName) || !Validator.IsPresent(txtQuantity) || !Validator.IsPresent(txtPrice))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection();
                str = "UPDATE Parttb set partName = @pName, quantity = @quantity, unitPrice = @price WHERE partID = @pID";
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@pID", txtPartID.Text);
                cmd.Parameters.AddWithValue("@pName", txtPartName.Text);
                cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inventory Data Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Inventory_search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Inventory_search_Load(object sender, EventArgs e)
        {

        }
    }
}
