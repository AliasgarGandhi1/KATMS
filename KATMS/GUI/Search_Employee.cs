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
    public partial class Search_Employee : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private string str;

        private void connection()
        {
            con = new SqlConnection("Data Source=ALIASGAR-GANDHI;Initial Catalog=KATMSdb;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public Search_Employee()
        {
            InitializeComponent();
        }

        private void btList_Click(object sender, EventArgs e)
        {
            List_Employees olist_Employees = new List_Employees();
            olist_Employees.Show();
            this.Hide();
        }

        private void btFindDetails_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtPhoneNo.Text) && !Validator.IsPresent(txtEmpID))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                if(txtEmpID.Text != "")
                    str = "select * from Employeetb where employeeID='"+txtEmpID.Text+"'";

                
                else
                    str = "select * from Employeetb where phoneNumber='"+txtPhoneNo.Text+"'";
                

                connection();
                cmd = new SqlCommand(str, con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Employee.empID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    Employee.firstName = ds.Tables[0].Rows[0][1].ToString();
                    Employee.lastName = ds.Tables[0].Rows[0][2].ToString();
                    Employee.phoneNo = ds.Tables[0].Rows[0][3].ToString();
                    Employee.address = ds.Tables[0].Rows[0][4].ToString();
                    Employee.emailID = ds.Tables[0].Rows[0][5].ToString();
                    Employee.bloodGroup = ds.Tables[0].Rows[0][6].ToString();
                    Employee.insuranceNo = ds.Tables[0].Rows[0][7].ToString();
                    Employee.payRate = Convert.ToDouble(ds.Tables[0].Rows[0][8]);
                    Employee.bankNo = ds.Tables[0].Rows[0][9].ToString();
                    Update_Employee oupdate_Employee = new Update_Employee();
                    oupdate_Employee.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Employee Data Does not exist!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void btNewEmployee_Click(object sender, EventArgs e)
        {
            New_Employee onew_Employee = new New_Employee();
            onew_Employee.Show();
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

        private void Search_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Search_Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
