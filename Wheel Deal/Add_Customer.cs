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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI2.WinForms;

namespace Wheel_Deal
{
    public partial class Add_Customer : Form
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());

        public Add_Customer()
        {
            InitializeComponent();
        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\source\repos\Wheel Deal\Wheel Deal\myDB.mdf"";Integrated Security=True");

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("AddCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhoneNumber", Int64.Parse(phoneNumber_text.Text));
                cmd.Parameters.AddWithValue("@Gender",gender.Text);
                cmd.Parameters.AddWithValue("@CSID", CSID_text.Text);
                cmd.Parameters.AddWithValue("@Birthday", birthday_customer.Value);
                cmd.Parameters.AddWithValue("@Country", country_text.Text);
                cmd.Parameters.AddWithValue("@City", city_text.Text);
                cmd.Parameters.AddWithValue("@Name", name_text.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully");
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!!");
            }

            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            CSID_text.Text = " ";
            name_text.Text = " ";
            country_text.Text = " ";
            city_text.Text = " ";
            phoneNumber_text.Text = " ";

        }

        private void guna2ComboBox_SelectedIndexChanged()
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }
    }
}


