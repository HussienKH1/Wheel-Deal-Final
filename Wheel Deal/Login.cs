﻿using System;
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

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\source\repos\Wheel Deal\Wheel Deal\myDB.mdf"";Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from person where Login = '" + UName_txt.Text.Trim() + "' and Password = '" + Pass_txt.Text.Trim() + "'", con);
            con.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dbt = new DataTable();
                adapter.Fill(dbt);
                if (dbt.Rows.Count > 0)
                {

                    if (dbt.Rows[0][6].ToString() == "Admin" && String.Compare(Pass_txt.Text, dbt.Rows[0][5].ToString(), false) == 0)
                    {
                        Global.CurrentUserName = dbt.Rows[0][4].ToString();
                        Global.CurrentLogInType = "Admin";
                        Admin objform2 = new Admin();
                        this.Hide();
                        objform2.Show();
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
    }
}
