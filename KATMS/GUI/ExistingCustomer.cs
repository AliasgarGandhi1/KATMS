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

namespace KATMS.GUI
{
    public partial class ExistingCustomer : Form
    {
        public ExistingCustomer()
        {
            InitializeComponent();
        }

        private void btNewCust_Click(object sender, EventArgs e)
        {
            Customer_Car customer_Car = new Customer_Car();
            //customer_Car.pn.Visible = true;
            //pnlCarDetails.Visible = true;
            //pnlNewCust.Visible = true;
            //pnlDefault.Visible = false;
            customer_Car.Show();
            this.Hide();
        }
    }
}
