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
using System.IO;
using System.Security.Cryptography;


namespace Wheel_Deal
{
    public partial class AddCars : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public AddCars()
        {
            InitializeComponent();
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int currentValue;
            int CRID = getCarID();
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                if (CRID != -1)
                {
                    SqlCommand cmd1 = new SqlCommand("Select Quantity from Car Where CRID = @CRID ", con);
                    cmd1.Parameters.AddWithValue("@CRID", CRID);
                    currentValue = Convert.ToInt32(cmd1.ExecuteScalar());
                    

                    SqlCommand cmd = new SqlCommand("UPDATE Car SET Quantity = @quantity WHERE CRID = @CRID", con);
                    cmd.Parameters.AddWithValue("@NewValue", Quantity.Text);
                    cmd.Parameters.AddWithValue("@CRID", CRID);
                    MessageBox.Show("Car(s) added successfully");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                else
                {
                    MessageBox.Show("No Car found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!!");
            }
            Cars cars = new Cars();
            this.Close();
            cars.loaddata();
            
        }
        
        private void AddCars_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int currentValue;
            if (int.TryParse(Quantity.Text, out currentValue))
            {
                // Increment the value by 1 and update the textbox
                Quantity.Text = (currentValue + 1).ToString();
            }
            else
            {
                // If parsing fails, set the textbox value to 1
                Quantity.Text = "1";
            }
        }
        private int getCarID()
        {
            int carid = -1;
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Select CSID from Customer where Name like '" + Car.SelectedItem.ToString() + "'", con);

                carid = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {

            }
            return carid;
        }
    }
}
