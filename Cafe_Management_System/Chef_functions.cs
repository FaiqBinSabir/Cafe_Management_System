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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;
namespace Cafe_Management_System
{
    public partial class Chef_functions : Form
    {
        public Chef_functions()
        {
            InitializeComponent();
        }


        string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        private void View_Products_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Products]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void View_Menu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Menu]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void View_Supplier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Supplier]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Vendor_Detailss_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from [Vendor]";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef_page cp = new Chef_page(); 
            cp.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage("intakhabmalik0582001@gmail.com","faiqbinsabir786@gmail.com","product report successful","Product " +id_input.Text+"quantity report send to admin..");
                SmtpClient c = new SmtpClient(smptt_input.Text);
                // SmtpClient client = new SmtpClient(smtp.SelectedItem.ToString());
                c.Port = 587;
                c.Credentials = new NetworkCredential("intakhabmalik0582001@gmail.com", "vtmemfxitutemawx");
                c.EnableSsl = true;
                c.Send(mail);
                MessageBox.Show("Email Sent!!", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id_input.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
