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
        Int64 id;
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

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Add_Customer objform = new Add_Customer();
            objform.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Add_Customer objform = new Add_Customer();
            objform.Show();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
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
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                string query = "SELECT* FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet dt = new System.Data.DataSet();
                adapter.Fill(dt, "Customer");
                dgv_customer.DataSource = dt.Tables[0];
            }

            catch
            {

            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        private void search_guna_TextChanged(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Customer where Name like '%" + txt_search.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                dgv_customer.DataSource = dt;
            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadData()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Customer", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_customer.DataSource = dt;


            }
            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv_customer.CurrentCell.RowIndex;
            dgv_customer.Rows.RemoveAt(rowIndex);
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("Delete from Customer where CSID =' " + id + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_customer.Rows[e.RowIndex];
            id = Convert.ToInt64(row.Cells[0].Value);
        }
    }
}
