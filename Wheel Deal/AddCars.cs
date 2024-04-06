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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\source\repos\Wheel Deal\Wheel Deal\myDB.mdf"";Integrated Security=True");
        public AddCars()
        {
            InitializeComponent();
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int currentValue;
            
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Select Quantity from Car Where CRID = @CRID ", con);
                    cmd1.Parameters.AddWithValue("@CRID", car.Text);
                    currentValue = Convert.ToInt32(cmd1.ExecuteScalar());
                    SqlCommand cmd = new SqlCommand("UPDATE Car SET Quantity = @quantity WHERE CRID = @CRID", con);
                    int newv = Convert.ToInt32(Quantity.Text);
                    currentValue += newv;
                    cmd.Parameters.AddWithValue("@quantity", currentValue);
                    cmd.Parameters.AddWithValue("@CRID", car.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car(s) added successfully");
                    if (con.State == ConnectionState.Open)
                        con.Close();
                
           
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
    }
}
