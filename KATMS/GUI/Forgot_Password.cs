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

namespace KATMS.GUI
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtEmailId))
                MessageBox.Show("Please enter the Email ID !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                MessageBox.Show("Your new password has been sent to your email address successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Forgot_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
