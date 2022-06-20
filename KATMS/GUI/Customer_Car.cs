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

namespace KATMS
{
    public partial class Customer_Car : Form
    {
        public Customer_Car()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCustDetails.Visible = true;
            pnlCarDetails.Visible = true;
            pnlNewCust.Visible = true;
            pnlDefault.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCustDetails.Visible = false;
            pnlCarDetails.Visible = false;
            pnlNewCust.Visible = false;
            pnlDefault.Visible = true;
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btHome_Click(object sender, EventArgs e)
        {

        }

        private void btHome_MouseHover(object sender, EventArgs e)
        {
            pbtHome.BackColor = Color.Transparent;
        }

        private void btExixtingCust_Click(object sender, EventArgs e)
        {
            ExistingCustomer excust = new ExistingCustomer();
            excust.Show();
            this.Hide();
        }
    }
}
