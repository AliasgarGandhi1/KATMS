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

namespace KATMS.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btSignIn_Click(object sender, EventArgs e)
        {

            if(!Validator.IsPresent(txtUserName) || !Validator.IsPresent(txtPassword))
            {
                MessageBox.Show("Username or Password is Missing!!!");
            }
            else
            {
                //Database coding.
                //Select query to match user name and password.
                Customer_Car customer_Car = new Customer_Car();
                customer_Car.Show();
                this.Hide();
            }
            
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password forgot_Password = new Forgot_Password();
            forgot_Password.Show();
            this.Hide();
        }
    }
}
