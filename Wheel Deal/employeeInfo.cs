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
        SqlConnection con =new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
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
                employee.DataSource = dt;
            }

            catch { 
            
            }
            if (con.State != ConnectionState.Closed)
                con.Close();


        }

        private void employeeInfo_Load(object sender, EventArgs e)
        {

        }

        private void employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
