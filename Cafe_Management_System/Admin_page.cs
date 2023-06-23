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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Management_System
{

    public partial class Admin_page : Form
    {



        public Admin_page()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;





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

        private void Admin_signin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [admin] where admin_id=@adminid and admin_password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@adminid", Admin_id_input.Text.Trim());
            cmd.Parameters.AddWithValue("@pass", Admin_password_input.Text.Trim());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                var name = dr["admin_id"].ToString();
                var pass = dr[1].ToString();
                dr.Close();
                if (name == Admin_id_input.Text && pass == Admin_password_input.Text)
                {
                    Singleton_design_pattern singleton = Singleton_design_pattern.Instance;
                    
                    MessageBox.Show("Successfully Login");
                    this.Hide();
                    Admin_function af = new Admin_function();
                    af.Show();

                }
                else 
                {
                    MessageBox.Show(" failed to extract data");

                }

               

            }
            else
            {
                MessageBox.Show("lgoin failed");
            }

            con.Close();

        }

        private void Admin_password_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_page_Load(object sender, EventArgs e)
        {

        }
    }
}
