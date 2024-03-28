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
    public partial class Rent1 : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Rent1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Rent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SSN", Int64.Parse(txt_SSN.Text));
                cmd.Parameters.AddWithValue("@CRID", Int64.Parse(txt_CID.Text));
                cmd.Parameters.AddWithValue("@RentID", Int64.Parse(txt_RID.Text));
                cmd.Parameters.AddWithValue("@Startdate", picker_SD.Value);
                cmd.Parameters.AddWithValue("@Enddate", picker_ED.Text);
                cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("rented");
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!!");
            }
        }

 
    }
}
