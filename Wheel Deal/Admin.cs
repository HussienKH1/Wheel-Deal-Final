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
using System.Windows.Forms.DataVisualization.Charting;

namespace Wheel_Deal
{
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Admin()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                string query = "SELECT * FROM person";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                recent.DataSource = dt;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login objform2= new Login();
            this.Hide();
            objform2.Show();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            Customer objform2 = new Customer();
            this.Hide();
            objform2.Show();
        }

        private void guna2Panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WELCOME_Click(object sender, EventArgs e)
        {

        }

        private void LOG_OUT_Click(object sender, EventArgs e)
        {
            menu2.Show(LOG_OUT2, 0, LOG_OUT2.Height);
        }

        private void menu2_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void menu2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Login nform = new Login();
            this.Hide();
            nform.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Month, profits From test ", con);
            da.Fill(dt);
            Profit_Chart.DataSource = dt;
            con.Close();
            Profit_Chart.Series["profits"].XValueMember = "Month";
            Profit_Chart.Series["profits"].YValueMembers = "Profits";
            Profit_Chart.Titles.Add("Monthly Profits");
        

    }
    }
}
