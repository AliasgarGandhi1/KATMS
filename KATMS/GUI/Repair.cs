using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KATMS.Validation;
using System.Data.SqlClient;
using KATMS.GUI;
using KATMS.BL;

namespace KATMS.GUI
{
    public partial class Repair : Form
    {

        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private string str;
        private int quantity=0;


        private void connection()
        {
            con = new SqlConnection("Data Source=ALIASGAR-GANDHI;Initial Catalog=KATMSdb;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
        }

        public Repair()
        {
            InitializeComponent();
        }

        private void btService_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            this.Hide();
        }

        private void btRepair_Click(object sender, EventArgs e)
        {
            Repair repair = new Repair();
            repair.Show();
            this.Hide();
        }

        private void btSHistory_Click(object sender, EventArgs e)
        {
            ServiceHistory servicehistory = new ServiceHistory();
            servicehistory.Show();
            this.Hide();
        }

        private void btAARepair_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(textBoxRName) || !Validator.IsPresent(textBoxQuantity) || !Validator.IsPresent(textBoxPName) || !Validator.IsPresent(txtPartID) || !Validator.IsPresent(textBoxUPrice) || !Validator.IsPresent(textBoxMY) || !Validator.IsPresent(textBoxKM))
            {
                MessageBox.Show("Please enter data in empty fields ...! ");
            }
            else {
                insertRepair_updatePart();
                textBoxRID.Clear();
                textBoxRName.Clear();
                txtPartID.Clear();
                textBoxQuantity.Clear();
                textBoxUPrice.Clear();
                textBoxKM.Clear();
                textBoxMY.Clear();
                textBoxPName.Clear();
                 }
        }
        private void insertRepair_updatePart()
        {
            //Inserting data in Repaittb.
            connection();
            str = "INSERT INTO Repairtb (repairName, quantity, partID, carID) VALUES (@rname, @rquantity, @rpID, @carID)";
            cmd = new SqlCommand(str, con);

            cmd.Parameters.AddWithValue("@rname", textBoxRName.Text);
            cmd.Parameters.AddWithValue("@rquantity", Convert.ToInt32(textBoxQuantity.Text));
            cmd.Parameters.AddWithValue("@rpID", txtPartID.Text);
            cmd.Parameters.AddWithValue("@carID", UserInfo.carID);

            cmd.ExecuteNonQuery();
            con.Close();


            //Adding Model year to Cartb.
            connection();
            str = "UPDATE Cartb SET year=@year WHERE carID=@carID";
            cmd = new SqlCommand(str, con);

            cmd.Parameters.AddWithValue("@carID", UserInfo.carID);
            cmd.Parameters.AddWithValue("@year", textBoxMY.Text);

            cmd.ExecuteNonQuery();
            con.Close();


            //Updating quantity in Parttb
            quantity -= Convert.ToInt32(textBoxQuantity.Text);

            connection();
            str = "UPDATE Parttb SET quantity=@qty WHERE partID=@pID";
            cmd = new SqlCommand(str, con);

            cmd.Parameters.AddWithValue("@pID", txtPartID.Text);
            cmd.Parameters.AddWithValue("@qty", quantity);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Repair Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxKM.Clear();
            textBoxMY.Clear();
            textBoxPName.Clear();
            textBoxQuantity.Clear();
            textBoxRID.Clear();
            textBoxRName.Clear();
            textBoxUPrice.Clear();
            textBoxRName.Focus();
            getRepairID();
        }


        private void btCBRepair_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(textBoxRName) || !Validator.IsPresent(textBoxQuantity) || !Validator.IsPresent(textBoxPName) || !Validator.IsPresent(txtPartID) || !Validator.IsPresent(textBoxUPrice) || !Validator.IsPresent(textBoxMY) || !Validator.IsPresent(textBoxKM))
            {
                MessageBox.Show("Please enter data in empty fields ...! ");
            }
            else
            {
                insertRepair_updatePart();
                //TODO: Redirect to new form where we will calculate the bill and print it.
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

        private void btSearchPart_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtPartID))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Finding part in Parttb.
                connection();
                str = "select * from Parttb where partID=@pID ";

                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@pID", txtPartID.Text);
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dataTable = ds.Tables[0];

                if (dataTable.Rows.Count > 0)
                {
                    textBoxPName.Text = dataTable.Rows[0]["partName"].ToString();
                    textBoxUPrice.Text = dataTable.Rows[0]["unitPrice"].ToString();
                    quantity = Convert.ToInt32(dataTable.Rows[0]["quantity"]);
                }
                else
                {
                    MessageBox.Show("Sorry, Part is not available!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btBackR_Click(object sender, EventArgs e)
        {
            Customers_Cars customers_Cars = new Customers_Cars();
            customers_Cars.ShowDialog();
            this.Hide();
        }

        private void Repair_Load(object sender, EventArgs e)
        {
            getRepairID();
        }

        private void getRepairID()
        {
            //Retriving max RepairID to generate next ID.
            connection();
            str = "select MAX(repairID) from Repairtb";
            cmd = new SqlCommand(str, con);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                try
                {
                    UserInfo.repairID = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
                    textBoxRID.Text = "" + (UserInfo.customerID);
                }
                catch (Exception ex)
                {
                    textBoxRID.Text = "" + 1;
                    UserInfo.repairID = 1;
                }
            }
            else
            {
                textBoxRID.Text = "" + 1;
                UserInfo.repairID = 1;
            }
        }

        private void textBoxPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Repair_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
