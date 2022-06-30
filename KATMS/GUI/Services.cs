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
using System.Data.SqlClient;
using KATMS.GUI;
using KATMS.BL;

namespace KATMS.GUI
{
    public partial class Services : Form
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

        public Services()
        {
            InitializeComponent();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btService_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            this.Hide();
        }

        private void btRepair_Click(object sender, EventArgs e)
        {
            Repair repair = new Repair();
            repair.Show();
            this.Hide();
        }

        private void btSHistory_Click(object sender, EventArgs e)
        {
            ServiceHistory servicehistory = new ServiceHistory();
            servicehistory.Show();
            this.Hide();
        }

        private void btAAServices_Click(object sender, EventArgs e)
        {
            //Code for adding service.
            if (!Validator.IsPresent(textBoxSName) || !Validator.IsPresent(textBoxSCost) || !Validator.IsPresent(textBoxTransmission) || !Validator.IsPresent(textBoxFuel) || !Validator.IsPresent(textBoxKM) || !Validator.IsPresent(textBoxMY))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                insertdata();
                textBoxSID.Clear();
                textBoxSName.Clear();
                textBoxSCost.Clear();
                textBoxTransmission.Clear();
                textBoxFuel.Clear();
                textBoxKM.Clear();
                textBoxMY.Clear();
                checkBox1.Checked = false;
            }
        }

        private void insertdata()
        {
            connection();
            str = "INSERT INTO Servicetb (serviceName, serviceCost, washing, kilometers, carID) VALUES (@sname, @scost, @swashing, @km, @carID)";
            cmd = new SqlCommand(str, con);
            
            cmd.Parameters.AddWithValue("@sname", textBoxSName.Text);
            cmd.Parameters.AddWithValue("@scost", textBoxSCost.Text);
            cmd.Parameters.AddWithValue("@km", textBoxKM.Text);
            cmd.Parameters.AddWithValue("@swashing", checkBox1.Checked.ToString());
            cmd.Parameters.AddWithValue("@carID", UserInfo.carID);

            cmd.ExecuteNonQuery();
            con.Close();

            connection();
            str = "UPDATE Cartb SET transmission=@transmission, fuelType=@fuelType, year=@year WHERE carID=@carID";
            cmd = new SqlCommand(str, con);

            cmd.Parameters.AddWithValue("@carID", UserInfo.carID);
            cmd.Parameters.AddWithValue("@transmission", textBoxTransmission.Text);
            cmd.Parameters.AddWithValue("@fuelType", textBoxFuel.Text);
            cmd.Parameters.AddWithValue("@year", textBoxMY.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btCBServices_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(textBoxSName) || !Validator.IsPresent(textBoxSCost) || !Validator.IsPresent(textBoxTransmission) || !Validator.IsPresent(textBoxFuel) || !Validator.IsPresent(textBoxKM) || !Validator.IsPresent(textBoxMY))
            {
                MessageBox.Show("Please enter data in empty fields...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                insertdata();
                //TODO: Redirect to new form where we will calculate the bill and print it.
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

        private void btBackS_Click(object sender, EventArgs e)
        {
            Customers_Cars customers_Cars = new Customers_Cars();
            customers_Cars.ShowDialog();
            this.Hide();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            connection();
            str = "select MAX(serviceID) from Servicetb";
            cmd = new SqlCommand(str, con);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                try
                {
                    UserInfo.serviceID = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
                    textBoxSID.Text = "" + (UserInfo.serviceID);
                }
                catch(Exception ex)
                {
                    textBoxSID.Text = "" + 1;
                    UserInfo.serviceID = 1;
                }
            }
            else
            {
                textBoxSID.Text = "" + 1;
                UserInfo.serviceID = 1;
            }
        }

        private void Services_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
