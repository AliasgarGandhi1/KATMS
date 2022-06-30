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
using KATMS.GUI;
using System.Data.SqlClient;
using KATMS.BL;

namespace KATMS.GUI
{
    public partial class New_Employee : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private string str;
        private SqlDataAdapter adapter;


        private void connection()
        {
            con = new SqlConnection("Data Source=ALIASGAR-GANDHI;Initial Catalog=KATMSdb;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
        }

        public New_Employee()
        {
            InitializeComponent();
        }

        private void New_Employee_Load(object sender, EventArgs e)
        {
            getEmployeeID();
        }

        private void getEmployeeID()
        {
            //Retriving max RepairID to generate next ID.
            connection();
            str = "select MAX(employeeID) from Employeetb";
            cmd = new SqlCommand(str, con);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                try
                {
                    txtEmpID.Text = "" + (Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1);
                }
                catch (Exception ex)
                {
                    txtEmpID.Text = "" + 1;
                }
            }
            else
            {
                txtEmpID.Text = "" + 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btList_Click(object sender, EventArgs e)
        {
            List_Employees olist_Employees = new List_Employees();
            olist_Employees.Show();
            this.Hide();
        }

        private void btAddEmployee_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtFirstName) || !Validator.IsPresent(txtLastName) || !Validator.IsPresent(txtPhoneNo.Text) || !Validator.IsPresent(txtAddress) || !Validator.IsPresent(txtEmailID) || !Validator.IsPresent(txtBloodGroup) || !Validator.IsPresent(txtInsurance) || !Validator.IsPresent(txtPayPerHour) || !Validator.IsPresent(txtBankAccount))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection();
                str = "INSERT INTO Employeetb (firstName, lastName, phoneNumber, address, emailID, bloodGroup, insuranceNumber, payPerHour, bankAccountNumber) VALUES (@fname, @lname, @phoneNo, @address, @emailID, @bloodGroup, @insurance, @payPerHour, @bankAccount)";
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@phoneNo", txtPhoneNo.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@emailID", txtEmailID.Text);
                cmd.Parameters.AddWithValue("@bloodGroup", txtBloodGroup.Text);
                cmd.Parameters.AddWithValue("@insurance", txtInsurance.Text);
                cmd.Parameters.AddWithValue("@payPerHour", txtPayPerHour.Text);
                cmd.Parameters.AddWithValue("@BankAccount", txtBankAccount.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFirstName.Clear();
                txtLastName.Clear();
                txtInsurance.Clear();
                txtPayPerHour.Clear();
                txtPhoneNo.Clear();
                txtAddress.Clear();
                txtBankAccount.Clear();
                txtBloodGroup.Clear();  
                txtEmailID.Clear();
                txtFirstName.Focus();
                getEmployeeID();
            }

        }

        private void btExistingEmployee_Click(object sender, EventArgs e)
        {
            Search_Employee osearch_Employee = new Search_Employee();
            osearch_Employee.Show();
            this.Hide();
        }

        private void txtPhoneNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

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

        private void New_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

