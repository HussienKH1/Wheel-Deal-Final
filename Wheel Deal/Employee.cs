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
    public partial class Employee : Form
    {  SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Employee()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CID", Int64.Parse(txt_SSN.Text));
                cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@Age", txt_Age.Text);
                cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@login", txt_login.Text);
                cmd.Parameters.AddWithValue("@password",txt_paasword .Text);
                cmd.Parameters.AddWithValue("@Role", txt_role.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee added successfully");
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!!");
            }
        }

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            txt_SSN.Text = " ";
            txt_Name.Text = " ";
            txt_Age.Text = " ";
            txt_Address.Text = " ";
            txt_login.Text = " ";
            txt_paasword.Text = " ";
            txt_phone.Text = " ";
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("drop * from person where SSN = '" + txt_SSN.Text.Trim() + "', Name'" + txt_Name.Text.Trim() + "', Age'" + txt_Age.Text.Trim() + "', Address'" + txt_Address.Text.Trim() + "',Login'" + txt_login.Text.Trim() + "',Password = '" + txt_paasword.Text.Trim() + "'and Role'" + txt_role.Text.Trim() + "'", con);
            con.Open();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update * from person where SSN = '" + txt_SSN.Text.Trim() + "', Name'" + txt_Name.Text.Trim() + "', Age'" + txt_Age.Text.Trim() + "', Address'" + txt_Address.Text.Trim() + "',Login'" + txt_login.Text.Trim() + "',Password = '" + txt_paasword.Text.Trim() + "'and Role'" + txt_role.Text.Trim() + "'", con);
            con.Open();
        }
            private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
