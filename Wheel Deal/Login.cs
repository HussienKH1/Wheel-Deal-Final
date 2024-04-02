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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Pass_txt.UseSystemPasswordChar = true;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
   
            SqlCommand cmd = new SqlCommand("Select * from person where Login = '" + UName_txt.Text.Trim() + "' and Password = '" + Pass_txt.Text.Trim() + "'", con);
            con.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dbt = new DataTable();
                adapter.Fill(dbt);
                if (dbt.Rows.Count > 0)
                {
                    if (String.Compare(Pass_txt.Text, dbt.Rows[0][5].ToString(), false) == 0)
                    {
                        Global.CurrentUserName = dbt.Rows[0][4].ToString();
                        
                        Global.CurrentName = dbt.Rows[0][1].ToString();
                        Admin objform2 = new Admin();
                        this.Hide();
                        objform2.Show();
                        if(dbt.Rows[0][6].ToString() == "Admin")
                        {
                            Global.CurrentLogInType = "Admin";
                        }
                        else
                        {
                            Global.CurrentLogInType = "Employee";
                        }
                    }

                    else
                    {
                        MessageBox.Show("Incorrect Password or Username");
                    }

                }
                else
                {
                    MessageBox.Show("Invald login. Try again!");
                    Pass_txt.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error occured...");
            }
            con.Close();
        }

        private void UName_txt_TextChanged(object sender, EventArgs e)
        {

        }


        private void view_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (view_pass.Checked == true)
            {
                Pass_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Pass_txt.UseSystemPasswordChar = true;
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
