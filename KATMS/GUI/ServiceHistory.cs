using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KATMS.BL;
using KATMS.Validation;
using System.Data.SqlClient;

namespace KATMS.GUI
{
    public partial class ServiceHistory : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
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

        public ServiceHistory()
        {
            InitializeComponent();
        }

        private void textBoxFuel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btService_Click(object sender, EventArgs e)
        {
            Services servicepage =new Services();
            servicepage.Show();
            this.Hide();
        }

        private void btSHistory_Click(object sender, EventArgs e)
        {
            ServiceHistory servicehistory = new ServiceHistory();
            servicehistory.Show();
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

        private void btFDetails_Click(object sender, EventArgs e)
        {
            if(!Validator.IsPresent(textBoxCNumber) && !Validator.IsPresent(maskedTextBoxPNumber.Text))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxCNumber.Text != "")
                {
                    str = "SELECT SERVICEID 'Service ID',SERVICENAME 'Service Name', SERVICECOST 'Service Cost', KILOMETERS 'Kilometers'  FROM SERVICETB WHERE CARID IN " +
                    "(SELECT CARID FROM CARTB WHERE carNumber=@CARNUMBER)";

                    connection();

                    cmd = new SqlCommand(str, con);
                    cmd.Parameters.AddWithValue("@CARNUMBER", textBoxCNumber.Text);

                    adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                        dataGridViewSHistory.DataSource = ds.Tables[0].DefaultView;

                    else
                    {
                        MessageBox.Show("History not Found...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    str = "SELECT SERVICEID 'Service ID',SERVICENAME 'Service Name', SERVICECOST 'Service Cost', KILOMETERS 'Kilometers'  FROM SERVICETB WHERE CARID IN " +
                    "(SELECT CARID FROM CARTB WHERE CUSTOMERID IN (SELECT CUSTOMERID FROM CUSTOMERTB WHERE PHONENUMBER=@PHONENO))";

                    connection();

                    cmd = new SqlCommand(str, con);
                    cmd.Parameters.AddWithValue("@PHONENO", maskedTextBoxPNumber.Text);

                    adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                        dataGridViewSHistory.DataSource = ds.Tables[0].DefaultView;

                    else
                    {
                        MessageBox.Show("History not Found...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btBackSH_Click(object sender, EventArgs e)
        {
            Customers_Cars customers_Cars = new Customers_Cars();
            customers_Cars.ShowDialog();
            this.Hide();
        }

        private void ServiceHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ServiceHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
