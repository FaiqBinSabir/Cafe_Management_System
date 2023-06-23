using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Customer_signin : Form
    {
        public Customer_signin()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;



        private void Waiter_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_page login_f = new Customer_page();
            login_f.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer__signin_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Customer] where  Customer_name=@Customername and Customer_password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Customername", Customer_id_input.Text.Trim());
            cmd.Parameters.AddWithValue("@pass", Customer_password_input.Text.Trim());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                dr.Read();
                var name = dr["Customer_name"].ToString();
                var pass = dr["Customer_password"].ToString();
                dr.Close();
                if (name == Customer_id_input.Text && pass == Customer_password_input.Text)
                {

                    Singleton_design_pattern singleton = Singleton_design_pattern.Instance;

                    MessageBox.Show("Successfully Login");
                    this.Hide();
                    Customer_table__Reservation ct = new Customer_table__Reservation();
                    ct.Show();

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




        }

        private void Customer_signin_Load(object sender, EventArgs e)
        {

        }
    }
}
