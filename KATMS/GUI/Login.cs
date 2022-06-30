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
    public partial class Login : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;


        public Login()
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
            adapter = new SqlDataAdapter();
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
             
            if(!Validator.IsPresent(txtUserName) || !Validator.IsPresent(txtPassword))
            {
                MessageBox.Show("Username or Password is Missing!!!");
            }
            else
            {
                //Code to check username and password are matched in database or not.
                String str;
                connection();
                str = "select * from Usertb where userName=@userName and password=@password";

                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dataTable = ds.Tables[0];


                //If username and password matches and user is admin then execute this block.
                if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["role"].ToString() == "Admin")
                {
                    UserInfo.userName = dataTable.Rows[0]["userName"].ToString();
                    UserInfo.role = dataTable.Rows[0]["role"].ToString();
                    MessageBox.Show("You are successfully logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMenu oadminMenu = new AdminMenu();
                    oadminMenu.Show();
                    this.Hide();
                }
                //If username and password matches and user is manager then execute this block.
                else if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["role"].ToString() == "Manager")
                {
                    UserInfo.userName = dataTable.Rows[0]["userName"].ToString();
                    UserInfo.role = dataTable.Rows[0]["role"].ToString();
                    MessageBox.Show("You are successfully logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManagerMenu omanagerMenu = new ManagerMenu();
                    omanagerMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }

        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password forgot_Password = new Forgot_Password();
            forgot_Password.Show();
            this.Hide();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
