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
    public partial class Admin_function : Form
    {
        public Admin_function()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void View_Customer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Customer]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Admin_page ap = new Admin_page();
            ap.Show();
        }

        private void View_Tables_Reservation_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Reservations]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Menu_Detail_Click(object sender, EventArgs e)
        {
            this.Hide();
           Menu_Detail md = new Menu_Detail();
            md.Show();
        }
    }
}
