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
using System.Web.UI.WebControls;

namespace Wheel_Deal
{
    public partial class Cars : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Cars()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Buy form = new Buy();
            form.ShowDialog();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Buy form = new Buy();
            form.ShowDialog();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Buy form = new Buy();
            form.ShowDialog();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Rent1 form = new Rent1();
            form.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Rent1 form = new Rent1();
            form.ShowDialog();
        }


        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Rent1 form = new Rent1();
            form.ShowDialog();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            New_or_Old form = new New_or_Old();
            form.ShowDialog();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from cars where Name like '%" +search_guna+ "%'", con);
            con.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dbt = new DataTable();
                adapter.Fill(dbt);
                con.Close();

            }
            catch (Exception ex) {
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void loaddata()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Car ", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    label1.Text = dt.Rows[2][1].ToString();
                    label2.Text = dt.Rows[1][1].ToString();
                    label3.Text = dt.Rows[0][1].ToString();
                    label4.Text = dt.Rows[4][1].ToString();
                    label5.Text = dt.Rows[3][1].ToString();
                    label6.Text = dt.Rows[5][1].ToString();
                    model1.Text = dt.Rows[2][9].ToString();
                    model2.Text = dt.Rows[1][9].ToString();
                    model3.Text = dt.Rows[0][9].ToString();
                    model4.Text = dt.Rows[4][9].ToString();
                    model5.Text = dt.Rows[3][9].ToString();
                    model6.Text = dt.Rows[5][9].ToString();
                    BUY1.Text = dt.Rows[2][7].ToString();
                    BUY2.Text = dt.Rows[1][7].ToString();
                    BUY4.Text = dt.Rows[5][7].ToString();
                    Rent1.Text = dt.Rows[0][7].ToString();
                    Rent2.Text = dt.Rows[3][7].ToString();
                    Rent3.Text = dt.Rows[4][7].ToString();
                    Q1.Text = dt.Rows[2][11].ToString();
                    Q2.Text = dt.Rows[1][11].ToString();
                    Q3.Text = dt.Rows[0][11].ToString();
                    Q4.Text = dt.Rows[4][11].ToString();
                    Q5.Text = dt.Rows[3][11].ToString();
                    Q6.Text = dt.Rows[5][11].ToString();
                }
            }
            catch (Exception ex) { }
        }
        private void Cars_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BUY2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            Admin objform2 = new Admin();
            this.Hide();
            objform2.Show(); 
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {  
            Customer objform2= new Customer();
            this.Hide();
            objform2.Show();
        }

        private void LOG_OUT_Click(object sender, EventArgs e)
        {
            menu.Show(LOG_OUT, 0, LOG_OUT.Height);
        }

        private void menu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Login nform = new Login();
            this.Hide();
            nform.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            menu1.Show(Addcar, 0, Addcar.Height);
        }

        private void menu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AddCars addCars = new AddCars();
            addCars.Show();
        }
    }
}
