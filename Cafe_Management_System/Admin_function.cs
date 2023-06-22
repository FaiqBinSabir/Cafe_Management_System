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

        private void Product_Detail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_Detail pd = new Product_Detail();
            pd.Show();
        }

        private void Supplier_Details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier_Detail sd = new Supplier_Detail();
            sd.Show();
        }

        private void Vendor_Details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendor_Detail vd = new Vendor_Detail(); 
            vd.Show();
        }

        private void Staff_Detail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Detail sd = new Staff_Detail();
            sd.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Reports_analyticscs ra = new Reports_analyticscs();
            ra.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
