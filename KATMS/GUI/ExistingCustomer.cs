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
using System.Data.SqlClient;
using KATMS.Validation;

namespace KATMS.GUI
{
    public partial class ExistingCustomer : Form
    {
        private bool flag = false;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private string str;

        public ExistingCustomer()
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

        private void btNewCust_Click(object sender, EventArgs e)
        {
            NewCustomer customer_Car = new NewCustomer();
            customer_Car.Show();
            this.Hide();
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExistingCustomer_Load(object sender, EventArgs e)
        {
            this.brandtbTableAdapter.Fill(this.kATMSdbDataSet.Brandtb);

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            flag = false;
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

        private void btSearchCust_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtSearchPhoneNo.Text) || !Validator.IsPresent(txtSearchCarNo))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                connection();
                str = "select cust.customerID, firstName, lastName, phoneNumber, emailID, carID, carNumber, model, brandName " +
                    "from Customertb cust, Cartb car, Brandtb brand where phoneNumber = @phoneNo and cust.customerID=car.customerID and brand.brandID = car.brandID and carNumber = @carNo";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@phoneNo", txtSearchPhoneNo.Text);
                cmd.Parameters.AddWithValue("@carNo", txtSearchCarNo.Text);
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if(ds.Tables[0].Rows.Count > 0)
                {
                    txtCustomerID.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtFname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtLastName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtPhoneNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtCarID.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtCarNo.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtModel.Text = ds.Tables[0].Rows[0][7].ToString();
                    cbBrand.SelectedValue = ds.Tables[0].Rows[0][8].ToString();

                    UserInfo.customerID = Convert.ToInt32(txtCustomerID.Text);
                    UserInfo.carID = Convert.ToInt32(txtCarID.Text);
                    flag = true;

                    txtSearchCarNo.Clear();
                    txtSearchPhoneNo.Clear();
                }

                else
                {
                    MessageBox.Show("Phone number or Car number is not exist!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btUpdateCust_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtFname) || !Validator.IsPresent(txtLastName) || !Validator.IsPresent(txtPhoneNo.Text)
               || !Validator.IsPresent(txtEmail) || !Validator.IsPresent(txtCarNo)
               || !Validator.IsPresent(txtModel))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //Code to update data into Customer table.
                connection();
                str = "UPDATE Customertb set firstName=@fname, lastName=@lname, emailID=@emailID, phoneNumber=@phoneNo WHERE customerID = " + txtCustomerID.Text;
                cmd = new SqlCommand(str, con);

                
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@emailID", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phoneNo", txtPhoneNo.Text);

                cmd.ExecuteNonQuery();
                con.Close();


                //Code to get brandID from Brandtb of selected brand name in combo box.
                connection();
                str = "select brandID from Brandtb where brandName=@brandnm";

                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@brandnm", cbBrand.SelectedValue);

                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dataTable = ds.Tables[0];
                String brandID = "";

                if (dataTable != null)
                {
                    brandID = dataTable.Rows[0]["brandID"].ToString();
                }


                //Code to update data into Car table.
                connection();
                str = "UPDATE Cartb set carNumber=@carNo, model=@model, brandID=@brandID, customerID=@custID where carID = " + txtCarID.Text;
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@carNo", txtCarNo.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@brandID", Convert.ToInt32(brandID));
                cmd.Parameters.AddWithValue("@custID", Convert.ToInt32(txtCustomerID.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCarNo.Clear();
                txtFname.Clear();
                txtLastName.Clear();
                txtCarID.Clear();
                txtCustomerID.Clear();
                txtEmail.Clear();
                txtModel.Clear();
                txtPhoneNo.Clear();
                txtSearchPhoneNo.Focus();
            }
        }

        private void btDeleteCust_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtFname) || !Validator.IsPresent(txtLastName) || !Validator.IsPresent(txtPhoneNo.Text)
               || !Validator.IsPresent(txtEmail) || !Validator.IsPresent(txtCarNo)
               || !Validator.IsPresent(txtModel))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Code to update data into Customer table.
                connection();
                str = "Delete from Cartb where carID=" + txtCarID.Text;
                cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();
                con.Close();


                //Code to update data into Car table.
                connection();
                str = "";
                cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCarNo.Clear();
                txtFname.Clear();
                txtLastName.Clear();
                txtCarID.Clear();
                txtCustomerID.Clear();
                txtEmail.Clear();
                txtModel.Clear();
                txtPhoneNo.Clear();
                txtSearchPhoneNo.Focus();
            }
        }

        private void btService_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Services services = new Services();
                services.Show();
                this.Hide();
                flag = false;
            }
            else
                MessageBox.Show("Search the Customer's Data First !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btRepair_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Repair repair = new Repair();
                repair.Show();
                this.Hide();
                flag = false;
            }
            else
                MessageBox.Show("Search the Customer's Data First !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btExixtingCust_Click(object sender, EventArgs e)
        {

        }

        private void ExistingCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
