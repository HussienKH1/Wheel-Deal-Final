using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheel_Deal
{
    public partial class employeeInfo : Form
    {
        Int64 id;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\source\repos\Wheel Deal\Wheel Deal\myDB.mdf"";Integrated Security=True");
        public employeeInfo()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                string query = "SELECT* FROM person";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                employeeDGV.DataSource = dt;
            }

            catch { 
            
            }
            if (con.State != ConnectionState.Closed)
                con.Close();


        }

        private void employeeInfo_Load(object sender, EventArgs e)
        {
            name_txt.Text= Global.CurrentName.ToString();
        }

        private void employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEmployee_search_TextChanged(object sender, EventArgs e)
        {

            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from person where Name like '%" + txtEmployee_search.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                dt.Clear();
                da.Fill(dt);
                employeeDGV.DataSource = dt;
            }

            catch
            {
                MessageBox.Show("Error");
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(); 
            employee.Show();
            
        }
        public void LoadData()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from person", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                employeeDGV.DataSource = dt;


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
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = employeeDGV.CurrentCell.RowIndex;
                employeeDGV.Rows.RemoveAt(rowIndex);
                if (con.State != ConnectionState.Open)
                    con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("Delete from person where SSN =' " + id + "'", con);
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
            else
            {
                MessageBox.Show("Delete operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void employeeDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.employeeDGV.Rows[e.RowIndex];
            id = Convert.ToInt64(row.Cells[0].Value);
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
      
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            this.Hide();
            cars.Show();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
