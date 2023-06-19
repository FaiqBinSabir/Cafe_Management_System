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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Management_System
{
    public partial class Customer_page : Form
    {
        public Customer_page()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void Customer_Page_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_forms lf = new Login_forms();
            lf.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void View_Menu_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Customer_signin_box.Visible = false;


            SqlConnection con = new SqlConnection(cs);
            string query = "select Food_name,Food_price from [Menu]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void Customer_signin_Click(object sender, EventArgs e)
        {

            this.Hide();

            Customer_signin cs = new Customer_signin();
            cs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_signin_box.Visible = true;
            dataGridView1.Visible = false;
           
        }

        private void Customer__signin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into Customer values (@name,@number,@email,@password,@payment)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", Customer_name_input.Text);
            cmd.Parameters.AddWithValue("@number", Customer_number_input.Text);
            cmd.Parameters.AddWithValue("@email", Customer_email_input.Text);
            cmd.Parameters.AddWithValue("@password", Customer_password_input.Text);
            cmd.Parameters.AddWithValue("@payment", Customer_payment_input.Text);
            con.Open();

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("account created sucessfully");
                this.Hide();
                Customer_signin cs = new Customer_signin();
                cs.Show();
               



            }
            else
            {

                MessageBox.Show("cant entered your data");
            }
            con.Close();
        }
    }
}