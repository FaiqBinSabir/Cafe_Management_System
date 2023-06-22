using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management_System
{
    public partial class Chef_page : Form
    {
        public Chef_page()
        {
            InitializeComponent();


        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

       

        private void Chef_page_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_forms login_f = new Login_forms();

            login_f.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [staff] where  staff_id=@name and staff_password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", Chef_id_input.Text.Trim());
            cmd.Parameters.AddWithValue("@pass", Chef_password_input.Text.Trim());
            //cmd.Parameters.AddWithValue("@type", textBox1.Text.Trim());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                dr.Read();
                 MessageBox.Show("Successfully Login");
                    this.Hide();
                    Chef_functions cf= new Chef_functions();
                cf.Show();

               



            }
            else
            {
                MessageBox.Show("lgoin failed");
            }

        }
    }
}
