using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KATMS.Validation;
using KATMS.BL;

namespace KATMS.GUI
{
    public partial class SignUp : Form
    {

        private SqlConnection con;
        private SqlCommand cmd;
        private string str = "";


        public SignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtEmailID) || !Validator.IsPresent(txtPassword) || !Validator.IsPresent(txtConfirmPassword) || !Validator.IsPresent(txtUserName))
            {
                MessageBox.Show("Please Enter Data in Empty Fields !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm password must be same !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection();
                str = "INSERT INTO Usertn (userName, password, emailID, role) VALUES(@usernm, @passwd, @emailID, @role)";
                cmd = new SqlCommand(str, con);

                cmd.Parameters.AddWithValue("@usernm", txtUserName.Text);
                cmd.Parameters.AddWithValue("@passwd", txtPassword.Text);
                cmd.Parameters.AddWithValue("@emailID", txtEmailID.Text) ;
                cmd.Parameters.AddWithValue("@role", cbRole.SelectedValue);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New User da  successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
                        
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
