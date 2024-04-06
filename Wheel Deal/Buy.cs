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
    public partial class Buy : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Buy()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                int customerid = getCustomerID();
                if (customerid != -1)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Boughtby values (@BoughtID, @CRID, @CSID, @Price, @Date) ", con);
                    cmd.Parameters.AddWithValue("@BoughtID", txt_BID.Text);
                    cmd.Parameters.AddWithValue("@CRID", txt_CID.Text);
                    cmd.Parameters.AddWithValue("@CSID", customerid);
                    cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                    cmd.Parameters.AddWithValue("@Date", picker_BD.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bought successfully");
                    if (con.State == ConnectionState.Open)
                        con.Close();

                }
                else
                {
                    MessageBox.Show("No Customer is available with this name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!");
            }
        }

        private int getCustomerID()
        {
            int customerid = -1;
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Select CSID from Customer where Name like '"+txt_CSID.Text.Trim()+"'",con);

                customerid = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex) { 
                
            }
            return customerid;
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CSID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_BID_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
