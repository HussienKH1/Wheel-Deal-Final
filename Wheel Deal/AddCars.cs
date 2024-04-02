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


namespace Wheel_Deal
{
    public partial class AddCars : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public AddCars()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void city_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private byte[] getPhoto() 
        {
            MemoryStream stream = new MemoryStream();
            imageAddCars.Image.Save(stream, imageAddCars.Image.RawFormat);
            return stream.GetBuffer(); 
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("AddCar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CRID", CRID_text.Text);
                cmd.Parameters.AddWithValue("@Brand", brand_text.Text);
                cmd.Parameters.AddWithValue("@Color", Color_txt.Text);
                cmd.Parameters.AddWithValue("@Speed", speed_txt.Text);
                cmd.Parameters.AddWithValue("@Capacity", capacity_text.Text);
                cmd.Parameters.AddWithValue("@Mileage", mileage_txt.Text);
                cmd.Parameters.AddWithValue("@Engine", engine_txt.Text);
                cmd.Parameters.AddWithValue("@Price", price_txt.Text);
                cmd.Parameters.AddWithValue("@Type", type_txt.Text);
                cmd.Parameters.AddWithValue("@Model", model_txt.Text);
                cmd.Parameters.AddWithValue("@Image", getPhoto()); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Car added successfully");
                if (con.State == ConnectionState.Open)
                    con.Close();

            }
            catch
            {
                MessageBox.Show("error!!!");
            }
        }
        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
               imageAddCars.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void AddCars_Load(object sender, EventArgs e)
        {

        }

        private void imageAddCars_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
