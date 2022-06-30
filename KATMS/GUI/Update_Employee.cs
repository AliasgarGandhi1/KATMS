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
using System.Data.SqlClient;
using KATMS.Validation;
using KATMS.BL;

namespace KATMS.GUI
{
    public partial class Update_Employee : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private string str;


        private void connection()
        {
            con = new SqlConnection("Data Source=ALIASGAR-GANDHI;Initial Catalog=KATMSdb;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
        }
        public Update_Employee()
        {
            InitializeComponent();
        }

        private void Update_Employee_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = Employee.empID.ToString();
            txtFirstName.Text = Employee.firstName;
            txtLastName.Text = Employee.lastName;
            txtAddress.Text = Employee.address;
            txtBankAccount.Text = Employee.bankNo;
            txtEmailID.Text = Employee.emailID;
            txtInsurance.Text = Employee.insuranceNo;
            txtPayperHour.Text = Employee.payRate.ToString();
            txtPhoneNo.Text = Employee.phoneNo;
            txtBloodGroup.Text = Employee.bloodGroup;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btList_Click(object sender, EventArgs e)
        {
            List_Employees olist_Employees = new List_Employees();
            olist_Employees.Show();
            this.Hide();
        }

        private void btNewEmployee_Click(object sender, EventArgs e)
        {
            New_Employee onew_Employee = new New_Employee();
            onew_Employee.Show();
            this.Hide();
        }

        private void btUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtFirstName) || !Validator.IsPresent(txtLastName) || !Validator.IsPresent(txtPhoneNo.Text) || !Validator.IsPresent(txtAddress) || !Validator.IsPresent(txtEmailID) || !Validator.IsPresent(txtBloodGroup) || !Validator.IsPresent(txtInsurance) || !Validator.IsPresent(txtPayperHour) || !Validator.IsPresent(txtBankAccount))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection();
                str = "UPDATE Employee set firstName = @fname, lastName=@lname, phoneNumber=@phoneNo, address=@address, emailID=@emailID, bloodGroup=@bloodGroup, insuranceNumber=@insurance, payPerHour=@payPerHour, bankAccount=@BankAccount WHERE employeeID = @empID";
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@empID", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@phoneNo", txtPhoneNo.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@emailID", txtEmailID.Text);
                cmd.Parameters.AddWithValue("@bloodGroup", txtBloodGroup.Text);
                cmd.Parameters.AddWithValue("@insurance", txtInsurance.Text);
                cmd.Parameters.AddWithValue("@payPerHour", txtPayperHour.Text);
                cmd.Parameters.AddWithValue("@BankAccount", txtBankAccount.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Data Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDisableEmployee_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtFirstName) || !Validator.IsPresent(txtLastName) || !Validator.IsPresent(txtPhoneNo.Text) || !Validator.IsPresent(txtAddress) || !Validator.IsPresent(txtEmailID) || !Validator.IsPresent(txtBloodGroup) || !Validator.IsPresent(txtInsurance) || !Validator.IsPresent(txtPayperHour) || !Validator.IsPresent(txtBankAccount))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection();
                str = "DELETE from Employeetb WHERE employeeID = @empID";
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@empID", txtEmpID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Data Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Update_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btExistingEmployee_Click(object sender, EventArgs e)
        {
            Search_Employee osearch_Employee = new Search_Employee();
            osearch_Employee.Show();
            this.Hide();
        }
    }
}
