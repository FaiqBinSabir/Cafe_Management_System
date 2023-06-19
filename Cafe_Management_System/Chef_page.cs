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

        private void Chef_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

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

        private void Chef_signin_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection();

            string query =( "select * from staff");
            SqlCommand cmd = new SqlCommand(query, cs); 
            cs.Open();

           int a = cmd.ExecuteNonQuery();
            if (a>0)
            {
                MessageBox.Show("sucewsss");
            }
            else
            {
                MessageBox.Show("failed");
            }
            cs.Close(); 

        }
    }
}
