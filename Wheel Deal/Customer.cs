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

namespace Wheel_Deal
{
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Customer()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                string query = "SELECT* FROM Customer";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgv_customer.DataSource = dt;
            }

            catch
            {

            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            Cars objform2 = new Cars();
            this.Hide();
            objform2.Show();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            Admin objform2 = new Admin();
            this.Hide();
            objform2.Show();
        }

        private void LOG_OUT3_Click(object sender, EventArgs e)
        {
            menu3.Show(LOG_OUT3, 0, LOG_OUT3.Height);
        }

        private void menu3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            Login nform = new Login();
            this.Hide();
            nform.Show();
        }
    }
}
