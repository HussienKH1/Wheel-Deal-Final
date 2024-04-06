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
            int customerid = getCustomerID();
            int CRID=11;
            int currentValue;
            try 
            {
                if (customerid != -1)
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Rentby values (@CRID, @RentID, @Startdate, @Enddate, @Price, @CSID)", con);
                    cmd.Parameters.AddWithValue("@CSID", customerid);
                    cmd.Parameters.AddWithValue("@CRID", CRID);
                    cmd.Parameters.AddWithValue("@RentID", txt_RID.Text);
                    cmd.Parameters.AddWithValue("@Startdate", picker_SD.Value);
                    cmd.Parameters.AddWithValue("@Enddate", picker_ED.Value);
                    cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rented");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    SqlCommand cmd1 = new SqlCommand("Select Quantity from Car where CRID = @CRID)", con);
                    cmd1.Parameters.AddWithValue("@CRID", CRID);
                    currentValue = Convert.ToInt32(cmd1.ExecuteScalar());
                    currentValue -- ;
                }
                else
                {
                    MessageBox.Show("No Customer is available with this name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!!");
            }
        }
        private int getCustomerID()
        {
            int customerid = -1;
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Select CSID from Customer where Name like '" + txt_CSID.Text.Trim() + "'", con);

                customerid = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {

            }
            return customerid;
        }


    }
}
