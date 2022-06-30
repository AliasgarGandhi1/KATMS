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

namespace KATMS
{
    public partial class NewCustomer : Form
    {

        private bool flag = false;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private string str ="";

        public NewCustomer()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kATMSdbDataSet.Brandtb' table. You can move, or remove it, as needed.
            this.brandtbTableAdapter.Fill(this.kATMSdbDataSet.Brandtb);

            getCustomerCarId();
        }

        private void getCustomerCarId()
        {
            //Code to get the Last ID of the customer.
            connection();
            str = "select MAX(cust.customerID), MAX(carID) from Customertb cust, Cartb";
            cmd = new SqlCommand(str, con);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                UserInfo.customerID = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
                txtCustomerID.Text = "" + (UserInfo.customerID);
                UserInfo.carID = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
                txtCarID.Text = "" + (UserInfo.carID);
            }
            else
            {
                txtCustomerID.Text = "" + 1;
                UserInfo.customerID = 1;
                txtCarID.Text = "" + 1;
                UserInfo.carID = 1;
            }
        }

        private void btHome_Click(object sender, EventArgs e)
        {

        }

        private void connection()
        {
            con = new SqlConnection("Data Source=ALIASGAR-GANDHI;Initial Catalog=KATMSdb;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
        }

        private void btExixtingCust_Click(object sender, EventArgs e)
        {
            ExistingCustomer excust = new ExistingCustomer();
            excust.Show();
            this.Hide();
        }

        private void btSaveCust_Click(object sender, EventArgs e)
        {
            if ( !Validator.IsPresent(txtFname) || !Validator.IsPresent(txtPhoneNo.Text) 
                || !Validator.IsPresent(txtEmail) || !Validator.IsPresent(txtCarNo)
                || !Validator.IsPresent(txtModel))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                //Code to insert data into Customer table.
                connection();
                str = "INSERT INTO Customertb(firstName, lastName, emailID, phoneNumber) VALUES(@fname, @lname, @emailID, @phoneNo)";
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
                String brandID="";

                if (dataTable != null)
                {
                     brandID = dataTable.Rows[0]["brandID"].ToString();
                }

                //Code to insert data into Car table.
                connection();
                str= "INSERT INTO Cartb (carNumber, model, brandID, customerID) VALUES(@carNo, @model, @brandID, @custID)";
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@carNo", txtCarNo.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@brandID", Convert.ToInt32(brandID));
                cmd.Parameters.AddWithValue("@custID", Convert.ToInt32(txtCustomerID.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                flag = true;
                MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCarNo.Clear();
                txtModel.Clear();
                txtFname.Clear();
                txtEmail.Clear();
                txtPhoneNo.Clear();
                getCustomerCarId();
                txtFname.Focus();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.brandtbTableAdapter.FillBy(this.kATMSdbDataSet.Brandtb);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btHome_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Enter and Save the Customer's Data First !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Enter and Save the Customer's Data First !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pnlNewCust_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCustDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
